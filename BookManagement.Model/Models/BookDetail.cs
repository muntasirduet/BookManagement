using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagement.Model.Models;

public class BookDetail
{
    [Key]
    public int BookDetail_Id { get; set; }
    [Required]
    public int NumberOfChapter { get; set; }
    public int NumberOfPage { get; set; }
    public double Weight { get; set; }
    public Book Book { get; set; }
}