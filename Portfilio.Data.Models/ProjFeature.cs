using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfilio.Data.Models
{
    public class ProjFeature
    {
        [Key]
        public int ProjFeatureId { get; set; }

        public int FeatureId { get; set; }
        [ForeignKey("FeatureId")]
        public virtual Feature Feature { get; set; }

        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }
    }
}
