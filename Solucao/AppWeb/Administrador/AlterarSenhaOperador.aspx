<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="AlterarSenhaOperador.aspx.cs" Inherits="Administrador_AlterarSenhaOperador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
        <tr>
            <td style="width: 98px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 98px; height: 27px;">
                Cliente</td>
            <td style="height: 27px">
                <asp:Label ID="lblCliente" runat="server" Text="Label" style="font-weight: 700"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 98px">
                &nbsp;</td>
            <td>
                <br />
                Deseja mesmo resetar senha do operador acima ?<br />
                <br />
                <b>Obs:</b> Caso afirmativo a senha será iniciada para <b>123456</b><br />
                <br />
                <asp:Button ID="btnSim" runat="server" onclick="btnSim_Click" Text="Sim" 
                    Width="90px" Height="30px" />
                &nbsp;<asp:Button ID="btnNao" runat="server" Text="Não" Width="90px" 
                    onclick="btnNao_Click" Height="30px" />
            </td>
        </tr>
    </table>
</asp:Content>

