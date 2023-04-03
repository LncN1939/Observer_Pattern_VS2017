using Observer_Pattern_Leo.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Observer_Pattern_Leo.Subject.UpdateXmlHelper;

namespace Observer_Pattern_Leo
{
    public partial class wbObserver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabPCXmlHelper.GetPcIds();
        }

        protected void btnNotificar_Click(object sender, EventArgs e)
        {
            // Seguridad a la hora de presionar el boton Enviar
            if (string.IsNullOrEmpty(txtIdPC.Text))
            {
                lblMensajes.Text = "El nombre es obligatorio";
                return;
            }

            //Se muestra el mensaje del Observador laboratorio en pantalla.
            string idPC = txtIdPC.Text;
            var observadorLaboratorio = new ObservadorLaboratorio(lblMensajes);
            observadorLaboratorio.Notificar(idPC);

            // Agrega el ID de la PC al archivo XML
            LabPCXmlHelper.AddPcId(idPC);
        }

        protected void txtIdPC_TextChanged(object sender, EventArgs e)
        {
            //Nada
        }
    }
}