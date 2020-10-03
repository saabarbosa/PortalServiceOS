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

public partial class Administrador_AlterarCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int id_Cliente = Convert.ToInt16(Request["Cliente"]);
            CarregaCliente(id_Cliente);

        }
    }
    protected void CarregaCliente(int id_Cliente)
    {
        Cliente cliente = new Cliente();
        cliente = ClienteOad.Get_Cliente(id_Cliente);
        if (cliente.Nr_Cpf != "")
        {
            pnlPessoaFisica.Visible = true;
            pnlPessoaJuridica.Visible = false;
            txtNome.Text = cliente.Nm_Cliente;
            txtCpf.Text = cliente.Nr_Cpf;
            rdbCliente.SelectedIndex = 0;
        }
        else
        {
            pnlPessoaFisica.Visible = false;
            pnlPessoaJuridica.Visible = true;
            TxtRazaoSocial.Text = cliente.Nm_Cliente;
            TxtCnpj.Text = cliente.Nr_Cnpj;
            rdbCliente.SelectedIndex = 1;
        }
        txtEndereco.Text = cliente.Ds_Endereco;
        txtTelFixo1.Text = cliente.Ds_Telefone;
        ListItem lItemCliente = ddlBase.Items.FindByText(cliente.Nm_Base);
        lItemCliente.Selected = true;
        

    }
    protected void rdbCliente_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rdbCliente.SelectedValue == "F")
        {

            pnlPessoaJuridica.Visible = false;
            pnlPessoaFisica.Visible = true;
        }
        else
        {
            pnlPessoaJuridica.Visible = true;
            pnlPessoaFisica.Visible = false;
        }
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarClientes.aspx");
    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        string operacao = "A";
        //string tpCliente = rdbCliente.SelectedValue;

        Cliente cliente = new Cliente();
        cliente.Cd_Cliente = Convert.ToInt16(Request["Cliente"]);
        if (rdbCliente.SelectedValue == "F")
        {
            cliente.Nm_Cliente = txtNome.Text;
            cliente.Nr_Cpf = Util.RemoverFormatacao(txtCpf.Text);
            cliente.Nr_Cnpj = null;
        }
        else
        {
            cliente.Nm_Cliente = TxtRazaoSocial.Text;
            cliente.Nr_Cnpj = Util.RemoverFormatacao(TxtCnpj.Text);
            cliente.Nr_Cpf = null;
        }

        cliente.Ds_Endereco = txtEndereco.Text;
        cliente.Ds_Telefone = Util.RemoverFormatacao(txtTelFixo1.Text);
        cliente.Nm_Base = ddlBase.SelectedItem.Value;
        ClienteOad.OperacaoCliente(cliente, operacao);
        Response.Redirect("~/Administrador/ListarClientes.aspx");
    }
}
