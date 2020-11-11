using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    [Table("Assignment")]
    public class Assignment
    {
        public Assignment()
        {

        }
        [Key]
        public int AssignmentId { get; set; }
        [Required]
        [MaxLength(80)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Describe { get; set; }
        public bool Finish { get; set;  }
        [Required]
        public DateTime Date { get; set; }
        public Category Category { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
