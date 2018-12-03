namespace MIPHelpDesk
{
    partial class ConsultarUsuario_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarUsuario_Form));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.dados_usuario = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Acesso = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sexo = new System.Windows.Forms.TextBox();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_numDoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_senha1 = new System.Windows.Forms.TextBox();
            this.cb_acesso = new System.Windows.Forms.ComboBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_edit_usuario = new System.Windows.Forms.Button();
            this.btn_cad_usuario = new System.Windows.Forms.Button();
            this.login_user = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dados_usuario)).BeginInit();
            this.dados_usuario.Panel1.SuspendLayout();
            this.dados_usuario.Panel2.SuspendLayout();
            this.dados_usuario.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Digite o login do usuário/técnico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login usuário:";
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_consultar.BackgroundImage")));
            this.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_consultar.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(368, 57);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(116, 29);
            this.btn_consultar.TabIndex = 2;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // dados_usuario
            // 
            this.dados_usuario.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.dados_usuario.Location = new System.Drawing.Point(12, 104);
            this.dados_usuario.Name = "dados_usuario";
            this.dados_usuario.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // dados_usuario.Panel1
            // 
            this.dados_usuario.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // dados_usuario.Panel2
            // 
            this.dados_usuario.Panel2.Controls.Add(this.btn_edit_usuario);
            this.dados_usuario.Panel2.Controls.Add(this.btn_cad_usuario);
            this.dados_usuario.Size = new System.Drawing.Size(506, 358);
            this.dados_usuario.SplitterDistance = 298;
            this.dados_usuario.TabIndex = 26;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Acesso, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_sexo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_sobrenome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_telefone, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_numDoc, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_login, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_senha, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_senha1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cb_acesso, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txt_nome, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(506, 295);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Acesso
            // 
            this.Acesso.AutoSize = true;
            this.Acesso.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acesso.Location = new System.Drawing.Point(3, 256);
            this.Acesso.Name = "Acesso";
            this.Acesso.Size = new System.Drawing.Size(78, 26);
            this.Acesso.TabIndex = 28;
            this.Acesso.Text = "Acesso:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 26);
            this.label10.TabIndex = 26;
            this.label10.Text = "Confirmar Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "*Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sobrenome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sexo (M / F):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Numero documento:";
            // 
            // txt_sexo
            // 
            this.txt_sexo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sexo.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sexo.Location = new System.Drawing.Point(256, 67);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(233, 28);
            this.txt_sexo.TabIndex = 5;
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sobrenome.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sobrenome.Location = new System.Drawing.Point(256, 35);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(233, 28);
            this.txt_sobrenome.TabIndex = 4;
            // 
            // txt_telefone
            // 
            this.txt_telefone.BackColor = System.Drawing.SystemColors.Window;
            this.txt_telefone.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(256, 99);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(233, 28);
            this.txt_telefone.TabIndex = 6;
            // 
            // txt_numDoc
            // 
            this.txt_numDoc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_numDoc.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numDoc.Location = new System.Drawing.Point(256, 131);
            this.txt_numDoc.Name = "txt_numDoc";
            this.txt_numDoc.Size = new System.Drawing.Size(233, 28);
            this.txt_numDoc.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "*Login:";
            // 
            // txt_login
            // 
            this.txt_login.BackColor = System.Drawing.SystemColors.Window;
            this.txt_login.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login.Location = new System.Drawing.Point(256, 163);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(233, 28);
            this.txt_login.TabIndex = 8;
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.SystemColors.Window;
            this.txt_senha.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(256, 195);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(233, 28);
            this.txt_senha.TabIndex = 9;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 26);
            this.label8.TabIndex = 22;
            this.label8.Text = "*Senha:";
            // 
            // txt_senha1
            // 
            this.txt_senha1.BackColor = System.Drawing.SystemColors.Window;
            this.txt_senha1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha1.Location = new System.Drawing.Point(256, 227);
            this.txt_senha1.Name = "txt_senha1";
            this.txt_senha1.PasswordChar = '*';
            this.txt_senha1.Size = new System.Drawing.Size(233, 28);
            this.txt_senha1.TabIndex = 10;
            this.txt_senha1.UseSystemPasswordChar = true;
            // 
            // cb_acesso
            // 
            this.cb_acesso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_acesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_acesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cb_acesso.FormattingEnabled = true;
            this.cb_acesso.Location = new System.Drawing.Point(256, 259);
            this.cb_acesso.Name = "cb_acesso";
            this.cb_acesso.Size = new System.Drawing.Size(247, 32);
            this.cb_acesso.TabIndex = 11;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nome.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(256, 3);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(233, 28);
            this.txt_nome.TabIndex = 3;
            // 
            // btn_edit_usuario
            // 
            this.btn_edit_usuario.AutoSize = true;
            this.btn_edit_usuario.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btn_edit_usuario.Location = new System.Drawing.Point(75, 13);
            this.btn_edit_usuario.Name = "btn_edit_usuario";
            this.btn_edit_usuario.Size = new System.Drawing.Size(127, 34);
            this.btn_edit_usuario.TabIndex = 12;
            this.btn_edit_usuario.Text = "Editar";
            this.btn_edit_usuario.UseVisualStyleBackColor = true;
            this.btn_edit_usuario.Click += new System.EventHandler(this.edit_usuario_Click);
            // 
            // btn_cad_usuario
            // 
            this.btn_cad_usuario.AutoSize = true;
            this.btn_cad_usuario.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btn_cad_usuario.Location = new System.Drawing.Point(303, 13);
            this.btn_cad_usuario.Name = "btn_cad_usuario";
            this.btn_cad_usuario.Size = new System.Drawing.Size(127, 34);
            this.btn_cad_usuario.TabIndex = 13;
            this.btn_cad_usuario.Text = "Cadastrar";
            this.btn_cad_usuario.UseVisualStyleBackColor = true;
            this.btn_cad_usuario.Click += new System.EventHandler(this.cad_usuario_Click);
            // 
            // login_user
            // 
            this.login_user.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_user.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_user.Location = new System.Drawing.Point(144, 57);
            this.login_user.Name = "login_user";
            this.login_user.Size = new System.Drawing.Size(218, 28);
            this.login_user.TabIndex = 1;
            // 
            // ConsultarUsuario_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 485);
            this.Controls.Add(this.login_user);
            this.Controls.Add(this.dados_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_consultar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarUsuario_Form";
            this.Text = " Controle de Usuario";
            this.dados_usuario.Panel1.ResumeLayout(false);
            this.dados_usuario.Panel2.ResumeLayout(false);
            this.dados_usuario.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dados_usuario)).EndInit();
            this.dados_usuario.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.SplitContainer dados_usuario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sexo;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_numDoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_senha1;
        private System.Windows.Forms.Button btn_edit_usuario;
        private System.Windows.Forms.Button btn_cad_usuario;
        private System.Windows.Forms.Label Acesso;
        private System.Windows.Forms.ComboBox cb_acesso;
        private System.Windows.Forms.TextBox login_user;
    }
}