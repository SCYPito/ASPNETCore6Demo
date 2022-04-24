using Microsoft.AspNetCore.Mvc;

namespace DemoWebAPI.Models
{
    public class Order
    {
        [FromRoute(Name ="oid")]
        public int Id { get; set; }
        [FromQuery(Name = "name")]
        public string Name { get; set; }
        [FromQuery(Name = "price")]
        public int Price { get; set; }
        [FromQuery(Name = "pid")]
        public int ProductId { get; set; }
    }
}
