using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shoptask.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public bool EnableSize { get; set; }
        public int companyID { get; set; }
        [ForeignKey("companyID")]
        public Company company { get; set; }
    }
}
