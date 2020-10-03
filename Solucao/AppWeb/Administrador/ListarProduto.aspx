<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="ListarProduto.aspx.cs" Inherits="Administrador_ListarProduto" %>
<%@ Register Src="Topo.ascx" TagName="Topo" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div>
        </div>
                <div style="padding:10px 10px 10px 10px; border:solid 1px #CCCCCC">
        <table style="width: 100%;">
            <tr>
                <td width="25">
                    &nbsp;<img src="../Images/edit.gif" /></td>
                <td>
                    Modificar dados do produto cadastrado</td>
            </tr>
            <tr>
                <td width="25">
                    &nbsp;<img src="../Images/delete.gif" /></td>
                <td>
                    Excluir produto</td>
            </tr>
        </table>
                </div>
        <br />
        <table style="width: 100%;">
            <tr>
                <td>
                    &nbsp; <img src="../Images/add.gif" style="width: 16px; height: 16px" />
                    <asp:HyperLink ID="hlkNovo" runat="server" NavigateUrl="~/Administrador/CadastrarProduto.aspx">Novo Produto</asp:HyperLink></td>
            </tr>
        </table>
        <br />
        <table style="width: 100%;">
            <tr>
                <td style="text-align: center">
                    &nbsp;
                    <asp:Label ID="lblMensagem" runat="server" Font-Italic="False" ForeColor="Red" Text="Não há Produtos Cadastrados"></asp:Label></td>
            </tr>
        </table>
        <asp:GridView ID="gvwDados" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            PagerStyle-HorizontalAlign="Center" PageSize="9" Style="width: 100%;
            height: 30px" OnPageIndexChanging="gvwDados_PageIndexChanging">
            <Columns>
                <asp:BoundField DataField="nm_Produto" HeaderText="Nome  Produto">
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="nm_Categoria" HeaderText="Nome  Categoria">
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="nr_Ordem" HeaderText="Ordem" HeaderStyle-Width="60px">
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>                
                <asp:HyperLinkField DataNavigateUrlFields="id_Produto,id_Categoria" DataNavigateUrlFormatString="AlterarProduto.aspx?Produto={0}&amp;Categoria={1}"
                    DataTextFormatString="Detalhes" HeaderText="&lt;img src='../Images/edit.gif' border=0 &gt;"
                    Text="&lt;img src='../Images/edit.gif' border=0 title='Alterar produto' &gt;">
                    <HeaderStyle HorizontalAlign="Center" Width="30px" />
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:HyperLinkField>
                <asp:HyperLinkField DataNavigateUrlFields="id_Produto,id_Categoria" DataNavigateUrlFormatString="ExcluirProduto.aspx?Produto={0}&amp;Categoria={1}"
                    DataTextFormatString="Detalhes" HeaderText="&lt;img src='../Images/delete.gif' border=0 &gt;"
                    Text="&lt;img src='../Images/delete.gif' border=0 title='Excluir produto' &gt;">
                    <HeaderStyle HorizontalAlign="Center" Width="30px" />
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:HyperLinkField>
            </Columns>
            <PagerStyle HorizontalAlign="Center" />
            <AlternatingRowStyle BackColor="#F0F0F0" />
        </asp:GridView>
</asp:Content>
