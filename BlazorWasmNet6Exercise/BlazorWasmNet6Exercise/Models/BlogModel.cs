using System.ComponentModel.DataAnnotations;

namespace BlazorWasmNet6Exercise.Models
{
    public class BlogModel
    {
        [Key]
        public int BlogId { get; set; }

        [MaxLength(10, ErrorMessage ="部落格名稱太長")]

        public string BlogName { get; set; }

        public List<PostModel> Posts { get; set; }

        public DateTime CreateDateTime { get; set; }

    }
}
