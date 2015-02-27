using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfilio.Data.Models
{
    public class Tech
    {
        [Key]
        public int TechId { get; set; }
        public string Name { get; set; }
    }
}
