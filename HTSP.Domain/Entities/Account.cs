using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HTSP.Domain.Entities
{
    public class Account
    {
        public Guid AccountID { get; set; }
        [Display(Name = "Login")]
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string AccountLogin { get; set; }
        [Display(Name = "Password")]
        [Required]
        [StringLength(50, MinimumLength = 6)]
        public string AccountPassWord { get; set; }
        public User User { get; set; }

        public int OrderID { get; set; }
        public List<Order> Orders { get; set; }
    }
}
