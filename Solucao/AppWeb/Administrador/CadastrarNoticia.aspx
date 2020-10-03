<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="CadastrarNoticia.aspx.cs" Inherits="Administrador_CadastrarNoticia" MaintainScrollPositionOnPostback="true" %>
<%@ Register Src="Topo.ascx" TagName="Topo" TagPrefix="uc1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div>
    </div>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
        <br />
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Manchete</td>
                <td>
                    <asp:TextBox ID="txtnm_Manchete" runat="server"
                        Width="500px"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator 
                        ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtnm_Manchete" 
                        ErrorMessage="*">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Chamada</td>
                <td>
                    <asp:TextBox ID="txtnm_Chamada" runat="server"
                        Width="500px"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator 
                        ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtnm_Chamada" 
                        ErrorMessage="*">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Conteúdo</td>
                <td>
                    <cc1:Editor ID="Editor1" runat="server" AutoFocus="false" />

                </td>
            </tr>
        </table>

        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                </td>
                <td>
                    <asp:Button ID="btnCancelar" runat="server" CausesValidation="False" OnClick="btnCancelar_Click"
                        Text="Cancelar" Height="30px" Width="90px" />&nbsp;
                    <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click"
                        Text="Salvar alterações" Height="30px" />
                </td>
            </tr>
        </table>
</asp:Content>
