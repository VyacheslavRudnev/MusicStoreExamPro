using System.ComponentModel.DataAnnotations;

namespace DAL.Entities;

public class ArtistData
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public ICollection<AlbumData> Album { get; set;}
    public override string ToString()
    {
        return $"{Name}";
    }
}
