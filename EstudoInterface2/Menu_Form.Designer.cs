namespace MIPHelpDesk
{
    partial class Menu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.consultar_chamado = new System.Windows.Forms.Button();
            this.controle_usuarios = new System.Windows.Forms.Button();
            this.lista_de_chamados = new System.Windows.Forms.Button();
            this.abrir_chamado = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo, ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNome
            // 
            this.lbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(155, 18);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(30, 25);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "...";
            this.lbNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.consultar_chamado);
            this.groupBox1.Controls.Add(this.controle_usuarios);
            this.groupBox1.Controls.Add(this.lista_de_chamados);
            this.groupBox1.Controls.Add(this.abrir_chamado);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 12F);
            this.groupBox1.Location = new System.Drawing.Point(7, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controle";
            // 
            // consultar_chamado
            // 
            this.consultar_chamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultar_chamado.Font = new System.Drawing.Font("Open Sans", 12F);
            this.consultar_chamado.Location = new System.Drawing.Point(270, 39);
            this.consultar_chamado.Name = "consultar_chamado";
            this.consultar_chamado.Size = new System.Drawing.Size(187, 35);
            this.consultar_chamado.TabIndex = 2;
            this.consultar_chamado.Text = "Consultar chamado";
            this.consultar_chamado.UseVisualStyleBackColor = true;
            this.consultar_chamado.Click += new System.EventHandler(this.consultar_chamado_Click);
            // 
            // controle_usuarios
            // 
            this.controle_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controle_usuarios.Font = new System.Drawing.Font("Open Sans", 12F);
            this.controle_usuarios.Location = new System.Drawing.Point(40, 77);
            this.controle_usuarios.Name = "controle_usuarios";
            this.controle_usuarios.Size = new System.Drawing.Size(187, 35);
            this.controle_usuarios.TabIndex = 1;
            this.controle_usuarios.Text = "Controle usuários";
            this.controle_usuarios.UseVisualStyleBackColor = true;
            this.controle_usuarios.Click += new System.EventHandler(this.controle_usuarios_Click);
            // 
            // lista_de_chamados
            // 
            this.lista_de_chamados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lista_de_chamados.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_de_chamados.Location = new System.Drawing.Point(40, 39);
            this.lista_de_chamados.Name = "lista_de_chamados";
            this.lista_de_chamados.Size = new System.Drawing.Size(187, 35);
            this.lista_de_chamados.TabIndex = 0;
            this.lista_de_chamados.Text = "Lista de chamados";
            this.lista_de_chamados.UseVisualStyleBackColor = true;
            this.lista_de_chamados.Click += new System.EventHandler(this.lista_de_chamados_Click);
            // 
            // abrir_chamado
            // 
            this.abrir_chamado.AutoSize = true;
            this.abrir_chamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abrir_chamado.Font = new System.Drawing.Font("Open Sans", 12F);
            this.abrir_chamado.Location = new System.Drawing.Point(270, 77);
            this.abrir_chamado.Name = "abrir_chamado";
            this.abrir_chamado.Size = new System.Drawing.Size(187, 35);
            this.abrir_chamado.TabIndex = 4;
            this.abrir_chamado.Text = "Abrir chamado";
            this.abrir_chamado.UseVisualStyleBackColor = true;
            this.abrir_chamado.Click += new System.EventHandler(this.abrir_chamado_Click);
            // 
            // sair
            // 
            this.sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sair.AutoSize = true;
            this.sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.sair.Location = new System.Drawing.Point(515, 25);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(34, 18);
            this.sair.TabIndex = 5;
            this.sair.TabStop = true;
            this.sair.Text = "Sair";
            this.sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sair_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(514, 189);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(27, 49);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(548, 195);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(601, 261);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio - MIP HelpDesk";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button consultar_chamado;
        private System.Windows.Forms.Button controle_usuarios;
        private System.Windows.Forms.Button lista_de_chamados;
        private System.Windows.Forms.Button abrir_chamado;
        private System.Windows.Forms.LinkLabel sair;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}