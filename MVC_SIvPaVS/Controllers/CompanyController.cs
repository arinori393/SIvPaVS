﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIvPaVS.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult CompanyAddress()
        {
            return PartialView();
        }


    }
}