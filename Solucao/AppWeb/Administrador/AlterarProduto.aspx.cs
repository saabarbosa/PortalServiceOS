using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

using Modelo;
using Cad;

public partial class Administrador_AlterarProduto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            RetornarCategorias();
            int id_produto = Convert.ToInt16(Request["Produto"]);
            int id_categoria = Convert.ToInt16(Request["Categoria"]);
            pnlImpressora.Visible = false;
            pnlCopiadora.Visible = false;
            RetornaDadosProduto(id_produto,id_categoria);
        }
    }
    protected void RetornarCategorias()
    {
        List<Categoria> list = new List<Categoria>();
        list = CategoriaOad.GetAll_Categorias();
        ddlCategoria.DataSource = list;
        ddlCategoria.DataBind();
    }
    protected void RetornaDadosProduto(int id_produto, int id_categoria)
    {
        Produto produto = new Produto();
        produto = ProdutoOad.Get_Produto(id_produto);        
        txtnm_Produto.Text = produto.Nm_Produto;
        Editor1.Content = produto.Ds_Produto;
        txtURL.Text = produto.Url_Produto;
        ListItem lItemCategoria = ddlCategoria.Items.FindByValue(produto.Id_Categoria.ToString());
        lItemCategoria.Selected = true;

        Session["Foto"] = produto.Img_Produto;
        hdfTamFoto.Value = produto.Tam_Produto;

        if (hdfTamFoto.Value != "0")
            imgFoto.ImageUrl = "Imagem.aspx?Produto=" + produto.Id_Produto + "&Tam=" + hdfTamFoto.Value;
        //else
        //    imgFoto.ImageUrl = "~/Images/FS-1016_web.jpg";

        txtOrdem.Text = produto.Nr_Ordem;

        string value = ddlCategoria.SelectedValue;
        if (value.Equals("1")){
            pnlImpressora.Visible = true;
            pnlCopiadora.Visible = false;

            if (produto.Orca_Tp_Impressao != null)
            {
                ListItem lItem1 = rblTpImpressao.Items.FindByValue(produto.Orca_Tp_Impressao.ToString());
                lItem1.Selected = true;
            }
            if (produto.Orca_Vl_Impressao != null)
            {
                ListItem lItem2 = rblVolImpressao.Items.FindByValue(produto.Orca_Vl_Impressao.ToString());
                lItem2.Selected = true;
            }
            if (produto.Orca_Conexao != null)
            {
                ListItem lItem3 = rblConexao.Items.FindByValue(produto.Orca_Conexao.ToString());
                lItem3.Selected = true;
            }
            if (produto.Orca_Frente_Verso != null)
            {
                ListItem lItem4 = rblFrenteVerso.Items.FindByValue(produto.Orca_Frente_Verso.ToString());
                lItem4.Selected = true;
            }



        }else if (value.Equals("2")){
            pnlImpressora.Visible = true;
            pnlCopiadora.Visible = true;

            if (produto.Orca_Tp_Impressao != null)
            {
                ListItem lItem1 = rblTpImpressao.Items.FindByValue(produto.Orca_Tp_Impressao.ToString());
                lItem1.Selected = true;
            }
            if (produto.Orca_Vl_Impressao != null)
            {
                ListItem lItem2 = rblVolImpressao.Items.FindByValue(produto.Orca_Vl_Impressao.ToString());
                lItem2.Selected = true;
            }
            if (produto.Orca_Conexao != null)
            {
                ListItem lItem3 = rblConexao.Items.FindByValue(produto.Orca_Conexao.ToString());
                lItem3.Selected = true;
            }
            if (produto.Orca_Frente_Verso != null)
            {
                ListItem lItem4 = rblFrenteVerso.Items.FindByValue(produto.Orca_Frente_Verso.ToString());
                lItem4.Selected = true;
            }
            if (produto.Orca_Scanner != null)
            {
                ListItem lItem5 = rblScanner.Items.FindByValue(produto.Orca_Scanner.ToString());
                lItem5.Selected = true;
            }
            if (produto.Orca_Fax != null)
            {
                ListItem lItem6 = rblFax.Items.FindByValue(produto.Orca_Fax.ToString());
                lItem6.Selected = true;
            }
            if (produto.Orca_Alimentador != null)
            {
                ListItem lItem7 = rblAlimentador.Items.FindByValue(produto.Orca_Alimentador.ToString());
                lItem7.Selected = true;
            }
        }


    }
    private byte[] ResizeImageFile(byte[] imageFile, int targetSize)
    {
        using (System.Drawing.Image oldImage = System.Drawing.Image.FromStream(new MemoryStream(imageFile)))
        {
            Size newSize = CalculateDimensions(oldImage.Size, targetSize);
            using (Bitmap newImage = new Bitmap(newSize.Width, newSize.Height, PixelFormat.Format24bppRgb))
            {
                using (Graphics canvas = Graphics.FromImage(newImage))
                {
                    canvas.SmoothingMode = SmoothingMode.AntiAlias;
                    canvas.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    canvas.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    canvas.DrawImage(oldImage, new Rectangle(new Point(0, 0), newSize));
                    MemoryStream m = new MemoryStream();
                    newImage.Save(m, ImageFormat.Jpeg);
                    return m.GetBuffer();
                }
            }
        }
    }

    private Size CalculateDimensions(Size oldSize, int targetSize)
    {
        Size newSize = new Size();
        if (oldSize.Height > oldSize.Width)
        {
            newSize.Width = (int)(oldSize.Width * ((float)targetSize / (float)oldSize.Height));
            newSize.Height = targetSize;
        }
        else
        {
            newSize.Width = targetSize;
            newSize.Height = (int)(oldSize.Height * ((float)targetSize / (float)oldSize.Width));
        }
        return newSize;
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {       
        byte[] byteImagemFoto;
        string TamFoto;
        bool permiteGravarFoto = false;
        if (fupFoto.HasFile)
        {
            #region Captura o tamanho da Foto
            // esta string armazenará o tipo de imagem (JPEG, BMP, GIF, etc)
            string strTipoFoto = fupFoto.PostedFile.ContentType;
            // esta variavel armazenará o tamanho do arquivo de imagem 
            switch (strTipoFoto)
            {
                case "image/pjpeg": permiteGravarFoto = true;
                    break;
                case "image/jpg": permiteGravarFoto = true;
                    break;
                case "image/jpeg": permiteGravarFoto = true;
                    break;
                case "image/png": permiteGravarFoto = true;
                    break;
                case "image/x-png": permiteGravarFoto = true;
                    break;
                case "image/gif": permiteGravarFoto = true;
                    break;
                default: permiteGravarFoto = false; Response.Write("<script>alert('Tipo de imagem inválido.')</script>");
                    break;
            }
            int intTamanhoFoto = System.Convert.ToInt32(fupFoto.PostedFile.InputStream.Length);
            // a variável byteImagem é um array com tamanho estabelecido pela propriedade
            // length que foi armazenada na variável intTamanho (tamanho do arquivo em bytes)
            byteImagemFoto = new byte[intTamanhoFoto];
            // o método Read() do controle File se encarregará de ler o arquivo de imagem 
            // e armazenar o conteúdo na variável byteImagem. A sintaxe deste método é: 
            // Read(<variável>, início, fim)
            fupFoto.PostedFile.InputStream.Read(byteImagemFoto, 0, intTamanhoFoto);
            byteImagemFoto = ResizeImageFile(byteImagemFoto, 80);
            TamFoto = Convert.ToString(intTamanhoFoto);
            #endregion
        }
        else
        {
            byteImagemFoto = (byte[])Session["Foto"];
            TamFoto = hdfTamFoto.Value;
            permiteGravarFoto = true;
        }
        if (permiteGravarFoto)
        {
            Produto produto = new Produto();
            produto.Id_Produto = Convert.ToInt16(Request["Produto"]);
            produto.Nm_Produto = txtnm_Produto.Text;
            produto.Ds_Produto = Editor1.Content;            
            produto.Id_Categoria = Convert.ToInt16(ddlCategoria.SelectedValue);
            produto.Img_Produto = byteImagemFoto;
            produto.Tam_Produto = TamFoto;
            produto.Url_Produto = txtURL.Text;
            produto.Nr_Ordem = txtOrdem.Text;

            // Impressora e Copiadora
            produto.Orca_Tp_Impressao = rblTpImpressao.SelectedValue;
            produto.Orca_Vl_Impressao = rblVolImpressao.SelectedValue;
            produto.Orca_Conexao = rblConexao.SelectedValue;
            produto.Orca_Frente_Verso = rblFrenteVerso.SelectedValue;

            // Copiadora
            produto.Orca_Scanner = rblScanner.SelectedValue;
            produto.Orca_Fax = rblFax.SelectedValue;
            produto.Orca_Alimentador = rblAlimentador.SelectedValue;

            ProdutoOad.OperacaoProduto(produto, "A");
            Response.Redirect("~/Administrador/ListarProduto.aspx");
        }
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Administrador/ListarProduto.aspx");
    }

    protected void ddlCategoria_SelectedIndexChanged1(object sender, EventArgs e)
    {
        string value = ddlCategoria.SelectedValue;
        switch (value)
        {
            case "1": //Impressora
                pnlImpressora.Visible = true;
                pnlCopiadora.Visible = false;
                break;
            case "2": //Copiadora
                pnlImpressora.Visible = true;
                pnlCopiadora.Visible = true;
                break;
            case "3": //Grandes Formatos
                pnlImpressora.Visible = false;
                pnlCopiadora.Visible = false;
                break;
            default: //Duplicador
                pnlImpressora.Visible = false;
                pnlCopiadora.Visible = false;
                break;
        }
    }
}
