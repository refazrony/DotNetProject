using MediatR;

namespace CleanAr.Application.Blogs.Commands.DeleteBlog
{
    class DeleteBlogCommand : IRequest<int>
    {
        public int id { get; set; }
    }
}