using GameStore.Data;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.IO;

namespace GameStore.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CategoriesController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        [Route("[Controller]/List")]
        [HttpGet]
        public IActionResult GetIndexView(string? search, string sortType, string sortOrder, int pageSize = 20, int pageNumber = 1)
        {
            IQueryable<Category> categories = _context.Categories.AsQueryable();
            
            if (sortType == "Name" && sortOrder == "asc")
            {
                categories = categories.OrderBy(e => e.Name);
            }
            else if (sortType == "Name" && sortOrder == "desc")
            {
                categories = categories.OrderByDescending(e => e.Name);
            }
            else if (sortType == "Description" && sortOrder == "asc")
            {
                categories = categories.OrderBy(e => e.Description);
            }
            else if (sortType == "Description" && sortOrder == "desc")
            {
                categories = categories.OrderByDescending(e => e.Description);
            }
            if (pageSize > 50) pageSize = 50;
            if (pageSize < 1) pageSize = 1;
            if (pageNumber < 1) pageNumber = 1;

            categories = categories.Skip(pageSize * (pageNumber - 1)).Take(pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.PageNumber = pageNumber;

            if (string.IsNullOrEmpty(search))
            {
                return View("Index", categories);
            }
            else
            {
                ViewBag.CurrentSearch = search;
                return View("index", categories.Where(e => e.Name.Contains(search)).ToList());
            }
        }
        [HttpGet]
        public IActionResult GetDetailsView(int id)
        {
            Category cat = _context.Categories.Include(c=>c.Games).FirstOrDefault(c => c.Id == id);
            ViewBag.CurrentCategory = cat;
            if (_context.Categories == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", cat);
            }
            
        }
        [HttpGet]
        public IActionResult GetCreateView( ) {


            return View("Create");
        
        }
        [HttpPost]
        public ActionResult AddNew(Category cat, IFormFile? imageFormFile)
        {

         
            if (ModelState.IsValid == true)
            {
                if (imageFormFile == null)
                {

                    cat.ImagePath = "\\images\\NoImageAvailable.jpeg";

                }
                else
                {
                    Guid imgGuid = Guid.NewGuid();
                    string imgExtension = Path.GetExtension(imageFormFile.FileName);
                    string imgName = imgGuid + imgExtension;
                    cat.ImagePath = "\\images\\categories\\" + imgName;

                    string imgFullPath = _webHostEnvironment.WebRootPath + cat.ImagePath;

                    FileStream fileStream = new FileStream(imgFullPath, FileMode.Create);
                    imageFormFile.CopyTo(fileStream);
                    fileStream.Dispose();


                }

            }
            if (ModelState.IsValid == true)
            {
                _context.Categories.Add(cat);
                _context.SaveChanges();
                return RedirectToAction("GetIndexView");
            }
            else
            {
                ViewBag.AllCategories = _context.Categories.ToList();
                return View("Create", cat);

            }

        }
        [HttpGet]
        public IActionResult GetEditView(int id)
        {
            Category category = _context.Categories.Find(id);
            if(category == null)
            {
                return NotFound();
            }
            else
            {

                return View("Edit", category);
            }
        }
        [HttpPost]
        public IActionResult EditCurrent(Category cat, IFormFile? imageFormFile)
        {
            if (ModelState.IsValid == true)
            {
                if (imageFormFile != null)
                {
                    if (cat.ImagePath != "\\images\\NoImageAvailable.jpeg")
                    {

                        string imagPath = _webHostEnvironment.WebRootPath + cat.ImagePath;
                        if (System.IO.File.Exists(imagPath))
                        {
                            System.IO.File.Delete(imagPath);
                        }

                    }
                    Guid imgGuid = Guid.NewGuid();
                    string imgExtension = Path.GetExtension(imageFormFile.FileName);
                    string imgName = imgGuid + imgExtension;
                    cat.ImagePath = "\\images\\categories\\" + imgName;

                    string imgFullPath = _webHostEnvironment.WebRootPath + cat.ImagePath;

                    FileStream fileStream = new FileStream(imgFullPath, FileMode.Create);
                    imageFormFile.CopyTo(fileStream);
                    fileStream.Dispose();

                }


                _context.Categories.Update(cat);
                _context.SaveChanges();
                return RedirectToAction("GetIndexView");
            }
            else
            {
                ViewBag.AllCategories = _context.Categories.ToList();
                return View("Edit", cat);
            }
        }
        public IActionResult GetDeleteView(int id)
        {
            Category category = _context.Categories.Include(c => c.Games).FirstOrDefault(c => c.Id == id);
            ViewBag.CurrentCategory = category;
            if (category == null)
            {
                return NotFound();
            }
            else
            {

                return View("Delete", category);
            }
        }
        [HttpPost]
        public IActionResult DeleteCurrent(int id)
        {
        Category cat = _context.Categories.Find(id);
            if (cat.ImagePath != "\\images\\NoImageAvailable.jpeg")
            {
                string imgPath = _webHostEnvironment.WebRootPath + cat.ImagePath;
                System.IO.File.Delete(imgPath);
            }
            _context.Categories.Remove(cat);
            _context.SaveChanges();
            return RedirectToAction("GetIndexView");
        }

    }

}
