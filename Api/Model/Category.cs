using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    [Table("Category")]
    public class Category
    {
        public Category()
        {
            Assignment = new Collection<Assignment>();
        }
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(20)]
        public string Type { get; set; }
        public ICollection<Assignment> Assignment { get; set; }
    }
}
