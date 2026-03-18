using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CrudEscola
{
    public class Professor
    {
        // Propriedades (Mantendo seus nomes originais)
        public string nome { get; set; }
        public string dataNascimento { get; set; }
        protected string estado { get; set; }
        protected string cidade { get; set; }
        private string usuario { get; set; }
        private string senha { get; set; }
        private string cpf { get; set; }
        private string telefone { get; set; }

        Conexao conexao = new Conexao();

        // Construtor (Mantendo os nomes dos parâmetros originais)
        public Professor(string nomeConst, string dataNascimentoConst, string estadoConst, string cidadeConst, string cpfConst, string telefoneConst, string usuarioConst, string senhaConst)
        {
            nome = nomeConst;
            dataNascimento = dataNascimentoConst;
            estado = estadoConst;
            cidade = cidadeConst;
            cpf = cpfConst;
            telefone = telefoneConst;
            usuario = usuarioConst;
            senha = senhaConst;
        }

        // Método para cadastrar o professor
        public void CadastrarProfessor()
        {
            try
            {
                // SQL original mantendo a ordem das colunas do seu banco
                string sql = "INSERT INTO professor (nome, dataNascimento, telefone, cpf, estado, cidade, usuario, senha) " +
                             "VALUES (@nome, @dataNascimento, @telefone, @cpf, @estado, @cidade, @usuario, @senha)";

                // Uso do AbrirConexao() para garantir o comando ativo
                MySqlCommand comando = new MySqlCommand(sql, conexao.AbrirConexao());

                // Parâmetros originais
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@cpf", cpf);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@cidade", cidade);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                comando.ExecuteNonQuery();
                MessageBox.Show("Professor cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Professor. Erro: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
    }
}