using BlazorWasmNet6Exercise.Models;
using BlazorWasmNet6Exercise.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;

namespace BlazorWasmNet6Exercise.Pages
{
    public class PostBase : ComponentBase, IDisposable
    {
        [Inject]
        protected IJSRuntime js { get; set; }

        [Parameter]
        public PostModel Post { get; set; }
        public EditContext editContext;
        private JsInteropClasses jsClass;

        protected override Task OnInitializedAsync()
        {
            jsClass = new(js);
            editContext = new EditContext(Post);
            editContext.SetFieldCssClassProvider(new CustomFieldClassProvider());
            return base.OnInitializedAsync();
        }

        private void TitleChanged(string value)
        {
            Post.Title = value;
        }

        //[Parameter]
        //public Dictionary<string, object> InputAttributes { get; set; } =
        //new Dictionary<string, object>()
        //  {
        //        { "value", "Submit"},
        //        { "class", "btn btn-primary"},
        //        { "type", "Button"},
        //  };

        [CascadingParameter(Name = "ColorStyle")]
        public string ColorStyle { get; set; } = "color: goldenrod";
        //[CascadingParameter(Name = "FontSizeStyle")]
        //public string FontSizeStyle { get; set; }

        [Parameter]
        public EventCallback<int> getPostId { get; set; }
        //[Parameter]
        //public Action<int> getPostIdForDelegate { get; set; }
        protected void returnPostId()
        {
            getPostId.InvokeAsync(Post.PostId);
            //getPostIdForDelegate.Invoke(Post.PostId);
        }

        protected async Task deletePost() 
        {
            //方法一
            //bool confirm = await js.InvokeAsync<bool>("confirm", $"是否刪除{Post.Title}?");
            //方法二 將 JS function封包起來，享受強型別的優勢
            bool confirm = await jsClass.Confirm(Post.Title);
            if (confirm) 
            {
                await getPostId.InvokeAsync(Post.PostId);
            }
        }

        public void Dispose()
        {
            jsClass?.Dispose();
        }
    }
}
