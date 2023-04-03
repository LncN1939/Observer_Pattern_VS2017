using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI.WebControls;

namespace Observer_Pattern_Leo.Subject
{
    //Se crea el laboratorio quien va a ser notificado
    public class ObservadorLaboratorio : IObservador
    {
        private Label labelMensajes;

        public ObservadorLaboratorio(Label labelMensajes)
        {
            this.labelMensajes = labelMensajes;
        }

        public void Notificar(string idPC)
        {
            string mensaje = string.Format("La PC con ID {0} está disponible. Notificando al laboratorio...", idPC);
            labelMensajes.Text += mensaje + "<br/>";
            // Aquí iría la lógica para notificar al laboratorio en la vida real
        }
    }
}