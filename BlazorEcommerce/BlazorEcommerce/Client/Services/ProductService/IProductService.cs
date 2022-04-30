namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetProducts();
        //將Products資料全部撈出來的方法
        Task<ServiceResponse<Product>> GetProduct(int productId);
        ////將Products資料用(productId)搜尋的方法
    }
}
