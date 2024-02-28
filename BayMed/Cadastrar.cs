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
    public partial class Cadastrar : Form
    {
        DAO bd;
        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO(); //Conectar a tela com a classe DAO
        }//fim do construtor

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void idade_TextChanged(object sender, EventArgs e)
        {

        }

        private void cidade2_TextChanged(object sender, EventArgs e)
        {

        }

        private void estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void RG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void produto_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cadastrarBotao_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(codigo.Text);
            string name = nome.Text;
            string ida = idade.Text;
            string cid = cidade2.Text;
            string est = estado.Text;
            string rg = RG.Text;          
            string tel = telefone.Text;

            bd.Inserir(cod, name, ida, cid, est, rg, tel);//Inserindo no BD

            //Limpando os campos
            codigo.Text = "";
            nome.Text = "";
            idade.Text = "";
            telefone.Text = "";
            cidade2.Text = "";
            estado.Text = "";
            RG.Text = "";
          
            telefone.Text = "";
        }//fim do botão cadastrar

        private void VoltarCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
