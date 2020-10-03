<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="AlterarNoticia.aspx.cs" Inherits="Administrador_AlterarNoticia" %>

<%@ Register Src="Topo.ascx" TagName="Topo" TagPrefix="uc1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Manchete<asp:RequiredFieldValidator ID="rfvnm_Manchete" runat="server" ControlToValidate="txtnm_Manchete"
                        ErrorMessage="  *"></asp:RequiredFieldValidator></td>
                <td>
                    <asp:TextBox ID="txtnm_Manchete" runat="server" 
                        Width="500px"></asp:TextBox></td>
            </tr>
        </table>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Chamada<asp:RequiredFieldValidator ID="rfvnm_Chamada" runat="server" ControlToValidate="txtnm_Chamada"
                        ErrorMessage="  *"></asp:RequiredFieldValidator></td>
                <td>
                    <asp:TextBox ID="txtnm_Chamada" runat="server" 
                        Width="500px"></asp:TextBox></td>
            </tr>
        </table> 
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Conteúdo</td>
                <td>
                    <cc1:Editor ID="Editor1" runat="server" />
                </td>
            </tr>
        </table>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                </td>
                <td>
                    <asp:Button ID="btnCancelar" runat="server" OnClientClick="location='ListarNoticias.aspx'"
                        Text="Cancelar" OnClick="btnCancelar_Click" Height="31px" Width="89px" />&nbsp;
                    <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" 
                        Text="Salvar alterações" Height="30px" />
                </td>
            </tr>
        </table>
</asp:Content>

