namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        //在介面中可宣告方法名稱 再交給類別進行實作
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
        //ProductDetails Server部分
        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
        //利用categoryUrl搜尋該類別取得清單
        Task<ServiceResponse<List<Product>>> SearchProducts(string searchText);
        //Server接受搜尋字串取得清單
        Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText);
        //
    }
}
