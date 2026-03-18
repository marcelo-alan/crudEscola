namespace CrudEscola
{
    partial class frmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bntSair = new System.Windows.Forms.Button();
            this.lblTurma = new System.Windows.Forms.LinkLabel();
            this.lblAlunos = new System.Windows.Forms.LinkLabel();
            this.lblprofessor = new System.Windows.Forms.LinkLabel();
            this.lblInicio = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalTurmas = new System.Windows.Forms.TextBox();
            this.lblTotalAlunos = new System.Windows.Forms.TextBox();
            this.lblTotalProfessores = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.bntSair);
            this.panel1.Controls.Add(this.lblTurma);
            this.panel1.Controls.Add(this.lblAlunos);
            this.panel1.Controls.Add(this.lblprofessor);
            this.panel1.Controls.Add(this.lblInicio);
            this.panel1.Location = new System.Drawing.Point(20, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 332);
            this.panel1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(17, 131);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Buscar Aluno";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // lblTurma
            // 
            this.lblTurma.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.lblTurma.AutoSize = true;
            this.lblTurma.LinkColor = System.Drawing.Color.Black;
            this.lblTurma.Location = new System.Drawing.Point(17, 159);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(42, 13);
            this.lblTurma.TabIndex = 3;
            this.lblTurma.TabStop = true;
            this.lblTurma.Text = "Turmas";
            this.lblTurma.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTurma_LinkClicked);
            // 
            // lblAlunos
            // 
            this.lblAlunos.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.LinkColor = System.Drawing.Color.Black;
            this.lblAlunos.Location = new System.Drawing.Point(17, 101);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(86, 13);
            this.lblAlunos.TabIndex = 2;
            this.lblAlunos.TabStop = true;
            this.lblAlunos.Text = "cadastrar Alunos";
            this.lblAlunos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAlunos_LinkClicked);
            // 
            // lblprofessor
            // 
            this.lblprofessor.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.lblprofessor.AutoSize = true;
            this.lblprofessor.LinkColor = System.Drawing.Color.Black;
            this.lblprofessor.Location = new System.Drawing.Point(17, 65);
            this.lblprofessor.Name = "lblprofessor";
            this.lblprofessor.Size = new System.Drawing.Size(62, 13);
            this.lblprofessor.TabIndex = 1;
            this.lblprofessor.TabStop = true;
            this.lblprofessor.Text = "Professores";
            this.lblprofessor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lblInicio
            // 
            this.lblInicio.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.lblInicio.AutoSize = true;
            this.lblInicio.LinkColor = System.Drawing.Color.Black;
            this.lblInicio.Location = new System.Drawing.Point(17, 29);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(32, 13);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.TabStop = true;
            this.lblInicio.Text = "Inicio";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblTotalTurmas);
            this.panel2.Controls.Add(this.lblTotalAlunos);
            this.panel2.Controls.Add(this.lblTotalProfessores);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(176, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 331);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 45);
            this.label5.TabIndex = 6;
            this.label5.Text = "Geral";
            // 
            // lblTotalTurmas
            // 
            this.lblTotalTurmas.Location = new System.Drawing.Point(136, 197);
            this.lblTotalTurmas.Name = "lblTotalTurmas";
            this.lblTotalTurmas.Size = new System.Drawing.Size(107, 20);
            this.lblTotalTurmas.TabIndex = 5;
            // 
            // lblTotalAlunos
            // 
            this.lblTotalAlunos.Location = new System.Drawing.Point(132, 148);
            this.lblTotalAlunos.Name = "lblTotalAlunos";
            this.lblTotalAlunos.Size = new System.Drawing.Size(107, 20);
            this.lblTotalAlunos.TabIndex = 4;
            // 
            // lblTotalProfessores
            // 
            this.lblTotalProfessores.Location = new System.Drawing.Point(158, 98);
            this.lblTotalProfessores.Name = "lblTotalProfessores";
            this.lblTotalProfessores.Size = new System.Drawing.Size(107, 20);
            this.lblTotalProfessores.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total de turmas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total de Aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total de professore:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(607, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "label1";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(679, 32);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblData);
            this.panel3.Controls.Add(this.lblUsuario);
            this.panel3.Location = new System.Drawing.Point(23, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 51);
            this.panel3.TabIndex = 3;
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CrudEscola.Properties.Resources.Fundo_escola;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel lblTurma;
        private System.Windows.Forms.LinkLabel lblAlunos;
        private System.Windows.Forms.LinkLabel lblprofessor;
        private System.Windows.Forms.LinkLabel lblInicio;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblTotalTurmas;
        private System.Windows.Forms.TextBox lblTotalAlunos;
        private System.Windows.Forms.TextBox lblTotalProfessores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}