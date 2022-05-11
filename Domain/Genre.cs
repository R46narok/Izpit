using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Genre
{
    [Key]
    public int Key { get; set; }

    [Required, MaxLength(20)]
    public string Name { get; set; }

    public IList<User> Users { get; set; }
}