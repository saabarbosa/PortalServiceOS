using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Login2_LoggingIn(object sender, LoginCancelEventArgs e)
    {

        
    }
    protected void Login2_LoggedIn(object sender, EventArgs e)
    {        
        string [] roles = Roles.GetRolesForUser(Login2.UserName);
        if ((roles[0].Equals("Administrador")) || (roles[0].Equals("Operadores")))
            Login2.DestinationPageUrl = "~/Administrador/Default.aspx";
        else            
            Login2.DestinationPageUrl = "~/Cliente/Default.aspx";            
    }
}
