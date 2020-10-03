<%@ Page Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="ExcluirEquipamento.aspx.cs" Inherits="Administrador_ExcluirEquipamento" Title="Apparato" %>

<%@ Register src="Topo.ascx" tagname="Topo" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">

<br />
    <table style="width: 100%; height: 30px">
            <tr>
                <td>
                    <asp:Label ID="lblConfirmacao" runat="server" 
                        Text="Tem certeza que deseja excluir o equipamento abaixo ?" 
                        style="font-weight: 700"></asp:Label></td>
            </tr>
    </table>
    <table style="width: 100%;; height: 30px">
        <tr>
            <td>
                <asp:Label ID="lblNome" runat="server" Font-Bold="False"></asp:Label></td>
        </tr>
    </table>
    <table style="width: 100%; height: 30px">
        <tr>
            <td>
                <br />
                &nbsp;<asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click"
                    Text="Cancelar" Width="90px" Height="30px" />
                &nbsp;
                <asp:Button ID="btnExcluir" runat="server" OnClick="btnExcluir_Click"
                    Text="Confirmar" Width="90px" Height="30px" /><br />
                &nbsp;<asp:Label ID="lblSucesso" runat="server" ForeColor="Green" Text="Equipamento excluído com sucesso."
                    Visible="False"></asp:Label><br />
                &nbsp;<asp:Button ID="btnVoltar" runat="server" OnClick="btnVoltar_Click"
                    Text="Voltar" Visible="False" Width="90px" /></td>
        </tr>
    </table>
</asp:Content>

