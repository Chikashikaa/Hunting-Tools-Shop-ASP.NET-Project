using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HTSP.Domain.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Set Date")]
        public DateTime OrderSetDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Get Date")]
        public DateTime OrderGetDate { get; set; }
        [Display(Name = "Status")]
        [Required]
        public bool OrderStatus { get; set; }

        public Account Account { get; set; }

        public int OrderLineID { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }
}
