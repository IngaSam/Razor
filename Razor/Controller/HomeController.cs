using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Razor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Razor.Controller
{
    public class HomeController: ControllerBase
    {
        public IActionResult Index()
        {
            Product myProduct = new Product()
            {
                ProductID = 1,
                Name = "Kayak",
                Description = "A boat for one person",
                Category = "Watersports",
                Price = 275M,
            };

            return Ok(myProduct);
        }
     }
}
