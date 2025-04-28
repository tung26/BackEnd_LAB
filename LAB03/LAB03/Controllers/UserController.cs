using LAB03.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB03.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>()
        {
            new User() {Id="1",Username="aaa",Password="1",Phone="111",Email="111"},
            new User() {Id="1",Username="aaa",Password="1",Phone="111",Email="111"},
            new User() {Id="1",Username="aaa",Password="1",Phone="111",Email="111"},
            new User() {Id="1",Username="aaa",Password="1",Phone="111",Email="111"},
            new User() {Id="1",Username="aaa",Password="1",Phone="111",Email="111"},
        };
        public IActionResult Index()
        {
            return View(users);
        }
    }
}
