using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Anime_Club_Files
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        Views.Create_Page List;
        public MainWindow()
        {
            InitializeComponent();
            List = new Views.Create_Page();
            //this.main_window.Height = 525;
            //this.main_window.Width = 350;
            this.main_window.Navigate(List);
        }

     
        

    }
}
