using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        public string UserName { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TBName_TextChanged(object sender, EventArgs e)
        {
        }

        protected void ButEntrar_Click(object sender, EventArgs e)
        {
            string username = TBName.Text;
            if (UsuarioAutorizado(username))
            {
                UserName = username;
                ((SiteMaster)this.Master).UserName2 = "Pepito2";
                SiteMaster.UserName3 = username = "Pepito3";
            }
            /*else
                MostrarErrorAutorizacion();*/
        }

        private bool UsuarioAutorizado(string username)
        {
            string[] authorizedUsers = { "tarik", "tariq", "taric" };

            foreach (string user in authorizedUsers)
            {
                if (user.Equals(username, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        /*private void ActualizarSaludo(string username)
        {
            
            if (master != null)
                master.CambiarSaludo($"Bienvenido, {username}!");
        }

        private void MostrarErrorAutorizacion()
        {
            SiteMaster master = this.Master as SiteMaster;
            if (master != null)
                master.NoAutorizado();
        }*/
    }
}