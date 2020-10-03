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

public partial class ResultadoCategoria : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int id_Categoria = Convert.ToInt16(Request["Categoria"]);
            carregaProdutos(id_Categoria);
        }
    }

    protected void carregaProdutos(int id_Categoria)
    {
        Repeater1.DataSource = ProdutoOad.Get_Produtos(id_Categoria);
        Repeater1.DataBind();
    }
}
