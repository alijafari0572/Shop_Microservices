using Products.domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

namespace Products.Infra.Products
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductReqDto>().ReverseMap();
            CreateMap<Product, ProductResDto>().ForMember(dest => dest.CategoryTitle_Id,
                config =>
                    config.MapFrom(src => $"{src.Category.Title}({src.CategoryId})")).ReverseMap();
        }
    }
}