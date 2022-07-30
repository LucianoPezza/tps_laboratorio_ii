using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Mi_calculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Cierra el formulario solo si se confirma, caso contrario continua en ejecucion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Se encarga de cerrar el formulario, si se responde "si" se cierra, sino permanece en ejecucion. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?", "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            char charAux;
            double numero = 0;

            if (cbOperador.Text == "")
            {
                charAux = ' ';
                numero = Operar(txtOperando1.Text, txtOperando2.Text, charAux.ToString());
                lblResultados.Text = numero.ToString();
                lstOperaciones.Items.Add(txtOperando1.Text + "+" + txtOperando2.Text + "=" + numero.ToString());
            }
            else
            {
                numero = Operar(txtOperando1.Text, txtOperando2.Text, cbOperador.Text);
                lblResultados.Text = numero.ToString();
                lstOperaciones.Items.Add(txtOperando1.Text + cbOperador.Text + txtOperando2.Text + "=" + numero.ToString());

            }
            btnConvertirADecimal.Enabled = false;
            btnConvertirABinario.Enabled = true;
        }

        /// <summary>
        /// Funcion operar que se encarga de de llamar a la funcion calculadora para devolverla y pasarle sus parametros.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            return Calculadora.Operar(num1, num2, Convert.ToChar(operador));
        }

        /// <summary>
        /// Al persionar el boton convierte el resultado en un numero binario. Si es un valor invalido se bloquea el boton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando numero = new Operando();
            if (Convert.ToDouble(lblResultados.Text) == double.MinValue)
            {
                MessageBox.Show("Limpia la consola para continuar o haga otra operacion", "Operacion Invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnConvertirABinario.Enabled = false;
                btnConvertirADecimal.Enabled = false;
            }
            else
            {
                lblResultados.Text = numero.DecimalBinario(lblResultados.Text);
                btnConvertirABinario.Enabled = false;
                btnConvertirADecimal.Enabled = true;
            }
        }

        /// <summary>
        /// Al persionar el boton convierte un numero binario a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando numero = new Operando();

            lblResultados.Text = numero.BinarioDecimal(lblResultados.Text);
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cbOperador.Text = "";
            cbOperador.Items.Add('+');
            cbOperador.Items.Add('-');
            cbOperador.Items.Add('*');
            cbOperador.Items.Add('/');
        }

        /// <summary>
        /// Funcion que se encarga de resetear la calculadora.
        /// </summary>
        private void Limpiar()
        {
            txtOperando1.Clear();
            txtOperando2.Clear();
            cbOperador.Text = " ";
            lblResultados.Text = " ";
            lblResultados.Text = " ";
            lstOperaciones.Items.Clear();
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCalculadora_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?", "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
