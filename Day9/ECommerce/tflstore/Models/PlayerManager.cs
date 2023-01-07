namespace tflstore.Models;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

public class PlayerManager
{




static List<Player> players= new List<Player>();
static string fileName=@"E:\chaitanya_prashant\.Net\lab_dotnet\Day9\ECommerce\tflstore\ppp.json";
     public static List<Player> GetAllPlayers()
    {
        
        var readData=System.IO.File.ReadAllText(fileName);
        List<Player>? newlist=JsonSerializer.Deserialize<List<Player>>(readData);
    //players=newlist;

        return newlist;
       // return players;
    }

    public static void InsertIntoFile(Player insert)
    {

        var readData=System.IO.File.ReadAllText(fileName);
        List<Player>? newplayer=JsonSerializer.Deserialize<List<Player>>(readData);
    players=newplayer;
    //   Player p1=new Player(){FirstName=firstname,LastName=lastname,ContactNumber=contactnumber,Email=email,Password=password};
    //players.Add(p1);
     players.Add(insert);

    var data=JsonSerializer.Serialize<List<Player>>(players);
    System.IO.File.WriteAllText(fileName,data);


    }





    // public static List<Player> GetAllPlayers()
    // {
    //     List<Player> list= new List<Player>();

    //     list.Add(new Player{FirstName="prashant",LastName="chede",ContactNumber="8381058326",Email="chedeprashant1998@gmail.com",Password="ppc@123"});
    //     list.Add(new Player{FirstName="abc",LastName="def",ContactNumber="8381058326",Email="chedeprashant1998@gmail.com",Password="ppc@123"});
    //     list.Add(new Player{FirstName="uvw",LastName="chexyzde",ContactNumber="8381058326",Email="chedeprashant1998@gmail.com",Password="ppc@123"});
    //     return list;
    // }
    
}
