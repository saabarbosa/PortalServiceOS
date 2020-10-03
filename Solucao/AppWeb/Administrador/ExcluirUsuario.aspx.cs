using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Modelo;
using Cad;

public partial class Administrador_ExcluirUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string username = Request["Username"];
            CarregaUsuario(username);
        }
    }
    protected void CarregaUsuario(string username)
    {
        MembershipUser user = Membership.GetUser(username);
        lblCliente.Text = user.UserName;
 
    }
    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarClientes.aspx");
    }
    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        string username = Request["Username"];
        Membership.DeleteUser(username);
        btnCancelar.Visible = false;
        btnExcluir.Visible = false;
        lblConfirmacao.Visible = false;
        lblSucesso.Visible = true;
        btnVoltar.Visible = true;
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarClientes.aspx");
    }
}
