using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Security;
using Modelo;
using Cad;

public partial class Administrador_AlterarSenhaOperador : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string username = Request["username"];
            RetornaDadosOperador(username);
        }
    }

    protected void RetornaDadosOperador(string username)
    {
        lblCliente.Text = username;

    }
    protected void btnSim_Click(object sender, EventArgs e)
    {
        Cliente cliente = new Cliente();
        cliente = ClienteOad.Get_Cliente(Convert.ToInt16(Request["Cliente"]));

        MembershipUser membershipUser = Membership.GetUser(Request["username"]);
        object userId = membershipUser.ProviderUserKey;

        foreach (MembershipUser user in Membership.GetAllUsers())
        {
            if (user.ProviderUserKey.ToString().Equals(userId.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                user.UnlockUser();
                user.ChangePassword(user.ResetPassword(), "123456");

            }
        }
        Response.Redirect("~/Administrador/ListarClientes.aspx");
            
    }
    protected void btnNao_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarClientes.aspx");
    }
}
