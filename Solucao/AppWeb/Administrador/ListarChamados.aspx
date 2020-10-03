<%@ Page Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="ListarChamados.aspx.cs" Inherits="Administrador_ListarChamados" Title="Apparato" %>

<%@ Register src="Topo.ascx" tagname="Topo" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <br />
    <table style="width: 100%; height: 30px">
        <tr>
            <td style="text-align: left">
                <b>&nbsp;<asp:Label ID="lblChamadosPendentes" runat="server" Font-Italic="False" Text="Chamados Pendentes"></asp:Label>
                <br />
                </b>
                <br />
                <asp:DropDownList ID="ddlClientes" runat="server" DataTextField="Nm_Cliente" 
                    DataValueField="Cd_Cliente" Width="230px" Height="25px">
                </asp:DropDownList>
&nbsp;<asp:Button ID="btnPesquisar" runat="server" onclick="btnPesquisar_Click" 
                    Text="Pesquisar" Width="90px" Height="30px" />
            </td>
        </tr>
    </table>
    <asp:GridView ID="gvwChamados" runat="server" AllowPaging="True" AutoGenerateColumns="False"
        PagerStyle-HorizontalAlign="Center"
        PageSize="20" Style="width: 100%; height: 30px" OnPageIndexChanging="gvwChamados_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="nm_Equipamento" HeaderText="Equipamento">
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>                
            <asp:BoundField DataField="Nm_Cliente" HeaderText="Cliente">
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>              
            <asp:BoundField DataField="dt_Solicitacao" DataFormatString="{0:dd/MM/yyyy}" 
                HtmlEncode="False" HeaderText="Data Chamado" HeaderStyle-Width="90px" >
<HeaderStyle Width="90px"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="nm_Status" HeaderText="Situação" 
                HeaderStyle-Width="130px">
<HeaderStyle Width="130px"></HeaderStyle>
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:HyperLinkField DataNavigateUrlFields="cd_Solicitacao" DataNavigateUrlFormatString="AlterarSolicitacao.aspx?Solicitacao={0}"
                DataTextFormatString="Detalhes" HeaderText="&lt;img src='../Images/edit.gif' border=0 &gt;"
                
                Text="&lt;img src='../Images/edit.gif' border=0 title='Alterar Solicitacao' &gt;">
                <HeaderStyle HorizontalAlign="Center" Width="30px" />
                <ItemStyle HorizontalAlign="Center" Width="30px" />
            </asp:HyperLinkField>
        </Columns>
        <PagerStyle HorizontalAlign="Center" />
        <AlternatingRowStyle BackColor="#F0F0F0" />
    </asp:GridView>        
</asp:Content>

