using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.IO;

public partial class Contato : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            string nome = txtNome.Text;
            if (nome.Equals(""))
            {
                lblErro1.Visible = true;
                return;
            }
            string fone = txtTelefone.Text;
            string email = txtEmail.Text;
            if (email.Equals(""))
            {
                lblErro2.Visible = true;
                return;
            }
            string assunto = txtAssunto.Text;
            string mensagem = txtMensagem.Text;
            if (mensagem.Equals(""))
            {
                lblErro3.Visible = true;
                return;
            }

            // Metodo para enviar email
            EnviarEmail(nome, fone, email, assunto, mensagem);

        }

    }


    protected void EnviarEmail(string nome, string fone, string email, 
                               string assunto, string mensagem)
    {
        try
        {

            MailAddress mailAddress = new MailAddress("vendas@apparato.com.br");
            MailMessage message = new MailMessage();

            message.To.Add("vendas@apparato.com.br");
            /* Rotina para enviar email com cópia*/
            if ((email != null) && (!email.Equals("")))
                message.CC.Add(email);

            message.Subject = assunto;
            message.IsBodyHtml = true;
            message.From = mailAddress;

            string msg_html = "<html><head><title>Fale Conosco</title><style type=\"text/css\"><!--.ms-title{   color: #000000;   font-family: verdana;   font-size: 16pt;   font-weight: normal;   margin: 0 0 4px;}.ms-standardheader {   color:#525252;   font-size:1em;   text-align:left;   font-family:verdana;   font-weight:bold;   font-size:8pt;   border-top-color:#BAD6DD;   border-top-width:1px;   border-top-style:solid;  }.ms-fields{   color: #000000;   font-family: verdana;   font-size: 8pt;   font-weight: normal;   background-color:#EFF2FA;   border-top-color:#BAD6DD;   border-top-width:1px;   border-top-style:solid;}--></style></head>";
            msg_html += "<body><table width=\"600\" border=\"0\" cellspacing=\"0\" cellpadding=\"6\">";
            msg_html += "<tr>    <td width=\"150\" nowrap=\"nowrap\" class=\"ms-standardheader\">Data/Hora: </td><td class=\"ms-fields\">" + DateTime.Now + "</td></tr>";
            msg_html += "<tr>    <td width=\"150\" nowrap=\"nowrap\" class=\"ms-standardheader\">Nome:</td><td class=\"ms-fields\">" + nome + "</td></tr>";
            msg_html += "<tr>    <td width=\"150\" nowrap=\"nowrap\" class=\"ms-standardheader\">Telefone:</td><td class=\"ms-fields\">" + fone + "</td></tr>";
            msg_html += "<tr>    <td width=\"150\" nowrap=\"nowrap\" class=\"ms-standardheader\">E-mail:</td><td class=\"ms-fields\">" + email + "</td></tr>";
            msg_html += "<tr>    <td width=\"150\" nowrap=\"nowrap\" class=\"ms-standardheader\">Mensagem:</td><td class=\"ms-fields\">" + mensagem + "</td></tr>";
            msg_html += "</table><br><h3>Breve entraremos em contato.</h3></body></html>";
            message.Body = msg_html;

            /* Rotina para anexar arquivo
            if (fupAnexar1.HasFile)
            {
                MemoryStream MStream = new MemoryStream(fupAnexar.FileBytes);
                Attachment anexo = new Attachment(MStream, fupAnexar.FileName);
                message.Attachments.Add(anexo);
            }
             * */

            // servidor de e-mail
            SmtpClient smtpClient = new SmtpClient("smtp.apparato.com.br", 587);
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = new System.Net.NetworkCredential("teste2@apparato.com.br", "123456");

            smtpClient.Send(message);
            Response.Write("<script>alert('Formulario enviado com sucesso. ');</script>");
            Response.Redirect("Default.aspx");
        }
        catch (Exception ex)
        {
            //Response.Write("<script>alert('Houve uma falha na transmissao. Favor contactar o administrador do sistema.');</script>");
            Response.Write(ex.Message);
        }

    }


    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }
}
