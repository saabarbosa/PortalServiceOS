<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="CadastrarProduto.aspx.cs" Inherits="Administrador_CadastrarProduto" MaintainScrollPositionOnPostback="true" %>
<%@ Register Src="Topo.ascx" TagName="Topo" TagPrefix="uc1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div>
    </div>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
        <br />
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Produto</td>
                <td>
                    <asp:TextBox ID="txtnm_Produto" runat="server"
                        Width="500px"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator 
                        ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtnm_Produto" 
                        ErrorMessage="*">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Descrição</td>
                <td>
                    <cc1:Editor ID="Editor1" runat="server" AutoFocus="false" />

                </td>
            </tr>
        </table>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Categoria
                </td>
                <td>
                    <asp:DropDownList ID="ddlCategoria" runat="server" 
                        DataTextField="nm_Categoria" DataValueField="id_Categoria" 
                        AutoPostBack="True" onselectedindexchanged="ddlCategoria_SelectedIndexChanged">
                    </asp:DropDownList></td>
            </tr>
        </table>
         <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    URL
                </td>
                <td>
                   <asp:TextBox ID="txtURL" runat="server"
                        Width="500px" MaxLength="150"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtURL" ErrorMessage="*">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Foto&nbsp;</td>
                <td>
                    <asp:FileUpload ID="fupFoto" runat="server" Width="400px" /><br />
                    <asp:Label ID="lblFoto" runat="server" Text="Tipo de imagem (JPEG, JPG, PNG, GIF)"
                        Visible="False" ForeColor="Red"></asp:Label></td>
            </tr>
        </table>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Ordem<br />
                    (Sequência de Exibição)</td>
                <td>
                    <asp:TextBox ID="txtOrdem" runat="server" MaxLength="2" Width="36px"></asp:TextBox>
&nbsp;Ex: 1, 10<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtOrdem" ErrorMessage="*">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            
            
            <asp:Panel ID="pnlImpressora" runat="server">

            <tr>
                <td style="width: 98px">
                    Detalhes</td>
                <td>
                    <table style="width: 100%; background-color:#E6E8FA">
                        <tr valign="top">
                            <td style="width: 50%">
                                <b>Tipo de impressão ?</b><br />
                                <asp:RadioButtonList ID="rblTpImpressao" runat="server">
                                    <asp:ListItem>Preto e Branca</asp:ListItem>
                                    <asp:ListItem>Colorida</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                            <td style="width: 50%">
                                <b>Volume mensal de impressão ?</b><br />
                                <asp:RadioButtonList ID="rblVolImpressao" runat="server">
                                    <asp:ListItem>0 a 20.000 impressos</asp:ListItem>
                                    <asp:ListItem>20.001 a 85.000 impressos</asp:ListItem>
                                    <asp:ListItem>85.001 a 150.000 impressos</asp:ListItem>
                                    <asp:ListItem>150.001 a 300.000 impressos</asp:ListItem>
                                    <asp:ListItem>Acima de 300.000 impressos</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 50%">
                                <b>Conexão:</b><br />
                                <asp:RadioButtonList ID="rblConexao" runat="server">
                                    <asp:ListItem>Não</asp:ListItem>
                                    <asp:ListItem>Sim</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                            <td style="width: 50%">
                                <b>Frente e verso:</b><br />
                                <asp:RadioButtonList ID="rblFrenteVerso" runat="server">
                                    <asp:ListItem>Não</asp:ListItem>
                                    <asp:ListItem>Sim</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            
           </asp:Panel>
           <asp:Panel ID="pnlCopiadora" runat="server">
            
            <tr>
                <td style="width: 98px">
                    &nbsp;</td>
                <td>
                    <table style="width: 100%; background-color:#E6E8FA">
                        <tr>
                            <td style="width: 50%">
                                <b>Necessita de Scanner?</b><br />
                                <asp:RadioButtonList ID="rblScanner" runat="server">
                                    <asp:ListItem>Não</asp:ListItem>
                                    <asp:ListItem>Sim</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                            <td style="width: 50%">
                                <b>Necessita de FAX?</b><br />
                                <asp:RadioButtonList ID="rblFax" runat="server">
                                    <asp:ListItem>Não</asp:ListItem>
                                    <asp:ListItem>Sim</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <b>Alimentador Automático de Originais?</b><br />
                                <asp:RadioButtonList ID="rblAlimentador" runat="server">
                                    <asp:ListItem>Não</asp:ListItem>
                                    <asp:ListItem>Sim</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            
            </asp:Panel>

            
            <tr>
                <td style="width: 98px">
                </td>
                <td>
                    <asp:Button ID="btnCancelar" runat="server" CausesValidation="False" OnClick="btnCancelar_Click"
                        Text="Cancelar" Height="30px" Width="90px" />&nbsp;
                    <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click"
                        Text="Salvar alterações" Height="30px" />
                </td>
            </tr>
        </table>
</asp:Content>
