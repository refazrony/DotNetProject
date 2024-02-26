using AutoMapper;
using CleanAr.Application.Blogs.Queries.GetBlogs;
using CleanAr.Domain.Repository;
using MediatR;

namespace CleanAr.Application.Blogs.Queries.GetBlogById
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, BlogVm>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public GetBlogByIdQueryHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            this._blogRepository = blogRepository;
            this._mapper = mapper;
        }
        public async Task<BlogVm> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var blog = await _blogRepository.GetByIdAsync(request.BlogId);
            return _mapper.Map<BlogVm>(blog);
        }
    }
}