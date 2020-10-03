<%@ Page  Title="Apparato" Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="CadastrarEquipamento.aspx.cs" Inherits="Administrador_CadastrarEquipamento" %>

<%@ Register src="Topo.ascx" tagname="Topo" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div>        
    </div>
    <br />
    <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
        <tr>
            <td style="width: 98px">
                Equipamento</td>
            <td>
                <asp:TextBox ID="txtnm_Equipamento" runat="server"
                    Width="500px"></asp:TextBox></td>
        </tr>
    </table>
    <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
        <tr>
            <td style="width: 98px">
                Cliente
            </td>
            <td>
                <asp:DropDownList ID="ddlCliente" runat="server" 
                    DataTextField="nm_Cliente" DataValueField="cd_Cliente">
                </asp:DropDownList></td>
        </tr>
    </table>
    <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
        <tr>
            <td style="width: 98px">
                Descrição
            </td>
            <td>
               <asp:TextBox ID="txtDescricao" runat="server"
                    Width="500px" Height="60px" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
    </table>  
    <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
        <tr>
            <td style="width: 98px">
                Serial</td>
            <td>
               <asp:TextBox ID="txtSerial" runat="server"
                    Width="210px" MaxLength="120"></asp:TextBox></td>
        </tr>
    </table>
    <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
        <tr>
            <td style="width: 98px">
                Localizador</td>
            <td>
               <asp:TextBox ID="txtLocalizador" runat="server"
                    Width="210px" MaxLength="120"></asp:TextBox></td>
        </tr>
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

