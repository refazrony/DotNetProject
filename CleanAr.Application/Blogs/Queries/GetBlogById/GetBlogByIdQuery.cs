using CleanAr.Application.Blogs.Queries.GetBlogs;
using CleanAr.Application.Commoms.Mappings;
using MediatR;

namespace CleanAr.Application.Blogs.Queries.GetBlogById
{
    public class GetBlogByIdQuery : IRequest<BlogVm>
    {
        public int BlogId { get; set; }


    }
}
