<%@ Page Language="C#" MasterPageFile="~/Cliente/Private.master" AutoEventWireup="true" CodeFile="OrdemServico.aspx.cs" Inherits="Cliente_OrdemServico" Title="Apparato" %>

<%@ Register src="Topo.ascx" tagname="Topo" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div>
        <br />
        <b><span style="font-size: 12px">&nbsp;Abrir Ordem de Serviço</span></b></div>
    <br />
     <table style="width: 100%; height: 30px">
        <tr>
            <td style="width: 130px">
                <b>Equipamento
            </b>
            </td>
            <td>
                <asp:DropDownList ID="ddlEquipamento" runat="server" 
                    DataTextField="Identificador" DataValueField="cd_Equipamento">
                </asp:DropDownList></td>
        </tr>
    </table>   
    <table style="width: 100%; height: 30px">
        <tr>
            <td style="width: 130px">
                Tipo de Chamado
            </td>
            <td>
                <asp:DropDownList ID="ddlTpSolicitacao" runat="server" 
                    DataTextField="Tp_Solicitacao" DataValueField="Cd_TpSolicitacao" 
                    AutoPostBack="True" 
                    onselectedindexchanged="ddlTpSolicitacao_SelectedIndexChanged">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 130px">
                Medidor</td>
            <td>
               <asp:TextBox ID="txtMedidor" runat="server"
                    Width="210px"></asp:TextBox></td>
        </tr>
    </table>
    <asp:Panel ID="pnlChamado" runat="server">
    <table style="width: 100%; height: 30px">
        <tr>
            <td style="width: 130px">
                Defeito apresentado:</td>
            <td>
                <asp:CheckBoxList ID="cbxDefeitoChamado" runat="server" RepeatColumns="3">
                    <asp:ListItem>Papel atolado</asp:ListItem>
                    <asp:ListItem>Impressão manchando</asp:ListItem>
                    <asp:ListItem>Não imprime</asp:ListItem>
                    <asp:ListItem>Impressão em branco</asp:ListItem>
                    <asp:ListItem>Pontos na impressão</asp:ListItem>
                    <asp:ListItem>Não liga</asp:ListItem>
                    <asp:ListItem>Barulho anormal</asp:ListItem>
                    <asp:ListItem>Não digitaliza</asp:ListItem>
                    <asp:ListItem>MSG: Chamar assist. técnica.</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>    
        <tr>
            <td style="width: 130px">
                Descrição do Chamado</td>
            <td>
                <asp:TextBox ID="txtDescricao" runat="server"
                    Width="500px" Height="184px" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
    </table>
    </asp:Panel>
    
 <asp:Panel ID="pnlSuprimento" runat="server">
    <table style="width: 100%; height: 30px">
        <tr>
            <td style="width: 130px">
                Defeito apresentado:</td>
            <td>
                <asp:CheckBoxList ID="cbxSuprimento" runat="server" RepeatColumns="4">
                    <asp:ListItem>Toner Preto</asp:ListItem>
                    <asp:ListItem>Toner amarelo</asp:ListItem>
                    <asp:ListItem>Toner ciano</asp:ListItem>
                    <asp:ListItem>Toner magenta</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>    
    </table>
    </asp:Panel>    
    
    
    <table style="width: 100%; height: 30px">
        <tr>
            <td style="width: 130px">
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

