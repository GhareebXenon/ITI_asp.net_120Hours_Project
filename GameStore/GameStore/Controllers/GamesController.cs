using GameStore.Data;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Controllers
{
    public class GamesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public GamesController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        [Route("[Controller]/List")]
        [HttpGet]
        public IActionResult GetIndexView( int catId, int devId,string? search, string sortType, string sortOrder, int pageSize = 20, int pageNumber = 1)
        {
           
            IQueryable<Game> games = _context.Games.AsQueryable();
            ViewBag.AllGames = _context.Games.ToList();
            ViewBag.SelectedCatId = catId;
            ViewBag.AllCategories = _context.Categories.ToList();
            ViewBag.SelectedDevId = devId;
            ViewBag.AllDevelopers = _context.Developers.ToList();
            ViewBag.CurrentSearch = search;
            if (catId != 0)
            {
                games = games.Where(e => e.CategoryId == catId);
            }
            if (devId != 0)
            {
                games = games.Where(e => e.DeveloperId == devId);
            }
            if (string.IsNullOrEmpty(search) == false)
            {
                games = games.Where(e => e.Name.Contains(search));
            }
            if (sortType == "Name" && sortOrder == "asc")
            {
                games = games.OrderBy(e => e.Name);
            }
            else if (sortType == "Name" && sortOrder == "desc")
            {
                games = games.OrderByDescending(e => e.Name);
            }
            else if (sortType == "Price" && sortOrder == "asc")
            {
                games = games.OrderBy(e => e.Price);
            }
            else if (sortType == "Price" && sortOrder == "desc")
            {
                games = games.OrderByDescending(e => e.Price);
            }
            if (pageSize > 50) pageSize = 50;
            if (pageSize < 1) pageSize = 1;
            if (pageNumber < 1) pageNumber = 1;

            games = games.Skip(pageSize * (pageNumber - 1)).Take(pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.PageNumber = pageNumber;

            return View("Index", games);

        }
        [HttpGet]
        public IActionResult GetDetailsView(int id)
        {
            Game game = _context.Games.Include(e =>e.Category).Include(e=>e.Developer).FirstOrDefault(g => g.Id == id);
            
            ViewBag.CurrentGame = game;
            if (game == null)
            {
                return NotFound();
            }
           
                return View("Details", game);
            

        }
        [HttpGet]
        public IActionResult GetCreateView()
        {
            ViewBag.AllCategories = _context.Categories.ToList();
            ViewBag.AllDevelopers = _context.Developers.ToList();
            return View("Create");

        }
        [HttpPost]
        public ActionResult AddNew(Game game, IFormFile? imageFormFile)
        {


            if (ModelState.IsValid == true)
            {
                if (imageFormFile == null)
                {

                    game.ImagePath = "\\images\\NoImageAvailable.jpeg";

                }
                else
                {
                    Guid imgGuid = Guid.NewGuid();
                    string imgExtension = Path.GetExtension(imageFormFile.FileName);
                    string imgName = imgGuid + imgExtension;
                    game.ImagePath = "\\images\\games\\" + imgName;

                    string imgFullPath = _webHostEnvironment.WebRootPath + game.ImagePath;

                    FileStream fileStream = new FileStream(imgFullPath, FileMode.Create);
                    imageFormFile.CopyTo(fileStream);
                    fileStream.Dispose();


                }

            }
            if (ModelState.IsValid == true)
            {
                _context.Games.Add(game);
                _context.SaveChanges();
                return RedirectToAction("GetIndexView");
            }
            else
            {
                ViewBag.AllGames = _context.Games.ToList();
                return View("Create", game);

            }
        }
        [HttpPost]
        public IActionResult EditCurrent(Game game, IFormFile? imageFormFile)
        {
            if (ModelState.IsValid == true)
            {
                if (imageFormFile != null)
                {
                    if (game.ImagePath != "\\images\\NoImageAvailable.jpg")
                    {

                        string imagPath = _webHostEnvironment.WebRootPath + game.ImagePath;
                        if (System.IO.File.Exists(imagPath))
                        {
                            System.IO.File.Delete(imagPath);
                        }

                    }
                    Guid imgGuid = Guid.NewGuid();
                    string imgExtension = Path.GetExtension(imageFormFile.FileName);
                    string imgName = imgGuid + imgExtension;
                    game.ImagePath = "\\images\\games\\" + imgName;

                    string imgFullPath = _webHostEnvironment.WebRootPath + game.ImagePath;

                    FileStream fileStream = new FileStream(imgFullPath, FileMode.Create);
                    imageFormFile.CopyTo(fileStream);
                    fileStream.Dispose();

                }


                _context.Games.Update(game);
                _context.SaveChanges();
                return RedirectToAction("GetIndexView");
            }
            else
            {
                ViewBag.AllCategories = _context.Categories.ToList();
                ViewBag.AllDevelopers = _context.Developers.ToList();
                return View("Edit", game);
            }
        }
        [HttpGet]
        public IActionResult GetEditView(int id)
        {
            Game game = _context.Games.Find(id);
            if (game == null)
            {
                return NotFound();
            }
            else
            {
                ViewBag.AllCategories = _context.Categories.ToList();
                ViewBag.AllDevelopers = _context.Developers.ToList();
                return View("Edit", game);
            }
        }
        public IActionResult GetDeleteView(int id)
        {
            Game game = _context.Games.Find(id);
            ViewBag.CurrentGame = game;
            if (game == null)
            {
                return NotFound();
            }
            else
            {

                return View("Delete", game);
            }
        }
        [HttpPost]
        public IActionResult DeleteCurrent(int id)
        {
            Game game = _context.Games.Find(id);
            if (game.ImagePath != "\\images\\NoImageAvailable.jpeg")
            {
                string imgPath = _webHostEnvironment.WebRootPath + game.ImagePath;
                System.IO.File.Delete(imgPath);
            }
            _context.Games.Remove(game);
            _context.SaveChanges();
            return RedirectToAction("GetIndexView");
        }
    }

}

