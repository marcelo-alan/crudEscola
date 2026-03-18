using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CrudEscola
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void AtualizarDashboard()
        {
            Conexao con = new Conexao();
            try
            {
                MySqlConnection conexaoAberta = con.AbrirConexao();
                if (conexaoAberta != null)
                {
                    // Contadores (Mantendo os nomes dos seus labels)
                    lblTotalAlunos.Text = new MySqlCommand("SELECT COUNT(*) FROM aluno", conexaoAberta).ExecuteScalar().ToString();
                    lblTotalProfessores.Text = new MySqlCommand("SELECT COUNT(*) FROM professor", conexaoAberta).ExecuteScalar().ToString();
                    lblTotalTurmas.Text = new MySqlCommand("SELECT COUNT(*) FROM turma", conexaoAberta).ExecuteScalar().ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro Dashboard: " + ex.Message); }
            finally { con.FecharConexao(); }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Bem-vindo, " + sessaoSistema.nomeUsuario;
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            AtualizarDashboard();
        }

        // --- NAVEGAÇÃO SEGURA (ESCONDE/MOSTRA) ---

        private void lblAlunos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cadastroAluno tela = new cadastroAluno();
            this.Hide();           // Esconde a principal
            tela.ShowDialog();     // Abre a nova
            this.Show();           // Volta ao fechar a nova
            AtualizarDashboard();  // Atualiza números
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buscar tela = new buscar();
            this.Hide();
            tela.ShowDialog();
            this.Show();
            AtualizarDashboard();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro tela = new frmCadastro();
            this.Hide();
            tela.ShowDialog();
            this.Show();
            AtualizarDashboard();
        }

        private void lblTurma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTurma tela = new frmTurma();
            this.Hide();
            tela.ShowDialog();
            this.Show();
            AtualizarDashboard();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}