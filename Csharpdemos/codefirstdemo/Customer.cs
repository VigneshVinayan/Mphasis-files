using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.ComponentModel;

namespace codefirstdemo
{
    public class Customer
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]// now it won't increment automatically
        [Column("CustomerId")]
        public int id { get; set; }

        [Required(ErrorMessage = "Customer name cannot be blank")]
        [Column("CustomerName",TypeName = "nvarchar")]
        [RegularExpression("[a-z]+",ErrorMessage = "name should only be characters")]
        [MaxLength(100)]
        public string name{ get; set; }

        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        
        public string caddress { get; set; }

        [Column( TypeName = "varchar")]
        [MaxLength(10)]
        [RegularExpression("[0-9]{10}",ErrorMessage = "Invalid Number")]
        public string phone { get; set; }
        [RegularExpression("[0-9]+", ErrorMessage = "Not a valid age")]
        [Range(20, 60, ErrorMessage = "You are not eligible")]
        public int age { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email")]
        [Required(ErrorMessage = "Email should not be blank")]
        public string Email { get; set; }
        [RegularExpression("[India|UK|Canada]+",ErrorMessage = "Invalid Nationality")]
        public string Nationality { get; set; }
    }
}
