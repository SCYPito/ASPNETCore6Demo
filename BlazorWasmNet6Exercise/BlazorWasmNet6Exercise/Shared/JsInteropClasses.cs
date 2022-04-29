using Microsoft.JSInterop;

namespace BlazorWasmNet6Exercise.Shared
{
    public class JsInteropClasses
    {
        private readonly IJSRuntime js;

        public   JsInteropClasses(IJSRuntime js) 
        {
            this.js = js;
        }

        public async ValueTask<bool> Confirm(string title) 
        {
            bool confirm = await js.InvokeAsync<bool>("Sweetconfirm", $"是否刪除{title}?");
            return confirm;
        }

        public void Dispose() 
        {
        }
    }
}
