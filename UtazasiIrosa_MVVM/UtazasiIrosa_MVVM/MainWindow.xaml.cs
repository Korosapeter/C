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
using UtazasiIrosa_MVVM.Models;
using UtazasiIrosa_MVVM.Views;

namespace UtazasiIrosa_MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IrodaContext _context;
        AddUtazas addUtazas;
        public MainWindow()
        {

            InitializeComponent();
        }

        private void btauthor_Click(object sender, RoutedEventArgs e)
        {
            contentcontrol.Content = addUtazas.Content;
        }
    }
}