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

public partial class Administrador_AlterarEquipamento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            RetornarClientes();
            int cd_equipamento = Convert.ToInt16(Request["Equipamento"]);            
            RetornaDadosEquipamento(cd_equipamento);
        }
    }
    protected void RetornarClientes()
    {
        List<Cliente> list = new List<Cliente>();
        list = ClienteOad.GetAll_Clientes();
        ddlCliente.DataSource = list;
        ddlCliente.DataBind();
    }
    protected void RetornaDadosEquipamento(int cd_equipamento)
    {
        Equipamento equipamento = new Equipamento();
        equipamento = EquipamentoOad.Get_Equipamento_By_Equipamento(cd_equipamento);
        txtnm_Equipamento.Text = equipamento.Nm_Equipamento;
        txtDescricao.Text = equipamento.Ds_Equipamento;
        txtSerial.Text = equipamento.Nm_Serial;
        txtLocalizador.Text = equipamento.Nm_Localizador;
        ListItem lItemCliente = ddlCliente.Items.FindByValue(equipamento.Cd_Cliente.ToString());
        lItemCliente.Selected = true;        
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarEquipamentos.aspx");
    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Equipamento equipamento = new Equipamento();
        equipamento.Cd_Equipamento = Convert.ToInt16(Request["Equipamento"]);
        equipamento.Nm_Equipamento = txtnm_Equipamento.Text;
        equipamento.Ds_Equipamento = txtDescricao.Text;
        equipamento.Nm_Serial = txtSerial.Text;
        equipamento.Nm_Localizador = txtLocalizador.Text;
        equipamento.Cd_Cliente = Convert.ToInt16(ddlCliente.SelectedValue);
        //equipamento.Nm_Medidor = txtMedidor.Text;

        EquipamentoOad.OperacaoEquipamento(equipamento, "A");
        Response.Redirect("~/Administrador/ListarEquipamentos.aspx");
    }
}
