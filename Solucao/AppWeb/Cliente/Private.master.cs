using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Private : System.Web.UI.MasterPage {

    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Contato.aspx");
    }

}