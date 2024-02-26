using CleanAr.Domain.Repository;
using MediatR;

namespace CleanAr.Application.Blogs.Commands.DeleteBlog
{
    class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommand, int>
    {
        private readonly IBlogRepository _blogRepository;

        public DeleteBlogCommandHandler(IBlogRepository blogRepository)
        {
            this._blogRepository = blogRepository;
        }
        public async Task<int> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
        {
            return await _blogRepository.DelteAsync(request.id);
        }
    }
}