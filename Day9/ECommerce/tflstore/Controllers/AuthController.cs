using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tflstore.Models;
using System.Collections.Generic;
namespace tflstore.Controllers;
using System.Text;
using System.Text.Json;


public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    List<Player> players=new List<Player>();
    // string fileName=@"E:\chaitanya_prashant\.Net\lab_dotnet\Day9\ECommerce\tflstore\ppp.json";
    public IActionResult Login()
    {
    
        return View();
    }

     public IActionResult Register()
    {
        return View();
    }

    public IActionResult RegDone()
    {
        return View();
    }



    public IActionResult Postregister(string firstname,string lastname,string contactnumber,string email,string password)
    {
        Player p1=new Player(){FirstName=firstname,LastName=lastname,ContactNumber=contactnumber,Email=email,Password=password};
    PlayerManager.InsertIntoFile(p1);
        return Redirect("RegDone");
       // return View();
    }


    public IActionResult Validate(string email,string password)
    {

    //     var readData=System.IO.File.ReadAllText(fileName);
    //     List<Player>? newplayer=JsonSerializer.Deserialize<List<Player>>(readData);
    // players=newplayer;
    // foreach(Player p in players)
    // {
    //     if(p.Email==email  && p.Password== password)
    //     {
    //         return Redirect("RegDone");
    //     }
    // }
    //    return View();




    List<Player>  allPlayers=PlayerManager.GetAllPlayers();
    foreach(Player p in allPlayers)
    {
        if(p.Email==email  && p.Password== password)
        {
            return Redirect("RegDone");
        }
    }
    



       return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
