using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagement.Model.Models;

public class Author
{
    [Key]
    public int Author_Id { get; set; }
    [MaxLength(50)]
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    
    public DateTime BirthDate { get; set; }
    
    public string Location { get; set; }
    
    [NotMapped]
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
}