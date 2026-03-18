using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CrudEscola
{
    public class Conexao
    {
        // String de conexão direta
        string dados = "server=localhost; database=crudescola; user=root; password=";
        public MySqlConnection conexao = null;

        public MySqlConnection AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(dados);
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao Banco: " + ex.Message);
                return null;
            }
        }

        public void FecharConexao()
        {
            try
            {
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao fechar Banco: " + ex.Message); }
        }
    }
}