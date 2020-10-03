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

public partial class Administrador_ListarChamados : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {            
            listaChamados();
            ddlClientes.DataSource = ClienteOad.GetAll_Clientes();
            ddlClientes.DataBind();
            ListItem item = new ListItem("Todos","0");
            ddlClientes.Items.Insert(0, item);
        }
    }
    protected void listaChamados()
    {
        List<Solicitacao> list = new List<Solicitacao>();
        list = SolicitacaoOad.Get_All_Solicitacao_Pendentes();
        gvwChamados.DataSource = list;
        gvwChamados.DataBind();
    }
    protected void gvwChamados_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvwChamados.PageIndex = e.NewPageIndex;        
        listaChamados(); 
    }
    protected void btnPesquisar_Click(object sender, EventArgs e)
    {
        List<Solicitacao> list = new List<Solicitacao>();
        int cliente = Convert.ToInt32(ddlClientes.SelectedItem.Value);
        if (cliente == 0)
            list = SolicitacaoOad.Get_All_Solicitacao_Pendentes();
        else
            list = SolicitacaoOad.Get_Solicitacao_By_Cliente(cliente);
        gvwChamados.DataSource = list;
        gvwChamados.DataBind();
    }
}
