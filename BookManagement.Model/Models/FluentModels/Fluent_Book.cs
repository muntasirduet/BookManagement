using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagement.Model.Models.FluentModels;



public class Fluent_Book
{

    public int IDBook { get; set; }
    public string Title { get; set; }
 
    public string ISBN{ get; set; }
    public decimal Price { get; set; }
    public string PriceRange { get; set; }
    public Fluent_BookDetail FluentBookDetail { get; set; }

}