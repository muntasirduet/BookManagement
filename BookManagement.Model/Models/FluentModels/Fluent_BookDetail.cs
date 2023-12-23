using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagement.Model.Models.FluentModels;

public class Fluent_BookDetail
{

    public int BookDetail_Id { get; set; }

    public int NumberOfChapter { get; set; }
    public int NumberOfPage { get; set; }
    public double Weight { get; set; }

    public int Book_Id { get; set; }
    public Fluent_Book Book { get; set; }

}