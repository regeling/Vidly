using System.Data.Entity;
using System.Web.Mvc;
using System.Linq;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movies = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movies == null)
                return HttpNotFound();

            return View(movies);
        }
    }
}