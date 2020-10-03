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

public partial class Administrador_ListarProduto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            listaProduto();
        }
    }

    protected void listaProduto()
    {
        List<Produto> list = new List<Produto>();
        list = ProdutoOad.GetAll_Produtos();
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
        gvwDados.DataSource = ProdutoOad.GetAll_Produtos();
        gvwDados.DataBind();

    }
}
