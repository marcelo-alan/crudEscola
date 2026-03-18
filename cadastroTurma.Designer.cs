namespace CrudEscola
{
    partial class frmTurma
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
            this.txtNomeTurma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblTurma = new System.Windows.Forms.LinkLabel();
            this.lblAlunos = new System.Windows.Forms.LinkLabel();
            this.lblprofessor = new System.Windows.Forms.LinkLabel();
            this.lblInicio = new System.Windows.Forms.LinkLabel();
            this.bntSair = new System.Windows.Forms.Button();
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
            this.panel2.Controls.Add(this.txtNomeTurma);
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
            this.button1.Location = new System.Drawing.Point(251, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNomeTurma
            // 
            this.txtNomeTurma.Location = new System.Drawing.Point(92, 137);
            this.txtNomeTurma.Name = "txtNomeTurma";
            this.txtNomeTurma.Size = new System.Drawing.Size(397, 20);
            this.txtNomeTurma.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome da turma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cadastro turmas";
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(21, 125);
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
            this.lblTurma.Location = new System.Drawing.Point(21, 153);
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
            this.lblAlunos.Location = new System.Drawing.Point(21, 95);
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
            this.lblprofessor.Location = new System.Drawing.Point(21, 59);
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
            this.lblInicio.Location = new System.Drawing.Point(21, 23);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(32, 13);
            this.lblInicio.TabIndex = 6;
            this.lblInicio.TabStop = true;
            this.lblInicio.Text = "Inicio";
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
            // frmTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CrudEscola.Properties.Resources.Fundo_escola;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTurma";
            this.Text = "cadastroTurma";
            this.Load += new System.EventHandler(this.frmTurma_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNomeTurma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lblTurma;
        private System.Windows.Forms.LinkLabel lblAlunos;
        private System.Windows.Forms.LinkLabel lblprofessor;
        private System.Windows.Forms.LinkLabel lblInicio;
    }
}