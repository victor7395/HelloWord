using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    //INTERFACE PARA A FUNÇÃO DE LIGAR
    public interface IDialer
    {
        bool Chamar(String Numero);
    }
}
