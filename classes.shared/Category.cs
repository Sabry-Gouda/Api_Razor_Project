using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes.shared
{
    public class Category
    {
        public int id { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(3, ErrorMessage = "Name Must Be More Than Two Character")]
        public string name { get; set; }
        public virtual List<Product> products { get; set; }
    }
}
