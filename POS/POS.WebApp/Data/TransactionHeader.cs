using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POS.WebApp.Data
{
    public class TransactionHeader
    {
        public TransactionHeader()
        {
            this.TransactionDetail = new HashSet<TransactionDetail>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        [StringLength(30)]
        public string UpdatedBy { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

        [InverseProperty("TransactionHeader")]
        public ICollection<TransactionDetail> TransactionDetail { get; set; }
    }
}
