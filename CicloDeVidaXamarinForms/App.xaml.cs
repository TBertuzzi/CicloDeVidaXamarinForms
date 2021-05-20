using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CicloDeVidaXamarinForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            //Evento Global PageAppearing
            Application.Current.PageAppearing += OnPageAppearing;
            Application.Current.PageDisappearing += OnPageDisappearing;

            //Evento Global para Modal
            Application.Current.ModalPushing += OnModalPushing;
            Application.Current.ModalPushed += OnModalPushed;
            Application.Current.ModalPopping += OnModalPopping;
            Application.Current.ModalPopped += OnModalPopped;
        }

        private void OnModalPopped(object sender, ModalPoppedEventArgs e)
        {
            Debug.WriteLine("É acionado assim que o Modal desaparece da tela.");
        }

        private void OnModalPopping(object sender, ModalPoppingEventArgs e)
        {
            Debug.WriteLine("É acionado no exato momento que o Modal esta prestes a fechar.");
        }

        private void OnModalPushed(object sender, ModalPushedEventArgs e)
        {
            Debug.WriteLine("É acionado assim que o Modal abre.");
        }

        private void OnModalPushing(object sender, ModalPushingEventArgs e)
        {
            Debug.WriteLine("É acionado quando navegamos para o Modal. Antes do Modal abrir. Pode ser utilizado para carregar ou preparar algo para o dado ser exibido na tela.");
        }

        private void OnPageAppearing(object sender, Page e)
        {
            if (e is ContentPage)
            {
                Console.WriteLine($"Aberto a pagina {e.GetType()}");
            }

        }

        private void OnPageDisappearing(object sender, Page e)
        {
            if (e is ContentPage)
            {
                Console.WriteLine($"Fechando a pagina {e.GetType()}");
            }

        }

        protected override void OnStart()
        {
            // Quando o App Inicia
            Debug.WriteLine("É acionado assim que seu App inicia, ou seja aqui você pode efetuar alguma ação assim que o Aplicativo é Aberto.");
        }

        protected override void OnSleep()
        {
            // Quando o app vai para "Descanso"
            Debug.WriteLine("É acionado assim que o App é colocado em Background, ou seja quando o usuário sai dele mas não fecha o mesmo." +
                " Algumas ações podem ser adicionadas aqui, como parar de processar algo e etc.");
        }

        protected override void OnResume()
        {
            // Quando o App Volta
            Debug.WriteLine("acionado assim que o App volta do BackGround, ou seja nesse momento você pode retomar alguma ação ," +
                " voltar a processar algo e etc.");
        }
    }
}
