using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pizza.Models;
using System;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pizza.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PizzaController(IPizzaRepository pizzaRepository, ICategoryRepository _categoryRepository)
        {
            _pizzaRepository = pizzaRepository;
            _categoryRepository = categoryRepository;
        }
        //action method nameed list
        public ViewResult List()
        {
            return View(_pizzaRepository.Pizzas);
        }
    }
}
