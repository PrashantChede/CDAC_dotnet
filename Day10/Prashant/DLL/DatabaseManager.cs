namespace DLL;
using BOL;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
public class DatabaseManager
{

public static List<Admin> GetAllAdminsFromFile()
    {
       // Console.WriteLine("inside DAL");
        string loginFile=@"D:\cdac_project\.Net\Prashant\HighwayHelp\wwwroot\file\adminLoginCradentials.json";
        var readData=System.IO.File.ReadAllText(loginFile);
        List<Admin> allAdmins=JsonSerializer.Deserialize<List<Admin>>(readData);
        return allAdmins;
    }


    public static List<Hospital> GetAllHospitalsFromFile()
    {
       // Console.WriteLine("inside DAL");
        string hospitalFile=@"D:\cdac_project\.Net\Prashant\HighwayHelp\wwwroot\file\hospitalDetails.json";
        var readData=System.IO.File.ReadAllText(hospitalFile);
        List<Hospital> allHospitals=JsonSerializer.Deserialize<List<Hospital>>(readData);
        return allHospitals;
    }


     public static bool InsertIntoFile(List<Hospital> allHospitals)
    {
       // Console.WriteLine("inside DAL");
       string hospitalFile=@"D:\cdac_project\.Net\Prashant\HighwayHelp\wwwroot\file\hospitalDetails.json";
        var jsonData=JsonSerializer.Serialize<List<Hospital>>(allHospitals); 
        System.IO.File.WriteAllText(hospitalFile,jsonData);
        
        return true;
    }

}
