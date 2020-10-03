<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Administrador/Private.master" AutoEventWireup="true" CodeFile="AlterarMinhaSenha.aspx.cs" Inherits="Administrador_AlterarMinhaSenha" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <asp:ChangePassword ID="ChangePassword1" runat="server" 
        CancelButtonText="Cancelar" CancelDestinationPageUrl="~/Administrador/Default.aspx" 
        ChangePasswordButtonText="Modificar Senha" 
        ChangePasswordFailureText="Senha incorreta ou nova senha Inválida." 
        ChangePasswordTitleText="Modifique sua Senha" 
        ConfirmNewPasswordLabelText="Confirme nova senha:" 
        ConfirmPasswordCompareErrorMessage="Nova Senha." 
        ConfirmPasswordRequiredErrorMessage="Confirme Nova Senha." 
        ContinueButtonText="Ir para o Início" 
        ContinueDestinationPageUrl="~/Administrador/Default.aspx" 
        NewPasswordLabelText="Novas Sernha:" 
        NewPasswordRegularExpressionErrorMessage="Por favor entre com uma senha diferente." 
        NewPasswordRequiredErrorMessage="Nova Senha é Obrigatório." 
        PasswordLabelText="Senha:" PasswordRequiredErrorMessage="Senha é Obrigatório." 
        SuccessText="Sua Senha foi modificada!" SuccessTitleText="" 
        UserNameLabelText="Usuário:" 
        UserNameRequiredErrorMessage="Usuário é Obrigatório.">
    </asp:ChangePassword>
</asp:Content>
