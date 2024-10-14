using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    public class ProductModel
    {
        [Key]
        public int Product_Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 100 characters")]
        public string Product_Name { get; set; }

        [DisplayName("Product Price")]
        [Required(ErrorMessage = "Product price is required")]
        public decimal Product_Price { get; set; }

        [DisplayName("Product Stock")]
        [Required(ErrorMessage = "Product stock is required")]
        [Range(0, 10000, ErrorMessage = "Product stock must be between 1 and 10000 characters")]
        public int Product_Stock { get; set; }

        [DisplayName("Category Id")]
        [Required(ErrorMessage = "Category Id is required")]
        [Range(0, 10000, ErrorMessage = "Category Id debe must be between 0 and 100 characters.")]
        public int Category_Id { get; set; } // Llave foránea
    }
}
