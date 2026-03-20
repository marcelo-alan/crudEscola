namespace CrudEscola
{
    partial class frmDashboard
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalTurmas = new System.Windows.Forms.TextBox();
            this.lblTotalAlunos = new System.Windows.Forms.TextBox();
            this.lblTotalProfessores = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.label5);
            this.pnlPrincipal.Controls.Add(this.lblTotalTurmas);
            this.pnlPrincipal.Controls.Add(this.lblTotalAlunos);
            this.pnlPrincipal.Controls.Add(this.lblTotalProfessores);
            this.pnlPrincipal.Controls.Add(this.label4);
            this.pnlPrincipal.Controls.Add(this.label3);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Location = new System.Drawing.Point(2, 1);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(580, 349);
            this.pnlPrincipal.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 45);
            this.label5.TabIndex = 6;
            this.label5.Text = "Informações gerais";
            // 
            // lblTotalTurmas
            // 
            this.lblTotalTurmas.Location = new System.Drawing.Point(52, 266);
            this.lblTotalTurmas.Name = "lblTotalTurmas";
            this.lblTotalTurmas.Size = new System.Drawing.Size(107, 20);
            this.lblTotalTurmas.TabIndex = 5;
            // 
            // lblTotalAlunos
            // 
            this.lblTotalAlunos.Location = new System.Drawing.Point(52, 199);
            this.lblTotalAlunos.Name = "lblTotalAlunos";
            this.lblTotalAlunos.Size = new System.Drawing.Size(107, 20);
            this.lblTotalAlunos.TabIndex = 4;
            // 
            // lblTotalProfessores
            // 
            this.lblTotalProfessores.Location = new System.Drawing.Point(52, 131);
            this.lblTotalProfessores.Name = "lblTotalProfessores";
            this.lblTotalProfessores.Size = new System.Drawing.Size(107, 20);
            this.lblTotalProfessores.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total de turmas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total de Alunos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total de professores:";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 350);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblTotalTurmas;
        private System.Windows.Forms.TextBox lblTotalAlunos;
        private System.Windows.Forms.TextBox lblTotalProfessores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}