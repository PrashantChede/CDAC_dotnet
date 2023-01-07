namespace tflstore.Models;

public class Player
{

    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string ContactNumber{get;set;}
    public string Email{get;set;}
    public string Password{get;set;}

    public Player()
    {

    }

    public Player(string email, string password)
    {
        this.Email=email;
        this.Password=password;
    }

    public Player(string firstName,string lastName,string email, string password)
    {
         this.FirstName=firstName;
         this.LastName=lastName;
        this.Email=email;
        this.Password=password;
    }

    public Player(string firstName,string lastName,string contactNumber,string email, string password)
    {
         this.FirstName=firstName;
         this.LastName=lastName;
          this.ContactNumber=contactNumber;
        this.Email=email;
        this.Password=password;
    }
    
}
