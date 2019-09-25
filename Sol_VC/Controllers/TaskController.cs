using System;
using Microsoft.AspNetCore.Mvc;

namespace Sol_VC.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index(){

            return View();
        }
    }
}
