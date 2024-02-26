using AutoMapper;
using CleanAr.Domain.Entity;
using CleanAr.Domain.Repository;
using MediatR;

namespace CleanAr.Application.Blogs.Commands.UpdateBlog
{

    class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand, int>
    {
        private readonly IBlogRepository _blogRepository;


        public UpdateBlogCommandHandler(IBlogRepository blogRepository)
        {
            this._blogRepository = blogRepository;

        }
        public async Task<int> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var UpdateEntity = new Blog()
            {
                id = request.id,
                Name = request.Name,
                Description = request.Description,
                Author = request.Author
            };

            return await _blogRepository.UpdateAsync(request.id, UpdateEntity);
        }
    }
}