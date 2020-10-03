<%@	Page Language="C#" MasterPageFile="~/Default.master" Title="Apparato" CodeFile="Default.aspx.cs" Inherits="Default_aspx" %>

<%@ Register src="Noticias.ascx" tagname="Noticias" tagprefix="uc1" %>

<asp:content id="Content1" contentplaceholderid="Main" runat="server">
       
    <table width="100%" border="0" cellspacing="0" cellpadding="4">
      <tr>
        <td valign="top"><h3>Bem vindo</h3>
          <table width="100%" border="0" cellspacing="0" cellpadding="4">
            <tr>
              <td><p>A Apparato atua no segmento de locações e outsourcing desenvolvendo soluções 
            para impressão e imagem, oferecendo muito além de produtos de alta tecnologia. 
                <br />
            <br />
            Oferecemos um serviço de suporte, pós-venda e manutenção diferenciado. 
            Buscamos sempre atender a necessidade do nosso cliente oferecendo soluções customizadas. 
               <br />
            <br />
            Nossos clientes contam com uma equipe especializada e treinada para solucionar qualquer necessidade. 
               <br />
            <br />

            Atualmente estamos localizados em Aracaju e Maceió, numa localidade de fácil acesso e estacionamento. Venha nos visitar e conhecer todos 
            os benefícios que podemos lhes oferecer.
            <br /></p>
                </td>
            </tr>
          </table><br />
          <h3>Novidades</h3>          
            <uc1:Noticias ID="Noticias1" runat="server" />
          <br />
          <br />
          <div align="center"></div>
          </td>
        <td width="250" valign="top"><img src="Images/news.png" width="80" height="26" />
            <br />
			  <br />
                <asp:GridView ID="gvwRSS" runat="server" Width="100%" AutoGenerateColumns="False" 
                         PageSize="6" AllowPaging="True" BorderColor="White" BorderStyle="None" 
                          BorderWidth="0px" CellPadding="2" 
                          onpageindexchanging="gvwRSS_PageIndexChanging" ShowHeader="False">
                      <Columns>
                         <asp:TemplateField ItemStyle-Width="10px">
                             <ItemTemplate>
                                 <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/setaRosa.png"  />
                             </ItemTemplate>
                            <ItemStyle Width="10px">
                            </ItemStyle>
                         </asp:TemplateField>
                          <asp:HyperLinkField DataNavigateUrlFields="link" DataTextField="title" 
                              Target="_blank" ItemStyle-CssClass="linha">
                          <ItemStyle Font-Bold="False" />
                          </asp:HyperLinkField>
                          
                      </Columns>
                  </asp:GridView>
			  
	  
			  
			  

			  
	  
			  
			  
			  </td>
      </tr>
    </table>       

	</asp:content>
