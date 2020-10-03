using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

using Modelo;
using Cad;

public partial class Administrador_CadastrarCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarClientes.aspx");
    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            string operacao = "I";
            string tpCliente = rdbCliente.SelectedValue;        
            
            Cliente cliente = new Cliente();
            cliente.UserId = null;        
            if (rdbCliente.SelectedValue == "F")
            {
                cliente.Nm_Cliente = txtNome.Text;
                cliente.Nr_Cpf = Util.RemoverFormatacao(txtCpf.Text);
            }
            else
            {
                cliente.Nm_Cliente = TxtRazaoSocial.Text;
                cliente.Nr_Cnpj = Util.RemoverFormatacao(TxtCnpj.Text);
            }

            cliente.Ds_Endereco = txtEndereco.Text;                        
            cliente.Ds_Telefone = Util.RemoverFormatacao(txtTelFixo1.Text);
            cliente.Id_Login = txtLogin.Text;
            cliente.Nm_Base = ddlBase.SelectedItem.Value;
            cliente.Senha = "123456";
            ClienteOad.OperacaoCliente(cliente, operacao);

        }
        catch (Exception ex)
        {
           Response.Write("<script>window.alert('Operação não realizada.')</script>");
           return;
                
        }
        Response.Redirect("~/Administrador/ListarClientes.aspx");
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
}
