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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

using Modelo;
using Cad;

public partial class Administrador_CadastrarNoticia : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Noticia noticia = new Noticia();
        noticia.Ds_Manchete = txtnm_Manchete.Text;
        noticia.Ds_Chamada = txtnm_Chamada.Text;
        noticia.Ds_Conteudo = Editor1.Content;
        noticia.Dt_Criacao = DateTime.Now;

        NoticiaOad.OperacaoNoticia(noticia, "I");
        Response.Redirect("~/Administrador/ListarNoticias.aspx");
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarNoticias.aspx");
    }


}
