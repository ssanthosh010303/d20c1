/*
 * Author: Sakthi Santhosh
 * Created on: 09/05/2024
 */
using System.ComponentModel.DataAnnotations;

namespace Challenge1.PizzaAppLibrary;

public class Pizza
{
    public int Id { get; set; }

    [Required]
    [StringLength(256)]
    public string Name { get; set; }

    [Required]
    [Range(0.1, 1000)]
    public decimal PriceDollars { get; set; }

    [MaxLength(10)]
    public List<Topping> Toppings { get; set; }
}

public class Topping
{
    public int ToppingId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }
}
