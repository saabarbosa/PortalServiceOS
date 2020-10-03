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

public partial class Administrador_ExcluirCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int id_cliente = Convert.ToInt16(Request["Cliente"]);
            CarregaCliente(id_cliente);
        }
    }
    protected void CarregaCliente(int id_Cliente)
    {
        Cliente cliente = new Cliente();
        cliente = ClienteOad.Get_Cliente(id_Cliente);

        lblCliente.Text = cliente.Nm_Cliente;
        lblCpfCnpj.Text = cliente.Nr_Cnpj + cliente.Nr_Cpf;
 
    }
    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarClientes.aspx");
    }
    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        int id_cliente = Convert.ToInt16(Request["Cliente"]);
        if (EquipamentoOad.Get_Equipamento_By_Cliente(id_cliente).Count > 0)
        {
            btnCancelar.Visible = false;
            btnExcluir.Visible = false;
            lblConfirmacao.Text = "Cliente não pode ser excluído. Verifique se não há nenhum equipamento relacionado.";
        }
        else
        {
            Cliente cliente = new Cliente();
            cliente = ClienteOad.Get_Cliente(id_cliente);
            ClienteOad.OperacaoCliente(cliente, "E");
            btnCancelar.Visible = false;
            btnExcluir.Visible = false;
            lblConfirmacao.Visible = false;
            lblSucesso.Visible = true;
            btnVoltar.Visible = true;
        }
       

    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarClientes.aspx");
    }
}
