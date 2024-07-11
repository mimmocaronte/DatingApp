using API.Extensions;

namespace API.Entities;

public class AppUser
{
    public int Id { get; set; }
    public string UserName { get; set;}
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string KnownAs { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime LastActive { get; set; } = DateTime.UtcNow;
    public string Gender { get; set; }
    public string Introduction { get; set; }    
    public string LookingFor { get; set; }
    public string Interests { get; set; }
    public string City { get; set; }
    public List<Photo> Photos { get; set; } = new();

    //Tenendo un metodo di questo tipo tutto funziona, ma quando si usa l'AutoMapper viene creata un query più complessa (e quindi "pesante") del dovuto.
    //Per ottimizzare una situazione simile si deve commentare qui e far gestire questi tipi di mapping "customizzati" direttamente nel AutoMapperProfiles
    // public int GetAge()
    // {
    //     return DateOfBirth.CalculateAge();
    // }
}
