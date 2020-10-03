<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="AlterarCategoria.aspx.cs" Inherits="Administrador_AlterarCategoria" %>
<%@ Register Src="Topo.ascx" TagName="Topo" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">

    <div>
    
    </div>
        <br />
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px">
                    Categoria<asp:RequiredFieldValidator ID="rfvCategoria" runat="server" ControlToValidate="txtCategoria"
                        ErrorMessage="  *"></asp:RequiredFieldValidator></td>
                <td>
                    <asp:TextBox ID="txtCategoria" runat="server" Width="500px"></asp:TextBox></td>
            </tr>
        </table>
        <table style="margin-left: 20px; width: 95%; margin-right: 20px; height: 30px">
            <tr>
                <td style="width: 98px; height: 26px">
                </td>
                <td style="height: 26px">
                    <input id="btnCancelar" class="botao" onclick="location='ListarCategoria.aspx'" type="button"
                        value="Cancelar" style="height: 30px; width: 90px" />
                    &nbsp;<asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click"
                        Text="Salvar alterações" Height="30px" />
                </td>
            </tr>
        </table>
</asp:Content>
