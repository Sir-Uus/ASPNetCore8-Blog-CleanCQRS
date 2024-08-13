using System;
using AutoMapper;

namespace Application.Blogs.Common.Mappings;

public interface IMapForm<T>
{
    void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
}
