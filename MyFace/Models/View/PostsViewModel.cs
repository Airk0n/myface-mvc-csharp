using System.Collections.Generic;
using System.Linq;
using MyFace.Models.Database;
using MyFace.Models.Request;

namespace MyFace.Models.View
{
    public class PostsViewModel
    {
        public IEnumerable<PostViewModel> Posts { get; }
        public CreateInteractionRequestModel CreateInteractionRequestModel = new CreateInteractionRequestModel();

        public PostsViewModel(IEnumerable<Post> posts)
        {
            Posts = posts.Select(post => new PostViewModel(post));
        }

        void Test()
        {
            var test = this;
        }
    }
}