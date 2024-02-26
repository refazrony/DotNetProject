using MediatR;

namespace CleanAr.Application.Blogs.Commands.UpdateBlog
{



    class UpdateBlogCommand : IRequest<int>
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}