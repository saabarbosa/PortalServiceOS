<%@ Page Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="AlterarSolicitacao.aspx.cs" Inherits="Administrador_AlterarSolicitacao" Title="Untitled Page" %>

<%@ Register src="Topo.ascx" tagname="Topo" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div>

</div>
    <br />
    <table style="width: 100%; height: 30px">
        <tr>
            <td style="width: 110px; font-weight: 700; height: 23px;">
                Cliente</td>
            <td style="height: 23px">
                <asp:Label ID="lblCliente" runat="server" Text="Label"></asp:Label>
                                </td>
        </tr>
        <tr>
            <td style="width: 110px">
                Equipamento
            </td>
            <td>
                <asp:Label ID="lblEquipamento" runat="server" Text="Label"></asp:Label>
                                </td>
        </tr>
    </table>   
    <table style="width: 100%; height: 30px">
        <tr>
            <td style="width: 110px">
                Tipo de Chamado
            </td>
            <td>
                <asp:Label ID="lblTpChamado" runat="server" Text="Label" 
                    style="font-weight: 700"></asp:Label>
                                </td>
        </tr>
    </table>
     <table style="width: 100%; height: 30px">
        <tr>
            <td style="width: 110px">
                Situação
            </td>
            <td>
                <asp:DropDownList ID="ddlSituacao" runat="server" 
                    DataTextField="nm_Status" DataValueField="cd_Status">
                </asp:DropDownList></td>
        </tr>
    </table>
    <table style="width: 100%; height: 30px">
        <tr>
            <td style="width: 110px">
                Defeito apresentado:</td>
            <td>
                <asp:BulletedList ID="blist" runat="server" 
                    style="font-weight: 700; color: #CC0000">
                </asp:BulletedList>
            </td>
        </tr>
        <tr>
            <td style="width: 110px">
                Descrição do Chamado</td>
            <td>
                <asp:TextBox ID="txtDescricao" runat="server"
                    Width="500px" Height="184px" TextMode="MultiLine" Enabled="False"></asp:TextBox></td>
        </tr>
    </table>
    <table style="width: 100%; height: 30px">
        <tr>
            <td style="width: 110px">
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

