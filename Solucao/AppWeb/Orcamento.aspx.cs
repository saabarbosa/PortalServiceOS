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
using System.Net.Mail;
using System.IO;
using System.Collections.Generic;

using Modelo;
using Cad;

public partial class Orcamento : System.Web.UI.Page
{

    private Hashtable hashOrcamento = new Hashtable();
    private string escolha = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            MultiView1.ActiveViewIndex = 0;
    }

    protected void btn_QuestaoInicial_Click(object sender, EventArgs e)
    {
        escolha = rdbTipoMaquina.SelectedValue;
        int indice = 0; 
        switch (escolha){
            case "I":
                indice = 1;
                pnlView3.Visible = false;
                break;
            case "C":
                indice = 1;
                pnlView3.Visible = true;
                break;
            case "G":
                indice = 3;
                break;
            case "D":
                indice = 3;
                break;
            default:
                break;
        }
        MultiView1.ActiveViewIndex += indice;
        PreencherDados(escolha);

    }
    private void PreencherDados(string escolha)
    {
        // Inicio do View4
        string tipoTpMaquina = rdbTipoMaquina.SelectedItem.Text;
        string tipoImpressora = rdbTipoImpressora.SelectedItem.Text;
        string NrImpressos = rdbNumeroImpressos.SelectedItem.Text;
        string conexao = ddlConexao.SelectedItem.Text;
        string frenteverso = ddlFrenteVerso.SelectedItem.Text;
        string scanner = ddlScanner.SelectedItem.Text;
        string fax = ddlFax.SelectedItem.Text;
        string alimentador = ddlAlimentador.SelectedItem.Text;

        hashOrcamento.Clear();

        switch (escolha)
        {
            case "I": // Impressora
                hashOrcamento.Add(5, "Impressora");
                hashOrcamento.Add(4, "Tipo: " + tipoImpressora);
                hashOrcamento.Add(3, "Núm. Impressos: " + NrImpressos);
                hashOrcamento.Add(2, "Conexão: " + conexao);
                hashOrcamento.Add(1, "Frente/Verso: " + frenteverso);
                break;
            case "C": // Copiadora
                hashOrcamento.Add(8, "Multifuncional");
                hashOrcamento.Add(7, "Tipo: " + tipoImpressora);
                hashOrcamento.Add(6, "Núm. Impressos: " + NrImpressos);
                hashOrcamento.Add(5, "Conexão: " + conexao);
                hashOrcamento.Add(4, "Frente/Verso: " + frenteverso);
                hashOrcamento.Add(3, "Scanner: " + scanner);
                hashOrcamento.Add(2, "Fax: " + fax);
                hashOrcamento.Add(1, "Alimentador: " + alimentador);
                break;
            case "G": // Grandes formatos
                hashOrcamento.Add(1, "Grandes formatos");
                break;
            case "D": // Duplicadores
                hashOrcamento.Add(1, "Duplicadores");
                break;
            default:
                break;
        }
        gvwOrcamento.DataSource = hashOrcamento;
        gvwOrcamento.DataBind();
        // Fim do View4


        // Impressora ou Multifuncional
        if ((tipoTpMaquina.Equals("Impressora")) || (tipoTpMaquina.Equals("Multifuncional")))
        {
            Produto produto = new Produto();
            int id_categoria = 1;
            if (tipoTpMaquina.Equals("Multifuncional"))
                id_categoria = 2;
            produto.Id_Categoria = id_categoria;
            produto.Orca_Tp_Impressao = tipoImpressora;
            produto.Orca_Vl_Impressao = NrImpressos;
            produto.Orca_Conexao = conexao;
            produto.Orca_Frente_Verso = frenteverso;
            produto.Orca_Scanner = scanner;
            produto.Orca_Fax = fax;
            produto.Orca_Alimentador = alimentador;
            // Atribui info ao produto
            List<Produto> produtos = ProdutoOad.Get_OrcamentoProdutos(produto);
            if (produtos.Count > 0)
            {
                pnlSearch.Visible = true;
                pnlEmail.Visible = false;
                Repeater1.DataSource = produtos;
                Repeater1.DataBind();
            }
            else
            {
                pnlEmail.Visible = true;
                pnlSearch.Visible = false;
            }
        }

        

    }

    protected void btn_Voltar02_Click(object sender, EventArgs e)
    {
        escolha = rdbTipoMaquina.SelectedValue;
        MultiView1.ActiveViewIndex -= 1;
        PreencherDados(escolha);
    }
    protected void btn_Voltar03_Click(object sender, EventArgs e)
    {
        escolha = rdbTipoMaquina.SelectedValue;
        MultiView1.ActiveViewIndex -= 1;
        PreencherDados(escolha);
    }
    protected void btn_Continuar02_Click(object sender, EventArgs e)
    {
        escolha = rdbTipoMaquina.SelectedValue;
        MultiView1.ActiveViewIndex += 1;
        PreencherDados(escolha);
    }
    protected void btn_Continuar03_Click(object sender, EventArgs e)
    {
        escolha = rdbTipoMaquina.SelectedValue;
        MultiView1.ActiveViewIndex += 1;
        PreencherDados(escolha);


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

            string assunto  = "Orçamento via WebSite";

            escolha = rdbTipoMaquina.SelectedValue;
            PreencherDados(escolha);

            // Metodo para enviar email
            EnviarEmail(nome, fone, email, assunto, hashOrcamento);
            Response.Redirect("Default.aspx");
        }
    }



    protected void EnviarEmail(string nome, string fone, string email,
                               string assunto, Hashtable hashOrcamento)
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

            string msg_html = "<html><head><title>Orçamento</title><style type=\"text/css\"><!--.ms-title{   color: #000000;   font-family: verdana;   font-size: 16pt;   font-weight: normal;   margin: 0 0 4px;}.ms-standardheader {   color:#525252;   font-size:1em;   text-align:left;   font-family:verdana;   font-weight:bold;   font-size:8pt;   border-top-color:#BAD6DD;   border-top-width:1px;   border-top-style:solid;  }.ms-fields{   color: #000000;   font-family: verdana;   font-size: 8pt;   font-weight: normal;   background-color:#EFF2FA;   border-top-color:#BAD6DD;   border-top-width:1px;   border-top-style:solid;}--></style></head>";
            msg_html += "<body><table width=\"600\" border=\"0\" cellspacing=\"0\" cellpadding=\"6\">";
            msg_html += "<tr>    <td width=\"150\" nowrap=\"nowrap\" class=\"ms-standardheader\">Data/Hora: </td><td class=\"ms-fields\">" + DateTime.Now + "</td></tr>";
            msg_html += "<tr>    <td width=\"150\" nowrap=\"nowrap\" class=\"ms-standardheader\">Nome:</td><td class=\"ms-fields\">" + nome + "</td></tr>";
            msg_html += "<tr>    <td width=\"150\" nowrap=\"nowrap\" class=\"ms-standardheader\">Telefone:</td><td class=\"ms-fields\">" + fone + "</td></tr>";
            msg_html += "<tr>    <td width=\"150\" nowrap=\"nowrap\" class=\"ms-standardheader\">E-mail:</td><td class=\"ms-fields\">" + email + "</td></tr>";
            msg_html += "<tr>    <td width=\"150\" nowrap=\"nowrap\" class=\"ms-standardheader\">Informações:</td><td class=\"ms-fields\">";

            foreach (DictionaryEntry Item in hashOrcamento)
            {
                ListItem newListItem = new ListItem();
                msg_html += Item.Value.ToString() + "<br>";
            }

            msg_html += "<br>" + "</td></tr>";
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
        Response.Redirect("~/Orcamento.aspx");
    }
}
