using System.ComponentModel.DataAnnotations;

namespace BookManagement.Model.Models.FluentModels;

public class Fluent_Publisher
{ 
    public int Publisher_Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }

}