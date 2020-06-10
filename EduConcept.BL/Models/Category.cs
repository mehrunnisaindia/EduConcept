using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EduConcept.BL.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Category Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }

        public int? ParentId{ get; set; }
        [ForeignKey("ParentId")]
        public virtual Category Parent { get; set; }

        public virtual ICollection<Category> Children { get; set; }



    }
}
