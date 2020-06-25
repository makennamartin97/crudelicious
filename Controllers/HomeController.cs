using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using crudelicious.Models;

namespace crudelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context {get; set;}
        public HomeController(MyContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> Dishes = _context.Dishes.ToList();
            //List<Dish> shrimpdish = _context.Dishes.Where(u => u.Name == "Coconut Shrimp with Tropical Rice");
            //Dish selectedDish = _context.Dishes.FirstOrDefault(Dish => Dish.id == id);

            //return View("details", selectedDish);
            //IEnumerable<Dish> DishesOrdered = Dishes.OrderByDescending(dish => dish.CreatedAt);
            //List<Dish> DishesInOrder = Dishes.OrderByDescending(d => d.CreatedAt).Take(5).ToList();
            return View("Index", Dishes);
        }
        [HttpGet("all")]
        public IActionResult all()
        {
            List<Dish> Dishes = _context.Dishes.ToList();
            //List<Dish> shrimpdish = _context.Dishes.Where(u => u.Name == "Coconut Shrimp with Tropical Rice");
            //Dish selectedDish = _context.Dishes.FirstOrDefault(Dish => Dish.id == id);

            //return View("details", selectedDish);
            //IEnumerable<Dish> DishesOrdered = Dishes.OrderByDescending(dish => dish.CreatedAt);
            //List<Dish> DishesInOrder = Dishes.OrderByDescending(d => d.CreatedAt).Take(5).ToList();
            return View("all", Dishes);
        }

        
        [HttpGet("new")]
        public IActionResult New()
        {
            return View("new");
        }
        [HttpPost("process")]
        public IActionResult Process(Dish newdish)
        {
            if(ModelState.IsValid)
            {
                DateTime localDate = DateTime.Now;
                newdish.CreatedAt = localDate;
                newdish.UpdatedAt = localDate;
                _context.Dishes.Add(newdish);
                _context.SaveChanges();
                return Redirect("/all");

            }
            else{
                return View("new"); 
            }
             
        }
        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            Dish selectedDish = _context.Dishes.FirstOrDefault(Dish => Dish.id == id);
            return View("details", selectedDish);
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            //Dish dish = _context.Dishes.FirstOrDefault(Dish => Dish.id == id);
            Dish selectedDish = _context.Dishes.FirstOrDefault(Dish => Dish.id == id);
            return View("edit", selectedDish);
        }
        [HttpPost("update/{id}")]
        public IActionResult update(Dish d, int id)
        {
            //ViewBag.Index = selectedDish;
            if (ModelState.IsValid)
            {
                Dish selectedDish = _context.Dishes.FirstOrDefault(Dish => Dish.id == id);
                selectedDish.Name = d.Name;
                selectedDish.Chef = d.Chef;
                selectedDish.Calories = d.Calories;
                selectedDish.Tastiness = d.Tastiness;
                selectedDish.Description = d.Description;
                selectedDish.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                
                return RedirectToAction("all", id);
            }
            else
            {
                d.id = id;
                return View("edit", id);
            }
        }

        [HttpGet("delete/{id}")]
        public IActionResult delete(int id)
        {
            Dish deletedish = _context.Dishes.SingleOrDefault(Dish => Dish.id == id);
        
            _context.Dishes.Remove(deletedish);
            _context.SaveChanges();
            return RedirectToAction("all");
        }



    }
}
