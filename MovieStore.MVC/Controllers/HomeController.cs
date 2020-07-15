using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieStore.MVC.Models;

namespace MovieStore.MVC.Controllers
{
    //Any C# class can become a MVC Controller if it inherits from Controller base class from Microsoft.AspNetCore.Mvc
    
    //http://localhost:2323/home/index

    //HomeController
    //Index--Action method
    public class HomeController : Controller
    {
        //create action method
        public IActionResult Index()
        {
            //return a instance of a class that implements that IActionResult
            //View() is a method that returns ViewResult (which implements IActionResult)
            //By default MVC will look for same View name as Action method name
            //it will look inside Views folder -->Home(same name as Controller)-->Index.cshtml

            //1.Program.cs-->Main method
            //2.StartUp Class (app.UseStaticFiles,app.... they are middlewares  app.UseEndpoints use routing)
            //3.ConfigureServices
            //4.Configure
            //5.HomeController
            //6.Action method
            //7.return a View

            //ASP.NET Core Middleware-- a piece of software logic that will be executed
            //the order of middlewares matters
            //e.g Train--DC to Boston
            //DC 20people,multiple stops,boston
            //request -->Middleware1--some process-->next M2-->...M5-->Response
            return View();

            
        }

    }
}
