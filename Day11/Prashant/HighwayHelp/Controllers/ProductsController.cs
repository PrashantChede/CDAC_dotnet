using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HighwayHelp.Models;
using BLL;
using BOL;
using System.Collections.Generic;

namespace HighwayHelp.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        HelpManager hm=new HelpManager();
        List<Hospital> allHospitals=hm.GetAllHospitals();
        this.ViewData["hospitals"]=allHospitals;

        return View();
    }

 public IActionResult AllProducts()
    {
        // CatalogManager manager=new CatalogManager();
        // List<Product> allProducts=manager.GetAllProducts();
        // this.ViewData["products"]=allProducts;
        return View();
    }

 public IActionResult ShowAllHospitals()
    {
        HelpManager hm=new HelpManager();
        List<Hospital> allHospitals=hm.GetAllHospitals();
        this.ViewData["hospitals"]=allHospitals;
        
        return View();
    }



    // public IActionResult Details(int id)
    // {
    //     Console.WriteLine("inside controllers Deatils");
    //      HelpManager hm=new HelpManager();
    //      Hospital hospital=hm.GetHospital(id);
    //      this.ViewData["hospital"]=hospital;
    //      return View();

    // } 


    //  public IActionResult Insert(int id, string name, string email, string pin)
    // {
    //    // Console.WriteLine("inside controllers Deatils");
       
    //      HelpManager hm=new HelpManager();
    //      if(hm.InsertHospital(id,name,email,pin))
    //      {
    //     return Redirect("Index");
    //      }
    //     // this.ViewData["hospital"]=hospital;
    //      return View();

    // } 

   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
