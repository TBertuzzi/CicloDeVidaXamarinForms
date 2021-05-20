using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace CicloDeVidaXamarinForms.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {

        }
        public async Task LoadAsync()
        {
            //Carrega Aqui de Forma Assincrona

            Debug.WriteLine("Carregando a ViewModel");
        }
    }
}
