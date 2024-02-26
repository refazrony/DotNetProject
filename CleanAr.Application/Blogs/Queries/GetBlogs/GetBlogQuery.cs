using MediatR;

namespace CleanAr.Application.Blogs.Queries.GetBlogs
{
    public class GetBlogQuery : IRequest<List<BlogVm>>
    {

    }


    //new Style
    // public record GetBlogQuery: IRequest<List<BlogVm>>;

}

