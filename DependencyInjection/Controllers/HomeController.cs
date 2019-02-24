using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;

        public HomeController(IRepository repo) => repository = repo;

        public ViewResult Index() => View(repository.Products);
    }
}
