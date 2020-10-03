<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Topo.ascx.cs" Inherits="Cliente_Topo" %>
<table width="804" border="0" cellspacing="0" cellpadding="6">
  <tr>
    <td><div align="right">                <asp:LoginStatus ID="LoginStatus1" 
            runat="server" CssClass="entrar" 
                    LogoutAction="RedirectToLoginPage" LoginText="Entrar" 
            LogoutText="Sair" />
                &nbsp;| Usuário logado: <asp:LoginName ID="LoginName2" runat="server" /></div></td>
  </tr>
</table>
<table width="804" height="110" border="0" cellpadding="0" cellspacing="0" 
    background="../Images/menu.jpg" class="menu">
  <tr>
    <td valign="top"><table width="100%" height="40" border="0" cellpadding="8" cellspacing="2">
      <tr>
        <td width="70" style="text-align: center">                
            <asp:HyperLink ID="HyperLink1" runat="server" 
                NavigateUrl="~/Cliente/Default.aspx" CssClass="menu">Home</asp:HyperLink></td>
        <td>                    <asp:HyperLink ID="hlkCategoria" CssClass="menu" runat="server" NavigateUrl="~/Cliente/OrdemServico.aspx">Abrir Ordem de Serviço</asp:HyperLink>&nbsp; |&nbsp;
                <asp:HyperLink ID="hlkSenha" runat="server"  CssClass="menu" NavigateUrl="~/Cliente/AlterarSenha.aspx">Alterar Senha</asp:HyperLink>

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
