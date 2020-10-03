<%@ Page Title="Apparato" Language="C#" MasterPageFile="~/Public.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">
    <div style="padding:15px 15px 15px 15px; border:solid 1px #CCCCCC">
                    <table border="0" cellpadding="1" cellspacing="0" style="width:100%" 
                                __designer:mapid="720">
                    <tr __designer:mapid="721">
                        <td __designer:mapid="722">
                         <div style="padding:10px 10px 10px 10px; border:solid 1px #FDE979; background-color:#FFFFCC">
                            <span style="font-size: 12px">Você está entrando na área restrita da </span> <span style="color: #CC0000" 
                                __designer:mapid="723"><b __designer:mapid="724">
                            <span style="font-size: 12px">Apparato</span></b></span>.<br 
                                __designer:mapid="725" />
                            Por favor, identifique-se informando os campos abaixo: <b>usuário(e-mail) e senha</b>.<br __designer:mapid="727" />
                            </div>
                            
                            <br />
                            
                            <b>Obs:
                            </b>Somente clientes cadastrados podem acessar esta área. Caso você esteja 
                            cadastrado e não está conseguindo acessar a área restrita ou deseja se 
                            cadastrar entre em contato através do nosso e-mail: 
                            <span style="color: #800000" 
                                __designer:mapid="728"><b __designer:mapid="729">
                            <a href="mailto:sac@apparato.com.br" __designer:mapid="72a">sac@apparato.com.br</a></b></span>.<br 
                                __designer:mapid="72b" />
                              </td>
                             </tr>
                           </table>
</div>
<br />
 <div style="padding:15px 15px 15px 15px; border:solid 1px #CCCCCC">
                <table border="0" cellpadding="1" cellspacing="0" style="width:100%">
                    <tr>
                        <td>
                            <div>
                                <asp:Login ID="Login2" runat="server" 
                                    FailureText="Sua tentativa de login não foi aceito. Tente novamente." 
                                    MembershipProvider="AspNetSqlMembershipProviderApparato" PasswordLabelText="Senha:" 
                                    PasswordRequiredErrorMessage="Senha é obrigatório." TitleText="Acesso" 
                                    UserNameLabelText="Usuário:" 
                                    UserNameRequiredErrorMessage="Usuário é obrigatório." 
                                    onloggingin="Login2_LoggingIn" 
                                    LoginButtonText="Entrar" onloggedin="Login2_LoggedIn" 
                                    RememberMeText="Lembrar minha senha.">
                                    <TitleTextStyle Font-Size="Medium" />
                                </asp:Login>

                            </div>
                        </td>
                    </tr>
                </table>
</div>                

    <br />
    <br />
</asp:Content>

