﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WebAppTagHelper.Models;

namespace WebAppTagHelper.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        public IActionResult RegisterTH(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            var model = new RegisterViewModel
            {
                FirstName = "Joe",
                LastName = "Plumber",
                CountryCode = "US",
                Email = "Joe@Whitehouse.gov",
                SpecialMeal = true,
                RegisterAddress = new RegisterAddress
                {
                    City = "San Francisco",
                    State = "CA",
                    PhoneNumber = "408-876-1234"
                }
            };
            ViewBag.Countries = new List<SelectListItem>
            {
                new SelectListItem { Value = "MX", Text = "Mexico" },
                new SelectListItem { Value = "CA", Text = "Canada" },
                new SelectListItem { Value = "US", Text = "USA" },
                new SelectListItem { Value = "FR", Text = "France" },
                new SelectListItem { Value = "ES", Text = "Spain" },
                new SelectListItem { Value = "DE", Text = "Germany"}
            };
            ViewBag.Countries = ViewBag.Countries;
            return View("RegisterTH", model);
        }




        [HttpGet]
        [AllowAnonymous]
        public IActionResult RegisterTHSimple(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            var model = new RegisterViewModel
            {
                FirstName = "Joe",
                LastName = "Plumber",
                CountryCode = "US",
                Email = "Joe@Whitehouse.gov",
                SpecialMeal = true,
                RegisterAddress = new RegisterAddress
                {
                    City = "San Francisco",
                    State = "CA",
                    PhoneNumber = "408-876-1234"
                }
            };
            ViewData["ReturnUrl"] = returnUrl;
            return View("RegisterTHSimple", model);
        }

       
    }
}