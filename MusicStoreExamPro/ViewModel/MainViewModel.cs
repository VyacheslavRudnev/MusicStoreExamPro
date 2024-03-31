using BLL.Interfaces;
using BLL.Models;
using MusicStoreExamPro.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MusicStoreExamPro.ViewModel;

//internal class MainViewModel : ViewModelBase
//{
    //private readonly IService<Album> _service;

    //public ObservableCollection<Album> Album { get; }

    //public MainViewModel()
    //{
    //    _service = new AlbumService(ConfigurationManager.ConnectionStrings["default"].ConnectionString);
    //    Albums = new ObservableCollection<Album>(_service.GetAll());
    //    Album album = new Album();
    //    SelectedAlbum = new Album();
    //    AddAlbumCommand = new RelayCommand(AddAlbum);
    //    DeleteAlbumCommand = new RelayCommand(DeleteAlbum);
    //    UpdateAlbumCommand = new RelayCommand(UpdateAlbum);
    //    RemoveAlbumCommand = new RelayCommand(RemoveAlbum);
    //    SellAlbumCommand = new RelayCommand(RemoveAlbum);
    //    AddDiscountCommand = new RelayCommand(SellAlbum);
    //    ReserveAlbumCommand = new RelayCommand(ReserveAlbum);
    //}

    //public ObservableCollection<Album> Albums { get; set; }
    //public Album SelectedAlbum { get; }
    //public ICommand AddAlbumCommand { get; }
    //public ICommand DeleteAlbumCommand { get; private set; }
    //public ICommand UpdateAlbumCommand { get; private set; }
    //public ICommand RemoveAlbumCommand { get; private set; }
    //public ICommand SellAlbumCommand { get; private set; }
    //public ICommand AddDiscountCommand { get; private set; }
    //public ICommand ReserveAlbumCommand { get; private set; }



    //private void AddAlbum()
    //{
    //    try
    //    {
    //        if (Album == null) return;
    //        _service.AddAlbum(Album);
    //        Albums.Add(Album);
    //    }
    //    catch (Exception ex)
    //    {
    //        Debug.WriteLine(ex.Message);
    //    }
    //    Album = new Album();
    //}

//    private void DeleteMovie()
//    {
//        if (SelectedMovie == null) return;
//        _service.Remove(SelectedMovie.Id);
//        Movies.Remove(Movies.First(m => m.Id == SelectedMovie.Id));
//    }

//    private void UpdateMovie()
//    {
//        if (Movie == null || SelectedMovie == null) return;
//        _service.Update(SelectedMovie.Id, Movie);
//        int index = Array.IndexOf(Movies.ToArray(), Movies.First(m => m.Id == SelectedMovie.Id));
//        Movies[index] = Movie;
//        Movie = new Movie();
//    }
//}

