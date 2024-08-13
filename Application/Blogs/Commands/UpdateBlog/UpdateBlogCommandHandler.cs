using AutoMapper;
using Domain.Entity;
using Domain.Repository;
using MediatR;

namespace Application.Blogs.Commands.UpdateBlog;

public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand, int>
{
    private readonly IBlogRepository _blogRepository;

    public UpdateBlogCommandHandler(IBlogRepository blogRepository)
    {
        _blogRepository = blogRepository;
    }

    public async Task<int> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
    {
        var UpdateBlogEntity = new Blog()
        {
            Id = request.Id,
            Name = request.Name,
            Description = request.Description,
            Author = request.Author,
        };

        await _blogRepository.UpdateAsync(request.Id, UpdateBlogEntity);

        return request.Id;
    }
}
