using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace BayMed
{
    internal class DAO
    {
        MySqlConnection conexao;
        public string dados;
        public string sql;
        public int[] codigo;
        public string[] idade;
        public string[] nome;
        public string[] telefone;
        public string[] cidade;
        public string[] estado;
        public string[] RG; 
        public int i;
        public int contador;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=baymedti18n;Uid=root;Password=");
            try
            {
                conexao.Open();
                MessageBox.Show("Conectado com sucesso!");//Temporariamente             
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro + "\n\nAlgo deu errado!");
                conexao.Close();
            }//fim do catch
        }//fim do construtor

        public void Inserir(int codigo, string nome,string idade ,string cidade, string estado, string RG, string telefone)
        {
            dados = "('" + codigo + "','" + nome + "','" + idade + "','"+ cidade + "','" 
                    + estado + "','" + RG + "','" + telefone + "')";
            sql = " insert into pharma(codigo, nome, idade ,cidade, estado, RG, telefone) values" + dados;

            try
            {
                MySqlCommand conn = new MySqlCommand(sql, conexao);
                MessageBox.Show(conn.ExecuteNonQuery() + " dado inserido!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//fim do método

        public void PreencherVetor()
        {
            string query = "select * from pharma";

            //Instanciar os vetores
            this.codigo = new int[100];
            this.nome = new string[100];
            this.idade = new string[100];
            this.cidade = new string[100];
            this.estado = new string[100];
            this.RG = new string[100];
          
            this.telefone = new string[100];

            //Preencher com valores genéricos
            for (i = 0; i < 100; i++)
            {
                codigo[i] = 0;
                nome[i] = "";
                idade[i] = "";
                cidade[i] = "";
                estado[i] = "";
                RG[i] = "";
            
                telefone[i] = "";
            }//fim do for

            //Criar o comando de consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Listar todos os dados que estão no banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;//Utilizar novamente o contar i
            contador = 0;//Contar quantos dados eu tenho no banco
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = "" + leitura["nome"];
                idade[i] = "" + leitura["idade"];
                cidade[i] = "" + leitura["cidade"];
                estado[i] = "" + leitura["estado"];
                RG[i] = "" + leitura["RG"];
                telefone[i] = "" + leitura["Telefone"];
               
                telefone[i] = "" + leitura["telefone"];
                i++;//Mudando o contador
                contador++;//Contar quantos dados tem no banco
            }//fim do while

            //Encerrar o banco
            leitura.Close();
        }//fim do método

        public int RetornarContagem()
        {
            return contador;
        }//fim do método

        public int SelecionarPorCodigo(int cod)
        {
            PreencherVetor();

            for (int i = 0; i < RetornarContagem(); i++)
            {
                if (codigo[i] == cod)
                {
                    return i;
                }//fim do if
            }//fim do for
            return -1;//Flag = Bandeira|Sinal
        }//fim do método

        public void Atualizar(int codigo, string nome, string idade, string cidade, string estado, string RG, string telefone)
        {
            try
            {
                string query = "update pharma set nome = '" + nome + "', idade = '" + idade +
                               "', cidade = '" + cidade + "', estado = '" + estado + "', RG = '" + RG + 
                               "', produto = '" + "',telefone = '" + telefone + "'where codigo = '" +
                               codigo + "'";
                //Preeparar o comando do BD
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                MessageBox.Show(resultado + " Atualizado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Impossível Atualizar \n\n" + erro);
            }
        }//fim do atualizar

        public void Excluir(int cod)
        {
            string query = "delete from pharma where codigo = '" + cod + "'";

            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = "" + sql.ExecuteNonQuery();

            MessageBox.Show(resultado + " dado excluído");
        }//fim do excluir



    }//fim da classe
}

