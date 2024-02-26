using CleanAr.Domain.Repository;
using MediatR;

namespace CleanAr.Application.Blogs.Queries.GetBlogs
{
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<BlogVm>>
    {
        private readonly IBlogRepository _blogRepository;

        public GetBlogQueryHandler(IBlogRepository blogRepository)
        {
            this._blogRepository = blogRepository;
        }
        public async Task<List<BlogVm>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            var blogs = await _blogRepository.GetAllBlogsAsync();

            var blogList = blogs.Select(x => new BlogVm
            {
                Author = x.Author,
                Name = x.Name,
                Description = x.Description,
                id = x.id
            }).ToList();

            return blogList;
        }
    }


    //new Style
    // public record GetBlogQuery: IRequest<List<BlogVm>>;

}
