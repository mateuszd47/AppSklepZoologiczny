using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppSklepZoologiczny.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        [Required(ErrorMessage = "Date is required")]
        [Display(Name = "Date Order")]
        public DateTime DateTimeOrder { get; set; }
        [Required]
        [Display(Name = "Product")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Min value 1 / Max value 100")]
        public int Quantity { get; set; }
        [Required]
        [Precision(18, 2)]
        public decimal UnitPrice { get; set; }

    }
}
