using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class ProjectViewModel
    {
        public int ProjectId { get; set; }
        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }
        public string Description { get; set; }
        [Display(Name = "Image Path")]
        public string ImagePath { get; set; }
        public string ProjectUrl { get; set; }
        public string GitHubRep { get; set; }
        public List<TechViewModel> Technologies { get; set; }
        public List<FeatureViewModel> Features { get; set; }
    }

    public class TechViewModel
    {
        public int TechId { get; set; }
        public string Name { get; set; }
    }

    public class FeatureViewModel
    {
        public int FeatureId { get; set; }
        public string Description { get; set; }
    }
}