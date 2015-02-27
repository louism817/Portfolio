﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfilio.Data.Models
{
    public class ProjTech
    {
        [Key]
        public int ProjTechId { get; set; }

        public int TechId { get; set; }
        [ForeignKey("TechId")]
        public virtual Tech Tech { get; set; }

        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }
    }
}
