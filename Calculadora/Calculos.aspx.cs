using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora
{
    public partial class Calculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox3.Text = string.Empty;
            try
            {
                if (TextBox1.Text != " " && TextBox2.Text != " ")
                {
                    int num1 = int.Parse(TextBox1.Text);
                    int num2 = int.Parse(TextBox2.Text);
                    float resultado = 0;
                    if (RadioButtonList1.SelectedItem.Value == "Sumar")
                    {
                        resultado = num1 + num2;
                        TextBox3.Text = Convert.ToString(resultado);
                    }
                    else if (RadioButtonList1.SelectedItem.Value == "Restar")
                    {
                        resultado = num1 - num2;
                        TextBox3.Text = Convert.ToString(resultado);
                    }
                    else if (RadioButtonList1.SelectedItem.Value == "Multiplicar")
                    {
                        resultado = num1 * num2;
                        TextBox3.Text = Convert.ToString(resultado);
                    }
                    else if (RadioButtonList1.SelectedItem.Value == "Dividir")
                    {
                        resultado = num1 / num2;
                        TextBox3.Text = Convert.ToString(resultado);
                    }
                }

            }
            catch
            {
                TextBox3.Text = "Debe completar los datos ";
            }




        }
    }
}