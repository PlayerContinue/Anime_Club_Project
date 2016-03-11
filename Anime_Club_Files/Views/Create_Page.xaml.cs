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
    /// Interaction logic for Create_Page.xaml
    /// </summary>
    public partial class Create_Page : Page
    {
        //Get the name List
        public VoteStore[] NameList {
            get { return this.list; }
            set { } }

        private VoteStore[] list;

        //Event for starting to vote
        public static readonly RoutedEvent StartVoting =
    EventManager.RegisterRoutedEvent("Start_Voting", RoutingStrategy.Bubble,
    typeof(RoutedEventHandler), typeof(Create_Page));

        public Create_Page()
        {
            InitializeComponent();
        }

        

        // .NET wrapper
        public event RoutedEventHandler Selected
        {
            add { AddHandler(StartVoting, value); }
            remove { RemoveHandler(StartVoting, value); }
        }

        /**
        Begin voting for on the current list
            On call will launch new instance of Vote_Page
            @param sender - The object which has been activated
            @param RoutedEventArgs - The arguments passed with the object
        */
        private void beginVoting(object sender, RoutedEventArgs e)
        {
            String[] List = this.user_list.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            this.list = new VoteStore[List.Length];
            for(int i = 0; i < list.Length; i++)
            {
                this.list[i] = new VoteStore(List[i]);
            }
            this.NavigationService.Navigate(new Vote_Page(this.list));
        }
    }
}
