<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Noticias.ascx.cs" Inherits="Noticias" %>
<asp:Label ID="lblMensagem" runat="server" Font-Italic="False" ForeColor="Red" Text="Não há Noticias"></asp:Label>
<asp:GridView ID="gvwNoticias" runat="server" Width="100%" AutoGenerateColumns="False" 
         PageSize="3" AllowPaging="True" BorderColor="White" BorderStyle="None" 
          BorderWidth="0px" CellPadding="2" 
          onpageindexchanging="gvwNoticias_PageIndexChanging" ShowHeader="False">
      <Columns>
         <asp:TemplateField ItemStyle-Width="10px">
             <ItemTemplate>
                 <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/setaRosa.png"  />
             </ItemTemplate>
            <ItemStyle Width="10px">
            </ItemStyle>
         </asp:TemplateField>
         
          <asp:HyperLinkField  DataTextFormatString="{0:dd/MM}" DataTextField="dt_criacao" 
              ItemStyle-CssClass="linha">
          <ItemStyle Font-Bold="False" Width="45px" />
          </asp:HyperLinkField>
          <asp:HyperLinkField DataTextField="ds_chamada" 
              ItemStyle-CssClass="linha">
          <ItemStyle Font-Bold="True" />
          </asp:HyperLinkField>
          <asp:HyperLinkField DataNavigateUrlFields="id_noticia" DataNavigateUrlFormatString="Noticia.aspx?cod={0}" DataTextField="ds_chamada" DataTextFormatString="Leia mais..." 
              ItemStyle-CssClass="linha">
          <ItemStyle Font-Bold="False" Width="80px" />
          </asp:HyperLinkField>
          
      </Columns>
  </asp:GridView>