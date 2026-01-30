namespace RetornoAulasCSHarp
{
    partial class SCREEN
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
            this.LBL_NOME = new System.Windows.Forms.Label();
            this.TXT_NOME = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BTN_CADASTROS_STRIP = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_ALUNOS_STRIP = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_SAIR_STRIP = new System.Windows.Forms.ToolStripMenuItem();
            this.TXT_EMAIL = new System.Windows.Forms.TextBox();
            this.LBL_EMAIL = new System.Windows.Forms.Label();
            this.LBL_TELEFONE = new System.Windows.Forms.Label();
            this.TXT_TELEFONE = new System.Windows.Forms.MaskedTextBox();
            this.BTN_ATUALIZAR = new System.Windows.Forms.Button();
            this.BTN_DELETAR = new System.Windows.Forms.Button();
            this.BTN_ADICIONAR = new System.Windows.Forms.Button();
            this.BTN_IMG_ADICIONAR = new System.Windows.Forms.Button();
            this.PB_IMAGEM = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_IMG_ALTERAR = new System.Windows.Forms.Button();
            this.BTN_IMG_EXCLUIR = new System.Windows.Forms.Button();
            this.BTN_BUSCAR = new System.Windows.Forms.Button();
            this.LblLink = new System.Windows.Forms.LinkLabel();
            this.Lbl_Copyright = new System.Windows.Forms.Label();
            this.Lbl_Rodape = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMAGEM)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_NOME
            // 
            this.LBL_NOME.AutoSize = true;
            this.LBL_NOME.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NOME.Location = new System.Drawing.Point(12, 38);
            this.LBL_NOME.Name = "LBL_NOME";
            this.LBL_NOME.Size = new System.Drawing.Size(56, 24);
            this.LBL_NOME.TabIndex = 0;
            this.LBL_NOME.Text = "NOME";
            // 
            // TXT_NOME
            // 
            this.TXT_NOME.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_NOME.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_NOME.Location = new System.Drawing.Point(16, 65);
            this.TXT_NOME.Name = "TXT_NOME";
            this.TXT_NOME.Size = new System.Drawing.Size(401, 23);
            this.TXT_NOME.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_CADASTROS_STRIP,
            this.BTN_SAIR_STRIP});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // BTN_CADASTROS_STRIP
            // 
            this.BTN_CADASTROS_STRIP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_ALUNOS_STRIP});
            this.BTN_CADASTROS_STRIP.Font = new System.Drawing.Font("Rubik Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CADASTROS_STRIP.Name = "BTN_CADASTROS_STRIP";
            this.BTN_CADASTROS_STRIP.Size = new System.Drawing.Size(92, 23);
            this.BTN_CADASTROS_STRIP.Text = "CADASTROS";
            // 
            // BTN_ALUNOS_STRIP
            // 
            this.BTN_ALUNOS_STRIP.Name = "BTN_ALUNOS_STRIP";
            this.BTN_ALUNOS_STRIP.Size = new System.Drawing.Size(126, 24);
            this.BTN_ALUNOS_STRIP.Text = "ALUNOS";
            this.BTN_ALUNOS_STRIP.Click += new System.EventHandler(this.BTN_ALUNOS_STRIP_Click);
            // 
            // BTN_SAIR_STRIP
            // 
            this.BTN_SAIR_STRIP.Font = new System.Drawing.Font("Rubik Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SAIR_STRIP.Name = "BTN_SAIR_STRIP";
            this.BTN_SAIR_STRIP.Size = new System.Drawing.Size(49, 23);
            this.BTN_SAIR_STRIP.Text = "SAIR";
            this.BTN_SAIR_STRIP.Click += new System.EventHandler(this.BTN_SAIR_STRIP_Click);
            // 
            // TXT_EMAIL
            // 
            this.TXT_EMAIL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_EMAIL.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_EMAIL.Location = new System.Drawing.Point(16, 126);
            this.TXT_EMAIL.Name = "TXT_EMAIL";
            this.TXT_EMAIL.Size = new System.Drawing.Size(401, 23);
            this.TXT_EMAIL.TabIndex = 2;
            this.TXT_EMAIL.TextChanged += new System.EventHandler(this.TXT_EMAIL_TextChanged);
            // 
            // LBL_EMAIL
            // 
            this.LBL_EMAIL.AutoSize = true;
            this.LBL_EMAIL.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_EMAIL.Location = new System.Drawing.Point(12, 99);
            this.LBL_EMAIL.Name = "LBL_EMAIL";
            this.LBL_EMAIL.Size = new System.Drawing.Size(67, 24);
            this.LBL_EMAIL.TabIndex = 0;
            this.LBL_EMAIL.Text = "E-MAIL";
            this.LBL_EMAIL.Click += new System.EventHandler(this.LBL_EMAIL_Click);
            // 
            // LBL_TELEFONE
            // 
            this.LBL_TELEFONE.AutoSize = true;
            this.LBL_TELEFONE.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TELEFONE.Location = new System.Drawing.Point(12, 169);
            this.LBL_TELEFONE.Name = "LBL_TELEFONE";
            this.LBL_TELEFONE.Size = new System.Drawing.Size(93, 24);
            this.LBL_TELEFONE.TabIndex = 0;
            this.LBL_TELEFONE.Text = "TELEFONE";
            this.LBL_TELEFONE.Click += new System.EventHandler(this.LBL_EMAIL_Click);
            // 
            // TXT_TELEFONE
            // 
            this.TXT_TELEFONE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_TELEFONE.Font = new System.Drawing.Font("Rubik", 9.75F);
            this.TXT_TELEFONE.Location = new System.Drawing.Point(16, 201);
            this.TXT_TELEFONE.Name = "TXT_TELEFONE";
            this.TXT_TELEFONE.Size = new System.Drawing.Size(401, 23);
            this.TXT_TELEFONE.TabIndex = 3;
            // 
            // BTN_ATUALIZAR
            // 
            this.BTN_ATUALIZAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.BTN_ATUALIZAR.Font = new System.Drawing.Font("Rubik Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ATUALIZAR.ForeColor = System.Drawing.Color.White;
            this.BTN_ATUALIZAR.Location = new System.Drawing.Point(222, 294);
            this.BTN_ATUALIZAR.Name = "BTN_ATUALIZAR";
            this.BTN_ATUALIZAR.Size = new System.Drawing.Size(195, 34);
            this.BTN_ATUALIZAR.TabIndex = 9;
            this.BTN_ATUALIZAR.Text = "ATUALIZAR";
            this.BTN_ATUALIZAR.UseVisualStyleBackColor = false;
            this.BTN_ATUALIZAR.Click += new System.EventHandler(this.BTN_ATUALIZAR_Click);
            // 
            // BTN_DELETAR
            // 
            this.BTN_DELETAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(3)))), ((int)(((byte)(2)))));
            this.BTN_DELETAR.Font = new System.Drawing.Font("Rubik Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_DELETAR.Location = new System.Drawing.Point(16, 294);
            this.BTN_DELETAR.Name = "BTN_DELETAR";
            this.BTN_DELETAR.Size = new System.Drawing.Size(195, 34);
            this.BTN_DELETAR.TabIndex = 10;
            this.BTN_DELETAR.Text = "DELETAR";
            this.BTN_DELETAR.UseVisualStyleBackColor = false;
            this.BTN_DELETAR.Click += new System.EventHandler(this.BTN_DELETAR_Click);
            // 
            // BTN_ADICIONAR
            // 
            this.BTN_ADICIONAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(151)))), ((int)(((byte)(99)))));
            this.BTN_ADICIONAR.Font = new System.Drawing.Font("Rubik Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADICIONAR.ForeColor = System.Drawing.Color.White;
            this.BTN_ADICIONAR.Location = new System.Drawing.Point(16, 254);
            this.BTN_ADICIONAR.Name = "BTN_ADICIONAR";
            this.BTN_ADICIONAR.Size = new System.Drawing.Size(195, 34);
            this.BTN_ADICIONAR.TabIndex = 7;
            this.BTN_ADICIONAR.Text = "ADICIONAR";
            this.BTN_ADICIONAR.UseVisualStyleBackColor = false;
            this.BTN_ADICIONAR.Click += new System.EventHandler(this.BTN_ADICIONAR_Click);
            // 
            // BTN_IMG_ADICIONAR
            // 
            this.BTN_IMG_ADICIONAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_IMG_ADICIONAR.BackColor = System.Drawing.Color.Gray;
            this.BTN_IMG_ADICIONAR.Font = new System.Drawing.Font("Rubik Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTN_IMG_ADICIONAR.Location = new System.Drawing.Point(641, 65);
            this.BTN_IMG_ADICIONAR.Name = "BTN_IMG_ADICIONAR";
            this.BTN_IMG_ADICIONAR.Size = new System.Drawing.Size(177, 168);
            this.BTN_IMG_ADICIONAR.TabIndex = 4;
            this.BTN_IMG_ADICIONAR.Text = "CARREGAR IMAGEM .PNG";
            this.BTN_IMG_ADICIONAR.UseVisualStyleBackColor = false;
            this.BTN_IMG_ADICIONAR.Click += new System.EventHandler(this.BTN_IMG_ADICIONAR_Click);
            // 
            // PB_IMAGEM
            // 
            this.PB_IMAGEM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_IMAGEM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_IMAGEM.Cursor = System.Windows.Forms.Cursors.No;
            this.PB_IMAGEM.Location = new System.Drawing.Point(449, 65);
            this.PB_IMAGEM.Name = "PB_IMAGEM";
            this.PB_IMAGEM.Size = new System.Drawing.Size(177, 263);
            this.PB_IMAGEM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_IMAGEM.TabIndex = 11;
            this.PB_IMAGEM.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOTO";
            // 
            // BTN_IMG_ALTERAR
            // 
            this.BTN_IMG_ALTERAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_IMG_ALTERAR.BackColor = System.Drawing.Color.Silver;
            this.BTN_IMG_ALTERAR.Font = new System.Drawing.Font("Rubik Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTN_IMG_ALTERAR.Location = new System.Drawing.Point(641, 254);
            this.BTN_IMG_ALTERAR.Name = "BTN_IMG_ALTERAR";
            this.BTN_IMG_ALTERAR.Size = new System.Drawing.Size(80, 74);
            this.BTN_IMG_ALTERAR.TabIndex = 5;
            this.BTN_IMG_ALTERAR.Text = "ALTERAR IMAGEM";
            this.BTN_IMG_ALTERAR.UseVisualStyleBackColor = false;
            this.BTN_IMG_ALTERAR.Click += new System.EventHandler(this.BTN_IMG_ALTERAR_Click);
            // 
            // BTN_IMG_EXCLUIR
            // 
            this.BTN_IMG_EXCLUIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_IMG_EXCLUIR.BackColor = System.Drawing.Color.RosyBrown;
            this.BTN_IMG_EXCLUIR.Font = new System.Drawing.Font("Rubik Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTN_IMG_EXCLUIR.Location = new System.Drawing.Point(738, 254);
            this.BTN_IMG_EXCLUIR.Name = "BTN_IMG_EXCLUIR";
            this.BTN_IMG_EXCLUIR.Size = new System.Drawing.Size(80, 74);
            this.BTN_IMG_EXCLUIR.TabIndex = 6;
            this.BTN_IMG_EXCLUIR.Text = "EXCLUIR IMAGEM";
            this.BTN_IMG_EXCLUIR.UseVisualStyleBackColor = false;
            this.BTN_IMG_EXCLUIR.Click += new System.EventHandler(this.BTN_IMG_EXCLUIR_Click);
            // 
            // BTN_BUSCAR
            // 
            this.BTN_BUSCAR.BackColor = System.Drawing.Color.DimGray;
            this.BTN_BUSCAR.Font = new System.Drawing.Font("Rubik Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BUSCAR.ForeColor = System.Drawing.Color.White;
            this.BTN_BUSCAR.Location = new System.Drawing.Point(222, 254);
            this.BTN_BUSCAR.Name = "BTN_BUSCAR";
            this.BTN_BUSCAR.Size = new System.Drawing.Size(195, 34);
            this.BTN_BUSCAR.TabIndex = 8;
            this.BTN_BUSCAR.Text = "BUSCAR";
            this.BTN_BUSCAR.UseVisualStyleBackColor = false;
            this.BTN_BUSCAR.Click += new System.EventHandler(this.BTN_BUSCAR_Click);
            // 
            // LblLink
            // 
            this.LblLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLink.AutoSize = true;
            this.LblLink.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLink.Location = new System.Drawing.Point(774, 362);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(44, 17);
            this.LblLink.TabIndex = 11;
            this.LblLink.TabStop = true;
            this.LblLink.Text = "GitHub";
            // 
            // Lbl_Copyright
            // 
            this.Lbl_Copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Copyright.AutoSize = true;
            this.Lbl_Copyright.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Copyright.Location = new System.Drawing.Point(675, 362);
            this.Lbl_Copyright.Name = "Lbl_Copyright";
            this.Lbl_Copyright.Size = new System.Drawing.Size(96, 17);
            this.Lbl_Copyright.TabIndex = 0;
            this.Lbl_Copyright.Text = "2026 ©Gegugus ";
            // 
            // Lbl_Rodape
            // 
            this.Lbl_Rodape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Rodape.AutoSize = true;
            this.Lbl_Rodape.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Rodape.Location = new System.Drawing.Point(13, 362);
            this.Lbl_Rodape.Name = "Lbl_Rodape";
            this.Lbl_Rodape.Size = new System.Drawing.Size(130, 17);
            this.Lbl_Rodape.TabIndex = 0;
            this.Lbl_Rodape.Text = "Cadastro de Alunos v1.1";
            // 
            // SCREEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 388);
            this.Controls.Add(this.LblLink);
            this.Controls.Add(this.Lbl_Copyright);
            this.Controls.Add(this.Lbl_Rodape);
            this.Controls.Add(this.BTN_IMG_EXCLUIR);
            this.Controls.Add(this.BTN_IMG_ALTERAR);
            this.Controls.Add(this.BTN_IMG_ADICIONAR);
            this.Controls.Add(this.PB_IMAGEM);
            this.Controls.Add(this.BTN_ADICIONAR);
            this.Controls.Add(this.BTN_DELETAR);
            this.Controls.Add(this.BTN_BUSCAR);
            this.Controls.Add(this.BTN_ATUALIZAR);
            this.Controls.Add(this.TXT_TELEFONE);
            this.Controls.Add(this.TXT_EMAIL);
            this.Controls.Add(this.TXT_NOME);
            this.Controls.Add(this.LBL_TELEFONE);
            this.Controls.Add(this.LBL_EMAIL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_NOME);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SCREEN";
            this.Text = "CADASTRO ALUNOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMAGEM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_NOME;
        private System.Windows.Forms.TextBox TXT_NOME;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BTN_CADASTROS_STRIP;
        private System.Windows.Forms.ToolStripMenuItem BTN_ALUNOS_STRIP;
        private System.Windows.Forms.ToolStripMenuItem BTN_SAIR_STRIP;
        private System.Windows.Forms.TextBox TXT_EMAIL;
        private System.Windows.Forms.Label LBL_EMAIL;
        private System.Windows.Forms.Label LBL_TELEFONE;
        private System.Windows.Forms.MaskedTextBox TXT_TELEFONE;
        private System.Windows.Forms.Button BTN_ATUALIZAR;
        private System.Windows.Forms.Button BTN_DELETAR;
        private System.Windows.Forms.Button BTN_ADICIONAR;
        private System.Windows.Forms.Button BTN_IMG_ADICIONAR;
        private System.Windows.Forms.PictureBox PB_IMAGEM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_IMG_ALTERAR;
        private System.Windows.Forms.Button BTN_IMG_EXCLUIR;
        private System.Windows.Forms.Button BTN_BUSCAR;
        private System.Windows.Forms.LinkLabel LblLink;
        private System.Windows.Forms.Label Lbl_Copyright;
        private System.Windows.Forms.Label Lbl_Rodape;
    }
}

