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

using Modelo;
using Cad;


public partial class Administrador_AlterarSolicitacao : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int cd_Solicitacao = Convert.ToInt16(Request["Solicitacao"]);
            RetornarStatus();
            RetornarSolicitacao(cd_Solicitacao);           
        }
    }

    protected void RetornarSolicitacao(int cd_Solicitacao)
    {
        Solicitacao solicitacao = new Solicitacao();
        solicitacao = SolicitacaoOad.Get_Solicitacao_By_Solicitacao(cd_Solicitacao);
        lblEquipamento.Text = solicitacao.Nm_Equipamento;
        lblCliente.Text = solicitacao.Nm_Cliente;
        txtDescricao.Text = solicitacao.Ds_Solicitacao;
        lblTpChamado.Text = solicitacao.Tp_Solicitacao;
        string defeito = solicitacao.Ds_Defeito;

        string[] arrDefeito = new string[30];
        char[] separador = { ';' };


        arrDefeito = defeito.Split(separador);

        for(int i = 0; i < arrDefeito.Length; i++)
        {
           if ( (arrDefeito[i] != null) && (!arrDefeito[i].Equals("")) )
            blist.Items.Add(arrDefeito[i].ToString());
        }

        if (blist.Items.Count == 0)
            blist.Items.Add("Não informado.");

        ListItem lItemStatus = ddlSituacao.Items.FindByValue(solicitacao.Cd_Status.ToString());
        lItemStatus.Selected = true;
    }
    protected void RetornarStatus()
    {
        List<Status> list = new List<Status>();
        list = StatusOad.GetAll_Status();
        ddlSituacao.DataSource = list;
        ddlSituacao.DataBind();
    }   
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Solicitacao solicitacao = new Solicitacao();
        int cd_Solicitacao = Convert.ToInt16(Request["Solicitacao"]);
        solicitacao = SolicitacaoOad.Get_Solicitacao_By_Solicitacao(cd_Solicitacao);       
        solicitacao.Cd_Status = Convert.ToInt16(ddlSituacao.SelectedValue);        

        SolicitacaoOad.OperacaoSolicitacao(solicitacao, "A");

        Cliente cliente = new Cliente();
        cliente = ClienteOad.Get_Cliente(solicitacao.Cd_Cliente);
        Cliente clienteUserName = ClienteOad.Get_Cliente_By_UserID(cliente.UserId.ToString());


        EnviarEmail(cliente.Nm_Cliente, cliente.Nm_Base, cliente.Ds_Telefone, clienteUserName.UserName, "Status do Chamado Via WebSite", "Status do Chamado modificado em nosso site.");

        Response.Redirect("~/Administrador/ListarChamados.aspx");
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarChamados.aspx");
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
            msg_html += "<tr>    <td width=\"185\" nowrap=\"nowrap\" class=\"ms-standardheader\">Tipo de Solicita&ccedil;&atilde;o</td>    <td class=\"ms-fields\">Status de Chamado Via WebSite</td></tr>";
            msg_html += "<tr>    <td width=\"185\" nowrap=\"nowrap\" class=\"ms-standardheader\">Nome</td>    <td class=\"ms-fields\">" + nome + "</td></tr><tr>    <td width=\"185\" nowrap=\"nowrap\" class=\"ms-standardheader\">Informa&ccedil;&otilde;es Adicionais</td>    <td class=\"ms-fields\">" + fone + "<br>" + email + "<br>" + mensagem + "<br>" + "</td></tr>";
            msg_html += "</table></body></html>";
            message.Body = msg_html;

            // servidor de e-mail
            SmtpClient smtpClient = new SmtpClient("smtp.apparato.com.br", 587);
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = new System.Net.NetworkCredential("teste2@apparato.com.br", "123456");

            smtpClient.Send(message);
            Response.Write("<script>alert('Chamado enviado por e-mail com sucesso. ');</script>");
            Response.Redirect("ListarChamados.aspx");
        }
        catch (Exception ex)
        {
            //Response.Write("<script>alert('Houve uma falha na transmissao. Favor contactar o administrador do sistema.');</script>");
            Response.Write(ex.Message);
        }

    }

}
