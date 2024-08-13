using System;
using Domain.Repository;
using MediatR;

namespace Application.Blogs.Commands.DeleteBlog;

public class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommand, int>
{
    private readonly IBlogRepository _blogRepository;

    public DeleteBlogCommandHandler(IBlogRepository blogRepository)
    {
        _blogRepository = blogRepository;
    }

    public async Task<int> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
    {
        await _blogRepository.DeleteAsync(request.Id);

        return request.Id;
    }
}
