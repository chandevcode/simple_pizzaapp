using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Data;
using RazorPizza.Models;

namespace RazorPizza.Pages
{
  public class OrderModel : PageModel
  {
    public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();

    private readonly ApplicationDbContext _context;

    public OrderModel(ApplicationDbContext context)
    {
      _context = context;
    }
    public void OnGet()
    {
      PizzaOrders = _context.PizzaOrders.ToList();
    }
  }
}