using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Default_aspx  : System.Web.UI.Page {

    protected void Page_Load(object sender, EventArgs e)
    {
        preencheGrid();
    }

    private void preencheGrid()
    {
        try
        {
            //criar o dataset
            DataSet dtSet = new DataSet();
            //dtSet.ReadXml("http://idgnow.uol.com.br/computacao_corporativa/RSS2/index.html");
            //this.gvwRSS.DataSource = dtSet.Tables[2].DefaultView;
            //this.gvwRSS.DataBind();


        }
        catch (Exception ex)
        {
            throw ex;
        }
    }



    protected void gvwRSS_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvwRSS.PageIndex = e.NewPageIndex;
        preencheGrid();
    }
}