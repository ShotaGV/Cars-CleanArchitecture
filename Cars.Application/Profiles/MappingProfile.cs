using AutoMapper;
using Cars.Application.Dtos.BrandDtos;
using Cars.Application.Dtos.ModelDtos;
using Cars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cars.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Brand, BrandDto>().ReverseMap();
            CreateMap<Brand, CreateBrandDto>().ReverseMap();
            CreateMap<Brand, UpdateBrandDto>().ReverseMap();
            CreateMap<Model, ModelDto>().ReverseMap();
            CreateMap<Model, CreateModelDto>().ReverseMap();
            CreateMap<Model, UpdateModelDto>().ReverseMap();

        }
    }
}
