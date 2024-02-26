using AutoMapper;
using CleanAr.Domain.Repository;
using MediatR;

namespace CleanAr.Application.Blogs.Queries.GetBlogs
{
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<BlogVm>>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public GetBlogQueryHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            this._blogRepository = blogRepository;
            this._mapper = mapper;
        }
        public async Task<List<BlogVm>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            var blogs = await _blogRepository.GetAllBlogsAsync();

            // var blogList = blogs.Select(x => new BlogVm
            // {
            //     Author = x.Author,
            //     Name = x.Name,
            //     Description = x.Description,
            //     id = x.id
            // }).ToList();

            var blogList = _mapper.Map<List<BlogVm>>(blogs);

            return blogList;
        }
    }


    //new Style
    // public record GetBlogQuery: IRequest<List<BlogVm>>;

}
