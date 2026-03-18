namespace CrudEscola
{
    partial class buscar
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bntSair = new System.Windows.Forms.Button();
            this.lblTurma = new System.Windows.Forms.LinkLabel();
            this.lblAlunos = new System.Windows.Forms.LinkLabel();
            this.lblprofessor = new System.Windows.Forms.LinkLabel();
            this.lblInicio = new System.Windows.Forms.LinkLabel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
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
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvAlunos);
            this.panel2.Location = new System.Drawing.Point(179, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 331);
            this.panel2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(421, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(503, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar";
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(24, 102);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(554, 212);
            this.dgvAlunos.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.bntSair);
            this.panel1.Controls.Add(this.lblTurma);
            this.panel1.Controls.Add(this.lblAlunos);
            this.panel1.Controls.Add(this.lblprofessor);
            this.panel1.Controls.Add(this.lblInicio);
            this.panel1.Location = new System.Drawing.Point(23, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 332);
            this.panel1.TabIndex = 4;
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
            // buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CrudEscola.Properties.Resources.Fundo_escola;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "buscar";
            this.Text = "buscar";
            this.Load += new System.EventHandler(this.buscar_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.LinkLabel lblTurma;
        private System.Windows.Forms.LinkLabel lblAlunos;
        private System.Windows.Forms.LinkLabel lblprofessor;
        private System.Windows.Forms.LinkLabel lblInicio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}