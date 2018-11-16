namespace MIPHelpDesk
{
    partial class Consultar_Chamado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar_Chamado));
            this.btn_chamado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_usuario = new System.Windows.Forms.Button();
            this.num_idChamado = new System.Windows.Forms.NumericUpDown();
            this.num_idUsuario = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_idChamado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_idUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_chamado
            // 
            this.btn_chamado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_chamado.BackgroundImage")));
            this.btn_chamado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_chamado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_chamado.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chamado.Location = new System.Drawing.Point(299, 64);
            this.btn_chamado.Name = "btn_chamado";
            this.btn_chamado.Size = new System.Drawing.Size(116, 29);
            this.btn_chamado.TabIndex = 2;
            this.btn_chamado.Text = "Consultar";
            this.btn_chamado.UseVisualStyleBackColor = true;
            this.btn_chamado.Click += new System.EventHandler(this.btn_chamado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Chamado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Digite o id do chamado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Extrabold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "OU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "do usuário ";
            // 
            // btn_usuario
            // 
            this.btn_usuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_usuario.BackgroundImage")));
            this.btn_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_usuario.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuario.Location = new System.Drawing.Point(299, 146);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.Size = new System.Drawing.Size(116, 29);
            this.btn_usuario.TabIndex = 4;
            this.btn_usuario.Text = "Consultar";
            this.btn_usuario.UseVisualStyleBackColor = true;
            this.btn_usuario.Click += new System.EventHandler(this.btn_usuario_Click);
            // 
            // num_idChamado
            // 
            this.num_idChamado.Font = new System.Drawing.Font("Open Sans", 12F);
            this.num_idChamado.Location = new System.Drawing.Point(114, 64);
            this.num_idChamado.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.num_idChamado.Name = "num_idChamado";
            this.num_idChamado.Size = new System.Drawing.Size(179, 29);
            this.num_idChamado.TabIndex = 1;
            this.num_idChamado.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_idUsuario
            // 
            this.num_idUsuario.Font = new System.Drawing.Font("Open Sans", 12F);
            this.num_idUsuario.Location = new System.Drawing.Point(114, 147);
            this.num_idUsuario.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.num_idUsuario.Name = "num_idUsuario";
            this.num_idUsuario.Size = new System.Drawing.Size(179, 29);
            this.num_idUsuario.TabIndex = 3;
            this.num_idUsuario.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Consultar_Chamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 213);
            this.Controls.Add(this.num_idUsuario);
            this.Controls.Add(this.num_idChamado);
            this.Controls.Add(this.btn_usuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_chamado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Consultar_Chamado";
            this.Text = "Consultar chamado - MIP HelpDesk";
            ((System.ComponentModel.ISupportInitialize)(this.num_idChamado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_idUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_chamado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_usuario;
        private System.Windows.Forms.NumericUpDown num_idChamado;
        private System.Windows.Forms.NumericUpDown num_idUsuario;
    }
}