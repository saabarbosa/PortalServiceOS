<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="ListarNoticias.aspx.cs" Inherits="Administrador_ListarNoticias" %>
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
                    Modificar dados da noticia cadastrada</td>
            </tr>
            <tr>
                <td width="25">
                    &nbsp;<img src="../Images/delete.gif" /></td>
                <td>
                    Excluir noticia</td>
            </tr>
        </table>
                </div>
        <br />
        <table style="width: 100%;">
            <tr>
                <td>
                    &nbsp; <img src="../Images/add.gif" style="width: 16px; height: 16px" />
                    <asp:HyperLink ID="hlkNovo" runat="server" NavigateUrl="~/Administrador/CadastrarNoticia.aspx">Nova Noticia</asp:HyperLink></td>
            </tr>
        </table>
        <br />
        <table style="width: 100%;">
            <tr>
                <td style="text-align: center">
                    &nbsp;
                    <asp:Label ID="lblMensagem" runat="server" Font-Italic="False" ForeColor="Red" Text="Não há Noticias Cadastradas"></asp:Label></td>
            </tr>
        </table>
        <asp:GridView ID="gvwDados" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            PagerStyle-HorizontalAlign="Center" PageSize="20" Style="width: 100%;
            height: 30px" OnPageIndexChanging="gvwDados_PageIndexChanging">
            <Columns>
                <asp:BoundField DataField="ds_manchete" HeaderText="Manchete">
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="ds_chamada" HeaderText="Chamada">
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="dt_criacao" HeaderText="Criação" HeaderStyle-Width="60px">
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>                
                <asp:HyperLinkField DataNavigateUrlFields="id_noticia" DataNavigateUrlFormatString="AlterarNoticia.aspx?Noticia={0}"
                    DataTextFormatString="Detalhes" HeaderText="&lt;img src='../Images/edit.gif' border=0 &gt;"
                    Text="&lt;img src='../Images/edit.gif' border=0 title='Alterar noticia' &gt;">
                    <HeaderStyle HorizontalAlign="Center" Width="30px" />
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:HyperLinkField>
                <asp:HyperLinkField DataNavigateUrlFields="id_noticia" DataNavigateUrlFormatString="ExcluirNoticia.aspx?Noticia={0}"
                    DataTextFormatString="Detalhes" HeaderText="&lt;img src='../Images/delete.gif' border=0 &gt;"
                    Text="&lt;img src='../Images/delete.gif' border=0 title='Excluir noticia' &gt;">
                    <HeaderStyle HorizontalAlign="Center" Width="30px" />
                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                </asp:HyperLinkField>
            </Columns>
            <PagerStyle HorizontalAlign="Center" />
            <AlternatingRowStyle BackColor="#F0F0F0" />
        </asp:GridView>
</asp:Content>
