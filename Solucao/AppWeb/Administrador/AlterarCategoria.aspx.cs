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

public partial class Administrador_AlterarCategoria : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int id_Categoria = Convert.ToInt16(Request["Categoria"]);
            CarregaCategoria(id_Categoria);
        }
    }

    protected void CarregaCategoria(int id_Categoria)
    {
        Categoria categoria = new Categoria();
        categoria = CategoriaOad.Get_Categoria(id_Categoria);
        txtCategoria.Text = categoria.Nm_Categoria;
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        int id_Categoria = Convert.ToInt16(Request["Categoria"]);
        Categoria categoria = new Categoria();
        categoria.Id_Categoria = id_Categoria;
        categoria.Nm_Categoria = txtCategoria.Text;
        CategoriaOad.OperacaoCategoria(categoria, "A");
        Response.Redirect("~/Administrador/ListarCategoria.aspx");
    }
}
