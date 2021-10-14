using System;
using System.Collections.Generic;
using MyFace.Models.Database;

namespace MyFace.Data
{
    public static class SamplePosts
    {
        public static IEnumerable<Post> GetPosts()
        {
            return new List<Post>
            {
                new Post
                {
                    Message = "Multi-tiered fault-tolerant flexibility",
                    ImageUrl = "https://picsum.photos/id/300/1280/960",
                    PostedAt = DateTime.Now,
                    UserId = 5
                },
                new Post
                {
                    Message = "Open-source 4th generation throughput",
                    ImageUrl = "https://picsum.photos/id/301/1280/960",
                    PostedAt = DateTime.Now,
                    UserId = 5
                },
                new Post
                {
                    Message = "Upgradable actuating extranet",
                    ImageUrl = "https://picsum.photos/id/302/1280/960",
                    PostedAt = DateTime.Now,
                    UserId = 5
                },
                new Post
                {
                    Message = "Operative optimal conglomeration",
                    ImageUrl = "https://picsum.photos/id/303/1280/960",
                    PostedAt = DateTime.Now,
                    UserId = 5
                },
                new Post
                {
                    Message = "Persevering maximized model",
                    ImageUrl = "https://picsum.photos/id/304/1280/960",
                    PostedAt = DateTime.Now,
                    UserId = 5
                },
                new Post
                {
                    Message = "Up-sized tangible contingency",
                    ImageUrl = "https://picsum.photos/id/305/1280/960",
                    PostedAt = DateTime.Now,
                    UserId = 1
                },
                new Post
                {
                    Message = "Exclusive optimal algorithm",
                    ImageUrl = "https://picsum.photos/id/306/1280/960",
                    PostedAt = DateTime.Now,
                    UserId = 1
                },
                new Post
                {
                    Message = "Profound neutral local area network",
                    ImageUrl = "https://picsum.photos/id/307/1280/960",
                    PostedAt = DateTime.Now,
                    UserId = 2
                },
                new Post
                {
                    Message = "Devolved directional flexibility",
                    ImageUrl = "https://picsum.photos/id/308/1280/960",
                    PostedAt = DateTime.Now,
                    UserId = 2
                },
                new Post
                {
                    Message = "Polarised context-sensitive access",
                    ImageUrl = "https://picsum.photos/id/309/1280/960",
                    PostedAt = DateTime.Now,
                    UserId = 2
                },
                new Post
                {
                    Message = "Total cohesive circuit",
                    ImageUrl = "https://picsum.photos/id/310/1280/960",
                    PostedAt = DateTime.Now,
                    UserId = 2
                },
                new Post
                {
                    Message = "Compatible reciprocal array",
                    ImageUrl = "https://picsum.photos/id/311/1280/960",
                    PostedAt = DateTime.Now,
                    UserId = 3
                },
                new Post
                {
                    Message = "Public-key neutral product",
                    ImageUrl = "https://picsum.photos/id/312/1280/960",
                    PostedAt = DateTime.Now,
                    UserId = 3
                },
                new Post
                {
                    Message = "Cross-platform intangible hardware",
                    ImageUrl = "https://picsum.photos/id/313/1280/960",
                    PostedAt = DateTime.Now,
                    UserId = 3
                },
                new Post
                {
                    Message = "Assimilated explicit array",
                    ImageUrl = "https://picsum.photos/id/314/1280/960",
                    PostedAt = DateTime.Now,
                    UserId = 4
                },
                new Post
                {
                    Message = "Adaptive bandwidth-monitored throughput",
                    ImageUrl = "https://picsum.photos/id/315/1280/960",
                    UserId = 4,
                    PostedAt = DateTime.Now,
                },
            };
        }
    }
}