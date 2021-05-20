using CicloDeVidaXamarinForms.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CicloDeVidaXamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainModalExtendedPage : ContentPageExtendedLifeCycle
    {
        public MainModalExtendedPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        protected override void OnAppearing(bool causedByModalPop)
        {
            if (!causedByModalPop)
                Debug.WriteLine("Modal Iniciando");
        }

        protected override void OnDisappearing(bool causedByModalPush)
        {
            if (!causedByModalPush)
                Debug.WriteLine("Modal Fechando");
        }
    }
}