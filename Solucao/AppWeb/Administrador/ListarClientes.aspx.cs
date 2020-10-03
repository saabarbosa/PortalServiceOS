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

public partial class Administrador_ListarClientes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            listaCliente();
            string[] roles = Roles.GetRolesForUser(Membership.GetUser().UserName);
            if (roles[0].Equals("Administrador"))
            {
                Image1.Visible = true;
                lnkUsuario.Visible = true;
                listaUsuarios("operadores");
            }
            else
            {
                Image1.Visible = false;
                lnkUsuario.Visible = false;
            }

        }
    }
    protected void listaCliente()
    {
        List<Cliente> list = new List<Cliente>();
        list = ClienteOad.GetAll_Clientes();
        if (list.Count == 0)
        {
            lblMensagem.Visible = true;
        }
        else
        {
            lblMensagem.Visible = false;
            gvwDados.DataSource = list;
            gvwDados.DataBind();
        }
    }
    protected void gvwDados_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvwDados.PageIndex = e.NewPageIndex;
        gvwDados.DataSource = ClienteOad.GetAll_Clientes();
        gvwDados.DataBind();

    }

    protected void listaUsuarios(string roles)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("Username", typeof(string));
        string[] usuario = Roles.GetUsersInRole(roles);
        for (int i = 0; i < usuario.Length; i++ )
        {
            dt.Rows.Add(usuario[i].ToString());
        }

        GridView1.DataSource = dt;
        GridView1.DataBind();

        //GridView2.DataSource = mbc;
        //GridView2.DataBind();
    }
}
