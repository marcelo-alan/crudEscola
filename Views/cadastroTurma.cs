using System;
using System.Windows.Forms;

namespace CrudEscola
{
    public partial class frmTurma : Form
    {
        public frmTurma()
        {
            InitializeComponent();
        }

        // Botão Cadastrar Turma (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Validação simples para não salvar campo vazio
            if (string.IsNullOrWhiteSpace(txtNomeTurma.Text))
            {
                MessageBox.Show("Por favor, digite o nome da turma.");
                return;
            }

            try
            {
                // 2. Instancia a classe Turma com o nome digitado
                Turma novaTurma = new Turma(txtNomeTurma.Text);

                // 3. Chama o método de cadastro (Certifique-se que existe o método CadastrarTurma na classe Turma)
                novaTurma.CadastrarTurma();

                // 4. Limpa e fecha para voltar à tela Principal
                txtNomeTurma.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar turma: " + ex.Message);
            }
        }

        private void frmTurma_Load(object sender, EventArgs e)
        {
            // Pode ficar vazio ou carregar uma lista de turmas se você tiver um DataGrid aqui
        }
    }
}