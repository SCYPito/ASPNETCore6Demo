using BlazorWasmNet6Exercise.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorWasmNet6Exercise.Pages
{
    public class PostBase : ComponentBase
    {
        [Parameter]
        public PostModel Post { get; set; }
        public EditContext editContext;

        protected override Task OnInitializedAsync()
        {
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
        public string ColorStyle { get; set; }
        [CascadingParameter(Name = "FontSizeStyle")]
        public string FontSizeStyle { get; set; }
    }
}
