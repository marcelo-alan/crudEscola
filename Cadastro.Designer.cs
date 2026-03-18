namespace CrudEscola
{
    partial class frmCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textEstado = new System.Windows.Forms.ComboBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.textData = new System.Windows.Forms.MaskedTextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textSenha);
            this.panel1.Controls.Add(this.textUsuario);
            this.panel1.Controls.Add(this.textTelefone);
            this.panel1.Controls.Add(this.textEstado);
            this.panel1.Controls.Add(this.textCidade);
            this.panel1.Controls.Add(this.textCpf);
            this.panel1.Controls.Add(this.textData);
            this.panel1.Controls.Add(this.textNome);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(121, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 361);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(218, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(297, 236);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(127, 20);
            this.textSenha.TabIndex = 16;
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(43, 236);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(202, 20);
            this.textUsuario.TabIndex = 15;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(43, 280);
            this.textTelefone.Mask = "(00)00000-0000";
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(127, 20);
            this.textTelefone.TabIndex = 14;
            // 
            // textEstado
            // 
            this.textEstado.FormattingEnabled = true;
            this.textEstado.Items.AddRange(new object[] {
            "AC",
            "",
            "AL",
            "",
            "AP",
            "",
            "AM",
            "",
            "BA",
            "",
            "CE",
            "",
            "DF",
            "",
            "ES",
            "",
            "GO",
            "",
            "MA",
            "",
            "MT",
            "",
            "MS",
            "",
            "MG",
            "",
            "PA",
            "",
            "PB",
            "",
            "PR",
            "",
            "PE",
            "",
            "PI",
            "",
            "RJ",
            "",
            "RN",
            "",
            "RS",
            "",
            "RO",
            "",
            "RR",
            "",
            "SC",
            "",
            "SP",
            "",
            "SE",
            "",
            "TO"});
            this.textEstado.Location = new System.Drawing.Point(225, 182);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(127, 21);
            this.textEstado.TabIndex = 13;
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(43, 183);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(127, 20);
            this.textCidade.TabIndex = 12;
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(193, 126);
            this.textCpf.Mask = "000.000.000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(127, 20);
            this.textCpf.TabIndex = 11;
            // 
            // textData
            // 
            this.textData.Location = new System.Drawing.Point(43, 126);
            this.textData.Mask = "00/00/0000";
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(127, 20);
            this.textData.TabIndex = 10;
            this.textData.ValidatingType = typeof(System.DateTime);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(43, 74);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(245, 20);
            this.textNome.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Senha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "E-mail / Usuário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefone";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cidade";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.MaskedTextBox textCpf;
        private System.Windows.Forms.MaskedTextBox textData;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.MaskedTextBox textTelefone;
        private System.Windows.Forms.ComboBox textEstado;
        private System.Windows.Forms.Button button1;
    }
}

