using System;
using System.ComponentModel.DataAnnotations;

namespace HTSP.Domain.Entities
{
    public class Article
    {
        public Guid ArticleID { get; set; }
        [Display(Name = "Naming")]
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string ArticleNaming { get; set; }
        public string ArticleImageConnectionStrings { get; set; }
        [Display(Name = "Type")]
        [Required]
        public string ArticleType { get; set; }
        [Display(Name = "Maker")]
        [Required]
        public string ArticleMaker { get; set; }
        [Display(Name = "Price")]
        [Required]
        public float ArticlePrice { get; set; }
        public string ArticleDescription { get; set; }


        public int OrderLineID { get; set; }
        public OrderLine OrderLine { get; set; }
    }
}
