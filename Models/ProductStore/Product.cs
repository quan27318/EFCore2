using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFCore2.Models
{
    [Table("Product")]
    public class Product
    {
        // [Key]
        public int ProductID { get; set; }

        // [Column("ProductName", TypeName = "ntext")]
        // [MaxLength(200)]
        public string ProductName { get; set; }

        // [Column("Manufacture", TypeName = "ntext")]
        // [MaxLength(200)]

        public string Manufacture { get; set; }
        public int CategoryID { get; set; }


    }

}
