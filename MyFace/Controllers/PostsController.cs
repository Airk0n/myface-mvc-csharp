﻿using System;
using Microsoft.AspNetCore.Mvc;
using MyFace.Models.Request;
using MyFace.Models.View;
using MyFace.Repositories;

namespace MyFace.Controllers
{
    [Route("/posts")]
    public class PostsController : Controller
    {
        private readonly IPostsRepo _posts;
        private readonly IInteractionsRepo _interactions;

        public PostsController(IPostsRepo posts, IInteractionsRepo interactions)
        {
            _posts = posts;
            _interactions = interactions;
        }
        
        [HttpGet("")]
        public IActionResult PostsPage(int pageNumber = 0, int pageSize = 10)
        {
            
            var posts = _posts.GetAll(pageNumber, pageSize);
            var viewModel = new PostsViewModel(posts);
            return View(viewModel);
        }

        [HttpGet("create")]
        public IActionResult CreatePostPage()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult CreatePost(CreatePostRequestModel newPost)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Model not valid");
                return View("CreatePostPage", newPost);
            }

            Console.WriteLine("Message:" + newPost.Message);
            newPost.UserId = 1;
            _posts.CreatePost(newPost);
            return RedirectToAction("PostsPage");

        }

        [HttpPost("{id}/add-interaction")]
        public IActionResult AddInteraction(int id, CreateInteractionRequestModel newInteraction)
        {
            Console.WriteLine("Are we in here?");
            _interactions.Create(newInteraction, id);
            return RedirectToAction("PostsPage");
        }
        
        // TODO [HttpDelete]
    }
}