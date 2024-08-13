using Application.Blogs.Queries.GetBlogs;
using MediatR;

namespace Application.Blogs.Queries.GetBlogsById;

public class GetBlogByIdQuery : IRequest<BlogVm>
{
    public int BlogId { get; set; }
}
