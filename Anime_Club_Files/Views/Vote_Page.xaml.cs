using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Anime_Club_Files.Modal;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Anime_Club_Files.Views
{
    /// <summary>
    /// Interaction logic for Vote_Page.xaml
    /// </summary>
    public partial class Vote_Page : Page
    {
        
        private VoteStore[] Vote_List; /**< A list of values which will be displayed to the user */

        /**
        A constructor for a page utilized for voting. 
        @param voteList - A list of strings which will be used as the titles for things to displayed
    */
        public Vote_Page(VoteStore[] voteList)
        {
            InitializeComponent();

            this.Vote_List = voteList;
            fillToComeList();
            this._name.Text = voteList[0].Name;
            this._description.Text = voteList[0].Description;
            

        }

        /**
        Fills the list with votes yet to be set
        */
        private void fillToComeList()
        {
           
            To_Come_List.ItemsSource = this.Vote_List;
        }



        


    }
}
