using Microsoft.AspNetCore.Mvc;
using SeverGame106.Data;
using SeverGame106.Models;

namespace SeverGame106.Controllers
{
    public class GameController : Controller
    {
        private readonly ApplicationDbContext _context;
        public GameController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<GameLevel> gameLevels = _context.GameLevels.ToList();
            return View(gameLevels);
        }

        public IActionResult Create()
        {
            
            return View();
        }
    }
}
