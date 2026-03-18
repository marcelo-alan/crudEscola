using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CrudEscola
{
    public class Aluno
    {
        // Propriedades do Aluno
        public string nomeAluno { get; set; }
        public string dataNascimento { get; set; }
        public string nomeResponsavel { get; set; }
        public string dataResponsavel { get; set; }
        public string turma { get; set; }
        public string telefoneResponsavel { get; set; }
        public string cpfResponsavel { get; set; }

        Conexao con = new Conexao();

        // Construtor: Recebe os dados da tela e preenche o objeto
        public Aluno(string nome, string dataNasc, string nomeResp, string dataResp, string turmaConst, string telResp, string cpfResp)
        {
            nomeAluno = nome;
            dataNascimento = dataNasc;
            nomeResponsavel = nomeResp;
            dataResponsavel = dataResp;
            turma = turmaConst;
            telefoneResponsavel = telResp;
            cpfResponsavel = cpfResp;
        }

        // Método para inserir no Banco de Dados
        public void CadastrarAluno()
        {
            try
            {
                // Abre e já captura a conexão para o comando
                string sql = "INSERT INTO aluno (nomeAluno, dataNascimento, nomeResponsavel, dataResponsavel, turma, telefoneResponsavel, cpfResponsavel) " +
                             "VALUES (@nome, @dataNasc, @nomeResp, @dataResp, @turma, @telResp, @cpfResp)";

                MySqlCommand cmd = new MySqlCommand(sql, con.AbrirConexao());

                // Parâmetros para evitar erros de SQL Injection
                cmd.Parameters.AddWithValue("@nome", nomeAluno);
                cmd.Parameters.AddWithValue("@dataNasc", dataNascimento);
                cmd.Parameters.AddWithValue("@nomeResp", nomeResponsavel);
                cmd.Parameters.AddWithValue("@dataResp", dataResponsavel);
                cmd.Parameters.AddWithValue("@turma", turma);
                cmd.Parameters.AddWithValue("@telResp", telefoneResponsavel);
                cmd.Parameters.AddWithValue("@cpfResp", cpfResponsavel);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Aluno: " + ex.Message);
            }
            finally
            {
                con.FecharConexao();
            }
        }
    }
}