using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;

/// <summary>
/// Summary description for Util
/// </summary>
public class Util
{

    
    public Util()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    //
    // Metodo para retirar caracteres específicos
    //
    public static string RemoverFormatacao(string valor)
    {

        //Aqui você pode incluir os caracteres qeu deseja que sejam retirados	
        char[] trim = { '=', ' ', '\\', ';', '.', ':', ',', '+', '-', '*', '/', '(', ')' };
        int pos;
        while ((pos = valor.IndexOfAny(trim)) >= 0)
            valor = valor.Remove(pos, 1);
        return valor;

    }

    public static string FormatarCampo(string valor, string mascara)
    {
        valor = RemoverFormatacao(valor);
        StringBuilder dado = new StringBuilder();
        // remove caracteres nao numericos

        foreach (char c in valor)
        {
            if (Char.IsNumber(c))
                dado.Append(c);
        }

        int indMascara = mascara.Length;
        int indCampo = dado.Length;

        for (; indCampo > 0 && indMascara > 0; )
        {
            if (mascara[--indMascara] == '#')
                indCampo--;
        }

        StringBuilder saida = new StringBuilder();
        for (; indMascara < mascara.Length; indMascara++)
        {
            saida.Append((mascara[indMascara] == '#') ? dado[indCampo++] : mascara[indMascara]);
        }
        return saida.ToString();
    }

    public static DataTable ConvertTo<T>(IList<T> list)
    {
        DataTable table = CreateTable<T>();
        Type entityType = typeof(T);
        System.ComponentModel.PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

        foreach (T item in list)
        {
            DataRow row = table.NewRow();

            foreach (PropertyDescriptor prop in properties)
            {
                row[prop.Name] = prop.GetValue(item);
            }

            table.Rows.Add(row);
        }

        return table;
    }

    public static IList<T> ConvertTo<T>(IList<DataRow> rows)
    {
        IList<T> list = null;

        if (rows != null)
        {
            list = new List<T>();

            foreach (DataRow row in rows)
            {
                T item = CreateItem<T>(row);
                list.Add(item);
            }
        }

        return list;
    }

    public static IList<T> ConvertTo<T>(DataTable table)
    {
        if (table == null)
        {
            return null;
        }

        List<DataRow> rows = new List<DataRow>();

        foreach (DataRow row in table.Rows)
        {
            rows.Add(row);
        }

        return ConvertTo<T>(rows);
    }

    public static T CreateItem<T>(DataRow row)
    {
        T obj = default(T);
        if (row != null)
        {
            obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in row.Table.Columns)
            {
                PropertyInfo prop = obj.GetType().GetProperty(column.ColumnName);
                try
                {
                    object value = row[column.ColumnName];
                    prop.SetValue(obj, value, null);
                }
                catch
                {
                    // You can log something here
                    throw;
                }
            }
        }

        return obj;
    }

    public static DataTable CreateTable<T>()
    {
        Type entityType = typeof(T);
        DataTable table = new DataTable(entityType.Name);
        PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

        foreach (PropertyDescriptor prop in properties)
        {
            table.Columns.Add(prop.Name, prop.PropertyType);
        }

        return table;
    }

}
