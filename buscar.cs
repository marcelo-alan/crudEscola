using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CrudEscola
{
    public partial class buscar : Form
    {
        public buscar()
        {
            InitializeComponent();
        }

        // --- BOTÃO PROCURAR (button1) ---
        private void button1_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            try
            {
                // SQL corrigido com base no seu Banco de Dados:
                // Tabela: aluno | Colunas: idAluno, nomeAluno, dataNascimento, turma
                string sql = "SELECT idAluno, nomeAluno, dataNascimento, turma FROM aluno " +
                             "WHERE nomeAluno LIKE @busca OR idAluno LIKE @busca";

                MySqlCommand cmd = new MySqlCommand(sql, con.AbrirConexao());

                // O @busca pega o que você digitar no textBox1
                cmd.Parameters.AddWithValue("@busca", "%" + textBox1.Text + "%");

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                // Joga os dados para o seu DataGridView
                dgvAlunos.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum aluno encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar: " + ex.Message);
            }
            finally
            {
                con.FecharConexao();
            }
        }

        // --- BOTÃO EXCLUIR (button2) ---
        private void button2_Click(object sender, EventArgs e)
        {
            // Verifica se tem alguma linha selecionada no grid
            if (dgvAlunos.CurrentRow != null)
            {
                // Pega o ID da primeira coluna (idAluno) e o Nome da segunda (nomeAluno)
                string id = dgvAlunos.CurrentRow.Cells["idAluno"].Value.ToString();
                string nome = dgvAlunos.CurrentRow.Cells["nomeAluno"].Value.ToString();

                DialogResult confirma = MessageBox.Show($"Deseja excluir o aluno {nome}?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirma == DialogResult.Yes)
                {
                    Conexao con = new Conexao();
                    try
                    {
                        // SQL de exclusão usando o nome correto da coluna: idAluno
                        string sql = "DELETE FROM aluno WHERE idAluno = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, con.AbrirConexao());
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Aluno excluído com sucesso!");

                        // Recarrega a busca para atualizar o grid na hora
                        button1_Click(sender, e);
                    }
                    catch (Exception ex) { MessageBox.Show("Erro ao excluir: " + ex.Message); }
                    finally { con.FecharConexao(); }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um aluno na lista para excluir.");
            }
        }

        // --- MÉTODOS MANTIDOS PARA NÃO BUGAR O DESIGNER ---
        private void button3_Click(object sender, EventArgs e)
        {
            // Espaço para o botão de Editar, se for usar depois.
            if (dgvAlunos.CurrentRow != null)
            {
                string nome = dgvAlunos.CurrentRow.Cells["nomeAluno"].Value.ToString();
                MessageBox.Show("Aluno selecionado para edição: " + nome);
            }
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mantido vazio para o Designer não dar erro.
        }

        private void buscar_Load(object sender, EventArgs e)
        {
            // Pode deixar vazio ou chamar o button1_Click(sender, e) para carregar tudo ao abrir
        }
    }
}