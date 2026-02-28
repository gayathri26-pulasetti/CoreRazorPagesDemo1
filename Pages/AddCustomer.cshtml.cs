using CoreRazorPagesDemo1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CoreRazorPagesDemo1.Pages
{

    public class AddCustomerModel : PageModel
    {
        public Customer? Customer { get; set; }
        private readonly MvcdbContext context;
        public AddCustomerModel(MvcdbContext context)
        {
            this.context = context;
        }
        public RedirectResult OnPost(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return Redirect("Index");
        }
    }
}