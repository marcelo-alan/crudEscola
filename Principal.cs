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

        // Método mestre para trocar as telas no painel
        private void AbrirFormNoPainel(Form formFilho)
        {
            if (this.pnlPrincipal.Controls.Count > 0)
                this.pnlPrincipal.Controls.Clear();

            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;

            this.pnlPrincipal.Controls.Add(formFilho);
            formFilho.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Bem-vindo, " + sessaoSistema.nomeUsuario;
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // Inicia mostrando o Dashboard
            AbrirFormNoPainel(new frmDashboard());
        }

        // --- VINCULE ESTES NOMES NO ÍCONE DO RAIO (EVENTOS) NO DESIGN ---

        private void lblAlunos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abre o formulário de cadastro de alunos
            AbrirFormNoPainel(new cadastroAluno());
        }

        private void lblprofessor_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abre o formulário de cadastro (Professor)
            AbrirFormNoPainel(new frmCadastro());
        }

        private void lblTurma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abre o formulário de cadastro de turmas
            AbrirFormNoPainel(new frmTurma());
        }

        private void lblBuscar_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abre o formulário de busca
            AbrirFormNoPainel(new buscar());
        }

        private void lblInicio_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abre o formulário de inico
            AbrirFormNoPainel(new frmDashboard());
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            // Exibe uma caixa de mensagem perguntando se deseja sair
            DialogResult resultado = MessageBox.Show("Deseja realmente sair do sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Fecha toda a aplicação
                Application.Exit();
            }
        }
    }
}