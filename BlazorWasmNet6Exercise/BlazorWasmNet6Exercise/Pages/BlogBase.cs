using BlazorWasmNet6Exercise.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorWasmNet6Exercise.Pages
{
    public class BlogBase : ComponentBase
    {
        public BlogModel Blog { get; set; }
        public int postId { get; set; } = 0;

        protected override Task OnInitializedAsync()
        {
            loadData();
            return base.OnInitializedAsync();
        }
        private void loadData()
        {
            Blog = new BlogModel
            {
                BlogId = 1,
                BlogName = "我的部落格",
                //Posts = new List<PostModel> {
                //    new PostModel{PostId=1, Title = "標題1", Content ="內容1", CreateDateTime = new (2021,9,7,10,20,35) },
                //    new PostModel{PostId=2, Title = "標題2", Content ="內容2", CreateDateTime = new (2021,9,8,11,21,36) },
                //    new PostModel{PostId=3, Title = "標題3", Content ="內容3", CreateDateTime = new (2021,9,9,12,22,37) },
                //    new PostModel{PostId=4, Title = "標題4", Content ="內容4", CreateDateTime = new (2021,9,10,13,23,38) },
                //},
                CreateDateTime = new (2021,9,7,10,20,35),
            };
            if(Blog.Posts == null) 
            {
                Blog.Posts = new List<PostModel>();
            }
        }
        public string ColorStyle { get; set; } = "color:goldenrod";
        //[CascadingParameter(Name = "FontSizeStyle")]
        //public string FontSizeStyle { get; set; }

        protected void add() 
        {
            postId++;
            Blog.Posts.Add(new PostModel() { PostId= postId });
        }

        protected void getPostId(int id)
        {
            Blog.Posts.Remove(Blog.Posts.FirstOrDefault(p => p.PostId == id));
            //StateHasChanged();
        }
    }
}
