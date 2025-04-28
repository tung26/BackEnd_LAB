using LAB03.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LAB03.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>()
        {
            new User() { Id = "1", Username = "aaa", Password = "1", Phone = "111", Email = "111" },
            new User() { Id = "2", Username = "bbb", Password = "2", Phone = "222", Email = "222" },
            new User() { Id = "3", Username = "ccc", Password = "3", Phone = "333", Email = "333" },
            new User() { Id = "4", Username = "ddd", Password = "4", Phone = "444", Email = "444" },
            new User() { Id = "5", Username = "eee", Password = "5", Phone = "555", Email = "555" },
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View(users);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    users.Add(user);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }

            return View(user);
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = users.FirstOrDefault(u => u.Id == user.Id);
                if (existingUser != null)
                {
                    existingUser.Username = user.Username;
                    existingUser.Password = user.Password;
                    existingUser.Email = user.Email;
                    existingUser.Phone = user.Phone;

                    return RedirectToAction("Index");
                }
            }
            return View(user);
        }
    }
}