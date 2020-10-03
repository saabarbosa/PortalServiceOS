<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Contato.aspx.cs" Inherits="Contato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <table width="100%" border="0" cellspacing="0" cellpadding="4">
      <tr>
        <td valign="middle">
           <h3>Fale conosco</h3>
           <table style="width: 100%">
               <tr>
                   <td style="width:50px">
            <img src="Images/faleConosco.jpg" align="left" hspace="10" /></td>
                   <td valign="top" style="width:200px">
                       <b>Aracaju (SE)<br /></b><br />
                       (79) 3222-0381<br />
                       (79) 8116-6738<br />
                       <br />
                       apparato@apparato.com.br<br />
                       <a href="mailto:vendas@apparato.com.br">vendas@apparato.com.br</a><br />
                    assistec@apparato.com.br
                   </td>
                   <td valign="top" style="color: #000000">
                       <b>Maceió (AL)</b><br /><br />
                       (82) 3235-4919<br />
                       (82) 9311-4040<br />
                       <br />
                    apparato@apparato.com.br<br />
                       <a href="mailto:vendas@apparato.com.br">vendas@apparato.com.br</a><br />
                    assistec-mcz@apparato.com.br
                   </td>
               </tr>
               </table>
            
            <span class="Apple-style-span" 
                style="border-collapse: separate; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; font-size: medium; ">
            <span class="Apple-style-span" 
                style="color: rgb(51, 51, 51); font-family: Tahoma, Verdana, arial, helvetica; font-size: 11px; -webkit-border-horizontal-spacing: 2px; -webkit-border-vertical-spacing: 2px; ">
            <strong>
            <br />
            Se preferir preencha o formulário abaixo e clique em enviar.<br />
            <br />
            </strong>
            <table style="width: 100%">
                <tr>
                    <td style="width: 78px">
                        Nome:</td>
                    <td valign="middle">
                        <asp:TextBox ID="txtNome" runat="server" Width="300px"></asp:TextBox>
&nbsp;</span></span><span class="Apple-style-span" 
                style="border-collapse: separate; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; font-size: medium; "><span class="Apple-style-span" 
                style="color: rgb(51, 51, 51); font-family: Tahoma, Verdana, arial, helvetica; font-size: 11px; -webkit-border-horizontal-spacing: 2px; -webkit-border-vertical-spacing: 2px; "><asp:Label 
                            ID="lblErro1" runat="server" ForeColor="Red" Text="Campo nome obrigatório." 
                            Visible="False"></asp:Label>
            </span>
            </span>
                    </td>
                </tr>
                <tr>
                    <td style="width: 78px">
                        Telefone(s):</td>
                    <td>
                        <asp:TextBox ID="txtTelefone" runat="server" Width="200px"></asp:TextBox>
                       </td>
                </tr>
                <tr>
                    <td style="width: 78px">
                        E-mail:</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="250px"></asp:TextBox>
                        <span class="Apple-style-span" 
                style="border-collapse: separate; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; font-size: medium; ">
                        <span class="Apple-style-span" 
                style="color: rgb(51, 51, 51); font-family: Tahoma, Verdana, arial, helvetica; font-size: 11px; -webkit-border-horizontal-spacing: 2px; -webkit-border-vertical-spacing: 2px; ">
                        &nbsp;&nbsp;<asp:Label 
                            ID="lblErro2" runat="server" ForeColor="Red" Text="Campo e-mail obrigatório." 
                            Visible="False"></asp:Label>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                            ControlToValidate="txtEmail" ErrorMessage="Email inválido." 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Email inválido.</asp:RegularExpressionValidator>
                        </span></span>
                    </td>
                </tr>
                <tr>
                    <td style="width: 78px">
                        Assunto:</td>
                    <td>
                        <asp:TextBox ID="txtAssunto" runat="server" Width="300px" ReadOnly="True">Contato via Site</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 78px">
                        Mensagem:</td>
                    <td valign="top">
                        <asp:TextBox ID="txtMensagem" runat="server" Height="150px" TextMode="MultiLine" 
                            Width="400px"></asp:TextBox>
                        <span class="Apple-style-span" 
                style="border-collapse: separate; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; font-size: medium; "><span class="Apple-style-span" 
                style="color: rgb(51, 51, 51); font-family: Tahoma, Verdana, arial, helvetica; font-size: 11px; -webkit-border-horizontal-spacing: 2px; -webkit-border-vertical-spacing: 2px; ">&nbsp;<asp:Label 
                            ID="lblErro3" runat="server" ForeColor="Red" Text="Campo mensgem obrigatório." 
                            Visible="False"></asp:Label>
            </span>
            </span>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td style="width: 78px">
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btnOk" runat="server" onclick="btnOk_Click" Text="Enviar" 
                            Width="75px" />
                    &nbsp;
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="84px" 
                            onclick="btnCancelar_Click" />
                        <br />
                    </td>
                </tr>
            </table>
            </span>
            </span></td>
      </tr>
     </table>
</asp:Content>

