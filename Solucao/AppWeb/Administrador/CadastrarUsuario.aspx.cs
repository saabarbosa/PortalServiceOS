using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

using Modelo;
using Cad;

public partial class Administrador_CadastrarUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarClientes.aspx");
    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            ClienteOad.CriarUsuario(txtLogin.Text, ddlRoles.SelectedValue);
        }
        catch (Exception ex)
        {
           Response.Write("<script>window.alert('Operação não realizada.')</script>");
           return;
                
        }
        Response.Redirect("~/Administrador/ListarClientes.aspx");
    }

}
