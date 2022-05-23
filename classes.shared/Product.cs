using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes.shared
{
    public class Product
    {
        public int id { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(3,ErrorMessage ="Name Must Be More Than Two Character")]
        public string name { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(3, ErrorMessage = "Description Must Be More Than Two Character")]
        public string description { get; set; }
        [Required]
       [RegularExpression(@"\w+\.(jpg|png)")]
        public string image { get; set; }
        [Required]
       [Range(minimum:1,maximum:int.MaxValue)]
        public int Price { get; set; }
        [ForeignKey("category")]
        public int Cat_id { get; set; }

        public virtual Category category { get; set; }
    }
}
