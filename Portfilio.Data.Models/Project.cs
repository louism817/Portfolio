using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfilio.Data.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string ProjectUrl { get; set; }
        public string GitHubRep { get; set; }

    }
}
