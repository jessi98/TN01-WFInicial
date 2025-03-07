using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class FormEx8 : Form
    {
        public FormEx8()
        {
            InitializeComponent();
        }

        private void FormEx8_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado, numero1, numero2 = 0;
            bool ehValidoNum1 = double.TryParse(txtNumero1.Text, out numero1);
            bool ehValidoNum2 = double.TryParse(txtNumero2.Text, out numero2);

            if (!ehValidoNum1 || !ehValidoNum2)
            {
                MessageBox.Show("Os valores digitados não são um número!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                if (rdbSoma.Checked)
                {
                    resultado = numero1 + numero2;
                    string mensagem = $"A soma de {numero1} + {numero2} = {resultado}";
                    MessageBox.Show(mensagem, "info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rdbSubtracao.Checked)
                {
                    resultado = numero1 - numero2;
                    string mensagem = $"A subtração de {numero1} - {numero2} = {resultado}";
                    MessageBox.Show(mensagem, "info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (rdbMultiplicacao.Checked)
                {
                    resultado = numero1 * numero2;
                    string mensagem = $"A multiplicação de {numero1} x {numero2} = {resultado}";
                    MessageBox.Show(mensagem, "info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (rdbDivisao.Checked)
                {
                    if (numero2 == 0)
                    {
                        MessageBox.Show("O denominador não pode ser zero!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        resultado = numero1 / numero2;
                        string mensagem = $"A divisão de {numero1} / {numero2} = {resultado:F2}";
                        MessageBox.Show(mensagem, "info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (rdbPotenciacao.Checked)
                {
                    resultado = Math.Pow(numero1, numero2);
                    string mensagem = $"A Potência de {numero1} ^ {numero2} = {resultado}";
                    MessageBox.Show(mensagem, "info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (rdbRadiciacao.Checked)
                {
                    if (numero2 == 0)
                    {
                        resultado = 1;
                    }
                    else

                        resultado = Math.Pow(numero1, (1 / numero2));
                    string mensagem = $"A Raiz de {numero1} ^ {1/numero2} = {resultado}";
                    MessageBox.Show(mensagem, "info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você deve escolher uma operaçao!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
