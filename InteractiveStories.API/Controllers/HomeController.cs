using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InteractiveStories.API.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Api Endpoint";
        }
    }
}
