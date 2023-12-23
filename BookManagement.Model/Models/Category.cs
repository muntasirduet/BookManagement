using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagement.Model.Models;

[Table("Categories")]
public class Category
{
    [Key]
    public int GenreId { get; set; }
    
    
    [Column("Name")]
    [Required]
    public string CategoryName { get; set; }
    
}