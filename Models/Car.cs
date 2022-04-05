using System.ComponentModel.DataAnnotations;

namespace gregsnet.Models
{
  public class Car
  {
    public string Id { get; set; }

    [Required]
    [MinLength(4)]
    public string Make { get; set; }

    [Required]
    [MinLength(4)]
    public string Model { get; set; }

    [MinLength(4)]
    public string ImgUrl { get; set; }

    [Range(0, int.MaxValue)]
    public int? Year { get; set; }

    [Range(0, int.MaxValue)]
    public int? Price { get; set; }

    public Car(string make, string model, string imgUrl, int? year, int? price)
    {
      Id = Guid.NewGuid().ToString();
      Make = make;
      Model = model;
      ImgUrl = imgUrl;
      Year = year;
      Price = price;
    }
  }
}