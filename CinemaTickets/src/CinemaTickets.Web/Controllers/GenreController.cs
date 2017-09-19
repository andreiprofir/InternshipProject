using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTickets.Web.Controllers
{
    [Route("[controller]")]
    public class GenreController : Controller
    {
        [Route("{id}")]
        public IActionResult Get(long id)
        {
            return View();
        }
    }
}