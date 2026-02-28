using CoreRazorPagesDemo1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreRazorPagesDemo1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MvcdbContext context;
        public IndexModel(MvcdbContext context)
        {
            this.context = context;
        }
        public List<Customer>? Customers { get; set; }
        public void OnGet()
        {
            Customers = context.Customers.Where(C => C.Status == "true").ToList();
        }

    }
}
