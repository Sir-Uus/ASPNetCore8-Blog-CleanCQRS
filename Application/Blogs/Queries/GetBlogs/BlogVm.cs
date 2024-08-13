using Application.Blogs.Common.Mappings;
using Domain.Entity;

namespace Application.Blogs.Queries.GetBlogs;

public class BlogVm : IMapForm<Blog>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
}
