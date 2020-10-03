<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Cliente/Private.master" AutoEventWireup="true" CodeFile="AlterarSenha.aspx.cs" Inherits="Cliente_AlterarSenha" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <asp:ChangePassword ID="ChangePassword1" runat="server" 
        CancelButtonText="Cancelar" CancelDestinationPageUrl="~/Cliente/Default.aspx" 
        ChangePasswordButtonText="Modificar Senha" 
        ChangePasswordFailureText="Senha incorreta ou nova senha Inválida." 
        ChangePasswordTitleText="Modifique sua Senha" 
        ConfirmNewPasswordLabelText="Confirme nova senha:" 
        ConfirmPasswordCompareErrorMessage="Nova Senha." 
        ConfirmPasswordRequiredErrorMessage="Confirme Nova Senha." 
        ContinueButtonText="Ir para o Início" 
        ContinueDestinationPageUrl="~/Cliente/Default.aspx" 
        NewPasswordLabelText="Novas Sernha:" 
        NewPasswordRegularExpressionErrorMessage="Por favor entre com uma senha diferente." 
        NewPasswordRequiredErrorMessage="Nova Senha é Obrigatório." 
        PasswordLabelText="Senha:" PasswordRequiredErrorMessage="Senha é Obrigatório." 
        SuccessText="Sua Senha foi modificada!" SuccessTitleText="" 
        UserNameLabelText="Usuário:" 
        UserNameRequiredErrorMessage="Usuário é Obrigatório.">
    </asp:ChangePassword>
</asp:Content>

