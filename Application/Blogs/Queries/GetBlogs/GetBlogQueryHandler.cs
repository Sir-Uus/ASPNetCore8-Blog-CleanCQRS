using AutoMapper;
using Domain.Repository;
using MediatR;

namespace Application.Blogs.Queries.GetBlogs;

public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<BlogVm>>
{
    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;

    public GetBlogQueryHandler(IBlogRepository blogRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }

    public async Task<List<BlogVm>> Handle(
        GetBlogQuery request,
        CancellationToken cancellationToken
    )
    {
        var blogs = await _blogRepository.GetAllBLogAsync();

        var blogList = _mapper.Map<List<BlogVm>>(blogs);

        return blogList;
    }
}
