<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Produtos.aspx.cs" Inherits="Produtos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <table width="100%" border="0" cellspacing="0" cellpadding="4">
      <tr>
        <td valign="top"><h3>Produtos</h3>
        <asp:GridView ID="gvwDados" runat="server" AutoGenerateColumns="False" Width="100%" BorderWidth="0" BorderStyle="None" PageSize="20" 
                HeaderStyle-Wrap="False" ShowHeader="False" BackColor="white" >
            <PagerSettings Visible="False" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <ul>
                            <li>
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "ResultadoCategoria.aspx?Categoria=" + Eval("id_Categoria") %>'
                                    Text='<%# Eval("nm_Categoria") %>'></asp:HyperLink>
                            </li>
                        </ul>    
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <HeaderStyle Wrap="False" />
        </asp:GridView>
        </td>
      </tr>
    </table>
</asp:Content>

