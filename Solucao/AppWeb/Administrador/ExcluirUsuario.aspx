<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="ExcluirUsuario.aspx.cs" Inherits="Administrador_ExcluirUsuario" %>

<%@ Register Src="Topo.ascx" TagName="Topo" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div>
    
    </div>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td>
                    <asp:Label ID="lblConfirmacao" runat="server" 
                        Text="Tem certeza que deseja excluir o cliente abaixo ?" 
                        style="font-weight: 700"></asp:Label></td>
            </tr>
        </table>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Cliente</td>
                <td style="color: #000000">
                    <asp:Label ID="lblCliente" runat="server"></asp:Label></td>
            </tr>
        </table>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td>
                    <br />
                    &nbsp;<asp:Button ID="btnCancelar" runat="server" CssClass="botao" OnClick="btnCancelar_Click"
                        Text="Cancelar" Width="90px" Height="30px" />
                    &nbsp;
                    <asp:Button ID="btnExcluir" runat="server" CssClass="botao" OnClick="btnExcluir_Click"
                        Text="Confirmar" Width="90px" Height="30px" /><br />
                    &nbsp;<asp:Label ID="lblSucesso" runat="server" ForeColor="Green" Text="Cliente exclu�do com sucesso."
                        Visible="False"></asp:Label><br />
                    &nbsp;<asp:Button ID="btnVoltar" runat="server" CssClass="botao" OnClick="btnVoltar_Click"
                        Text="Voltar" Visible="False" Width="90px" Height="30px" /></td>
            </tr>
        </table>
</asp:Content>
