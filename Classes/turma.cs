using MySql.Data.MySqlClient;
using System;
using System.Data; // Necessário para usar o DataTable
using System.Windows.Forms;

namespace CrudEscola
{
    public class Turma
    {
        public string nomeTurma { get; set; }
        Conexao conexao = new Conexao();

        // Construtor simples
        public Turma(string nome)
        {
            nomeTurma = nome;
        }

        // Método para salvar uma nova turma no banco
        public void CadastrarTurma()
        {
            try
            {
                conexao.AbrirConexao();
                string sql = "INSERT INTO turma (nomeTurma) VALUES (@nome)";
                MySqlCommand cmd = new MySqlCommand(sql, conexao.conexao);
                cmd.Parameters.AddWithValue("@nome", nomeTurma);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Turma cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar turma: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        // MÉTODO PARA LISTAR (Este é o que o ComboBox vai usar)
        public DataTable ListarTurmas()
        {
            DataTable dt = new DataTable();
            try
            {
                conexao.AbrirConexao();
                string sql = "SELECT * FROM turma ORDER BY nomeTurma";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao.conexao);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar turmas: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
            return dt;
        }
    }
}