using System.ComponentModel.DataAnnotations;

namespace ReminderShaveBlazor.Models
{
    public class Shave
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Status is required")]
        public ShaveStatus Status { get; set; }
        
        [Required(ErrorMessage = "ShavedOn date is required")]
        public DateTime? ShavedOn { get; set; }
    }

    public enum ShaveStatus
    {
        NotShaved,
        Shaved,
    }
}
