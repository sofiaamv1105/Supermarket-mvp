using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class CustomersModel
    {
        [Key] 
        public int Customer_Id { get; set; }

        [DisplayName("Document Number")]
        [Required(ErrorMessage = "Document number is required")]
        [StringLength(50, ErrorMessage = "Document number must be a maximum of 50 characters")]
        public string Document_Number { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters")]
        public string First_Name { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters")]
        public string Last_Name { get; set; }

        [DisplayName("Address")]
        [Required(ErrorMessage = "Address is required")]
        [StringLength(255, ErrorMessage = "Address must be a maximum of 255 characters")]
        public string Address { get; set; }

        [DisplayName("Birthday")]
        [Required(ErrorMessage = "Birthday is required")]
        [DataType(DataType.Date)] 
        public DateTime Birthday { get; set; }

        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "Phone number is required")]
        [StringLength(15, ErrorMessage = "Phone number must be a maximum of 15 characters")]
        public string Phone_Number { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        [StringLength(100, ErrorMessage = "Email must be a maximum of 100 characters")]
        public string Email { get; set; }
    }
}
