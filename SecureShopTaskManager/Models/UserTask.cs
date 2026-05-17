using System.ComponentModel.DataAnnotations;

namespace SecureShopTaskManager.Models
{
    public class UserTask
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public bool IsCompleted { get; set; }

        public string UserId { get; set; }
    }
}