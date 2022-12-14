using Exception_Handling_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exception_Handling_MVC.Controllers
{
    public class ContactsController : Controller
    {

        private readonly AdvancedTestDbContext _dbContext;
        public ContactsController(AdvancedTestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<TblContact> contacts = _dbContext.TblContacts.ToList();

            return View(contacts);
        }

        public IActionResult EditContact(int id)
        {
            try
            {
                //throw new Exception("Error in Loading Edit Form");
                var cnt = _dbContext.TblContacts.Find(id);
                var contact = _dbContext.TblContacts.SingleOrDefault(e => e.Id == id);
                return View(contact);
            }
            catch (Exception ex)
            {
                return View("Exception");
            }
        }
    }
}
