using AutoMapper;
using CleanAr.Application.Blogs.Queries.GetBlogs;
using CleanAr.Domain.Entity;
using CleanAr.Domain.Repository;
using MediatR;

namespace CleanAr.Application.Blogs.Commands.CreateBlog
{
   public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, BlogVm>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public CreateBlogCommandHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            this._blogRepository = blogRepository;
            this._mapper = mapper;
        }



        public async Task<BlogVm> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var blogEntity = new Blog()
            {
                Name = request.Name,
                Description = request.Description,
                Author = request.Author
            };
            var Result = await _blogRepository.CreateAsync(blogEntity);

            return _mapper.Map<BlogVm>(Result);
        }
    }

}