using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POS.WebApp.Data
{
    public class Unit
    {
        public Unit()
        {
            this.Item = new HashSet<Item>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }

        [InverseProperty("Unit")]
        public ICollection<Item> Item { get; set; }
    }
}
