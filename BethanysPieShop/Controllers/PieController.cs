﻿using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(
            IPieRepository pieRepository,
            ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _pieRepository = pieRepository;
        }

        public IActionResult List()                 // framework will look for view called List inside of the Pie folder
        {
            //ViewBag.CurrentCategory = "Cheese cakes";
            //return View(_pieRepository.AllPies);

            PieListViewModel piesListViewModel = new PieListViewModel(
                _pieRepository.AllPies, "Cheese cakes");

            return View(piesListViewModel);
        }
    }
}