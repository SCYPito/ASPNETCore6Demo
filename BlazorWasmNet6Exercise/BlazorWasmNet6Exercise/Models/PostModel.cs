using System.ComponentModel.DataAnnotations;

namespace BlazorWasmNet6Exercise.Models
{
    public class PostModel
    {
        public int PostId { get; set; }
        [Required]
        [MaxLength(10,ErrorMessage ="標題太長")]
        public string? Title { get; set; }
        [Required]
        [MinLength(100, ErrorMessage = "內容太短")]
        public string? Content { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
