using AutoMapper;
using ShoppingApp.Services.AuthAPI.Models;
using ShoppingApp.Services.AuthAPI.Models.Dto;

namespace ShoppingApp.Services.AuthAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<UserDto, User>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
