using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWord
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnHelloWorld_Clicked(object sender, EventArgs e)
        {
            //DISPLAY "MODAL"
            await DisplayAlert("First Message", "Hello World! HU3", "Ok");
        }

        private async void btnApresentacao_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Apresentação","Bem vindo, " + txtNome.Text,"Show!!");
        }

        private async void btnTeste_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("","Vacilaum", "Ok");
        }

        private async void btnNavegar_Clicked(object sender, EventArgs e)
        {
            //CARREGA UMA NOVA PÁGINA                               // PÁGINA CONTÉM A SETA DE VOLTAR E UMA BARRA DE NAVEGAÇÃO E VEM PELA LATERAL DA TELA
            await Navigation.PushAsync(new Calculadora());          // MODAL CARREGA UMA NOVA "PÁGINA" PORÉM SEM A NAVEGAÇÃO E VEM DE BAIXO PARA CIMA
            // await Navigation.PushModalAsync(new Calculadora());  //  <---|
        }

        private async void btnNavegarLigacao_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ligacao());
        }

        private void btnNavGoogle_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.google.com.br"));
        }

        private void btnAudio_Clicked(object sender, EventArgs e)
        {
            var player = DependencyService.Get<IPlayer>();
            player.Executar();
        }
    }
}