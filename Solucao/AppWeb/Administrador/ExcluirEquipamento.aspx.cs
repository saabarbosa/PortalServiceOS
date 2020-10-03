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

public partial class Administrador_ExcluirEquipamento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int cd_Equipamento = Convert.ToInt16(Request["Equipamento"]);
            CarregaEquipamento(cd_Equipamento);
        }
    }
    protected void CarregaEquipamento(int cd_Equipamento)
    {
        Equipamento equipamento = new Equipamento();
        equipamento = EquipamentoOad.Get_Equipamento_By_Equipamento(cd_Equipamento);
        lblNome.Text = equipamento.Nm_Equipamento;
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarEquipamentos.aspx");
    }
    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        int cd_Equipamento = Convert.ToInt16(Request["Equipamento"]);
        Equipamento equipamento = new Equipamento();
        equipamento = EquipamentoOad.Get_Equipamento_By_Equipamento(cd_Equipamento);
        EquipamentoOad.OperacaoEquipamento(equipamento, "E");        

        btnCancelar.Visible = false;
        btnExcluir.Visible = false;
        lblConfirmacao.Visible = false;

        lblSucesso.Visible = true;
        btnVoltar.Visible = true;
    }
    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarEquipamentos.aspx");
    }
}
