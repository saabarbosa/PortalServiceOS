<%@ Page  Title="Apparato" Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="AlterarEquipamento.aspx.cs" Inherits="Administrador_AlterarEquipamento" %>

<%@ Register src="Topo.ascx" tagname="Topo" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div>        
    </div>
    <table style="width: 100%; ">
        <tr>
            <td style="width: 98px">
                <b>Equipamento</b></td>
            <td>
                <asp:TextBox ID="txtnm_Equipamento" runat="server"
                    Width="500px"></asp:TextBox></td>
        </tr>
    </table>
    <table style="idth: 100%; eight: 30px">
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
    <table style="width: 100%; height: 30px">
        <tr>
            <td style="width: 98px">
                Descrição
            </td>
            <td>
               <asp:TextBox ID="txtDescricao" runat="server"
                    Width="500px" Height="60px" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
    </table>  
    <table style="width: 100%; height: 30px">
        <tr>
            <td style="width: 98px">
                Serial
            </td>
            <td>
               <asp:TextBox ID="txtSerial" runat="server"
                    Width="210px" MaxLength="120"></asp:TextBox></td>
        </tr>
    </table>
    <table style="width: 100%; height: 30px">
        <tr>
            <td style="width: 98px">
                Localizador
            </td>
            <td>
               <asp:TextBox ID="txtLocalizador" runat="server"
                    Width="210px" MaxLength="120"></asp:TextBox>&nbsp;</td>
        </tr>
    </table>    
    <table style="width: 100%; height: 30px">
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

