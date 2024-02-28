using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BayMed
{
    public partial class Atualizar : Form
    {
        DAO conectar;
        public Atualizar()
        {
            InitializeComponent();
            conectar = new DAO();
        }//fim do construtor

        private void buscarAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = conectar.SelecionarPorCodigo(Convert.ToInt32(buscarAtualizar.Text));//Buscando o código digitado
                if (cod == -1)
                {
                    MessageBox.Show("Código digitado não existe!");
                    codigoA.Text = "";
                    nomeA.Text = "";
                    idadeA.Text = "";
                    cidade2A.Text = "";
                    estadoA.Text = "";
                    RGA.Text = "";
                    telefoneA.Text = "";
                }
                else
                {
                    //Substituir os campos
                    codigoA.Enabled = false;
                    nomeA.Text = conectar.nome[cod];
                    idadeA.Text = conectar.telefone[cod];
                    cidade2A.Text = conectar.cidade[cod];
                    estadoA.Text = conectar.estado[cod];
                    RGA.Text = conectar.RG[cod];
                    telefoneA.Text = conectar.telefone[cod];
                }//fim do else
            }
            catch (Exception erro)
            {
                MessageBox.Show("Preencha o campo com o código\n\n" + erro);
            }//fim do catch
        }

        private void Atualizar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigoA.Text != "")
                {
                    int cod  = Convert.ToInt32(codigoA.Text);
                    string nome = nomeA.Text;
                    string idade = idadeA.Text;                   
                    string cidade = cidade2A.Text;
                    string estado = estadoA.Text;
                    string RG = RGA.Text;
                    string telefone = telefoneA.Text;



                    conectar.Atualizar(cod, nome, idade ,cidade, estado, RG, telefone );

                    //Limpar os campos
                    codigoA.Text = "";
                    nomeA.Text = "";
                    idadeA.Text = "";                 
                    cidade2A.Text = "";
                    estadoA.Text = "";
                    RGA.Text = "";
                    telefoneA.Text = "";
                }
                else
                {
                    MessageBox.Show("Por favor, informe um código e clique em buscar");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }

        private void VoltarAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void codigoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeA_TextChanged(object sender, EventArgs e)
        {

        }

        private void idadeA_TextChanged(object sender, EventArgs e)
        {

        }

        private void cidade2A_TextChanged(object sender, EventArgs e)
        {

        }

        private void estadoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void RGA_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
     

        private void telefoneA_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
