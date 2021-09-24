﻿using RegistroVMS.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroVMS.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PersonaViewModel()
        {

            return View();
        }
        public ActionResult PersonaViewModels(PersonaViewModel persona)
        {

            if (ModelState.IsValid)
            {
                return View("VistaMostrar" ,persona);
            }
            else
            return View("PersonaViewModel");

            
        }
        public ActionResult VistaMostrar()
        {
            return View();
        }

        public ActionResult VistaMostrars(PersonaViewModel PersonaViewModel)
        {
            return View("VistaMostrar");
        }
    }
}