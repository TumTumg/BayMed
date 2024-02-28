using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BayMed
{
    public partial class Excluir : Form
    {
        DAO conectar;
        public Excluir()
        {
            InitializeComponent();
            conectar = new DAO();
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do campo código

        private void excluirBotao_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox1.Text != "")
                {
                    conectar.Excluir(Convert.ToInt32(maskedTextBox1.Text));
                    maskedTextBox1.Text = "";//Limpa o campo
                }
                else
                {
                    MessageBox.Show("Impossível excluir, informe um código!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }

        private void voltarExcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
