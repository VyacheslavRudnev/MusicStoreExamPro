using BLL.Interfaces;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MusicStoreExamPro;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    //private Service albumService;
    private readonly AlbumService _albumService;
   
    public MainWindow()
    {
        InitializeComponent();
        _albumService = new AlbumService();
        dataGrid.ItemsSource = _albumService.GetAll();
        
    }
}