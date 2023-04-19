using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCalculadora : Form
    {
        int contVisor;
        double valor1;
        double memAux;
        String operador;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            contVisor = 0; //Código a ser inserido!
            valor1 = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado!

            {
                txtVisor.Text += '1'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incrementamento da variável de controle de texto do visor 
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '2';
                contVisor++;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '3';
                contVisor++;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '4';
                contVisor++;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '5';
                contVisor++;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '6';
                contVisor++;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '7';
                contVisor++;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '8';
                contVisor++;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '9';
                contVisor++;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '0';
                contVisor++;
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);
                operador = "+";
                txtVisor.Clear();
                contVisor = 0;

                btnSoma.Enabled = false;
                btnSub.Enabled = false;
                btnMult.Enabled = false;
                btnDiv.Enabled = false;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);
                operador = "-";
                txtVisor.Clear();
                contVisor = 0;

                btnSoma.Enabled = false;
                btnSub.Enabled = false;
                btnMult.Enabled = false;
                btnDiv.Enabled = false;
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);
                operador = "x";
                txtVisor.Clear();
                contVisor = 0;

                btnSoma.Enabled = false;
                btnSub.Enabled = false;
                btnMult.Enabled = false;
                btnDiv.Enabled = false;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);
                operador = "/";
                txtVisor.Clear();
                contVisor = 0;

                btnSoma.Enabled = false;
                btnSub.Enabled = false;
                btnMult.Enabled = false;
                btnDiv.Enabled = false;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                memAux = Convert.ToDouble(txtVisor.Text);

                switch (operador)
                {
                    case "+":
                        valor1 += memAux;
                        txtVisor.Text = Convert.ToString(valor1);
                        valor1 = 0;
                        break;

                    case "-":
                        valor1 -= memAux;
                        txtVisor.Text = Convert.ToString(valor1);
                        valor1 = 0;
                        break;

                    case "x":
                        valor1 *= memAux;
                        txtVisor.Text = Convert.ToString(valor1);
                        valor1 = 0;
                        break;

                    case "/":
                        if (valor1 != 0 && memAux != 0)
                        {
                            valor1 = valor1 / memAux;
                            txtVisor.Text = Convert.ToString(valor1);
                            valor1 = 0;
                        }
                        else
                        {
                            MessageBox.Show("Impossível realizar divisão por 0!", "Erro de execução");
                            valor1 = 0;
                            memAux = 0;
                            txtVisor.Clear();
                        }
                        break;

                    default:
                        break;

                }

                contVisor = 0;

                btnSoma.Enabled = true;
                btnSub.Enabled = true;
                btnMult.Enabled = true;
                btnDiv.Enabled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
            valor1 = memAux = contVisor = 0;

            btnSoma.Enabled = true;
            btnSub.Enabled = true;
            btnMult.Enabled = true;
            btnDiv.Enabled = true;
        }
    }
}
