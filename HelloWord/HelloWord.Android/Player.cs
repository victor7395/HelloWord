using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Media;
using Xamarin.Forms;
using HelloWord.Droid;

[assembly: Dependency(typeof(Player))] //TRAZ A DEPENDÊNCIA DO SERVIÇO NATIVO
namespace HelloWord.Droid
{
    public class Player : IPlayer
    {
        protected MediaPlayer player = new MediaPlayer();
        public void Executar()
        {
            player.Reset();
            player.SetDataSource("https://www.myinstants.com/media/sounds/faustao-errou.mp3");
            player.Prepare();
            player.Start();
        }
    }
}