﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWorld.ViewModels;
using TheWorld.Services;

namespace TheWorld.Controllers.Web
{
    public class AppController : Controller
    {
        ////service vs services
        //private IMailServices _mailService;

        //public AppController(IMailServices mailService)
        //{
        //    _mailService = mailService;
        //}
        public IActionResult Index()
        {
            return View();
        }


        
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact (ContactViewModel model)
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
