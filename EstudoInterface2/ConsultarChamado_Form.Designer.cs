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
            this.label3 = new System.Windows.Forms.Label();
            this.num_idChamado = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_idChamado)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_chamado
            // 
            this.btn_chamado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_chamado.BackgroundImage")));
            this.btn_chamado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_chamado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_chamado.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chamado.Location = new System.Drawing.Point(299, 82);
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
            this.label1.Location = new System.Drawing.Point(14, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Chamado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Digite o id do chamado";
            // 
            // num_idChamado
            // 
            this.num_idChamado.Font = new System.Drawing.Font("Open Sans", 12F);
            this.num_idChamado.Location = new System.Drawing.Point(114, 82);
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
            // Consultar_Chamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 150);
            this.Controls.Add(this.num_idChamado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_chamado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Consultar_Chamado";
            this.Text = "Consultar chamado - MIP HelpDesk";
            ((System.ComponentModel.ISupportInitialize)(this.num_idChamado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_chamado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_idChamado;
    }
}