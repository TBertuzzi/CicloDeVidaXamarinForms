using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CicloDeVidaXamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainModalPage : ContentPage
    {
        public MainModalPage()
        {
            InitializeComponent();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }


    }
}