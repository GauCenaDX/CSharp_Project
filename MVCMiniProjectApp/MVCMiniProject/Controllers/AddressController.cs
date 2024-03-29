﻿using Microsoft.AspNetCore.Mvc;
using MVCMiniProject.Models;

namespace MVCMiniProject.Controllers
{
    public class AddressController : Controller
    {
        //-- Adding a Logger for Address Controller
        private readonly ILogger<AddressController> _logger;

        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }
        //-----------------------------------------

        // GET: AddressController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AddressController/Create
        public ActionResult Create()    
        {
            return View();
        }

        // POST: AddressController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddressModel data)
        {
            //-- Adding Server Side validation
            if (ModelState.IsValid == false)
            {
                _logger.LogWarning("The User submitted an invalid Address upon Create.");

                return View();
            }
            //---------------------------------

            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
