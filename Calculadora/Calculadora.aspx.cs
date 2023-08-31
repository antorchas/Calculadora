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

            double n1 = double.Parse(txtnro1.Text);
            double n2 = double.Parse(txtnro2.Text);
            double res; 


           if (rbMult.Checked == true)
            {
                res = n1 * n2;
               lblResultado.Text = Convert.ToString(res);

            }

            else if (rbDividir.Checked == true)
            {
                res = n1 / n2;
                lblResultado.Text = Convert.ToString(res);

            }


        }
        private string Calcular()
        {
           double resultado = 0;

            if (resultado < 0) lblResultado.ForeColor = Color.Red;
            else lblResultado.ForeColor = Color.DarkGreen;

            return resultado.ToString("###0.00");
        }
    }
}