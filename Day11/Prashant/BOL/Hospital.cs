namespace BOL;
public class Hospital
{
    public int Id{get;set;}
    public string? Name{get;set;}
    public string? Email{get;set;}
    public string? Pin{get;set;}

    public Hospital(int id,string name,string email,string pin)
    {
        this.Id=id;
        this.Name=name;
        this.Email=email;
        this.Pin=pin;
    }

}
