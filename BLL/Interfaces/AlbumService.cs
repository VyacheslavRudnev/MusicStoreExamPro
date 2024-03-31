using AutoMapper;
using BLL.Models;
using DAL.Entities;
using DAL.Repository;

namespace BLL.Interfaces;

public class AlbumService : IService<Album>
{
    private readonly AlbumRepository _albumRepository;
    private readonly Mapper _mapper;
   
    public AlbumService()
    { 
        _albumRepository = new AlbumRepository(); //(string connectionString)
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Album, AlbumData>();
            cfg.CreateMap<Artist, ArtistData>();
        });
    }

    public void Add(Album item)
    {
        _albumRepository.Add(_mapper.Map<AlbumData>(item));
    }

    public List<Album> GetAll()
    {
        return _albumRepository.GetAll()
            .Select(s => new Album()
            {
                Id = s.Id,
                Title = s.Title,
                Publisher = s.Publisher,
                Tracks = s.Tracks,
                Genre = s.Genre,
                Year = s.Year,
                CostPrice = s.CostPrice,
                SellPrice = s.SellPrice,
                Artist = new Artist()
                {
                    Name = s.Artist.Name,
                },
            })
            .ToList();
    }

    public void Remove(int id)
    {
        _albumRepository.Remove(id);
    }

    public void Update(Album item, int id)
    {
        _albumRepository.Update(_mapper.Map<AlbumData>(item), id);
    }
}
