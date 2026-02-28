using CoreRazorPagesDemo1.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CoreRazorPagesDemo1.Pages
{
    public class DisplayCustomerModel : PageModel
    {
        private readonly MvcdbContext _context;
        public Customer? Customer { get; set; }

        public DisplayCustomerModel(MvcdbContext context)
        {
            _context = context;
        }
        public void OnGet(int Custid)
        {
            Customer = _context.Customers.Find(Custid);
        }
    }
}