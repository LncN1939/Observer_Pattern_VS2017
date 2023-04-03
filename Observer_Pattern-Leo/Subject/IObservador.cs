using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern_Leo.Subject
{
    //Se crea el observador
    interface IObservador
    {
        void Notificar(string idPC);
    }
}
