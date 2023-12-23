using System.ComponentModel.DataAnnotations;

namespace BookManagement.Model.Models;

public class Publisher
{
    [Key]
    public int Publisher_Id { get; set; }
    [MaxLength(50)]
    [Required]
    public string Name { get; set; }
    
    public string Location { get; set; }
}