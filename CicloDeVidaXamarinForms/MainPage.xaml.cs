using CicloDeVidaXamarinForms.ViewModels;
using System.Diagnostics;
using Xamarin.Forms;

namespace CicloDeVidaXamarinForms
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel ViewModel => BindingContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            Debug.WriteLine("É acionado quando a pagina esta para aparecer na tela.");

            await ViewModel.LoadAsync();

        }

        protected override void OnDisappearing()
        {
            base.OnAppearing();

            Debug.WriteLine("É acionado quando a pagina ira desaparecer da tela.");

        }

        private async void btnModalClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MainModalPage());
        }

        private async void btnModalExtendedClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MainModalExtendedPage());
        }
    }
}
