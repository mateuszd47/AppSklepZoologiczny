using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppSklepZoologiczny.Models
{
    public class Deliveries
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Order Id")]
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        [Required(ErrorMessage = "Date is required")]
        [Display(Name = "Date Deliveries")]
        public DateTime DateTimeDeliveries { get; set; }
        [Required]
        public bool IsDelivery { get; set; }
    }
}
