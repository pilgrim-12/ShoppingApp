using AutoMapper;
using ShoppingApp.Services.ProductAPI.Models;
using ShoppingApp.Services.ProductAPI.Models.Dto;

namespace ShoppingApp.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
