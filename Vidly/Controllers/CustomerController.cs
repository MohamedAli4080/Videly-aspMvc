using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public static List<Customer> Customers =new List<Customer>()
        {
            new Customer {ID=1, Name="Mohamed"},
            new Customer {ID=2, Name="Omer"},
            new Customer {ID=3, Name="Khaled"},
            new Customer {ID=4, Name="dedo"},
            new Customer {ID=5, Name="Ali"}
        };

        public ActionResult Index()
        {
            return View(Customers);
        }
        public ActionResult Details(int ID)
        {
             
            var customer = Customers.Find(c => c.ID == ID);
            if (customer==null )
            {
                 return HttpNotFound();
            }
            return View(customer);

        }
    }
}