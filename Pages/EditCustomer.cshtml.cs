using CoreRazorPagesDemo1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CoreRazorPagesDemo1.Pages
{
    public class EditCustomerModel : PageModel
    {
        public Customer? Customer { get; set; }
        private readonly MvcdbContext context;
        public EditCustomerModel(MvcdbContext context)
        {
            this.context = context;
        }
        public void OnGet(int Custid)
        {
            Customer = context.Customers.Find(Custid);
        }
        public RedirectResult OnPost(Customer customer)
        {
            customer.Status = "true";
            context.Customers.Update(customer);
            context.SaveChanges();
            return Redirect("Index");
        }
    }
}