namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        //在介面中可宣告方法名稱 再交給類別進行實作
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
        //ProductDetails Server部分

    }
}
