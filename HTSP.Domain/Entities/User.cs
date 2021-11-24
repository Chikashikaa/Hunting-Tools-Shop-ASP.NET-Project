using System;
using System.ComponentModel.DataAnnotations;

namespace HTSP.Domain.Entities
{
    public class User
    {
        public Guid UserID { get; set; }
        [Display(Name = "Name")]
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string UserName { get; set; }
        [Display(Name = "Surname")]
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string UserLastName { get; set; }
        [Display(Name = "Email")]
        [Required]
        [StringLength(100)]
        public string UserEmail { get; set; }
        [Display(Name = "Phone")]
        [Required]
        [StringLength(15, MinimumLength = 10)]
        public string UserPhoneNumber { get; set; }

        public int AccountID { get; set; }
        public Account Account { get; set; }
    }
}
