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

public partial class Administrador_ExcluirCategoria : System.Web.UI.Page
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
        lblNome.Text = categoria.Nm_Categoria;
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarCategoria.aspx");
    }
    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        int id_Categoria = Convert.ToInt16(Request["Categoria"]);

        //#region Desativa Pessoa sem Local
        List<Produto> produtos = ProdutoOad.Get_Produtos(id_Categoria);
        bool possui = (( produtos.Count>0 )?true:false);
        if (!possui)
        {
            Categoria categoria = new Categoria();
            categoria = CategoriaOad.Get_Categoria(id_Categoria);
            CategoriaOad.OperacaoCategoria(categoria, "E");
            btnCancelar.Visible = false;
            btnExcluir.Visible = false;
            lblConfirmacao.Visible = false;

            lblSucesso.Visible = true;
            btnVoltar.Visible = true;

        }
        else
            Response.Write("<script>alert('Categoria não pode ser excluída. A mesma possui vínculo com algum produto cadastrado.')</script>");
        //#endregion


    }
    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarCategoria.aspx");
    }
}
