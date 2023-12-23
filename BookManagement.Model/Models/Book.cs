using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookManagement.Model.Models.FluentModels;

namespace BookManagement.Model.Models;


[Table("tb_Book")]
public class Book
{
    [Key]
    [Column("BookID")]
    public int IDBook { get; set; }
    public string Title { get; set; }
    
    [MaxLength(20)]
    [Required]
    public string ISBN{ get; set; }
    public decimal Price { get; set; }
    [NotMapped]
    public string PriceRange { get; set; }     
    [ForeignKey("BookDetail")]
    public int BookDetail_Id { get; set; }
    public Fluent_BookDetail? BookDetail { get; set; }
    
    [ForeignKey("Publisher")]
    public int Publisher_Id { get; set; }
    public Publisher Publisher { get; set; }


    public List<BookAuthorMap> BookAuthorMap { get; set; }
}