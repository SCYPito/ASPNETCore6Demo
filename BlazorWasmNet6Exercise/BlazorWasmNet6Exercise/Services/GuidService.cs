namespace BlazorWasmNet6Exercise.Services
{
    public class GuidService : IGuidService
    {
        public string  uid { get; set; }

        public GuidService() 
        {
            uid = Guid.NewGuid().ToString();
        }
    }
}
