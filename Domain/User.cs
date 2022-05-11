using System.ComponentModel.DataAnnotations;

namespace Domain;

public class User
{
    [Key] 
    public int Id { get; set; }

    [Required, MaxLength(20)]
    public string FirstName { get; set; }

    [Required, MaxLength(20)]
    public string LastName { get; set; }

    [Required, Range(10, 80)]
    public int Age { get; set; }

    [Required, MaxLength(20)]
    public string Username { get; set; }
    
    [Required, MaxLength(70)]
    public string Password { get; set; }

    [Required, MaxLength(20)]
    public string Email { get; set; }

    public IList<User> Friends { get; set; }
    public IList<Game> Games { get; set; }
}