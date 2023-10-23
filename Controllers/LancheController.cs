﻿using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            this._lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            //ViewData["Titulo"] = "Todos os lanches teste";
            //var lanches = _lancheRepository.Lanches;
            //var totalLanches = lanches.Count();
            //ViewBag.Total = totalLanches;
            //return View(lanches);
            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "categoria atual";
            ViewBag.Total = lanchesListViewModel.Lanches.Count();
            return View(lanchesListViewModel);
        }
    }
}
