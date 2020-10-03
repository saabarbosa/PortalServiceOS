﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Modelo;
using Cad;

public partial class Produtos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            carregaCategorias();
        }
    }

    protected void carregaCategorias()
    {
        gvwDados.DataSource = CategoriaOad.GetAll_Categorias();
        gvwDados.DataBind();
    }

}
