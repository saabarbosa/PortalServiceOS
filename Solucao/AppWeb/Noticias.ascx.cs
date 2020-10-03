using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Modelo;
using Cad;

public partial class Noticias : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        List<Modelo.Noticia> list = new List<Modelo.Noticia>();
        list = NoticiaOad.GetAll_Noticias();

         if (list.Count == 0)
        {
            lblMensagem.Visible = true;
        }
        else
        {
            lblMensagem.Visible = false;
            gvwNoticias.DataSource = list;
            gvwNoticias.DataBind();
        }
 
    }
    protected void gvwNoticias_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvwNoticias.PageIndex = e.NewPageIndex;
        gvwNoticias.DataSource = NoticiaOad.GetAll_Noticias();
        gvwNoticias.DataBind();
    }
}
