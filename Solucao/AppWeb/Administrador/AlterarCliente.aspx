﻿<%@ Page Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="AlterarCliente.aspx.cs" Inherits="Administrador_AlterarCliente" Title="Apparato" %>

<%@ Register src="Topo.ascx" tagname="Topo" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div>        
    </div>
    <table style="MARGIN-LEFT: 20px; WIDTH: 95%; MARGIN-RIGHT: 20px; HEIGHT: 30px">
        <tr>
            <td style="WIDTH: 98px">
                <b>Cliente
            </b>
            </td>
            <td>
                <asp:RadioButtonList ID="rdbCliente" runat="server" AutoPostBack="True" 
                    OnSelectedIndexChanged="rdbCliente_SelectedIndexChanged" 
                    RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="F">Física</asp:ListItem>
                    <asp:ListItem Value="J">Jurídica</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
    </table>
    <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px;" cellpadding="0" cellspacing="0" >
        <tbody>
            <tr>
                <td colspan="2" style="width: 684px">
                    <table style="width: 100%">
                        <tbody>
                            <tr>
                                <td>
                                    <asp:Panel ID="pnlPessoaFisica" runat="server" Visible="true" Width="100%">
                                        <table style="width: 100%">
                                            <tbody>
                                                <tr>
                                                    <td style="width: 98px">
                                                        CPF</td>
                                                    <td>
                                                        <asp:TextBox ID="txtCpf" runat="server" CssClass="input" MaxLength="14" Width="116px"></asp:TextBox>
                                                    </td>
                                                </tr>                                                
                                                <tr>
                                                    <td style="width: 98px">
                                                        Nome</td>
                                                    <td>
                                                        <asp:TextBox ID="txtNome" runat="server" CssClass="input" MaxLength="60" Width="349px"></asp:TextBox></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </asp:Panel>
                                    <asp:Panel ID="pnlPessoaJuridica" runat="server" Visible="false" Width="100%">
                                        <table style="width: 100%">
                                            <tbody>
                                                <tr>
                                                    <td style="width: 98px">
                                                        CNPJ</td>
                                                    <td>
                                                        <asp:TextBox ID="TxtCnpj" runat="server" CssClass="input" MaxLength="18" Width="132px"></asp:TextBox></td>
                                                </tr>                                                
                                                <tr>
                                                    <td style="width: 98px">
                                                        Razão Social&nbsp;
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="TxtRazaoSocial" runat="server" CssClass="input" MaxLength="200"
                                                            Width="337px"></asp:TextBox></td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </asp:Panel>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>
    <table style="width: 95%; height: 30px; margin-left:20px; margin-right:20px">
      <tr>
        <td style="width: 98px">
                Endereço</td>
        <td>
                <asp:TextBox ID="txtEndereco" runat="server" Width="345px" CssClass="input" MaxLength="80"></asp:TextBox></td>                
      </tr>
    </table>
    <table style="width: 95%; height: 30px; margin-left:20px; margin-right:20px">
      <tr>
        <td style="width: 98px">
                Telefone</td>
        <td>
                <asp:TextBox ID="txtTelFixo1" MaxLength="13" runat="server" Width="115px" CssClass="input" ></asp:TextBox>                
      </tr>
      <tr>
        <td style="width: 98px" valign="top">
                Base</td>
        <td>
                <asp:DropDownList ID="ddlBase" runat="server">
                    <asp:ListItem>SE</asp:ListItem>
                    <asp:ListItem>AL</asp:ListItem>
                </asp:DropDownList>
          </tr>
      </table>    
    <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
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

