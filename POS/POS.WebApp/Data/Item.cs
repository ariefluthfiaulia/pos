using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POS.WebApp.Data
{
    public class Item
    {
        public Item()
        {
            this.TransactionDetail = new HashSet<TransactionDetail>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [ForeignKey("CategoryId")]
        public ItemCategory ItemCategory { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }
        public int UnitId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        [StringLength(30)]
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        [StringLength(30)]
        public string UpdatedBy { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

        [InverseProperty("Item")]
        public ICollection<TransactionDetail> TransactionDetail { get; set; }

    }
}
