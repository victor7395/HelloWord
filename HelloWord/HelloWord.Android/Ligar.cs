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
using Xamarin.Forms;
using HelloWord.Droid;
using Android.Telephony;

[assembly: Dependency(typeof(Ligar))] //TRAZ A DEPENDÊNCIA DO SERVIÇO NATIVO
namespace HelloWord.Droid
{
    public class Ligar : IDialer // INTERFACE DO MÉTODO DE CHAMAR
    {
        //SOBRESCRIÇÃO DO MÉTODO CHAMAR
        public bool Chamar(String Numero)
        {
            var contexto = Forms.Context;
            if (contexto == null)
                return false;

            var intent = new Intent(Intent.ActionCall);
            //RECEBE O URI COM O PARÂMETRO DO NÚMERO A SER DISCADO
            intent.SetData(Android.Net.Uri.Parse("tel:" + Numero));

            if (IsIntentAvailable(contexto, intent))
            {
                //FAZ DE FATO A CHAMADA
                contexto.StartActivity(intent);
                return true;
            }
            return false;
        }

        //VERIFICA SE O NÚMERO É VÁLIDO PARA DISCAGEM
        public static bool IsIntentAvailable(Context contexto, Intent intent)
        {
            var packageManager = contexto.PackageManager;

            var list = packageManager.QueryIntentServices(intent, 0)
                .Union(packageManager.QueryIntentActivities(intent, 0));

            if (list.Any())
                return true;

            var manager = TelephonyManager.FromContext(contexto);
            return manager.PhoneType != PhoneType.None;
        }
    }
}