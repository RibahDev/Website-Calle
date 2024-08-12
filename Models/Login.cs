using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalleStore.Models
{
    [Table("Product")]
    public class Login
    {
        [Key]
        public int Id { get; set; }

        
        
    }
}