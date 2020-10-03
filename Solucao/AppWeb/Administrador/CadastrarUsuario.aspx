<%@ Page Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="CadastrarUsuario.aspx.cs" Inherits="Administrador_CadastrarUsuario" Title="Apparato" %>

<%@ Register src="Topo.ascx" tagname="Topo" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div>
    </div>
    <br />
    
    <table style="MARGIN-LEFT: 20px; WIDTH: 95%; MARGIN-RIGHT: 20px; HEIGHT: 30px">
        <tr>
            <td style="WIDTH: 98px">
                Função
            </td>
            <td>
                <asp:DropDownList ID="ddlRoles" runat="server">
                    <asp:ListItem>Administrador</asp:ListItem>
                    <asp:ListItem Value="Operadores">Operador</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <table style="width: 95%; height: 30px; margin-left:20px; margin-right:20px">
      <tr>
        <td style="width: 98px" valign="top">
                Login</td>
        <td>
                <asp:TextBox ID="txtLogin" MaxLength="120" runat="server" Width="250px" 
                    CssClass="input"></asp:TextBox>                
      &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtLogin" ErrorMessage="Campo requerido.">Campo requerido.</asp:RequiredFieldValidator>
                <br />
                Informe como login o <b>e-mail </b>do usuário.
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="txtLogin" ErrorMessage="E-mail inválido." 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">E-mail inválido.</asp:RegularExpressionValidator>
                <br />
                Obs: A senha inicial deste usuário será <span style="color: #CC0000">123456</span></tr>
    </table>
    <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
        <tr>
            <td style="width: 98px">
            </td>
            <td>
                <asp:Button ID="btnCancelar" runat="server" CausesValidation="False" OnClick="btnCancelar_Click"
                    Text="Cancelar" />&nbsp;
                <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click"
                    Text="Salvar alterações" />
            </td>
        </tr>
    </table>
</asp:Content>

