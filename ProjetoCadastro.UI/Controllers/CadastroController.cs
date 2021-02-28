using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoCadastro.Application.Interfaces;
using ProjetoCadastro.Domain.Entities;
using ProjetoCadastro.UI.ViewModels;

namespace ProjetoCadastro.UI.Controllers
{
    public class CadastroController : Controller
    {
        private readonly IPessoaAppService _pessoaAppService;

        public CadastroController(IPessoaAppService pessoaAppService)
        {
            _pessoaAppService = pessoaAppService;
        }

        public ActionResult Index()
        {
            var pessoaViewModel =
                Mapper.Map<IEnumerable<Pessoa>, IEnumerable<PessoaViewModel>>(_pessoaAppService.GetAll());
            return View(pessoaViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PessoaViewModel pessoa)
        {
            if (ModelState.IsValid)
            {
                if (!_pessoaAppService.CheckRegistration(pessoa.Email))
                {
                    var pessoaDomain = Mapper.Map<PessoaViewModel, Pessoa>(pessoa);
                    _pessoaAppService.Add(pessoaDomain);
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Erro = "Usuario Ja Existe";
                    return View(pessoa);
                }
            }
            return View(pessoa);
        }

        public ActionResult Edit(int id)
        {
            var pessoa = _pessoaAppService.GetById(id);
            var pessoaViewModel = Mapper.Map<Pessoa, PessoaViewModel>(pessoa);
            return View(pessoaViewModel);
        }

        [HttpPost]
        public ActionResult Edit(PessoaViewModel pessoa)
        {
            if (ModelState.IsValid)
            {
                var pessoaDomain = Mapper.Map<PessoaViewModel, Pessoa>(pessoa);
                _pessoaAppService.Update(pessoaDomain);
                return RedirectToAction("Index");
            }

            return View(pessoa);
        }

        public ActionResult Details(int id)
        {
            var pessoa = _pessoaAppService.GetById(id);
            var clienteViewModel = Mapper.Map<Pessoa, PessoaViewModel>(pessoa);
            return View(clienteViewModel);
        }

        public ActionResult Delete(int id)
        {
            var pessoa = _pessoaAppService.GetById(id);
            var pessoaViewModel = Mapper.Map<Pessoa, PessoaViewModel>(pessoa);
            return View(pessoaViewModel);
        }

        [HttpPost, ActionName(("Delete"))]
        public ActionResult DeleteConfirmed(int id)
        {
            var pessoa = _pessoaAppService.GetById(id);
            _pessoaAppService.Remove(pessoa);
            return RedirectToAction("Index");

        }
    }
}