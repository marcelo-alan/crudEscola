using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CrudEscola
{
    public partial class frmLogin : Form
    {
        Conexao conexao = new Conexao();
        string sql;
        MySqlCommand comando;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblCadastrar_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro telaCadastro = new frmCadastro();
            telaCadastro.ShowDialog();

        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                sql = "SELECT * FROM professor WHERE usuario = @usuario AND senha = @senha";
                comando = new MySqlCommand(sql, conexao.conexao);
                // responsável por ler os dados retornados do banco de dados
                MySqlDataReader reader;
                // responsável por preencher os dados retornados do banco de dados em um DataTable ou DataSet
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = comando;
                comando.Parameters.AddWithValue("@usuario", textUsuario.Text);
                comando.Parameters.AddWithValue("@senha", textSenha.Text);
                reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login realizado com sucesso!");
                    sessaoSistema.idUsuario = reader["cpf"].ToString();
                    sessaoSistema.nomeUsuario = reader["nome"].ToString();
                    reader.Close();
                    conexao.FecharConexao();
                    this.Hide();
                    frmPrincipal menuPrincipal = new frmPrincipal();
                    menuPrincipal.ShowDialog();
                    this.Dispose();

                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos. Tente novamente.");
                    conexao.FecharConexao();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar login. Erro: " + ex.Message);
                conexao.FecharConexao();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}