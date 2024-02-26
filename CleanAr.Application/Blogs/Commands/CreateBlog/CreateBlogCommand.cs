using CleanAr.Application.Blogs.Queries.GetBlogs;
using MediatR;

namespace CleanAr.Application.Blogs.Commands.CreateBlog
{

    class CreateBlogCommand : IRequest<BlogVm>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}