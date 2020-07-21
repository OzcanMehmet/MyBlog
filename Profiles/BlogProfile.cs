
using AutoMapper;
using myblog.Model.DTO;
using myblog.Model.Entity;

namespace AdessoRideShare.Profiles
{
    public class BlogProfile : Profile
    {
        public BlogProfile()
        {
            CreateMap<CreateBlogDTO,Blog>();
            CreateMap<UpdateBlogDTO,Blog>();
        }
    }
}