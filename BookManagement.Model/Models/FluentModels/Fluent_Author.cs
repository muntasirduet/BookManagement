using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagement.Model.Models.FluentModels;

public class Fluent_Author
{
    public int Author_Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public DateTime BirthDate { get; set; }
    
    public string Location { get; set; }
    
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
}