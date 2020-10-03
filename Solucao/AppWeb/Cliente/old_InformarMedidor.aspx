<%@ Page  Title="" Language="C#" MasterPageFile="~/Cliente/Private.master" AutoEventWireup="true" CodeFile="old_InformarMedidor.aspx.cs" Inherits="Cliente_InformarMedidor" %>

<%@ Register src="Topo.ascx" tagname="Topo" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div>        
        <br />
        <b><span style="font-size: 12px">Informe o medidor do equipamento</span></b></div>
    <br />
    <table style="width: 100%; height: 30px">
        <tr>
            <td style="width: 120px">
                <b>Equipamento</b></td>
            <td>
                <asp:DropDownList ID="ddlEquipamento" runat="server" 
                    DataTextField="nm_Equipamento" DataValueField="cd_Equipamento">
                </asp:DropDownList></td>
        </tr>
    </table>
    <table style="width: 100%; height: 30px">
        <tr>
            <td style="width: 120px">
                Medidor
            </td>
            <td>
               <asp:TextBox ID="txtMedidor" runat="server"
                    Width="210px"></asp:TextBox></td>
        </tr>
    </table>
    <table style="width: 100%; height: 30px">
            <tr>
                <td style="width: 120px">
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

