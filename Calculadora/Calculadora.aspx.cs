using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora
{
    public partial class Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private string Validar()
        {

            
            if (string.IsNullOrEmpty(txtnro1.Text.Trim()))
                return "Debe Ingresar el primer número.";
            if (string.IsNullOrEmpty(txtnro2.Text.Trim()))
                return "Debe Ingresar el segundo número.";
            if(Convert.ToDouble(txtnro2.Text) == 0 && rbDividir.Checked)
                return "No puede dividir un número por 0";
            return null;
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            string validar = Validar(); 
            if (!(string.IsNullOrEmpty(validar)))
            {
                lblResultado.ForeColor = Color.Red; 
                lblResultado.Text = validar;
            }
            else
            {
                // aca llamariamos a la funcion de calcular
                lblResultado.Text = Calcular();
               
            }

            


        }
        private string Calcular()
        {
            try
            {
                double resultado = 0;
                double n1 = Convert.ToDouble(txtnro1.Text.Replace(".", ","));
                double n2 = Convert.ToDouble(txtnro2.Text.Replace(".", ","));
                double res;

                if (rbSumar.Checked == true)
                {
                    res = n1 + n2;
                    resultado = res;

                }

                else if (rbRestar.Checked == true)
                {
                    res = n1 - n2;
                    resultado = res;

                }

                else if (rbMult.Checked == true)
                {
                    res = n1 * n2;
                    resultado = res;

                }

                else if (rbDividir.Checked == true)
                {
                    res = n1 / n2;
                    resultado = res;

                }

                if (resultado < 0) lblResultado.ForeColor = Color.Red;
                else { lblResultado.ForeColor = Color.DarkGreen; }

                return resultado.ToString("###0.00");
            }
            catch (FormatException)
            {
                lblResultado.ForeColor = Color.Red;
                return "El número ingresado no tiene el formato correcto";
            }

          
        }
    }
}