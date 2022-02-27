using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFCore2.Models
{
    [TableAttribute("Category")]
    public class Category
    {
        //[Key]
        public int CategoryID { get; set; }
        // [Column("CategoryName", TypeName = "ntext")]
        // [MaxLength(200)]
        public string CategoryName { get; set; }
        
    }
}
