namespace RetornoAulasCSHarp
{
    partial class TB_ALUNOSCADASTRADOS
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
            this.DGV_ALUNOS = new System.Windows.Forms.DataGridView();
            this.Lbl_Rodape = new System.Windows.Forms.Label();
            this.Lbl_Copyright = new System.Windows.Forms.Label();
            this.LblLink = new System.Windows.Forms.LinkLabel();
            this.LBL_ALUNOSTABELA = new System.Windows.Forms.Label();
            this.BTN_ATUALIZAR = new System.Windows.Forms.Button();
            this.PB_IMAGEM = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ALUNOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMAGEM)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_ALUNOS
            // 
            this.DGV_ALUNOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ALUNOS.Location = new System.Drawing.Point(12, 44);
            this.DGV_ALUNOS.Name = "DGV_ALUNOS";
            this.DGV_ALUNOS.Size = new System.Drawing.Size(435, 298);
            this.DGV_ALUNOS.TabIndex = 0;
            this.DGV_ALUNOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridVisu_CellContentClick);
            // 
            // Lbl_Rodape
            // 
            this.Lbl_Rodape.AutoSize = true;
            this.Lbl_Rodape.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Rodape.Location = new System.Drawing.Point(12, 413);
            this.Lbl_Rodape.Name = "Lbl_Rodape";
            this.Lbl_Rodape.Size = new System.Drawing.Size(133, 17);
            this.Lbl_Rodape.TabIndex = 31;
            this.Lbl_Rodape.Text = "Cadastro de Alunos v1.0";
            // 
            // Lbl_Copyright
            // 
            this.Lbl_Copyright.AutoSize = true;
            this.Lbl_Copyright.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Copyright.Location = new System.Drawing.Point(528, 413);
            this.Lbl_Copyright.Name = "Lbl_Copyright";
            this.Lbl_Copyright.Size = new System.Drawing.Size(96, 17);
            this.Lbl_Copyright.TabIndex = 30;
            this.Lbl_Copyright.Text = "2026 ©Gegugus ";
            // 
            // LblLink
            // 
            this.LblLink.AutoSize = true;
            this.LblLink.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLink.Location = new System.Drawing.Point(627, 413);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(44, 17);
            this.LblLink.TabIndex = 29;
            this.LblLink.TabStop = true;
            this.LblLink.Text = "GitHub";
            // 
            // LBL_ALUNOSTABELA
            // 
            this.LBL_ALUNOSTABELA.AutoSize = true;
            this.LBL_ALUNOSTABELA.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ALUNOSTABELA.Location = new System.Drawing.Point(12, 17);
            this.LBL_ALUNOSTABELA.Name = "LBL_ALUNOSTABELA";
            this.LBL_ALUNOSTABELA.Size = new System.Drawing.Size(200, 24);
            this.LBL_ALUNOSTABELA.TabIndex = 32;
            this.LBL_ALUNOSTABELA.Text = "ALUNOS CADASTRADOS";
            // 
            // BTN_ATUALIZAR
            // 
            this.BTN_ATUALIZAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.BTN_ATUALIZAR.Font = new System.Drawing.Font("Rubik Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ATUALIZAR.ForeColor = System.Drawing.Color.White;
            this.BTN_ATUALIZAR.Location = new System.Drawing.Point(12, 361);
            this.BTN_ATUALIZAR.Name = "BTN_ATUALIZAR";
            this.BTN_ATUALIZAR.Size = new System.Drawing.Size(657, 34);
            this.BTN_ATUALIZAR.TabIndex = 33;
            this.BTN_ATUALIZAR.Text = "ATUALIZAR";
            this.BTN_ATUALIZAR.UseVisualStyleBackColor = false;
            this.BTN_ATUALIZAR.Click += new System.EventHandler(this.BTN_ATUALIZAR_Click);
            // 
            // PB_IMAGEM
            // 
            this.PB_IMAGEM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_IMAGEM.Location = new System.Drawing.Point(463, 44);
            this.PB_IMAGEM.Name = "PB_IMAGEM";
            this.PB_IMAGEM.Size = new System.Drawing.Size(206, 298);
            this.PB_IMAGEM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_IMAGEM.TabIndex = 34;
            this.PB_IMAGEM.TabStop = false;
            // 
            // TB_ALUNOSCADASTRADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 441);
            this.Controls.Add(this.PB_IMAGEM);
            this.Controls.Add(this.BTN_ATUALIZAR);
            this.Controls.Add(this.LBL_ALUNOSTABELA);
            this.Controls.Add(this.LblLink);
            this.Controls.Add(this.Lbl_Copyright);
            this.Controls.Add(this.Lbl_Rodape);
            this.Controls.Add(this.DGV_ALUNOS);
            this.Name = "TB_ALUNOSCADASTRADOS";
            this.Text = "ALUNOS CADASTRADOS";
            this.Load += new System.EventHandler(this.TB_ALUNOSCADASTRADOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ALUNOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMAGEM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_ALUNOS;
        private System.Windows.Forms.Label Lbl_Rodape;
        private System.Windows.Forms.Label Lbl_Copyright;
        private System.Windows.Forms.LinkLabel LblLink;
        private System.Windows.Forms.Label LBL_ALUNOSTABELA;
        private System.Windows.Forms.Button BTN_ATUALIZAR;
        private System.Windows.Forms.PictureBox PB_IMAGEM;
    }
}