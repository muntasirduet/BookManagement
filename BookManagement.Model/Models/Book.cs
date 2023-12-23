using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    public BookDetail BookDetail { get; set; }
}