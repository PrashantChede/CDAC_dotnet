namespace DLL;
using BOL;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using MySql.Data.MySqlClient;
public class DatabaseManager
{

public static string conString=@"server=localhost;port=3306;user=root; password=root123;database=highwayHelp";
public static List<Admin> GetAllAdminsFromDatabase()
    {
      List<Admin> allAdmins=new List<Admin>();
         MySqlConnection con=new MySqlConnection();
         con.ConnectionString=conString;

         try{
            con.Open();
              MySqlCommand cmd=new MySqlCommand();
               cmd.Connection=con;
               string query="select* from adminLoginCradentials";
               cmd.CommandText=query;
               MySqlDataReader reader=cmd.ExecuteReader();

               while(reader.Read())
               {
                 int id = int.Parse(reader["Id"].ToString());
                    string userName = reader["UserName"].ToString();
                    string password = reader["Password"].ToString();

            Admin newAdmin=new Admin(id,userName,password);
                allAdmins.Add(newAdmin);


               }
               


         }catch(Exception e)
         {
            Console.WriteLine(e.Message);
         }
         finally{
            con.Close();
         }
         return allAdmins;
    }


    public static List<Hospital> GetAllHospitalsFromDatabse()
    {
       
List<Hospital> allHospitals=new List<Hospital>();
         MySqlConnection con=new MySqlConnection();
         con.ConnectionString=conString;

         try{
            con.Open();
              MySqlCommand cmd=new MySqlCommand();
               cmd.Connection=con;
               string query="select* from hospitalDetails";
               cmd.CommandText=query;
               MySqlDataReader reader=cmd.ExecuteReader();

               while(reader.Read())
               {
                 int id = int.Parse(reader["hospId"].ToString());
                    string name = reader["hospName"].ToString();
                    string email = reader["hospEmail"].ToString();
                    string pin = reader["hospPin"].ToString();
 
            Hospital newHospital=new Hospital(id,name,email,pin);
                allHospitals.Add(newHospital);


               }
               


         }catch(Exception e)
         {
            Console.WriteLine(e.Message);
         }
         finally{
            con.Close();
         }
         return allHospitals;


    }


     public static bool InsertIntoFile(List<Hospital> allHospitals)
    {
       // Console.WriteLine("inside DAL");
       string hospitalFile=@"E:\chaitanya_prashant\.Net\lab_dotnet\CDAC_dotnet\Day10\Prashant\HighwayHelp\wwwroot\file\hospitalDetails.json";
        var jsonData=JsonSerializer.Serialize<List<Hospital>>(allHospitals); 
        System.IO.File.WriteAllText(hospitalFile,jsonData);
        
        return true;
    }

}
