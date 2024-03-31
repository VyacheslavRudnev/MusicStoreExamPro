using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository;

public class ArtistRepository : GenericRepository<ArtistData>
{
    public ArtistRepository() : base()
    {
    }
}