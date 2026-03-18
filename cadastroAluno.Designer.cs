namespace CrudEscola
{
    partial class cadastroAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTurma = new System.Windows.Forms.ComboBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtDataResp = new System.Windows.Forms.MaskedTextBox();
            this.txtTelResp = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeResp = new System.Windows.Forms.TextBox();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntSair = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblTurma = new System.Windows.Forms.LinkLabel();
            this.lblAlunos = new System.Windows.Forms.LinkLabel();
            this.lblprofessor = new System.Windows.Forms.LinkLabel();
            this.lblInicio = new System.Windows.Forms.LinkLabel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(26, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 51);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escola";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtTurma);
            this.panel2.Controls.Add(this.txtCPF);
            this.panel2.Controls.Add(this.txtDataResp);
            this.panel2.Controls.Add(this.txtTelResp);
            this.panel2.Controls.Add(this.txtNomeResp);
            this.panel2.Controls.Add(this.txtDataNasc);
            this.panel2.Controls.Add(this.txtNomeAluno);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(179, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 331);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(235, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTurma
            // 
            this.txtTurma.FormattingEnabled = true;
            this.txtTurma.Location = new System.Drawing.Point(438, 66);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(121, 21);
            this.txtTurma.TabIndex = 14;
            this.txtTurma.SelectedIndexChanged += new System.EventHandler(this.txtTurma_SelectedIndexChanged);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(256, 202);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 13;
            // 
            // txtDataResp
            // 
            this.txtDataResp.Location = new System.Drawing.Point(52, 251);
            this.txtDataResp.Mask = "00/00/0000";
            this.txtDataResp.Name = "txtDataResp";
            this.txtDataResp.Size = new System.Drawing.Size(80, 20);
            this.txtDataResp.TabIndex = 12;
            this.txtDataResp.ValidatingType = typeof(System.DateTime);
            // 
            // txtTelResp
            // 
            this.txtTelResp.Location = new System.Drawing.Point(52, 202);
            this.txtTelResp.Mask = "(00)00000-0000";
            this.txtTelResp.Name = "txtTelResp";
            this.txtTelResp.Size = new System.Drawing.Size(97, 20);
            this.txtTelResp.TabIndex = 11;
            // 
            // txtNomeResp
            // 
            this.txtNomeResp.Location = new System.Drawing.Point(49, 158);
            this.txtNomeResp.Name = "txtNomeResp";
            this.txtNomeResp.Size = new System.Drawing.Size(337, 20);
            this.txtNomeResp.TabIndex = 10;
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(49, 113);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(80, 20);
            this.txtDataNasc.TabIndex = 9;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(49, 66);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(337, 20);
            this.txtNomeAluno.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Data nascimento Responsavel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "CPF Responsavel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Telefone Responsavel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Turma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nome Responsavel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data Nascimento do Aluno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome do Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cadastro de alunos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.lblTurma);
            this.panel1.Controls.Add(this.lblAlunos);
            this.panel1.Controls.Add(this.lblprofessor);
            this.panel1.Controls.Add(this.lblInicio);
            this.panel1.Controls.Add(this.bntSair);
            this.panel1.Location = new System.Drawing.Point(23, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 332);
            this.panel1.TabIndex = 4;
            // 
            // bntSair
            // 
            this.bntSair.BackColor = System.Drawing.Color.Red;
            this.bntSair.ForeColor = System.Drawing.Color.White;
            this.bntSair.Location = new System.Drawing.Point(32, 238);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(51, 25);
            this.bntSair.TabIndex = 4;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(17, 131);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Buscar Aluno";
            // 
            // lblTurma
            // 
            this.lblTurma.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.lblTurma.AutoSize = true;
            this.lblTurma.LinkColor = System.Drawing.Color.Black;
            this.lblTurma.Location = new System.Drawing.Point(17, 159);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(42, 13);
            this.lblTurma.TabIndex = 9;
            this.lblTurma.TabStop = true;
            this.lblTurma.Text = "Turmas";
            // 
            // lblAlunos
            // 
            this.lblAlunos.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.LinkColor = System.Drawing.Color.Black;
            this.lblAlunos.Location = new System.Drawing.Point(17, 101);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(86, 13);
            this.lblAlunos.TabIndex = 8;
            this.lblAlunos.TabStop = true;
            this.lblAlunos.Text = "cadastrar Alunos";
            // 
            // lblprofessor
            // 
            this.lblprofessor.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.lblprofessor.AutoSize = true;
            this.lblprofessor.LinkColor = System.Drawing.Color.Black;
            this.lblprofessor.Location = new System.Drawing.Point(17, 65);
            this.lblprofessor.Name = "lblprofessor";
            this.lblprofessor.Size = new System.Drawing.Size(62, 13);
            this.lblprofessor.TabIndex = 7;
            this.lblprofessor.TabStop = true;
            this.lblprofessor.Text = "Professores";
            // 
            // lblInicio
            // 
            this.lblInicio.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.lblInicio.AutoSize = true;
            this.lblInicio.LinkColor = System.Drawing.Color.Black;
            this.lblInicio.Location = new System.Drawing.Point(17, 29);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(32, 13);
            this.lblInicio.TabIndex = 6;
            this.lblInicio.TabStop = true;
            this.lblInicio.Text = "Inicio";
            // 
            // cadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CrudEscola.Properties.Resources.Fundo_escola;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "cadastroAluno";
            this.Text = "cadastroAluno";
            this.Load += new System.EventHandler(this.cadastroAluno_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.TextBox txtNomeResp;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtTurma;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtDataResp;
        private System.Windows.Forms.MaskedTextBox txtTelResp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lblTurma;
        private System.Windows.Forms.LinkLabel lblAlunos;
        private System.Windows.Forms.LinkLabel lblprofessor;
        private System.Windows.Forms.LinkLabel lblInicio;
    }
}