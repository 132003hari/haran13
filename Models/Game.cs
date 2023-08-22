using System.ComponentModel.DataAnnotations;
namespace Gamestore.client.Models;

public class Game
{
  public int Id { get; set; }  
  [Required]
  [StringLength (50)]
  public  required string Name { get; set; }=string.Empty;
  [Range(1,100)]
  public decimal Price { get; set; }
  public DateTime ReleaseDate { get; set; }
}