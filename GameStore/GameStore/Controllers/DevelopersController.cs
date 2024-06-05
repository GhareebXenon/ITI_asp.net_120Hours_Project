using GameStore.Data;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Controllers
{
    public class DevelopersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public DevelopersController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        [Route("[Controller]/List")]
        [HttpGet]
        public IActionResult GetIndexView(string? search, string sortType, string sortOrder, int pageSize = 20, int pageNumber = 1)
        {
            IQueryable<Developer> developers = _context.Developers.AsQueryable();
            if (sortType == "Name" && sortOrder == "asc")
            {
                developers = developers.OrderBy(e => e.Name);
            }
            else if (sortType == "Name" && sortOrder == "desc")
            {
                developers = developers.OrderByDescending(e => e.Name);
            }
            else if (sortType == "About" && sortOrder == "asc")
            {
                developers = developers.OrderBy(e => e.About);
            }
            else if (sortType == "About" && sortOrder == "desc")
            {
                developers = developers.OrderByDescending(e => e.About);
            }
            if (pageSize > 50) pageSize = 50;
            if (pageSize < 1) pageSize = 1;
            if (pageNumber < 1) pageNumber = 1;

            developers = developers.Skip(pageSize * (pageNumber - 1)).Take(pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.PageNumber = pageNumber;

            if (string.IsNullOrEmpty(search))
            {
                return View("Index", developers);
            }
            else
            {
                ViewBag.CurrentSearch = search;
                return View("index", developers.Where(e => e.Name.Contains(search)).ToList());
            }
        }
    
        public IActionResult GetDetailsView(int id)
        {
            Developer dev = _context.Developers.Include(c => c.Games).FirstOrDefault(c => c.Id == id);
            ViewBag.CurrentDeveloper = dev;
            if (_context.Developers == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", dev);
            }

        }
        [HttpGet]
        public IActionResult GetCreateView()
        {


            return View("Create");

        }
        [HttpPost]
        public ActionResult AddNew(Developer developer, IFormFile? imageFormFile)
        {


            if (ModelState.IsValid == true)
            {
                if (imageFormFile == null)
                {

                    developer.ImagePath = "\\images\\NoImageAvailable.jpg";

                }
                else
                {
                    Guid imgGuid = Guid.NewGuid();
                    string imgExtension = Path.GetExtension(imageFormFile.FileName);
                    string imgName = imgGuid + imgExtension;
                    developer.ImagePath = "\\images\\games\\" + imgName;

                    string imgFullPath = _webHostEnvironment.WebRootPath + developer.ImagePath;

                    FileStream fileStream = new FileStream(imgFullPath, FileMode.Create);
                    imageFormFile.CopyTo(fileStream);
                    fileStream.Dispose();


                }

            }
            if (ModelState.IsValid == true)
            {
                _context.Developers.Add(developer);
                _context.SaveChanges();
                return RedirectToAction("GetIndexView");
            }
            else
            {
                ViewBag.AllDevelopers = _context.Developers.ToList();
                return View("Create", developer);

            }
        }
        [HttpGet]
        public IActionResult GetEditView(int id)
        {
            Developer developer = _context.Developers.Find(id);
            if (developer == null)
            {
                return NotFound();
            }
            else
            {

                return View("Edit", developer);
            }
        }
        [HttpPost]
        public IActionResult EditCurrent(Developer dev, IFormFile? imageFormFile)
        {
            if (ModelState.IsValid == true)
            {
                if (imageFormFile != null)
                {
                    if (dev.ImagePath != "\\images\\NoImageAvailable.jpeg")
                    {

                        string imagPath = _webHostEnvironment.WebRootPath + dev.ImagePath;
                        if (System.IO.File.Exists(imagPath))
                        {
                            System.IO.File.Delete(imagPath);
                        }

                    }
                    Guid imgGuid = Guid.NewGuid();
                    string imgExtension = Path.GetExtension(imageFormFile.FileName);
                    string imgName = imgGuid + imgExtension;
                    dev.ImagePath = "\\images\\developers\\" + imgName;

                    string imgFullPath = _webHostEnvironment.WebRootPath + dev.ImagePath;

                    FileStream fileStream = new FileStream(imgFullPath, FileMode.Create);
                    imageFormFile.CopyTo(fileStream);
                    fileStream.Dispose();

                }


                _context.Developers.Update(dev);
                _context.SaveChanges();
                return RedirectToAction("GetIndexView");
            }
            else
            {
                ViewBag.AllDevelopers = _context.Developers.ToList();
                return View("Edit", dev);
            }
        }
        public IActionResult GetDeleteView(int id)
        {
            Developer developer = _context.Developers.Include(c => c.Games).FirstOrDefault(c => c.Id == id);
            ViewBag.CurrentDeveloper = developer;
            if (developer == null)
            {
                return NotFound();
            }
            else
            {

                return View("Delete", developer);
            }
        }
        [HttpPost]
        public IActionResult DeleteCurrent(int id)
        {
            Developer dev = _context.Developers.Find(id);
            if (dev.ImagePath != "\\images\\NoImageAvailable.jpeg")
            {
                string imgPath = _webHostEnvironment.WebRootPath + dev.ImagePath;
                System.IO.File.Delete(imgPath);
            }
            _context.Developers.Remove(dev);
            _context.SaveChanges();
            return RedirectToAction("GetIndexView");
        }

    }
}

