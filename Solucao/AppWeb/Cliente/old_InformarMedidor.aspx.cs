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

public partial class Cliente_InformarMedidor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Cliente cliente = new Cliente();
            cliente = ClienteOad.Get_Cliente_By_UserID(Membership.GetUser().ProviderUserKey.ToString());
            RetornarEquipamentos(cliente.Cd_Cliente);
        }
    }

    protected void RetornarEquipamentos(int cd_cliente)
    {
        List<Equipamento> list = new List<Equipamento>();
        list = EquipamentoOad.Get_Equipamento_By_Cliente(cd_cliente);
        ddlEquipamento.DataSource = list;
        ddlEquipamento.DataBind();
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Cliente/Default.aspx");
    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Cliente cliente = new Cliente();
        cliente = ClienteOad.Get_Cliente_By_UserID(Membership.GetUser().ProviderUserKey.ToString());

        Equipamento equipamento = new Equipamento();
        equipamento.Cd_Equipamento = Convert.ToInt32(ddlEquipamento.SelectedItem.Value);
        equipamento.Cd_Cliente = cliente.Cd_Cliente;
        //equipamento.Nm_Medidor = txtMedidor.Text;
        
        EquipamentoOad.UpdateMedidor(equipamento);
        Response.Redirect("~/Cliente/Default.aspx");
    }
}
