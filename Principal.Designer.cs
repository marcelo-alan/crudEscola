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
            this.lblBuscar = new System.Windows.Forms.LinkLabel();
            this.bntSair = new System.Windows.Forms.Button();
            this.lblTurma = new System.Windows.Forms.LinkLabel();
            this.lblAlunos = new System.Windows.Forms.LinkLabel();
            this.lblprofessor = new System.Windows.Forms.LinkLabel();
            this.lblInicio = new System.Windows.Forms.LinkLabel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBuscar);
            this.panel1.Controls.Add(this.bntSair);
            this.panel1.Controls.Add(this.lblTurma);
            this.panel1.Controls.Add(this.lblAlunos);
            this.panel1.Controls.Add(this.lblprofessor);
            this.panel1.Controls.Add(this.lblInicio);
            this.panel1.Location = new System.Drawing.Point(20, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 349);
            this.panel1.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.LinkColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(14, 148);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(88, 20);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.TabStop = true;
            this.lblBuscar.Text = "Buscar Aluno";
            this.lblBuscar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBuscar_LinkClicked_1);
            // 
            // bntSair
            // 
            this.bntSair.BackColor = System.Drawing.Color.Red;
            this.bntSair.ForeColor = System.Drawing.Color.White;
            this.bntSair.Location = new System.Drawing.Point(36, 312);
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
            this.lblTurma.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.LinkColor = System.Drawing.Color.Black;
            this.lblTurma.Location = new System.Drawing.Point(14, 176);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(52, 20);
            this.lblTurma.TabIndex = 3;
            this.lblTurma.TabStop = true;
            this.lblTurma.Text = "Turmas";
            this.lblTurma.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTurma_LinkClicked);
            // 
            // lblAlunos
            // 
            this.lblAlunos.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlunos.LinkColor = System.Drawing.Color.Black;
            this.lblAlunos.Location = new System.Drawing.Point(14, 118);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(108, 20);
            this.lblAlunos.TabIndex = 2;
            this.lblAlunos.TabStop = true;
            this.lblAlunos.Text = "cadastrar Alunos";
            this.lblAlunos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAlunos_LinkClicked);
            // 
            // lblprofessor
            // 
            this.lblprofessor.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.lblprofessor.AutoSize = true;
            this.lblprofessor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprofessor.LinkColor = System.Drawing.Color.Black;
            this.lblprofessor.Location = new System.Drawing.Point(14, 82);
            this.lblprofessor.Name = "lblprofessor";
            this.lblprofessor.Size = new System.Drawing.Size(82, 20);
            this.lblprofessor.TabIndex = 1;
            this.lblprofessor.TabStop = true;
            this.lblprofessor.Text = "Professores";
            this.lblprofessor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblprofessor_LinkClicked_1);
            // 
            // lblInicio
            // 
            this.lblInicio.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.LinkColor = System.Drawing.Color.Black;
            this.lblInicio.Location = new System.Drawing.Point(14, 46);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(40, 20);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.TabStop = true;
            this.lblInicio.Text = "Inicio";
            this.lblInicio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblInicio_LinkClicked_1);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Location = new System.Drawing.Point(193, 89);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(580, 349);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(607, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblUsuario.TabIndex = 0;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(679, 32);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 13);
            this.lblData.TabIndex = 1;
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
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.LinkLabel lblTurma;
        private System.Windows.Forms.LinkLabel lblAlunos;
        private System.Windows.Forms.LinkLabel lblprofessor;
        private System.Windows.Forms.LinkLabel lblInicio;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblBuscar;
    }
}