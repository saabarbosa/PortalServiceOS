using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Modelo;
using Cad;

public partial class Noticia : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id_Noticia = Convert.ToInt16(Request["cod"]);
        Modelo.Noticia noticia =  new Modelo.Noticia();
        noticia = NoticiaOad.Get_Noticia(id_Noticia);

        

        lblManchete.Text = noticia.Ds_Manchete;
        lblData.Text = noticia.Dt_Criacao.ToString("dd/MM/yyyy");
        lblConteudo.Text = noticia.Ds_Conteudo;
    }
}
