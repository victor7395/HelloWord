using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWord
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ligacao : ContentPage
    {
        public Ligacao()
        {
            InitializeComponent();
        }

        private void btnLigar_Clicked(object sender, EventArgs e)
        {
            //VERIFICA O SISTEMA OPERACIONAL
            var OS = Device.RuntimePlatform.ToString();
            if (OS == "Android")
            {
                //FAZ LIGAÇÃO DE MODO NATIVO DO ANDROID
                var ligacao = DependencyService.Get<IDialer>();
                ligacao.Chamar(txtNumero.Text);
            }
            else if (OS == "IOS")
                //FAZ LIGAÇÃO DE MODO SIMPLIFICADO (SOMENTE COM IOS)
                Device.OpenUri(new Uri("tel:" + txtNumero.Text));
        }
    }
}