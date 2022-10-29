using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;
namespace RazorPizza.Pages
{
  public class PizzaModel : PageModel
  {
    public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
    {
      new PizzasModel(){
        ImageTitle="Margerita",
        PizzaName="Margerita",
        BasePrice=2,
        TomatoSauce=true,
        Cheese=true,
        FinalPrice=4
      },
       new PizzasModel(){
        ImageTitle="Bolognese",
        PizzaName="Bolognese",
        BasePrice=2,
        TomatoSauce=true,
        Cheese=true,
        FinalPrice=4
      },
      new PizzasModel(){
        ImageTitle="Hawaiian",
        PizzaName="Hawaiian",
        BasePrice=2,
        TomatoSauce=true,
        Cheese=true,
        FinalPrice=4
      },
      new PizzasModel(){
        ImageTitle="Meatfeast",
        PizzaName="Meatfeast",
        BasePrice=2,
        TomatoSauce=true,
        Cheese=true,
        FinalPrice=4
      },
      new PizzasModel(){
        ImageTitle="Seafood",
        PizzaName="Seafood",
        BasePrice=3,
        TomatoSauce=true,
        Cheese=true,
        FinalPrice=6
      },
       new PizzasModel(){
        ImageTitle="Pepperoni",
        PizzaName="Pepperoni",
        BasePrice=3,
        TomatoSauce=true,
        Cheese=true,
        FinalPrice=6
      },


    };

    public void OnGet()
    {

    }
  }
}