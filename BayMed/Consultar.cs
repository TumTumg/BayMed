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
    public partial class Consultar : Form
    {
        DAO conectar;
        public Consultar()
        {
            InitializeComponent();
            conectar = new DAO();

            ConfigurarGrid();//Prepara a tabela no meu Grid
            NomeColunas();//Preencher os nomes das colunas
            conectar.PreencherVetor();//Preencher os vetores com dados do BD
            AdicionarDados();//Pegar os dados do vetor e colocar no grid
        }//fim do construtor consultar

        public void NomeColunas()
        {
            dataGridView2.Columns[0].Name = "Código";
            dataGridView2.Columns[1].Name = "Nome";
            dataGridView2.Columns[2].Name = "Telefone";
            dataGridView2.Columns[3].Name = "Cidade";
            dataGridView2.Columns[4].Name = "Estado";
        }//fim do método

        public void AdicionarDados()
        {
            for (int i = 0; i < conectar.RetornarContagem(); i++)
            {
                dataGridView2.Rows.Add(conectar.codigo[i], conectar.nome[i],
                    conectar.telefone[i], conectar.cidade[i], conectar.estado[i]);
            }//fim do for
        }//fim do método

        public void ConfigurarGrid()
        {
            dataGridView2.AllowUserToAddRows = false;//Incluir Linhas
            dataGridView2.AllowUserToDeleteRows = false;//Exluir Linhas
            dataGridView2.AllowUserToResizeColumns = false;//Redimensionar Colunas
            dataGridView2.AllowUserToResizeRows = false;//Redimensionar Linhas
            dataGridView2.ColumnCount = 5;//Quantidade de colunas           
        }//fim do configurar

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do botão voltar

        private void InitializeComponent()
        {
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.voltarConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Brown;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(701, 170);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // voltarConsultar
            // 
            this.voltarConsultar.BackColor = System.Drawing.Color.IndianRed;
            this.voltarConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltarConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.voltarConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltarConsultar.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarConsultar.Location = new System.Drawing.Point(246, 247);
            this.voltarConsultar.Name = "voltarConsultar";
            this.voltarConsultar.Size = new System.Drawing.Size(233, 69);
            this.voltarConsultar.TabIndex = 19;
            this.voltarConsultar.Text = "voltar";
            this.voltarConsultar.UseVisualStyleBackColor = false;
            // 
            // Consultar
            // 
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(726, 374);
            this.Controls.Add(this.voltarConsultar);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Consultar";
            this.Text = "+";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }//fim da classe
}
