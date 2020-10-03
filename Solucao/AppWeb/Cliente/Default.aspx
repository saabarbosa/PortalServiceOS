<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Cliente/Private.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Cliente_Default" %>

<%@ Register Src="Topo.ascx" TagName="Topo" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div>
        
    </div>
        <br />
        <h3>Bem vindo ao sistema Apparato !</h3>
    <table style="width: 100%; height: 30px">
        <tr>
            <td style="text-align: left">
                <b>Meus&nbsp; Chamados Pendentes</b></td>
        </tr>
    </table>
    <asp:GridView ID="gvwChamados" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            PagerStyle-HorizontalAlign="Center"
            PageSize="5" Style="width: 100%; height: 30px" OnPageIndexChanging="gvwChamados_PageIndexChanging">
            <Columns>
                <asp:BoundField DataField="nm_Equipamento" HeaderText="Equipamento">
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>   
                <asp:BoundField DataField="nm_Localizador" HeaderText="Localizador">
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>                                  
                <asp:BoundField DataField="dt_Solicitacao" DataFormatString="{0:dd/MM/yyyy}" 
                    HtmlEncode="False" HeaderText="Data Chamado" >
                <HeaderStyle HorizontalAlign="Left" Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="nm_Status" HeaderText="Situação" >
                <HeaderStyle HorizontalAlign="Left" Width="180px" />
                </asp:BoundField>
            </Columns>
            <PagerStyle HorizontalAlign="Center" />
            <AlternatingRowStyle BackColor="#F0F0F0" />
        </asp:GridView>        
        <div align="center"><asp:Label ID="lblMensagemChamados" runat="server" 
                Text="Não há chamados pendentes." ForeColor="#990000"></asp:Label></div>
    <br />
    <br />
    <table style="width: 100%; height: 30px">
            <tr>
                <td style="text-align: left">
                    <b>Meus Equipamentos</b></td>
            </tr>
        </table>
    <br />        
    <asp:GridView ID="gvwDados" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            PagerStyle-HorizontalAlign="Center"
            PageSize="10" Style="width: 100%; height: 30px" OnPageIndexChanging="gvwDados_PageIndexChanging">
            <Columns>
                <asp:BoundField DataField="nm_Equipamento" HeaderText="Equipamento">
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>       
                <asp:BoundField DataField="nm_Serial" HeaderText="Serial" HeaderStyle-Width="200px">
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>                           
                <asp:BoundField DataField="nm_Localizador" HeaderText="Localizador" HeaderStyle-Width="200px">
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>                
                
            </Columns>
            <PagerStyle HorizontalAlign="Center" />
            <AlternatingRowStyle BackColor="#F0F0F0" />
        </asp:GridView>
                <div align="center"><asp:Label ID="lblMensagemEquipamentos" runat="server" 
                Text="Não há equipamentos cadastrados." ForeColor="#990000"></asp:Label></div>
        <br />        
</asp:Content>