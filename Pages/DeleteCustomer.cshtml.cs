using CoreRazorPagesDemo1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CoreRazorPagesDemo1.Pages
{
    public class DeleteCustomerModel : PageModel
    {
        public Customer Customer { get; set; }
        private readonly MvcdbContext context;
        public DeleteCustomerModel(MvcdbContext context)
        {
            this.context = context;
        }
        public void OnGet(int Custid)
        {
            Customer = context.Customers.Find(Custid);
        }
        public RedirectResult OnPost(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
            return Redirect("Index");
        }
    }
}