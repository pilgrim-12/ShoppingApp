using ShoppingApp.Services.ShoppingCartAPI.Models.Dto;
namespace ShoppingApp.Services.ShoppingCartAPI.Service.IService;

public interface IProductService
{
    Task<IEnumerable<ProductDto>> GetProducts();
}
