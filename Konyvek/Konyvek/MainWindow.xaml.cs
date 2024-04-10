using Konyvek.Models;
using Microsoft.EntityFrameworkCore.Storage;
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

namespace Konyvek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FogalalsContext _dbc;
        public MainWindow()
        {
            InitializeComponent();
            _dbc = new FogalalsContext();
            _dbc.Database.EnsureCreated();
            
        }
    }
}