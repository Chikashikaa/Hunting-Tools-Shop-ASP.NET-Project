using System;
using System.ComponentModel.DataAnnotations;

namespace HTSP.Domain.Entities
{
    public class OrderLine
    {
        public Guid OrderLineID { get; set; }
        [Required]
        public int ArticleNumber { get; set; }

        public Article Article { get; set; }

        public Guid OrderID { get; set; }
        public Order Order { get; set; }
    }
}


