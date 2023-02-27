
namespace Calculator
{
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class FrmCalculator : Form
    {
        #region Variables
        int x = 0;//Eje X
        int y = 0;//Eje Y
        double valor1 = 0;
        double valor2 = 0;
        double result = 0;
        string sing = "";//Variable para obtener signo de la operacion a realizar.
        #endregion

        #region Methods

        #region Method Sum
        /// <summary>
        /// Metodo para Sumar dos Valores.
        /// </summary>
        /// <param name="valor1">Primer Valor</param>
        /// <param name="valor2">Segundo Valor</param>
        /// <returns>Retorna el Resultado de la Suma</returns>
        public double Sum(double valor1, double valor2)
        {
            return valor1 + valor2;
        }
        #endregion

        #region Method Subtrac
        /// <summary>
        /// Metodo para Restar dos Valores
        /// </summary>
        /// <param name="valor1">Primer Valor</param>
        /// <param name="valor2">Segundo Valor</param>
        /// <returns>Retorna el Reusltado de la Resta</returns>
        public double Subtrac(double valor1, double valor2)
        {
            return valor1 - valor2;
        }
        #endregion

        #region Method Multiply
        /// <summary>
        /// Metodo para Multiplicar dos Valores
        /// </summary>
        /// <param name="valor1">Primer Valor</param>
        /// <param name="valor2">Segundo Valor</param>
        /// <returns>Retorna el Resultado de la Multiplicacion</returns>
        public double Multiply(double valor1, double valor2)
        {
            return valor1 * valor2;
        }
        #endregion

        #region Method Div
        /// <summary>
        /// Metodo para Dividir dos Valores
        /// </summary>
        /// <param name="valor1">Primer Valor</param>
        /// <param name="valor2">Segundo Valor</param>
        /// <returns>Retorna el Resultado de la Division</returns>
        public double Div(double valor1, double valor2)
        {
            double result = 0;
            if (valor1 == 0 || valor2 == 0)
                MessageBox.Show("No se puede dividir entre cero");
            else
                result = valor1 / valor2;
            return result;
        }
        #endregion

        #region Method Exponential
        /// <summary>
        /// Metodo para Buscar la Potencia de un Numero
        /// </summary>
        /// <param name="valor1">Primer Valor</param>
        /// <param name="valor2">Segundo Valor</param>
        /// <returns>Retorna el Resultado de la Potencia</returns>
        public double Exponential(double valor1, double valor2)
        {
            return Math.Pow(valor1, valor2);
        }
        #endregion

        #region Method Root
        /// <summary>
        /// Metodo para Buscar la Raiz de un Numero
        /// </summary>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        /// <returns>Retorna el Resultado de la Raiz</returns>
        public double Root(double valor1, double valor2)
        {
            return Math.Pow(valor1, (1.00 / valor2));
        }
        #endregion

        #region Method Percentage
        /// <summary>
        /// Metodo para Obtener el Porciento de un Numero
        /// </summary>
        /// <param name="valor1">Primer Valor</param>
        /// <param name="valor2">Segundo Valor</param>
        /// <returns>Retorna el Resultado del Porcentaje</returns>
        public double Percentage(double valor1, double valor2)
        {
            return valor1 * (valor2 / 100);
        }
        #endregion

        #region Method Operations
        /// <summary>
        /// Metodo para Realizar las Operaciones
        /// </summary>
        /// <param name="sing">Signo de la Operacion</param>
        /// <param name="valor1">Primer Valor</param>
        /// <param name="valor2">Segundo Valor</param>
        /// <returns>Retorna el Resultado de las Operaciones</returns>
        public double Operations(string sing, double valor1, double valor2)
        {
            if (LblDisplay.Text != string.Empty)
            {
                if (sing == "+")
                    result = Sum(valor1, valor2);
                else if (sing == "-")
                    result = Subtrac(valor1, valor2);
                else if (sing == "*")
                    result = Multiply(valor1, valor2);
                else if (sing == "/")
                    result = Div(valor1, valor2);
                else if (sing == "^")
                    result = Exponential(valor1, valor2);
                else if (sing == "√")
                    result = Root(valor1, valor2);
                else if (sing == "%")
                    result = Percentage(valor1, valor2);
            }
            return result;
        }
        #endregion

        #region Method Validate Numbers Decimal
        /// <summary>
        /// Metodo para validar que sean solo numeros
        /// </summary>
        /// <param name="key">Evento KeyPress</param>
        public static void Numbersdecimal(KeyPressEventArgs key)
        {
            if (Char.IsDigit(key.KeyChar))
            {
                key.Handled = false; 
            }
            else if (Char.IsSeparator(key.KeyChar))
            {
                key.Handled = false;
            }
            else if (Char.IsControl(key.KeyChar))
            {
                key.Handled = false;
            }
            else if (key.KeyChar.ToString().Equals("."))
            {
                key.Handled = false;
            }
            else
            {
                key.Handled = true;
            }
        }
        #endregion

        #region Method MouseMove
        /// <summary>
        /// Metodo para Mover el Formulario
        /// </summary>
        /// <param name="e">Evento MouseEventArgs</param>
        public new void Move(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                y = e.Y;
                x = e.X;
            }
            else
            {
                Top += e.Y - y;
                Left += e.X - x;
            }
        }
        #endregion

        #endregion

        #region Events
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void PanelControlWindows_MouseMove(object sender, MouseEventArgs e)
        {
            Move(e);
        }

        private void LblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            Move(e);
        }

        private void PtxIcon_MouseMove(object sender, MouseEventArgs e)
        {
            Move(e);
        }

        private void TxtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numbersdecimal(e);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text != "0" && TxtDisplay.Text.Length < 15)
                TxtDisplay.Text += 0;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text != "0" && TxtDisplay.Text.Length < 15)
                TxtDisplay.Text += 1;
            else
                TxtDisplay.Text = "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text != "0" && TxtDisplay.Text.Length < 15)
                TxtDisplay.Text += 2;
            else
                TxtDisplay.Text = "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text != "0" && TxtDisplay.Text.Length < 15)
                TxtDisplay.Text += 3;
            else
                TxtDisplay.Text = "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text != "0" && TxtDisplay.Text.Length < 15)
                TxtDisplay.Text += 4;
            else
                TxtDisplay.Text = "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text != "0" && TxtDisplay.Text.Length < 15)
                TxtDisplay.Text += 5;
            else
                TxtDisplay.Text = "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text != "0" && TxtDisplay.Text.Length < 15)
                TxtDisplay.Text += 6;
            else
                TxtDisplay.Text = "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text != "0" && TxtDisplay.Text.Length < 15)
                TxtDisplay.Text += 7;
            else
                TxtDisplay.Text = "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text != "0" && TxtDisplay.Text.Length < 15)
                TxtDisplay.Text += 8;
            else
                TxtDisplay.Text = "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text != "0" && TxtDisplay.Text.Length < 15)
                TxtDisplay.Text += 9;
            else
                TxtDisplay.Text = "9";
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text.Length > 0)
                if (!TxtDisplay.Text.Contains("."))
                    TxtDisplay.Text += ".";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "0";
            LblDisplay.Text = string.Empty;
            LblSing.Text = string.Empty;
            sing = string.Empty;
            valor1 = 0;
            valor2 = 0;
            result = 0;
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text != "0" && TxtDisplay.Text.Length > 0)
                TxtDisplay.Text = TxtDisplay.Text.Remove(TxtDisplay.Text.Length - 1, 1);
            if (TxtDisplay.Text != "0" && TxtDisplay.Text.Length == 0)
                TxtDisplay.Text = "0";
        }

        private void BtnSplit_Click(object sender, EventArgs e)
        {
            if (LblDisplay.Text == string.Empty)
            {
                valor1 = Convert.ToDouble(TxtDisplay.Text);
                LblDisplay.Text = TxtDisplay.Text;
                TxtDisplay.Text = "0";
                LblSing.Text = sing = "/";
            }
            else
            {
                valor1 = Convert.ToDouble(LblDisplay.Text);
                valor2 = Convert.ToDouble(TxtDisplay.Text);
                result = Operations(sing, valor1, valor2);
                TxtDisplay.Text = "0";
                LblSing.Text = sing = "/";
                LblDisplay.Text = result.ToString();
            }

        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {

            if (LblDisplay.Text == string.Empty)
            {
                valor1 = Convert.ToDouble(TxtDisplay.Text);
                LblDisplay.Text = TxtDisplay.Text;
                TxtDisplay.Text = "0";
                LblSing.Text = sing = "*";
            }
            else
            {
                valor1 = Convert.ToDouble(LblDisplay.Text);
                valor2 = Convert.ToDouble(TxtDisplay.Text);
                result = Operations(sing, valor1, valor2);
                TxtDisplay.Text = "0";
                LblSing.Text = sing = "*";
                LblDisplay.Text = result.ToString();
            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text == "0")
            {
                TxtDisplay.Text = "-";
            }
            else
            {
                if (LblDisplay.Text == string.Empty)
                {
                    valor1 = Convert.ToDouble(TxtDisplay.Text);
                    LblDisplay.Text = TxtDisplay.Text;
                    TxtDisplay.Text = "0";
                    LblSing.Text = sing = "-";
                }
                else
                {
                    valor1 = Convert.ToDouble(LblDisplay.Text);
                    valor2 = Convert.ToDouble(TxtDisplay.Text);
                    result = Operations(sing, valor1, valor2);
                    TxtDisplay.Text = "0";
                    LblSing.Text = sing = "-";
                    LblDisplay.Text = result.ToString();
                }

            }

        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (LblDisplay.Text == string.Empty)
            {
                valor1 = Convert.ToDouble(TxtDisplay.Text);
                LblDisplay.Text = TxtDisplay.Text;
                TxtDisplay.Text = "0";
                LblSing.Text = sing = "+";
            }
            else
            {
                valor1 = Convert.ToDouble(LblDisplay.Text);
                valor2 = Convert.ToDouble(TxtDisplay.Text);
                result = Operations(sing, valor1, valor2);
                TxtDisplay.Text = "0";
                LblSing.Text = sing = "+";
                LblDisplay.Text = result.ToString();
            }

        }

        private void BtnExponent_Click(object sender, EventArgs e)
        {
            if (LblDisplay.Text == string.Empty)
            {
                valor1 = Convert.ToDouble(TxtDisplay.Text);
                LblDisplay.Text = TxtDisplay.Text;
                TxtDisplay.Text = "0";
                LblSing.Text = sing = "^";
            }
            else
            {
                valor1 = Convert.ToDouble(LblDisplay.Text);
                valor2 = Convert.ToDouble(TxtDisplay.Text);
                result = Operations(sing, valor1, valor2);
                TxtDisplay.Text = "0";
                LblSing.Text = sing = "^";
                LblDisplay.Text = result.ToString();
            }
        }

        private void BtnRoot_Click(object sender, EventArgs e)
        {
            if (LblDisplay.Text == string.Empty)
            {
                valor1 = Convert.ToDouble(TxtDisplay.Text);
                LblDisplay.Text = TxtDisplay.Text;
                TxtDisplay.Text = "0";
                LblSing.Text = sing = "√";
            }
            else
            {
                valor1 = Convert.ToDouble(LblDisplay.Text);
                valor2 = Convert.ToDouble(TxtDisplay.Text);
                result = Operations(sing, valor1, valor2);
                TxtDisplay.Text = "0";
                LblSing.Text = sing = "√";
                LblDisplay.Text = result.ToString();
            }
        }

        private void BtnPercentage_Click(object sender, EventArgs e)
        {
            if (LblDisplay.Text == string.Empty)
            {
                valor1 = Convert.ToDouble(TxtDisplay.Text);
                LblDisplay.Text = TxtDisplay.Text;
                TxtDisplay.Text = "0";
                LblSing.Text = sing = "%";
            }
            else
            {
                valor1 = Convert.ToDouble(LblDisplay.Text);
                valor2 = Convert.ToDouble(TxtDisplay.Text);
                result = Operations(sing,valor1, valor2);
                TxtDisplay.Text = "0";
                LblSing.Text = sing = "%";
                LblDisplay.Text = result.ToString();
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(LblDisplay.Text);
            valor2 = Convert.ToDouble(TxtDisplay.Text);

            result = Operations(sing, valor1, valor2);

            TxtDisplay.Text = result.ToString();
            LblDisplay.Text = string.Empty;
            LblSing.Text = string.Empty;
            sing = string.Empty;
        }
        #endregion
    }
}
