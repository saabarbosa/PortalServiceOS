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


public partial class Cliente_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Cliente cliente = new Cliente();
            cliente = ClienteOad.Get_Cliente_By_UserID(Membership.GetUser().ProviderUserKey.ToString());
            listaEquipamentos(cliente.Cd_Cliente);
            listaChamados(cliente.Cd_Cliente);
        }
    }
    protected void listaEquipamentos(int cd_Cliente)
    {
        List<Equipamento> list = new List<Equipamento>();
        list = EquipamentoOad.Get_Equipamento_By_Cliente(cd_Cliente);
        if (list.Count > 0)
        {
            gvwDados.DataSource = list;
            gvwDados.DataBind();
            lblMensagemEquipamentos.Visible = false;
        }
        else
        {
            gvwDados.Visible = false;
            lblMensagemEquipamentos.Visible = true;
        }
    }
    protected void listaChamados(int cd_Cliente)
    {
        List<Solicitacao> list = new List<Solicitacao>();
        list = SolicitacaoOad.Get_Solicitacao_By_Cliente(cd_Cliente);
        if (list.Count > 0)
        {
            gvwChamados.DataSource = list;
            gvwChamados.DataBind();
            lblMensagemChamados.Visible = false;
        }
        else
        {
            gvwChamados.Visible = false;
            lblMensagemChamados.Visible = true;
        }

    }
    protected void gvwDados_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvwDados.PageIndex = e.NewPageIndex;
        Cliente cliente = new Cliente();
        cliente = ClienteOad.Get_Cliente_By_UserID(Membership.GetUser().ProviderUserKey.ToString());
        listaEquipamentos(cliente.Cd_Cliente);        
    }
    protected void gvwChamados_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvwChamados.PageIndex = e.NewPageIndex;
        Cliente cliente = new Cliente();
        cliente = ClienteOad.Get_Cliente_By_UserID(Membership.GetUser().ProviderUserKey.ToString());
        listaChamados(cliente.Cd_Cliente);     
    }
}
