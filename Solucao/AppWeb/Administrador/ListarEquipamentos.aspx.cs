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

public partial class Administrador_ListarEquipamentos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            listaEquipamento();
            ddlClientes.DataSource = ClienteOad.GetAll_Clientes();
            ddlClientes.DataBind();
            ListItem item = new ListItem("Todos", "0");
            ddlClientes.Items.Insert(0, item);
        }
    }
    protected void listaEquipamento()
    {
        List<Equipamento> list = new List<Equipamento>();
        list = EquipamentoOad.GetAll_Equipamentos();
        if (list.Count == 0)
        {
            lblMensagem.Visible = true;
        }
        else
        {
            lblMensagem.Visible = false;
            gvwDados.DataSource = list;
            gvwDados.DataBind();
        }
    }
    protected void gvwDados_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvwDados.PageIndex = e.NewPageIndex;
        gvwDados.DataSource = EquipamentoOad.GetAll_Equipamentos();
        gvwDados.DataBind();
    }
    protected void btnPesquisar_Click(object sender, EventArgs e)
    {
        List<Equipamento> list = new List<Equipamento>();
        int cliente = Convert.ToInt32(ddlClientes.SelectedItem.Value);
        if (cliente == 0)
            list = EquipamentoOad.GetAll_Equipamentos();
        else
            list = EquipamentoOad.Get_Equipamento_By_Cliente(cliente);
        gvwDados.DataSource = list;
        gvwDados.DataBind();
    }
}
