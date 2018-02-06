using System;
using Parcels.Models;
using Microsoft.AspNetCore.Mvc;

namespace Parcels.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Form()
        {
            return View();
        }

        [Route("/parcels")]
        public ActionResult Parcels()
        {
            ParcelVariable myParcel = new ParcelVariable();
            myParcel.SetWeight(Request.Query["weight"]);
            myParcel.SetLength(Request.Query["length"]);
            myParcel.SetWidth(Request.Query["width"]);
            myParcel.SetHeight(Request.Query["height"]);
            myParcel.SetPrice();
            return View(myParcel);
        }
    }
}
