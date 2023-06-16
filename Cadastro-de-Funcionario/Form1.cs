using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tx_resultadoIRPF.Text = "";
            tx_resultadosalario.Text = "";
            tx_avisofuncao.Text = "";
            tx_avisosalario.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if(box_funcao.Text == "Função" || tx_salario.Text == "")
            {
                tx_avisofuncao.Text = "Selecione uma função";
                tx_avisosalario.Text = "Coloque o salário";
            }
            
            else
            {
                tx_avisofuncao.Text = "";
                tx_avisosalario.Text = "";
                Funcionario f = new Funcionario(tx_matricula.Text, tx_nome.Text, box_funcao.Text, Convert.ToDouble(tx_salario.Text));
                tx_resultadosalario.Text = f.SalarioFuncionario();
                tx_resultadoIRPF.Text = f.Porcentagem();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_resultadoIRPF.Text = "";
            tx_resultadosalario.Text = "";
            tx_nome.Text = "";
            tx_matricula.Text = "";
            tx_cpf.Text = "";
            tx_salario.Text = "";
            box_funcao.Text = "Função";
            tx_avisofuncao.Text = "";
            tx_avisosalario.Text = "";
        }
    }
}
