<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="CadastrarCategoria.aspx.cs" Inherits="Administrador_CadastrarCategoria" %>

<%@ Register Src="Topo.ascx" TagName="Topo" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div>
        <br />
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Categoria<asp:RequiredFieldValidator ID="rfvCategoria" runat="server" ControlToValidate="txtCategoria"
                        ErrorMessage="  *"></asp:RequiredFieldValidator></td>
                <td>
                    <asp:TextBox ID="txtCategoria" runat="server" 
                        Width="500px"></asp:TextBox></td>
            </tr>
        </table>
    
    </div>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                </td>
                <td>
                    <asp:Button ID="btnCancelar" runat="server" OnClientClick="location='ListarCategoria.aspx'"
                        Text="Cancelar" />&nbsp;
                    <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click"
                        Text="Salvar alterações" />
                </td>
            </tr>
        </table>
</asp:Content>
