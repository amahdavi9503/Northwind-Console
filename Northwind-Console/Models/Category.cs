using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NorthwindConsole.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        //CategoryName is required _ this is an annotation 
        [Required(ErrorMessage = "YO - Enter the name!")]   
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Category has a virtual property here, which triggers lazy loading vs eager loading
        public virtual List<Product> Products { get; set; }
    }
}