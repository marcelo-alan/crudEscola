using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CrudEscola
{
    public partial class frmDashboard : Form
    {
        // Criamos a variável da conexão aqui fora para usar no método todo
        Conexao conexaoObjeto = new Conexao();

        public frmDashboard()
        {
            InitializeComponent();
        }

        public void CarregarDadosDashboard()
        {
            try
            {
                // Abrindo a conexão usando o seu método AbrirConexao
                MySqlConnection conexaoAberta = conexaoObjeto.AbrirConexao();

                if (conexaoAberta != null)
                {
                    // 1. Conta Alunos
                    MySqlCommand cmdAlunos = new MySqlCommand("SELECT COUNT(*) FROM aluno", conexaoAberta);
                    lblTotalAlunos.Text = cmdAlunos.ExecuteScalar().ToString();

                    // 2. Conta Professores
                    MySqlCommand cmdProf = new MySqlCommand("SELECT COUNT(*) FROM professor", conexaoAberta);
                    lblTotalProfessores.Text = cmdProf.ExecuteScalar().ToString();

                    // 3. Conta Turmas
                    MySqlCommand cmdTurmas = new MySqlCommand("SELECT COUNT(*) FROM turma", conexaoAberta);
                    lblTotalTurmas.Text = cmdTurmas.ExecuteScalar().ToString();
                }
                else
                {
                    MessageBox.Show("Falha ao abrir conexão com o Banco de Dados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar contadores: " + ex.Message);
            }
            finally
            {
                // Fechando a conexão corretamente
                conexaoObjeto.FecharConexao();
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            CarregarDadosDashboard();
        }
    }
}