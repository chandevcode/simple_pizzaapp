using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages.Forms

{
  public class CustomPizzaModel : PageModel
  {
    [BindProperty]
    public PizzasModel Pizza { get; set; }
    public float PizzaPrice { get; set; }
    public void OnGet()
    {

    }
    public IActionResult OnPost()
    {
      PizzaPrice = Pizza.BasePrice;
      if (Pizza.Cheese) PizzaPrice += 2;
      if (Pizza.TomatoSauce) PizzaPrice += 4;
      if (Pizza.Mushroom) PizzaPrice += 5;
      if (Pizza.Peperoni) PizzaPrice += 5;
      if (Pizza.Tuna) PizzaPrice += 1;
      if (Pizza.Beef) PizzaPrice += 1;
      if (Pizza.Ham) PizzaPrice += 12;
      if (Pizza.Pinapple) PizzaPrice += 5;

      return RedirectToPage("/Checkout/Checkout", new  { Pizza.PizzaName, PizzaPrice});
    }
  }
}