namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        //當categoryUrl改變的時候 事件動作
        List<Product> Products { get; set; }
        Task GetProducts(string categoryUrl = null);
        //將Products資料全部撈出來的方法
        Task<ServiceResponse<Product>> GetProduct(int productId);
        //將Products資料用(productId)搜尋的方法

    }
}
