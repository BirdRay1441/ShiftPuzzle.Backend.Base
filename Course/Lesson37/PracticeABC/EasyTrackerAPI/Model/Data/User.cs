
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

public class User
{ 

    public User(string name)
    {
        Name = name; 
    }

    public User()
    {
        
    }

    public long ID { get; set; }
    //public bool IsVerified = false;
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }  
}