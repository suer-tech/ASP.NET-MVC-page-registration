using Microsoft.AspNetCore.Mvc;
using DataAccess.Models;
using DataAccess;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        
        public RegistrationDataContext _context;

        public HomeController(RegistrationDataContext context)
        {
            
            _context = context;
        }

        public ActionResult Index()
        {
            return View();
        }
                          
        
        [HttpPost]
        public ActionResult Index(User person)
        {
           
            var user = new User
            {
                ID = person.ID,
                Surname = person.Surname,
                Name = person.Name,
                Secondname = person.Secondname,
                Email = person.Email,
                Phone = person.Phone
            };
            _context.Add(user);
            _context.SaveChanges();
            ModelState.Clear();

            return View();
            
        }

    }
     
}