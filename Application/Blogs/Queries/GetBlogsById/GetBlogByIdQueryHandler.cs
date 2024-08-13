using System;
using Application.Blogs.Queries.GetBlogs;
using AutoMapper;
using Domain.Repository;
using MediatR;

namespace Application.Blogs.Queries.GetBlogsById;

public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, BlogVm>
{
    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;

    public GetBlogByIdQueryHandler(IBlogRepository blogRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }

    public async Task<BlogVm> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
    {
        var blog = await _blogRepository.GetByIdAsync(request.BlogId);

        return _mapper.Map<BlogVm>(blog);
    }
}
