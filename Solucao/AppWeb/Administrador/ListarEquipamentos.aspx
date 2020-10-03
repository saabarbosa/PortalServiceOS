<%@ Page  Title="Apparato" Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="ListarEquipamentos.aspx.cs" Inherits="Administrador_ListarEquipamentos"  %>

<%@ Register src="Topo.ascx" tagname="Topo" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div>
    </div>
        <div style="padding:10px 10px 10px 10px; border:solid 1px #CCCCCC">
    <table style="width: 100%;">
        <tr>
            <td width="25">
                &nbsp;<img src="../Images/edit.gif" /></td>
            <td>
                Modificar dados do equipamento cadastrado</td>
        </tr>
        <tr>
            <td width="25">
                &nbsp;<img src="../Images/delete.gif" /></td>
            <td>
                Excluir Equipamento</td>
        </tr>
    </table>
        </div>
    <br />
    <table style="width: 100%;">
        <tr>
            <td>
                &nbsp;<img src="../Images/add.gif" style="width: 16px; height: 16px" />
                    <asp:HyperLink ID="hlkNovo" runat="server" NavigateUrl="~/Administrador/CadastrarEquipamento.aspx">Novo Equipamento</asp:HyperLink>
                <br />
                <br />
                <asp:DropDownList ID="ddlClientes" runat="server" DataTextField="Nm_Cliente" 
                    DataValueField="Cd_Cliente" Width="230px" Height="25px">
                </asp:DropDownList>
&nbsp;<asp:Button ID="btnPesquisar" runat="server" onclick="btnPesquisar_Click" 
                    Text="Pesquisar" Width="89px" Height="30px" />
            </td>
        </tr>
    </table>
    <br />
    <table style="width: 100%;">
        <tr>
            <td style="text-align: center">
                &nbsp;
                <asp:Label ID="lblMensagem" runat="server" Font-Italic="False" ForeColor="Red" Text="Não há Equipamentos Cadastrados"></asp:Label></td>
        </tr>
    </table>
    <asp:GridView ID="gvwDados" runat="server" AllowPaging="True" AutoGenerateColumns="False"
        PagerStyle-HorizontalAlign="Center" PageSize="20" Style="width: 100%;
        height: 30px" OnPageIndexChanging="gvwDados_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="nm_Equipamento" HeaderText="Nome Equipamento">
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>
            <asp:BoundField DataField="nm_Localizador" HeaderText="Localizador">
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>            
            <asp:BoundField DataField="nm_Cliente" HeaderText="Nome Cliente">
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>
            <asp:HyperLinkField DataNavigateUrlFields="cd_Equipamento" DataNavigateUrlFormatString="AlterarEquipamento.aspx?Equipamento={0}"
                DataTextFormatString="Detalhes" HeaderText="&lt;img src='../Images/edit.gif' border=0 &gt;"
                
                Text="&lt;img src='../Images/edit.gif' border=0 title='Alterar equipamento' &gt;">
                <HeaderStyle HorizontalAlign="Center" Width="30px" />
                <ItemStyle HorizontalAlign="Center" Width="30px" />
            </asp:HyperLinkField>
            <asp:HyperLinkField DataNavigateUrlFields="cd_Equipamento" DataNavigateUrlFormatString="ExcluirEquipamento.aspx?Equipamento={0}"
                DataTextFormatString="Detalhes" HeaderText="&lt;img src='../Images/delete.gif' border=0 &gt;"
                
                Text="&lt;img src='../Images/delete.gif' border=0 title='Excluir Equipamento' &gt;">
                <HeaderStyle HorizontalAlign="Center" Width="30px" />
                <ItemStyle HorizontalAlign="Center" Width="30px" />
            </asp:HyperLinkField>
        </Columns>
        <PagerStyle HorizontalAlign="Center" />
        <AlternatingRowStyle BackColor="#F0F0F0" />
    </asp:GridView>
    
</asp:Content>

