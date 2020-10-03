<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="ExcluirCategoria.aspx.cs" Inherits="Administrador_ExcluirCategoria" %>

<%@ Register Src="Topo.ascx" TagName="Topo" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div>
    
    </div>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td>
                    <asp:Label ID="lblConfirmacao" runat="server" Text="Tem certeza que deseja excluir a categoria abaixo ?"></asp:Label></td>
            </tr>
        </table>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td>
                    <asp:Label ID="lblNome" runat="server" Font-Bold="True"></asp:Label></td>
            </tr>
        </table>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td>
                    <br />
                    &nbsp;<asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click"
                        Text="Cancelar" Width="90px" Height="30px" />
                    &nbsp;
                    <asp:Button ID="btnExcluir" runat="server" OnClick="btnExcluir_Click"
                        Text="Confirmar" Width="90px" Height="30px" /><br />
                    &nbsp;<asp:Label ID="lblSucesso" runat="server" ForeColor="Green" Text="Categoria excluída com sucesso."
                        Visible="False"></asp:Label><br />
                    &nbsp;<asp:Button ID="btnVoltar" runat="server" OnClick="btnVoltar_Click"
                        Text="Voltar" Visible="False" Width="90px" /></td>
            </tr>
        </table>
</asp:Content>
