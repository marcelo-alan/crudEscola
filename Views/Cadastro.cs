using CrudEscola;
using System;
using System.Windows.Forms;

namespace CrudEscola
{
    public partial class frmCadastro : Form
    {
        // Variáveis globais
        public string nome;
        public string dataNascimento;
        public string telefone;
        public string cidade;
        public string estado;
        public string usuario;
        public string cpf;
        public string senha;

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Validação simples de campos obrigatórios
            if (string.IsNullOrWhiteSpace(textNome.Text) || string.IsNullOrWhiteSpace(textCpf.Text))
            {
                MessageBox.Show("Nome e CPF são obrigatórios!");
                return;
            }

            if (textEstado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um estado.");
                return;
            }

            if (textCpf.Text.Length < 11)
            {
                MessageBox.Show("O CPF deve conter pelo menos 11 dígitos.");
                return;
            }

            // 2. Atribuição dos valores
            nome = textNome.Text;
            dataNascimento = textData.Text;
            telefone = textTelefone.Text;
            cidade = textCidade.Text;
            estado = textEstado.SelectedItem.ToString();
            cpf = textCpf.Text;
            usuario = textUsuario.Text;
            senha = textSenha.Text;

            // 3. Instancia a classe Professor e chama o método de cadastro
            // Certifique-se que sua classe Professor tenha o construtor nessa ordem exata
            Professor professorObjeto = new Professor(nome, dataNascimento, estado, cidade, cpf, telefone, usuario, senha);

            try
            {
                professorObjeto.CadastrarProfessor();
                MessageBox.Show("Professor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Fecha o formulário após salvar
                // O Dashboard será atualizado automaticamente quando você clicar em "Início" 
                // ou quando o formulário Principal for recarregado.
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar no banco: " + ex.Message);
            }
        }

        // Eventos de clique vazios (Mantenha se eles estiverem vinculados no Designer)
        private void label5_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void Cadastro_Load(object sender, EventArgs e) { }
    }
}