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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }//Método construtor

        private void Menu_Load(object sender, EventArgs e)
        {

        }//Faz o carregamento de conteúdos da minha tela

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();//Aparecer a tela cadastrar
        }//Botã Cad

        private void consultar_Click(object sender, EventArgs e)
        {
            Consultar con = new Consultar();//Conexão com o BD
            con.ShowDialog();//Mostrar a tela
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            Atualizar atu = new Atualizar();
            atu.ShowDialog();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            Excluir ex = new Excluir();
            ex.ShowDialog();
        }

        private void ranking_Click(object sender, EventArgs e)
        {
            Ranking RN = new Ranking();
            RN.ShowDialog();
        }
    } 
}
