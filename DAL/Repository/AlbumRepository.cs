using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository;

public class AlbumRepository : GenericRepository<AlbumData>
{
    public AlbumRepository() : base()
    {
        var artist = _dataContext.Artist.Add(new ArtistData()
        {
            Name = "Muse",
        });

        Add(new AlbumData
        {
            Title = "Black Holes and Revelations",
            Publisher = "Mushroom Records",
            Tracks = 11,
            Genre = "Alternative rock",
            Year = 2006,
            CostPrice = 42,
            SellPrice = 75,
            Artist = artist.Entity, 
        });

        _dataContext.SaveChanges();
    }

    public override List<AlbumData> GetAll()
    {
        return _dataContext.Album
            .Include(x => x.Artist)
            .ToList();
    }
}


