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

public partial class Administrador_ExcluirNoticia : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int id_Noticia = Convert.ToInt16(Request["Noticia"]);
            CarregaNoticia(id_Noticia);
        }
    }
    protected void CarregaNoticia(int id_Noticia)
    {

        Noticia noticia = new Noticia();
        noticia = NoticiaOad.Get_Noticia(id_Noticia);
        lblManchete.Text = noticia.Ds_Manchete;
        lblChamada.Text = noticia.Ds_Chamada;
        lblconteudo.Text = noticia.Ds_Conteudo;

    }
    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarNoticias.aspx");
    }
    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        int id_noticia = Convert.ToInt16(Request["Noticia"]);
        Noticia noticia = new Noticia();

        noticia = NoticiaOad.Get_Noticia(id_noticia);
        NoticiaOad.OperacaoNoticia(noticia, "E");
       
        btnCancelar.Visible = false;
        btnExcluir.Visible = false;
        lblConfirmacao.Visible = false;

        lblSucesso.Visible = true;
        btnVoltar.Visible = true;
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarNoticias.aspx");
    }
}
