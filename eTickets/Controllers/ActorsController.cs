using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {

        private readonly AppDbContext _context;

        public ActorsController (AppDbContext contrext)
        {
            _context = contrext;
        }

        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View();
        }
    }
}
