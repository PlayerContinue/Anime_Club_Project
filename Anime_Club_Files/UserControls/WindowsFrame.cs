using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace Anime_Club_Files.UserControls
{
    class WindowsFrame : Frame
    {

        private void changeScreen(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show(sender.GetType().ToString());
        }

       
    }
}
