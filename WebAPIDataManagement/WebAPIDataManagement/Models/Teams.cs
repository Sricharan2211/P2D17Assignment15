using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIDataManagement.Models
{
    [Table("Teams")]
    public class Teams
    {
        [Key]
        public int TId {  get; set; }
        [Required]
        [StringLength(50)]
        public string TName { get; set; }
        [Required]
        public string TEmail {  get; set; }
        [Required]
        [StringLength (50)]
        public string TSlogan {  get; set; }
    }
}