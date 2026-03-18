using CrudEscola;
using System;
using System.Windows.Forms;

namespace CrudEscola
{
    public partial class frmCadastro : Form
    {
        // Variáveis globais (Mantendo seus nomes)
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

        // Botão Cadastrar (button1)
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

            // 2. Atribuição dos valores dos campos às variáveis
            nome = textNome.Text;
            dataNascimento = textData.Text;
            telefone = textTelefone.Text;
            cidade = textCidade.Text;
            estado = textEstado.SelectedItem.ToString();
            cpf = textCpf.Text;
            usuario = textUsuario.Text;
            senha = textSenha.Text;

            // 3. Instancia a classe Professor e chama o método de cadastro
            Professor professorObjeto = new Professor(nome, dataNascimento, estado, cidade, cpf, telefone, usuario, senha);
            professorObjeto.CadastrarProfessor();

            // 4. Atualiza o Dashboard da tela principal antes de fechar
            if (this.MdiParent is frmPrincipal principal)
            {
                principal.AtualizarDashboard();
            }

            this.Close();
        }

        // Eventos de clique vazios (mantidos para não dar erro no Designer)
        private void label5_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void Cadastro_Load(object sender, EventArgs e) { }
    }
}