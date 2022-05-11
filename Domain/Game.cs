using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Game
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(20)]
    public string Name { get; set; }

    public IList<User> Users { get; set; }
    public IList<Genre> Genres { get; set; }
}