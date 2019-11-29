using Xamarin.Forms;
using GreatQuotes.ViewModels;

namespace GreatQuotes
{    
    public partial class QuoteDetailPage : ContentPage
    {
        public QuoteDetailPage()
        {

            InitializeComponent ();
            BindingContext = App.MainViewModel.SelectedQuote;
            App.MainViewModel.SelectedQuote = null;
        }
    }
}

