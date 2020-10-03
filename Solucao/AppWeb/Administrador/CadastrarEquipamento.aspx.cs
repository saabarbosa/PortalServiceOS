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

public partial class Administrador_CadastrarEquipamento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            RetornarClientes();
        }
    }
    protected void RetornarClientes()
    {
        List<Cliente> list = new List<Cliente>();
        list = ClienteOad.GetAll_Clientes();
        ddlCliente.DataSource = list;
        ddlCliente.DataBind();
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarEquipamentos.aspx");
    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Equipamento equipamento = new Equipamento();
        equipamento.Nm_Equipamento = txtnm_Equipamento.Text;
        equipamento.Ds_Equipamento = txtDescricao.Text;
        equipamento.Cd_Cliente = Convert.ToInt16(ddlCliente.SelectedValue);
        //equipamento.Nm_Medidor = txtMedidor.Text;
        equipamento.Nm_Serial = txtSerial.Text;
        equipamento.Nm_Localizador = txtLocalizador.Text;
        
        EquipamentoOad.OperacaoEquipamento(equipamento, "I");
        Response.Redirect("~/Administrador/ListarEquipamentos.aspx");
    }
}
