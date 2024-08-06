using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButPulsar_Click(object sender, EventArgs e)
        {
            ButPulsar.Text = "Cliqueado! SIUUUUUUUUU";
        }

        protected void DiasSeleccionados_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxDias.Text = DiasSeleccionados.SelectedItem.Value;
        }

        protected void TextBoxDias_Load(object sender, EventArgs e)
        {
        }
    }
}