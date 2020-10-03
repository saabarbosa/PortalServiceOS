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

using System.Net.Mail;
using System.IO;


using Modelo;
using Cad;


public partial class Cliente_OrdemServico : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Cliente cliente = new Cliente();
            cliente = ClienteOad.Get_Cliente_By_UserID(Membership.GetUser().ProviderUserKey.ToString());
            RetornarEquipamentos(cliente.Cd_Cliente);
            RetornarTipoSolicitacao();
            pnlChamado.Visible = true;
            pnlSuprimento.Visible = false;
        }
    }
    protected void RetornarTipoSolicitacao()
    {
        List<TipoSolicitacao> list = new List<TipoSolicitacao>();
        list = Tipo_SolicitacaoOad.GetAll_Tipo_Solicitacao();
        ddlTpSolicitacao.DataSource = list;
        ddlTpSolicitacao.DataBind();
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
        Solicitacao solicitacao = new Solicitacao();
        solicitacao.Cd_Equipamento = Convert.ToInt16(ddlEquipamento.SelectedValue);
        solicitacao.Cd_Status = 1;
        solicitacao.Cd_TpSolicitacao = Convert.ToInt16(ddlTpSolicitacao.SelectedValue);
        solicitacao.Ds_Solicitacao = txtDescricao.Text;
        solicitacao.Dt_Solicitacao = DateTime.Now;
        solicitacao.Nm_Medidor = txtMedidor.Text;

        string defeito = "";
        if (ddlTpSolicitacao.SelectedValue.Equals("1"))
        {
            // CHAMADO TECNICO
            for (int i = 0; i < cbxDefeitoChamado.Items.Count; i++)
            {
                if (cbxDefeitoChamado.Items[i].Selected)
                    defeito += cbxDefeitoChamado.Items[i].Text + ";";
            }
        }
        else
        {
            // SUPRIMENTO
            for (int i = 0; i < cbxSuprimento.Items.Count; i++)
            {
                if (cbxSuprimento.Items[i].Selected)
                    defeito += cbxSuprimento.Items[i].Text + ";";
            }
        }


        solicitacao.Ds_Defeito = defeito;
        SolicitacaoOad.OperacaoSolicitacao(solicitacao, "I");

        Cliente cliente = new Cliente();
        cliente = ClienteOad.Get_Cliente_By_UserID(Membership.GetUser().ProviderUserKey.ToString());
        EnviarEmail(cliente.Nm_Cliente, cliente.Nm_Base, cliente.Ds_Telefone, Membership.GetUser().UserName, "Abertura de Chamado Via WebSite", "Gentileza verificar o chamado aberto no site.");


        
        Response.Redirect("~/Cliente/Default.aspx");
    }


    protected void EnviarEmail(string nome, string nmBase, string fone, string email,
                               string assunto, string mensagem)
    {
        try
        {

            MailAddress mailAddress = new MailAddress("apparato@apparato.com.br");
            MailMessage message = new MailMessage();

            if (nmBase.Equals("AL"))
                message.To.Add("assistec-mcz@apparato.com.br");
            else
                message.To.Add("assistec@apparato.com.br");
            /* Rotina para enviar email com cópia*/
            if ((email != null) && (!email.Equals("")))
                message.CC.Add(email);

            message.Subject = assunto;
            message.IsBodyHtml = true;
            message.From = mailAddress;

            string msg_html = "<html><head><title>Ordem de Serviço</title><style type=\"text/css\"><!--.ms-title{   color: #000000;   font-family: verdana;   font-size: 16pt;   font-weight: normal;   margin: 0 0 4px;}.ms-standardheader {   color:#525252;   font-size:1em;   text-align:left;   font-family:verdana;   font-weight:bold;   font-size:8pt;   border-top-color:#BAD6DD;   border-top-width:1px;   border-top-style:solid;  }.ms-fields{   color: #000000;   font-family: verdana;   font-size: 8pt;   font-weight: normal;   background-color:#EFF2FA;   border-top-color:#BAD6DD;   border-top-width:1px;   border-top-style:solid;}--></style></head>";
            msg_html += "<body><table width=\"100%\" height=\"50\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\">  <tr>    <td class=\"ms-title\">Data/Hora: " + DateTime.Now + "</td>  </tr></table><table width=\"600\" border=\"0\" cellspacing=\"0\" cellpadding=\"6\">";
            msg_html += "<tr>    <td width=\"185\" nowrap=\"nowrap\" class=\"ms-standardheader\">Tipo de Solicita&ccedil;&atilde;o</td>    <td class=\"ms-fields\">Abertura de Chamado Via WebSite</td></tr>";
            msg_html += "<tr>    <td width=\"185\" nowrap=\"nowrap\" class=\"ms-standardheader\">Nome</td>    <td class=\"ms-fields\">" + nome + "</td></tr><tr>    <td width=\"185\" nowrap=\"nowrap\" class=\"ms-standardheader\">Informa&ccedil;&otilde;es Adicionais</td>    <td class=\"ms-fields\">" + fone + "<br>" + email + "<br>" + mensagem + "<br>" + "</td></tr>";
            msg_html += "</table></body></html>";
            message.Body = msg_html;

            // servidor de e-mail
            SmtpClient smtpClient = new SmtpClient("smtp.apparato.com.br", 587);
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = new System.Net.NetworkCredential("teste2@apparato.com.br", "123456");

            smtpClient.Send(message);
            Response.Write("<script>alert('Chamado enviado por e-mail com sucesso. ');</script>");
            Response.Redirect("Default.aspx");
        }
        catch (Exception ex)
        {
            //Response.Write("<script>alert('Houve uma falha na transmissao. Favor contactar o administrador do sistema.');</script>");
            Response.Write(ex.Message);
        }

    }

    protected void ddlTpSolicitacao_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlTpSolicitacao.SelectedValue.Equals("1"))
        {
            pnlChamado.Visible = true;
            pnlSuprimento.Visible = false;
        }
        else
        {
            pnlChamado.Visible = false;
            pnlSuprimento.Visible = true;
        }
    }
}
