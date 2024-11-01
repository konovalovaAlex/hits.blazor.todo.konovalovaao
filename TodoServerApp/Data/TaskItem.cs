using System.ComponentModel.DataAnnotations;

namespace TodoServerApp.Data
{
    public class TaskItem
    {
        public int ID { get; set; }
        [Required]

        public string? Title { get; set; }
        [Required]

        public string? Description { get; set; }
        public DateTime? CratedDate { get; set; }
        public DateTime? FInishdDate { get; set; }

    }
}
