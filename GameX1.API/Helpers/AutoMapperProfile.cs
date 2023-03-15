namespace GameX1.UI.Helpers;

using AutoMapper;
using GameX1.Domain;
using GameX1.Model;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Picture, PictureModel>().ReverseMap();
        CreateMap<Picture, PictureModel>();
    }
}
