<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Administrador_Default" %>

<%@ Register Src="Topo.ascx" TagName="Topo" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div>
        
    </div>
        <br />
        <h3>Bem vindo ao sistema Apparato !</h3>
    <table style="width: 100%">
        <tr>
            <td valign=top style="padding:10px 10px 10px 10px; border:solid 1px #CCCCCC">
                <b>Área de Gestão do Site</b><br />
                <br />
                Nessa área você poderá:<br />
                 <ul>
                    <li>Criar, excluir e alterar as categorias</li>
                    <li>Criar, excluir e alterar os seus produtos</li>
                </ul>
            </td>
            <td style="width:5px; background-color:#FFFFFF">
                <img src="../Images/spacer.gif" style="width:5px;" />
            </td>
            <td valign=top style="padding:10px 10px 10px 10px; border:solid 1px #CCCCCC">
                <b>Área de Gestão do Cliente</b><br />
                <br />
                Nessa área você poderá:<ul>
                    <li>Criar e alterar clientes</li>
                    <li>Criar, excluir e alterar equipamentos dos clientes</li>
                    <li>Acompanhar e modificar o status dos chamados</li>
                    <li>Resetar senha dos clientes</li>
                </ul>
            </td>
        </tr>
    </table>
</asp:Content>