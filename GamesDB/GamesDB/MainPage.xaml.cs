using GamesDB.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GamesDB
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool pageAfterLoad = false;

        public MainPage()
        {
            this.InitializeComponent();
            // Initialize the viewmodel
            Titles = new TitleVM();
            spPage.Visibility = Visibility.Collapsed;

            this.Loaded += Page_Loaded;
            this.LayoutUpdated += SetFocusOnSearch;
        }

        // adapted from : http://stackoverflow.com/questions/33609832/uwp-navigation-example-and-focusing-on-control
        // In order to set focus on the search textbox once the app is loaded, need two events. A loaded event that will fire once the page is loaded and set a boolean value pageAfterLoad to true, and a LayoutUpdated, which will execute after the page has loaded, and check if the page is after load, if it is, set the focus on the search textbox

        // This was done because after the page loads, it would focus on the page, rather than the text box
        private void SetFocusOnSearch(object sender, object e)
        {
            if (pageAfterLoad)
            {
                queryText.Focus(FocusState.Programmatic);
                pageAfterLoad = !pageAfterLoad;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            pageAfterLoad = !pageAfterLoad;
        }

        public TitleVM Titles { get; set; }
        public int offset = 0;
        public string query;

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            // Check if there is any query to search, if not, return
            if (queryText.Text == "")
            {
                return;
            }
            else
            {
                // Because the database querying doesn't work well with spaces or capital letters, remove all such instances from query using Regular Expression and then search
                string temp = Regex.Replace(queryText.Text, " ", "");
                temp = temp.ToLower();

                // If to check if the current data is for the same query that was received
                if (query == temp)
                {
                    return;
                } // Else if the query is novel, get new data and reset some values
                else
                {
                    query = temp;
                    Titles.populateCollection(query, offset);

                    // For the first search, hide Next/back stack panel until clicked
                    if (spPage.Visibility != Visibility.Visible)
                    {
                        spPage.Visibility = Visibility.Visible;
                    }

                    // Reset values for every search, and disable/enable pagination buttons
                    offset = 0;
                    pageNumber.Text = "1";
                    btnBack.IsEnabled = false;
                    btnNext.IsEnabled = true;
                }
            }        
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (!btnBack.IsEnabled)
            {
                btnBack.IsEnabled = true;
            }
            
            offset++;
            // Increment page number
            int page = Convert.ToInt32(pageNumber.Text);
            page++;
            pageNumber.Text = page.ToString();
            // Send off new query with increased offset
            Titles.populateCollection(query, offset * 10);

            // If there are no more items on subsequent pages, disable next button
            if (Titles._Games.Count < 10)
            {
                btnNext.IsEnabled = false;
            }
            else
            {
                btnNext.IsEnabled = true;
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            offset--;
            // Checks if we're on page 1 again, if yes, disable back button
            if (offset < 1)
            {
                btnBack.IsEnabled = false;
            }
            // Increment page number
            int page = Convert.ToInt32(pageNumber.Text);
            page--;
            pageNumber.Text = page.ToString();
            // Send off new query with decreased offset
            Titles.populateCollection(query, offset * 10);
        }

        // KeyUp event handler for the page. If enter is hit, hit the search query button click event
        private void Page_KeyUp(object sender, KeyRoutedEventArgs e)
        { 
            if(e.Key == Windows.System.VirtualKey.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }
    }
}
