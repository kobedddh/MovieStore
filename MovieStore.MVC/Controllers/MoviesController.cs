using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieStore.MVC.Models;

namespace MovieStore.MVC.Controllers
{
    //public class MoviesController : Controller
    //{
    //    //GET localhost/Movies/index

    //    public IActionResult Index()
    //    {
    //        //go to database and get some list of movies and give it to the view

    //        var movies = new List<Movie>
    //        {
    //            new Movie {Id = 1, Title = "Avengers: Infinity War", Budget = 1200000},
    //            new Movie {Id = 2, Title = "Avatar", Budget = 1200000},
    //            new Movie {Id = 3, Title = "Star Wars: The Force Awakens", Budget = 1200000},
    //            new Movie {Id = 4, Title = "Titanic", Budget = 1200000},
    //            new Movie {Id = 5, Title = "Inception", Budget = 1200000},
    //            new Movie {Id = 6, Title = "Avengers: Age of Ultron", Budget = 1200000},
    //            new Movie {Id = 7, Title = "Interstellar", Budget = 1200000},
    //            new Movie {Id = 8, Title = "Fight Club", Budget = 1200000},
                
    //        };

    //        //ViewBag is a dynamic type,checks on run-time
    //        //we can use ViewBag.xxx to send data to view
    //        //or ViewData
    //        ViewBag.MoviesCount = movies.Count;
    //        ViewData["myname"] = "John Doe";
    //        //compile time checks vs run-time checks


    //        //why people prefer strongly typed language
    //        //we want to detect errors asap?
    //        //e.g
    //        //var list = new List<int>();
    //        //list.Add(asdasd);
    //        //when we use add() we can see hint about what type should be inside the ()--in this case is int type

    //        //3 ways to send data from Controller to View
    //        //1.Strongly-Typed models (preferred)
    //        // 2. ViewBag --dynamic
    //        // 3. ViewData - key/value


    //        //we need to pass data from Contorller action method to the view
    //        //usually its preferred to send a strongly typed Model or object to the view
    //        return View(movies);
    //    }

    //    [HttpPost] //by default, this attribute can only be on top of method,not class (but Route can do)
    //    public IActionResult Create(string title, decimal budget)
    //    {
    //        //POST //http://localhost/Movies/create

    //        //Model binding is case in-sensitive
    //        //   is case in-sensitive, look at incoming request and maps the input elements name/value with the parameter names of the action method,
    //        //then the parameter will have the value automatically; it will also does casting / converting

    //        //in [HttpPost] method, as long as the parameter in this Create() method is the same as the name attribute (in this case is inputbox name) inside Create.cshtml , 
    //        //the value input by user can be passed this Create() method parameter

    //        //we need to the data from the view and save it in database

    //        return View();
    //    }

    //    [HttpGet]
    //    public IActionResult Create()
        
    //    {
    //        //GET //http://localhost/Movies/create
    //        // we need to have this method so that we can show the empty page for user to enter Movie information that needs to be created
    //        ViewData["myname"] = "John Doe";
    //        return View();
    //    }
    //}
}
