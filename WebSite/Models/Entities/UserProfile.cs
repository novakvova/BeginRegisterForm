using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebSite.Models.Entities
{
    [Table("tblUserProfiles")]
    public class UserProfile
    {
        [Key, ForeignKey("User")]
        public string Id { get; set; }
        [Required]
        [StringLength(maximumLength:255)]
        public string Image { get; set; }
        public DateTime ? DateBirth { get; set; }
        [Required]
        [StringLength(maximumLength: 1000)]
        public string Description { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}