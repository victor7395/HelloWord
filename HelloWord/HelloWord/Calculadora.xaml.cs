using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWord
{
    public partial class Calculadora : ContentPage
    {
        public Calculadora()
        {
            InitializeComponent();
            this.DisplayAlert("Bem vindo", "Calculadora iniciada", "Ok");
        }
    }
}