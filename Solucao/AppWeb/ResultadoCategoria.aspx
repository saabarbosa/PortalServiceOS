<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="ResultadoCategoria.aspx.cs" Inherits="ResultadoCategoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <table width="100%" border="0" cellspacing="0" cellpadding="4">
      <tr>
        <td valign="top">
        
        <h3>Lista</h3>
        <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
                <table style="width: 100%; border:0px">                    
                    <tr>
                        <td style="height: 21px; width:100px; text-align: left">
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# "Imagem.aspx?Produto=" + Eval("id_Produto") %>' />                            
                        </td>
                        <td style="height: 21px">
                            <strong>
                                <asp:HyperLink ID="hlkProduto" Target="_blank" NavigateUrl='<%# Eval("Url_Produto") %>' runat="server"> <%# Eval("nm_Produto")%></asp:HyperLink>
                               
                                <br />
                            </strong>
                            <%# Eval("ds_Produto")%>                                                                                   
                        </td>                        
                    </tr>                    
                </table>
                <hr style="BORDER-RIGHT: #cccccc 1px dotted; BORDER-TOP: #cccccc 1px dotted; BORDER-LEFT: #cccccc 1px dotted; BORDER-BOTTOM: #cccccc 1px dotted" noShade SIZE="1" />
            </ItemTemplate>
        </asp:Repeater>        
        
        </td>
        </tr>
   </table>
   
</asp:Content>

