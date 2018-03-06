using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FriendZone.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FriendZone.Controllers
{
    public class FriendsController : Controller
    {
        // GET: /<controller>/
        public IActionResult FriendsInfo()
        {
            return View();
        }

        public IActionResult Info(int id)
        {
            var model= FriendsRepository.GetFriendsInfoById(id);
            return View(model);
        }

        public IActionResult Match()
        {
            return View();
        }
    }
}
