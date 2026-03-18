using System;
using System.Data;
using System.Windows.Forms;

namespace CrudEscola
{
    public partial class cadastroAluno : Form
    {
        public cadastroAluno()
        {
            InitializeComponent();
        }

        // Carrega as turmas no ComboBox ao abrir a tela
        private void cadastroAluno_Load(object sender, EventArgs e)
        {
            try
            {
                // Busca as turmas usando a classe Turma
                Turma metodosTurma = new Turma("");
                DataTable dt = metodosTurma.ListarTurmas();

                // Preenche o ComboBox (txtTurma)
                txtTurma.DataSource = dt;
                txtTurma.DisplayMember = "nomeTurma"; // O que o usuário vê
                txtTurma.ValueMember = "idTurma";     // O que o banco usa
                txtTurma.SelectedIndex = -1;          // Inicia vazio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar turmas: " + ex.Message);
            }
        }

        // Botão Salvar (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Instancia a classe Aluno com os dados dos campos
                Aluno novo = new Aluno(
                    txtNomeAluno.Text,
                    txtDataNasc.Text,
                    txtNomeResp.Text,
                    txtDataResp.Text,
                    txtTurma.Text,
                    txtTelResp.Text,
                    txtCPF.Text
                );

                // 2. Executa o cadastro no banco (Método da classe Aluno)
                novo.CadastrarAluno();

                // 3. Limpa os campos para o próximo uso
                LimparCampos();

                // 4. Fecha a tela de cadastro para voltar à Principal
                // Como usamos .ShowDialog() na Principal, ao fechar aqui, ela reaparece
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        // Método para limpar os campos
        private void LimparCampos()
        {
            txtNomeAluno.Clear();
            txtDataNasc.Clear();
            txtNomeResp.Clear();
            txtDataResp.Clear();
            txtTelResp.Clear();
            txtCPF.Clear();
            txtTurma.SelectedIndex = -1;
            txtNomeAluno.Focus();
        }

        private void txtTurma_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}