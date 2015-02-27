using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfilio.Data.Models
{
    public class Feature
    {
        [Key]
        public int FeatureId { get; set; }
        public string Description { get; set; }
    }
}
