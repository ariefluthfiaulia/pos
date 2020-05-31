using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POS.WebApp.Data
{
    public class TransactionDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("TransactionHeaderId")]
        public TransactionHeader TransactionHeader { get; set; }
        public int TransactionHeaderId { get; set; }
        [ForeignKey("ItemId")]
        public Item Item { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        [StringLength(30)]
        public string UpdatedBy { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
