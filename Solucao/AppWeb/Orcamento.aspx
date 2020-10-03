<%@ Page Language="C#" MasterPageFile="~/Default.master" MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeFile="Orcamento.aspx.cs" Inherits="Orcamento" Title="Apparato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <table width="100%" border="0" cellspacing="0" cellpadding="4">
      <tr>
        <td valign="top"><h3>Orçamento</h3>
   <table border="0" cellpadding="0" cellspacing="3" width="100%">
            <tr>
                <td style="font-size: 11px; color: rgb(51,51,51); font-family: Tahoma, Verdana, arial, helvetica">
                    <span class="style1" style="font-weight: bold; font-size: 12px; color: rgb(255,0,0)">
                        Monte sua Solução</span></td>
            </tr>
            <tr>
                <td style="font-size: 11px; font-family: Tahoma, Verdana, arial, helvetica">
                        <p>
                            <br />
                            Nesta área você terá a oportunidade de montar sua própria solução de acordo com
                            sua demanda e necessidade. </p>
                        <p>
                            <asp:MultiView ID="MultiView1" runat="server">
                                <asp:View ID="View1" runat="server">
                                <asp:Label ID="lblQuestao01" runat="server" 
                                        Text="1. Qual é o tipo de equipamento que você necessita ?" Font-Bold="True"></asp:Label><br />
                                    <br />
                                    <asp:RadioButtonList ID="rdbTipoMaquina" runat="server">
                                        <asp:ListItem Selected="True" Value="I">Impressora</asp:ListItem>
                                        <asp:ListItem Value="C">Multifuncional</asp:ListItem>
                                        <asp:ListItem Value="G">Grandes Formatos</asp:ListItem>
                                        <asp:ListItem Value="D">Duplicadores Digitais</asp:ListItem>
                                    </asp:RadioButtonList><br />
                                    <asp:Button ID="btn_QuestaoInicial" runat="server" Font-Bold="True" OnClick="btn_QuestaoInicial_Click"
                                        Text="Enviar >>" Width="78px" /></asp:View>
                                <asp:View ID="View2" runat="server">
                                    <asp:Label ID="lblQuestao02" runat="server" Font-Bold="True" Text="2. Qual o tipo de impressão ?"></asp:Label><br />
                                    <br />
                                    <asp:RadioButtonList ID="rdbTipoImpressora" runat="server">
                                        <asp:ListItem Selected="True" Value="P">Preto e Branca</asp:ListItem>
                                        <asp:ListItem Value="C">Colorida</asp:ListItem>
                                    </asp:RadioButtonList><br />
                                    <asp:Label ID="lblQuestao03" runat="server" Font-Bold="True" Text="3. Qual é seu volume mensal de Impressões ?"></asp:Label><br />
                                    <br />
                                    <asp:RadioButtonList ID="rdbNumeroImpressos" runat="server">
                                        <asp:ListItem Selected="True" Value="20">0 a 20.000 impressos</asp:ListItem>
                                        <asp:ListItem Value="85">20.001 a 85.000 impressos</asp:ListItem>
                                        <asp:ListItem Value="150">85.001 a 150.000 impressos</asp:ListItem>
                                        <asp:ListItem Value="300">150.001 a 300.000 impressos</asp:ListItem>
                                        <asp:ListItem Value="301">Acima de 300.000 impressos</asp:ListItem>
                                    </asp:RadioButtonList><br />
                                    <asp:Button ID="btn_Voltar02" runat="server" Font-Bold="True" OnClick="btn_Voltar02_Click"
                                        Text="<< Voltar " Width="103px" />
                                    <asp:Button ID="btn_Continuar02" runat="server" Font-Bold="True" Text="Continuar >>"
                                        Width="108px" OnClick="btn_Continuar02_Click" /></asp:View>
                                <asp:View ID="View3" runat="server">
                                    <asp:Label ID="lblQuestao04" runat="server" Font-Bold="True" Text="4. Conexão"></asp:Label><br />
                                    <br />
                                    <asp:DropDownList ID="ddlConexao" runat="server">
                                        <asp:ListItem>Sim</asp:ListItem>
                                        <asp:ListItem>N&#227;o</asp:ListItem>
                                     </asp:DropDownList><br />
                                    <br />
                                    <asp:Label ID="lblQuestao05" runat="server" Font-Bold="True" Text="5. Frente e Verso ? "></asp:Label><br />
                                    <br />
                                    <asp:DropDownList ID="ddlFrenteVerso" runat="server">
                                        <asp:ListItem>Sim</asp:ListItem>
                                        <asp:ListItem>N&#227;o</asp:ListItem>
                                    </asp:DropDownList><br />
                                    <asp:Panel ID="pnlView3" runat="server" Width="100%">
                                    
                                    
 <br />
                                    <asp:Label ID="lblQuestao06" runat="server" Font-Bold="True" Text="6. Necessita de Scanner ? "></asp:Label><br />
                                    <br />
                                    <asp:DropDownList ID="ddlScanner" runat="server">
                                        <asp:ListItem>N&#227;o</asp:ListItem>
                                        <asp:ListItem>Sim</asp:ListItem>
                                    </asp:DropDownList><br />
                                    <br />
                                    <asp:Label ID="lblQuestao07" runat="server" Font-Bold="True" Text="7. Necessita de FAX ? "></asp:Label><br />
                                    <br />
                                    <asp:DropDownList ID="ddlFax" runat="server">
                                        <asp:ListItem>Sim</asp:ListItem>
                                        <asp:ListItem>N&#227;o</asp:ListItem>
                                    </asp:DropDownList><br />
                                    <br />
                                    <asp:Label ID="lblQuestao08" runat="server" Font-Bold="True" Text="8. Alimentador Automático de Originais ?"></asp:Label><br />
                                    <br />
                                    <asp:DropDownList ID="ddlAlimentador" runat="server">
                                        <asp:ListItem>Sim</asp:ListItem>
                                        <asp:ListItem>N&#227;o</asp:ListItem>
                                    </asp:DropDownList><br />                                    
                                    
                                    </asp:Panel>
                                   
                                    <br />
                                    <asp:Button ID="btn_Voltar03" runat="server" Font-Bold="True" 
                                        Text="<< Voltar " Width="103px" OnClick="btn_Voltar03_Click" />
                                    <asp:Button ID="btn_Continuar03" runat="server" Font-Bold="True" Text="Continuar >>"
                                        Width="108px" OnClick="btn_Continuar03_Click" /></asp:View>
                                <asp:View ID="View4" runat="server">
                                    
                                    
                            <asp:datagrid  id="gvwOrcamento" runat="server" Width="100%" 
                                           autogeneratecolumns="False"
                                           forecolor="Black"
                                           backcolor="#FFFFFF"
                                           cellpadding="3"
                                           gridlines="None">
                             <HeaderStyle BackColor="#CCCCCC" />
                              <itemstyle/>
                              <alternatingitemstyle font-name="tahoma,arial,sans-serif"
                                           backcolor="#E2E2E2" />

                              <columns>
                                <asp:boundcolumn headertext="Dados selecionados:" datafield="Value"/>
                              </columns>

                            </asp:datagrid>                                    
                                       
                                    <asp:Panel ID="pnlEmail" runat="server">
                                                               
                                    <b>Preencha o formulário abaixo e clique em enviar:</b><br />
                                    <span class="Apple-style-span" 
                                        style="border-collapse: separate; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; font-size: medium; ">
                                    <span class="Apple-style-span" 
                                        style="color: rgb(51, 51, 51); font-family: Tahoma, Verdana, arial, helvetica; font-size: 11px; -webkit-border-horizontal-spacing: 2px; -webkit-border-vertical-spacing: 2px; ">
                                    <table style="width: 100%">
                                        <tr>
                                            <td style="width: 71px">
                                                Nome:</td>
                                            <td valign="middle" style="width: 305px">
                                                <asp:TextBox ID="txtNome" runat="server" Width="300px"></asp:TextBox>
                                                <span class="Apple-style-span" 
                                                    style="border-collapse: separate; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; font-size: medium; "><span 
                                                    class="Apple-style-span" 
                                                    style="color: rgb(51, 51, 51); font-family: Tahoma, Verdana, arial, helvetica; font-size: 11px; -webkit-border-horizontal-spacing: 2px; -webkit-border-vertical-spacing: 2px; "><asp:Label 
                                                    ID="lblErro1" runat="server" ForeColor="Red" Text="Campo nome obrigatório." 
                                                    Visible="False"></asp:Label>
                                                </span></span></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 71px">
                                                Telefone(s):</td>
                                            <td style="width: 305px">
                                                <span class="Apple-style-span" 
                                                    style="border-collapse: separate; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; font-size: medium; ">
                                                <span class="Apple-style-span" 
                                                    style="color: rgb(51, 51, 51); font-family: Tahoma, Verdana, arial, helvetica; font-size: 11px; -webkit-border-horizontal-spacing: 2px; -webkit-border-vertical-spacing: 2px; ">
                                                <asp:TextBox ID="txtTelefone" runat="server" Width="200px"></asp:TextBox>
                                                </span></span>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 71px">
                                                E-mail:</td>
                                            <td valign="middle">
                                                <asp:TextBox ID="txtEmail" runat="server" Width="250px"></asp:TextBox>
                                                <span class="Apple-style-span" 
                                                    style="border-collapse: separate; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; font-size: medium; ">
                                                <span class="Apple-style-span" 
                                                    style="color: rgb(51, 51, 51); font-family: Tahoma, Verdana, arial, helvetica; font-size: 11px; -webkit-border-horizontal-spacing: 2px; -webkit-border-vertical-spacing: 2px; ">
                                                &nbsp;<br />
                                                <asp:Label ID="lblErro2" runat="server" ForeColor="Red" 
                                                    Text="Campo e-mail obrigatório." Visible="False"></asp:Label>

                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                                    ControlToValidate="txtEmail" ErrorMessage="E-mail inválido." 
                                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">E-mail inválido.</asp:RegularExpressionValidator>
                                                                                               </span> </span>
                                            </td>
                                        </tr>
                                    </table>
                                    <p style="font-weight: 700">
                                        <br />
                                        Se preferir você pode entrar em contato diretamente conosco pelos seguintes 
                                        telefone(s):</p>
                                    <p>
                                        Tel: (79) 3222-0381 / 3211-4463<span class="Apple-converted-space">&nbsp;</span><br />
                                        Fax:(79) 3214-4820<br />
                                        Cel: (79) 8116-6738<br />
                                    </p>
                                    </span></span>
                                    </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <span class="Apple-style-span" 
                                                style="border-collapse: separate; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; font-size: medium; ">
                                            <span class="Apple-style-span" 
                                                style="color: rgb(51, 51, 51); font-family: Tahoma, Verdana, arial, helvetica; font-size: 11px; -webkit-border-horizontal-spacing: 2px; -webkit-border-vertical-spacing: 2px; ">
                                            <asp:Button ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
                                                Text="&lt;&lt; Cancelar" Width="100px" style="font-weight: 700" />
                                            </span></span>
                                             <span class="Apple-style-span" 
                                        style="border-collapse: separate; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; font-size: medium; ">
                                    <span class="Apple-style-span" 
                                        style="color: rgb(51, 51, 51); font-family: Tahoma, Verdana, arial, helvetica; font-size: 11px; -webkit-border-horizontal-spacing: 2px; -webkit-border-vertical-spacing: 2px; ">
                                    &nbsp;<asp:Button ID="btnOk" runat="server" onclick="btnOk_Click" 
                                        style="font-weight: 700" Text="Enviar &gt;&gt;" Width="100px" />
                                    </span></span>
                                        </td>
                                    </tr>
                                    </table>
                                    </span></span>
                                    
                                  </asp:Panel>   
                                  
                                  <asp:Panel ID="pnlSearch" runat="server">
                                    <br />
                                      <b>Produtos recomendados:</b><br />
                                      <asp:Repeater ID="Repeater1" runat="server">
                                          <ItemTemplate>
                                              <table style="width: 100%; border:0px">
                                                  <tr>
                                                      <td style="height: 21px; width:100px; text-align: left">
                                                          <asp:Image ID="Image1" runat="server" 
                                                              ImageUrl='<%# "Imagem.aspx?Produto=" + Eval("id_Produto") %>' />
                                                      </td>
                                                      <td style="height: 21px">
                                                          <strong>
                                                          <asp:HyperLink ID="hlkProduto" runat="server" 
                                                              NavigateUrl='<%# Eval("Url_Produto") %>'> <%# Eval("nm_Produto")%></asp:HyperLink>
                                                          <br />
                                                          </strong><%# Eval("ds_Produto")%>
                                                      </td>
                                                  </tr>
                                              </table>
                                              <hr noShade SIZE="1" 
                                                  style="BORDER-RIGHT: #cccccc 1px dotted; BORDER-TOP: #cccccc 1px dotted; BORDER-LEFT: #cccccc 1px dotted; BORDER-BOTTOM: #cccccc 1px dotted" />
                                          </ItemTemplate>
                                      </asp:Repeater>
                                  
                                  
                                  </asp:Panel>   
                                    
                                   
                                </asp:View>
                            </asp:MultiView>&nbsp;</p>

                    </td>
            </tr>
        </table>
        </td>
      </tr>
     </table>
</asp:Content>

