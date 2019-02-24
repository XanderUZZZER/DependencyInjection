﻿using DependencyInjection.Models;
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
        public IRepository Repository { get; } = TypeBroker.Repository;

        public ViewResult Index() => View(Repository.Products);
    }
}
