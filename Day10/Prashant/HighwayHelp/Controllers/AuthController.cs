using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HighwayHelp.Models;
using BLL;
using BOL;
using System.Collections.Generic;

namespace HighwayHelp.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // HelpManager hm=new HelpManager();
        // List<Hospital> allHospitals=hm.GetAllHospitals();
        // this.ViewData["hospitals"]=allHospitals;

        return View();
    }

    public IActionResult Login()
    {
        // HelpManager hm=new HelpManager();
        // List<Hospital> allHospitals=hm.GetAllHospitals();
        // this.ViewData["hospitals"]=allHospitals;

        return View();
    }

    public IActionResult WelcomeAdmin()
    {
        return View();
    }

    public IActionResult Validate(string username,string password)
    {
        // Console.WriteLine("inside controllers Deatils");
        //  HelpManager hm=new HelpManager();
        //  Hospital hospital=hm.GetHospital(id);
        //  this.ViewData["hospital"]=hospital;
        HelpManager hm=new HelpManager();
        if(hm.DoValidate(username,password))
        {

            return Redirect("WelcomeAdmin");
        }
         return View();

    } 

   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
