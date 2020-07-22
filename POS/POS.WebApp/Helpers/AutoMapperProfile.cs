using AutoMapper;
using POS.WebApp.Data;
using POS.WebApp.Dtos.Product;
using POS.WebApp.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace POS.WebApp.Helpers
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            var datetime = DateTimeOffset.Now;
            var user = ClaimTypes.Name;
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.ProductCategory,
                    opt => opt.MapFrom(src => src.ProductCategory.Name));
            CreateMap<ProductUpdateDto, Product>()
                .ForMember(dest => dest.CreatedAt,
                opt => opt.MapFrom(src => datetime))
                .ForMember(dest => dest.UpdatedAt,
                opt => opt.MapFrom(src => datetime))
                .ForMember(dest => dest.CreatedBy,
                opt => opt.MapFrom(src => user))
                .ForMember(dest => dest.UpdatedBy,
                opt => opt.MapFrom(src => user));

            CreateMap<User, UserDto>()
                .ForMember(dest => dest.UserRole,
                opt => opt.MapFrom(src => src.UserRole.Name))
                .ForMember(dest => dest.Gender,
                opt => opt.MapFrom(src => src.Gender.Name));

        }
    }
}
