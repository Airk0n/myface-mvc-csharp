using System;
using Microsoft.AspNetCore.Mvc;
using MyFace.Models.Request;
using MyFace.Models.View;
using MyFace.Repositories;

namespace MyFace.Controllers
{
    [Route("/users")]
    public class UsersController : Controller
    {
        private readonly IUsersRepo _users;

        public UsersController(IUsersRepo users)
        {
            _users = users;
        }
        
        [HttpGet("all")]
        public IActionResult UsersPage(int pageNumber = 0, int pageSize = 10)
        {
            var users = _users.GetAll(pageNumber, pageSize);
            var viewModel = new UsersViewModel(users);
            return View(viewModel);
        }

        [HttpGet("{id}")]
        public IActionResult UserPage(int id)
        {
            var user = _users.GetById(id);
            var viewModel = new UserViewModel(user);
            return View(viewModel);
        }

        [HttpGet("create")]
        public IActionResult CreateUserPage()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult CreateUser(CreateUserRequestModel newUser)
        {
            if (!ModelState.IsValid)
            {
                return View("CreateUserPage", newUser);
            }
            
            _users.Create(newUser);
            return RedirectToAction("UsersPage");
        }
    }
}