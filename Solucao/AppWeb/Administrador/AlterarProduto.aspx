<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="AlterarProduto.aspx.cs" Inherits="Administrador_AlterarProduto" %>

<%@ Register Src="Topo.ascx" TagName="Topo" TagPrefix="uc1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <br />
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Produto<asp:RequiredFieldValidator ID="rfvnm_Produto" runat="server" ControlToValidate="txtnm_Produto"
                        ErrorMessage="  *"></asp:RequiredFieldValidator></td>
                <td>
                    <asp:TextBox ID="txtnm_Produto" runat="server" onkeyup="nextFocus( this, 9, event );"
                        Width="500px"></asp:TextBox></td>
            </tr>
        </table>
    
 
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Descrição</td>
                <td>
                    <cc1:Editor ID="Editor1" runat="server" />
                </td>
            </tr>
        </table>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Categoria<asp:RequiredFieldValidator ID="rfvCategoria" runat="server" ControlToValidate="ddlCategoria"
                        ErrorMessage="  *"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCategoria" runat="server" DataTextField="nm_Categoria"
                        DataValueField="id_Categoria" AutoPostBack="True" 
                        onselectedindexchanged="ddlCategoria_SelectedIndexChanged1">
                    </asp:DropDownList></td>
            </tr>
        </table>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    URL<asp:RequiredFieldValidator ID="rfvURL" runat="server" ControlToValidate="txtURL"
                        ErrorMessage="  *"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="txtURL" runat="server" MaxLength="150" Width="500px"></asp:TextBox></td>
            </tr>
        </table>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Foto&nbsp;</td>
                <td>
                    <asp:Image ID="imgFoto" runat="server" ImageUrl="" /><br />
                    <asp:FileUpload ID="fupFoto" runat="server" CssClass="input" Width="400px" /><br />
                    <asp:Label ID="lblFoto" runat="server" Text="Tipo de imagem (JPEG, JPG, PNG, GIF)"
                        Visible="False" ForeColor="Red"></asp:Label><br />
                    <asp:HiddenField ID="hdfTamFoto" runat="server" />
                </td>
            </tr>
        </table>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Ordem</td>
                <td>
                    <asp:TextBox ID="txtOrdem" runat="server" MaxLength="2" Width="36px"></asp:TextBox>
&nbsp;Ex: 1, 10</td>
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
                    <asp:Button ID="btnCancelar" runat="server" OnClientClick="location='ListarProduto.aspx'"
                        Text="Cancelar" OnClick="btnCancelar_Click" Height="31px" Width="89px" />&nbsp;
                    <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" 
                        Text="Salvar alterações" Height="30px" />
                </td>
            </tr>
        </table>
</asp:Content>

