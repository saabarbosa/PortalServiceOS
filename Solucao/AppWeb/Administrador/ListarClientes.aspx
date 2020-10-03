<%@ Page Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="ListarClientes.aspx.cs" Inherits="Administrador_ListarClientes" Title="Apparato" %>

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
                Modificar dados do cliente cadastrado</td>
        </tr>
        <tr>
            <td width="25">
                &nbsp;<img src="../Images/delete.gif" /></td>
            <td>
                Excluir cliente</td>
        </tr>
    </table>
        </div>
    <br />
    <table style="width: 100%;height: 30px">
        <tr>
            <td>
                &nbsp;<img src="../Images/add.gif" style="width: 16px; height: 16px" />
                    <asp:HyperLink ID="hlkNovo" runat="server" NavigateUrl="~/Administrador/CadastrarCliente.aspx">Novo Cliente</asp:HyperLink>
                    
                    
                        &nbsp;&nbsp;&nbsp;<asp:Image ID="Image1" runat="server" ImageUrl="../Images/add.gif" style="width: 16px; height: 16px" />
                    <asp:HyperLink ID="lnkUsuario" runat="server" NavigateUrl="~/Administrador/CadastrarUsuario.aspx">Novo Usuário</asp:HyperLink>
                    
                    
                    
                    </td>
        </tr>
    </table>
    <br />
    <table style="width: 100%;">
        <tr>
            <td style="text-align: center">
                &nbsp;
                <asp:Label ID="lblMensagem" runat="server" Font-Italic="False" ForeColor="Red" Text="Não há Clientes Cadastrados"></asp:Label></td>
        </tr>
    </table>
    <asp:GridView ID="gvwDados" runat="server" AllowPaging="True" AutoGenerateColumns="False"
        PagerStyle-HorizontalAlign="Center" PageSize="20" Style="width: 100%;
        height: 30px" OnPageIndexChanging="gvwDados_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="nm_Cliente" HeaderText="Nome Cliente">
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>
            <asp:BoundField DataField="Nm_Base" HeaderText="Base" HeaderStyle-Width="30px">
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>            
            <asp:HyperLinkField DataNavigateUrlFields="cd_Cliente" DataNavigateUrlFormatString="AlterarCliente.aspx?Cliente={0}"
                DataTextFormatString="Detalhes" HeaderText="&lt;img src='../Images/edit.gif' border=0 &gt;"
                
                Text="&lt;img src='../Images/edit.gif' border=0 title='Alterar cliente' &gt;">
                <HeaderStyle HorizontalAlign="Center" Width="30px" />
                <ItemStyle HorizontalAlign="Center" Width="30px" />
            </asp:HyperLinkField>
            <asp:HyperLinkField DataNavigateUrlFields="cd_Cliente" DataNavigateUrlFormatString="AlterarSenha.aspx?Cliente={0}"
                DataTextFormatString="Detalhes" HeaderText="&lt;img src='../Images/ico_login.png' border=0 &gt;"
                
                Text="&lt;img src='../Images/ico_login.png' border=0 title='Alterar senha' &gt;">
                <HeaderStyle HorizontalAlign="Center" Width="30px" />
                <ItemStyle HorizontalAlign="Center" Width="30px" />
            </asp:HyperLinkField>            
            <asp:HyperLinkField DataNavigateUrlFields="cd_Cliente" DataNavigateUrlFormatString="ExcluirCliente.aspx?Cliente={0}"
                DataTextFormatString="Detalhes" HeaderText="&lt;img src='../Images/delete.gif' border=0 &gt;"
                
                Text="&lt;img src='../Images/delete.gif' border=0 title='Excluir cliente' &gt;">
                <HeaderStyle HorizontalAlign="Center" Width="30px" />
                <ItemStyle HorizontalAlign="Center" Width="30px" />
            </asp:HyperLinkField>
        </Columns>
        <PagerStyle HorizontalAlign="Center" />
        <AlternatingRowStyle BackColor="#F0F0F0" />
    </asp:GridView>
    <hr />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
        PagerStyle-HorizontalAlign="Center" PageSize="30" Style="width: 100%;
        height: 30px">
        <Columns>
            <asp:BoundField DataField="Username" HeaderText="Usuário">
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>
            <asp:HyperLinkField DataNavigateUrlFields="username" DataNavigateUrlFormatString="AlterarSenhaOperador.aspx?username={0}"
                DataTextFormatString="Detalhes" HeaderText="&lt;img src='../Images/ico_login.png' border=0 &gt;"
                
                Text="&lt;img src='../Images/ico_login.png' border=0 title='Alterar senha operador' &gt;">
                <HeaderStyle HorizontalAlign="Center" Width="30px" />
                <ItemStyle HorizontalAlign="Center" Width="30px" />
            </asp:HyperLinkField>  
            <asp:HyperLinkField DataNavigateUrlFields="Username" DataNavigateUrlFormatString="ExcluirUsuario.aspx?Username={0}"
                DataTextFormatString="Detalhes"  HeaderText="&lt;img src='../Images/delete.gif' border=0 &gt;"
                Text="&lt;img src='../Images/delete.gif' border=0 title='Excluir usuario' &gt;">
                <HeaderStyle HorizontalAlign="Center" Width="30px" />
                <ItemStyle HorizontalAlign="Center" Width="30px" />

            </asp:HyperLinkField>
        </Columns>
        <PagerStyle HorizontalAlign="Center" />
        <AlternatingRowStyle BackColor="#F0F0F0" />
    </asp:GridView>
    
</asp:Content>

