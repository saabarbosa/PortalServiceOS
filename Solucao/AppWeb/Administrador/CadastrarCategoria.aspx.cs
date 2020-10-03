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

using Modelo;
using Cad;

public partial class Administrador_CadastrarCategoria : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

        }
    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Categoria categoria = new Categoria();
        categoria.Nm_Categoria = txtCategoria.Text;
        CategoriaOad.OperacaoCategoria(categoria, "I");
        Response.Redirect("~/Administrador/ListarCategoria.aspx");
    }
}
