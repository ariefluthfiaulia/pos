using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POS.WebApp.Data
{
    public class Product
    {
        public Product()
        {
            this.TransactionDetail = new HashSet<TransactionDetail>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [ForeignKey("ProductCategoryId")]
        public ProductCategory ProductCategory { get; set; }
        public int ProductCategoryId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        [StringLength(30)]
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        [StringLength(30)]
        public string UpdatedBy { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

        [InverseProperty("Product")]
        public ICollection<TransactionDetail> TransactionDetail { get; set; }

    }
}
