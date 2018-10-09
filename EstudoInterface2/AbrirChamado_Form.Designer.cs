namespace EstudoInterface2
{
    partial class AbrirChamado_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbrirChamado_Form));
            this.abrirChamado = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_contato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.db_usuarioAfetado = new System.Windows.Forms.NumericUpDown();
            this.cb_tipoProblema = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.sair = new System.Windows.Forms.LinkLabel();
            this.lbNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_usuarioAfetado)).BeginInit();
            this.SuspendLayout();
            // 
            // abrirChamado
            // 
            this.abrirChamado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.abrirChamado.BackColor = System.Drawing.SystemColors.Desktop;
            this.abrirChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abrirChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.abrirChamado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.abrirChamado.Location = new System.Drawing.Point(105, 259);
            this.abrirChamado.Name = "abrirChamado";
            this.abrirChamado.Size = new System.Drawing.Size(308, 35);
            this.abrirChamado.TabIndex = 28;
            this.abrirChamado.Text = "Registrar";
            this.abrirChamado.UseVisualStyleBackColor = false;
            this.abrirChamado.Click += new System.EventHandler(this.abrirChamado_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(3, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 61);
            this.label5.TabIndex = 26;
            this.label5.Text = "Contato";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_contato
            // 
            this.tb_contato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_contato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_contato.Location = new System.Drawing.Point(105, 202);
            this.tb_contato.Name = "tb_contato";
            this.tb_contato.Size = new System.Drawing.Size(308, 23);
            this.tb_contato.TabIndex = 25;
            this.tb_contato.Text = "abellis456";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(3, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 61);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tipo do problema";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label.Location = new System.Drawing.Point(3, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(96, 61);
            this.label.TabIndex = 20;
            this.label.Text = "Usuario afetado";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.68468F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.31532F));
            this.tableLayoutPanel1.Controls.Add(this.cb_tipoProblema, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.db_usuarioAfetado, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_descricao, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.abrirChamado, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_contato, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 309);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // db_usuarioAfetado
            // 
            this.db_usuarioAfetado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.db_usuarioAfetado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.db_usuarioAfetado.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.db_usuarioAfetado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.db_usuarioAfetado.Location = new System.Drawing.Point(158, 14);
            this.db_usuarioAfetado.Margin = new System.Windows.Forms.Padding(56, 3, 53, 3);
            this.db_usuarioAfetado.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.db_usuarioAfetado.Name = "db_usuarioAfetado";
            this.db_usuarioAfetado.Size = new System.Drawing.Size(205, 33);
            this.db_usuarioAfetado.TabIndex = 31;
            this.db_usuarioAfetado.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cb_tipoProblema
            // 
            this.cb_tipoProblema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_tipoProblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cb_tipoProblema.FormattingEnabled = true;
            this.cb_tipoProblema.Location = new System.Drawing.Point(105, 136);
            this.cb_tipoProblema.Name = "cb_tipoProblema";
            this.cb_tipoProblema.Size = new System.Drawing.Size(308, 32);
            this.cb_tipoProblema.TabIndex = 32;
            this.cb_tipoProblema.Text = "Selecione um problema";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 61);
            this.label3.TabIndex = 22;
            this.label3.Text = "Descrição do problema";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_descricao.Location = new System.Drawing.Point(105, 64);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(308, 55);
            this.txt_descricao.TabIndex = 21;
            this.txt_descricao.Text = "Descreva brevemente o problema do usuário";
            this.txt_descricao.WordWrap = false;
            // 
            // sair
            // 
            this.sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sair.AutoSize = true;
            this.sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.sair.Location = new System.Drawing.Point(493, 9);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(34, 18);
            this.sair.TabIndex = 33;
            this.sair.TabStop = true;
            this.sair.Text = "Sair";
            this.sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNome
            // 
            this.lbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(118, 9);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(30, 25);
            this.lbNome.TabIndex = 32;
            this.lbNome.Text = "...";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Técnico:  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AbrirChamado_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 475);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AbrirChamado_Form";
            this.Text = "Abrir Chamado - MIP";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_usuarioAfetado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button abrirChamado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_contato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cb_tipoProblema;
        private System.Windows.Forms.NumericUpDown db_usuarioAfetado;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel sair;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label1;
    }
}