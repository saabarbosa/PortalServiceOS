<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Topo.ascx.cs" Inherits="Administrador_Topo" %>
<table width="804" border="0" cellspacing="0" cellpadding="6">
  <tr>
    <td><div align="right">                <asp:LoginStatus ID="LoginStatus2" 
            runat="server" CssClass="entrar" 
                    LogoutAction="RedirectToLoginPage" LoginText="Entrar" 
            LogoutText="Sair" />
                &nbsp;| Usuário logado: <asp:LoginName ID="LoginName1" runat="server" /></div></td>
  </tr>
</table>
<table width="804" height="110" border="0" cellpadding="0" cellspacing="0" background="../Images/menu.jpg">
  <tr>
    <td valign="top"><table width="100%" height="40" border="0" cellpadding="8" cellspacing="2">
      <tr>
        <td width="70" style="text-align: center">                
            <asp:HyperLink ID="hlkHome" runat="server" 
                NavigateUrl="~/Administrador/Default.aspx" CssClass="menu">Home</asp:HyperLink></td>
        <td>    <asp:HyperLink ID="hlkCategoria" runat="server" 
                NavigateUrl="~/Administrador/ListarCategoria.aspx" CssClass="menu">Categoria</asp:HyperLink>&nbsp; |&nbsp;
                                <asp:HyperLink ID="HyperLink1" runat="server" 
                NavigateUrl="~/Administrador/ListarProduto.aspx" CssClass="menu">Produto</asp:HyperLink>&nbsp; |&nbsp;
                <asp:HyperLink ID="hlkProduto" runat="server" 
                NavigateUrl="~/Administrador/ListarNoticias.aspx" CssClass="menu">Noticia</asp:HyperLink>&nbsp; |&nbsp;
                <asp:HyperLink ID="lnkClientes" runat="server" 
                    NavigateUrl="~/Administrador/ListarClientes.aspx" CssClass="menu">Clientes/Usuários</asp:HyperLink>&nbsp; |&nbsp;
                <asp:HyperLink ID="lnkEquipamentos" runat="server" 
                NavigateUrl="~/Administrador/ListarEquipamentos.aspx" CssClass="menu">Equipamentos</asp:HyperLink>&nbsp; |&nbsp;
                 <asp:HyperLink ID="lnkChamados" runat="server" 
                NavigateUrl="~/Administrador/ListarChamados.aspx" CssClass="menu">Chamados</asp:HyperLink>&nbsp; |&nbsp;
                 <asp:HyperLink ID="lnkSenha" runat="server" 
                NavigateUrl="~/Administrador/AlterarMinhaSenha.aspx" CssClass="menu">Alterar Senha</asp:HyperLink>
</td>
      </tr>
    </table>
      <table width="100%" height="50" border="0" cellpadding="6" cellspacing="2">
        <tr>
          <td>&nbsp;</td>
        </tr>
      </table></td>
  </tr>
</table>
