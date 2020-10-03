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

public partial class Administrador_ExcluirProduto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int id_Produto = Convert.ToInt16(Request["Produto"]);
            int id_Categoria = Convert.ToInt16(Request["Categoria"]);
            CarregaProduto(id_Produto);
        }
    }
    protected void CarregaProduto(int id_Produto)
    {
        Produto produto = new Produto();
        produto = ProdutoOad.Get_Produto(id_Produto);
        lblProduto.Text = produto.Nm_Produto;
        lblDescricao.Text = produto.Ds_Produto;
        lblCategoria.Text = produto.Nm_Categoria;
        lblURL.Text = produto.Url_Produto;

        Session["Foto"] = produto.Img_Produto;
        hdfTamFoto.Value = produto.Tam_Produto;

        if (hdfTamFoto.Value != "0")
            imgFoto.ImageUrl = "Imagem.aspx?Produto=" + produto.Id_Produto + "&Tam=" + hdfTamFoto.Value;
        //else
        //    imgFoto.ImageUrl = "~/Images/FS-1016_web.jpg";
    }
    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarProduto.aspx");
    }
    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        int id_produto = Convert.ToInt16(Request["Produto"]);
        Produto produto = new Produto();
        produto = ProdutoOad.Get_Produto(id_produto);
        ProdutoOad.OperacaoProduto(produto, "E");

       
        btnCancelar.Visible = false;
        btnExcluir.Visible = false;
        lblConfirmacao.Visible = false;

        lblSucesso.Visible = true;
        btnVoltar.Visible = true;
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarProduto.aspx");
    }
}
