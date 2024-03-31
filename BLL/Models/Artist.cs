using DAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace BLL.Models;

public class Artist
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public List<Album> Album { get; set; }

    public override string ToString()
    {
        return $"{Name}";
    }
}
