using System.ComponentModel.DataAnnotations;

namespace BookManagement.Model.Models;

public class SubCategory
{
    [Key]
    public int SubCategory_Id { get; set; }
    [MaxLength(50)]
    [Required]
    public string Name { get; set; }
}