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

using Cad;
using Modelo;

public partial class Assinantes_Imagem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.ContentType = "image/jpeg";
        int id_produto  = Convert.ToInt16(Request.Params["Produto"]);
        int tam = Convert.ToInt32(Request.Params["Tam"]);
        Produto produto = ProdutoOad.Get_Produto(id_produto);
        //Response.OutputStream.Write(produto.Img_Produto, 0, tam);
        
        Response.OutputStream.Write((byte[])Session["Foto"], 0, tam);   
        Response.End();
    }
}
