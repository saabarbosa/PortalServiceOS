using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Security;
using Modelo;
using Cad;

public partial class Administrador_AlterarSenha : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int id_cliente = Convert.ToInt16(Request["Cliente"]);
            RetornaDadosCliente(id_cliente);
        }
    }

    protected void RetornaDadosCliente(int id_cliente)
    {
        Cliente cliente = new Cliente();
        cliente = ClienteOad.Get_Cliente(id_cliente);
        lblCliente.Text = cliente.Nm_Cliente;

    }
    protected void btnSim_Click(object sender, EventArgs e)
    {
        Cliente cliente = new Cliente();
        cliente = ClienteOad.Get_Cliente(Convert.ToInt16(Request["Cliente"]));
        object userId = cliente.UserId;

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
