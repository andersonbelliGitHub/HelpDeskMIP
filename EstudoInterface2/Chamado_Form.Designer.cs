namespace EstudoInterface2
{
    partial class Chamado_Form
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
            this.id_chamado = new System.Windows.Forms.Label();
            this.nome_chamado = new System.Windows.Forms.Label();
            this.contato_chamado = new System.Windows.Forms.Label();
            this.sla_chamado = new System.Windows.Forms.Label();
            this.dt_abertura = new System.Windows.Forms.Label();
            this.decricao_chamado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // id_chamado
            // 
            this.id_chamado.AutoSize = true;
            this.id_chamado.Location = new System.Drawing.Point(67, 32);
            this.id_chamado.Name = "id_chamado";
            this.id_chamado.Size = new System.Drawing.Size(65, 13);
            this.id_chamado.TabIndex = 0;
            this.id_chamado.Text = "id_chamado";
            // 
            // nome_chamado
            // 
            this.nome_chamado.AutoSize = true;
            this.nome_chamado.Location = new System.Drawing.Point(67, 57);
            this.nome_chamado.Name = "nome_chamado";
            this.nome_chamado.Size = new System.Drawing.Size(83, 13);
            this.nome_chamado.TabIndex = 1;
            this.nome_chamado.Text = "nome_chamado";
            // 
            // contato_chamado
            // 
            this.contato_chamado.AutoSize = true;
            this.contato_chamado.Location = new System.Drawing.Point(67, 80);
            this.contato_chamado.Name = "contato_chamado";
            this.contato_chamado.Size = new System.Drawing.Size(93, 13);
            this.contato_chamado.TabIndex = 2;
            this.contato_chamado.Text = "contato_chamado";
            // 
            // sla_chamado
            // 
            this.sla_chamado.AutoSize = true;
            this.sla_chamado.Location = new System.Drawing.Point(67, 107);
            this.sla_chamado.Name = "sla_chamado";
            this.sla_chamado.Size = new System.Drawing.Size(70, 13);
            this.sla_chamado.TabIndex = 3;
            this.sla_chamado.Text = "sla_chamado";
            // 
            // dt_abertura
            // 
            this.dt_abertura.AutoSize = true;
            this.dt_abertura.Location = new System.Drawing.Point(67, 133);
            this.dt_abertura.Name = "dt_abertura";
            this.dt_abertura.Size = new System.Drawing.Size(61, 13);
            this.dt_abertura.TabIndex = 4;
            this.dt_abertura.Text = "dt_abertura";
            // 
            // decricao_chamado
            // 
            this.decricao_chamado.Location = new System.Drawing.Point(295, 32);
            this.decricao_chamado.Name = "decricao_chamado";
            this.decricao_chamado.Size = new System.Drawing.Size(100, 96);
            this.decricao_chamado.TabIndex = 5;
            this.decricao_chamado.Text = "";
            // 
            // Chamado_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 322);
            this.Controls.Add(this.decricao_chamado);
            this.Controls.Add(this.dt_abertura);
            this.Controls.Add(this.sla_chamado);
            this.Controls.Add(this.contato_chamado);
            this.Controls.Add(this.nome_chamado);
            this.Controls.Add(this.id_chamado);
            this.Name = "Chamado_Form";
            this.Text = "Chamado_Form";
            this.Load += new System.EventHandler(this.Chamado_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_chamado;
        private System.Windows.Forms.Label nome_chamado;
        private System.Windows.Forms.Label contato_chamado;
        private System.Windows.Forms.Label sla_chamado;
        private System.Windows.Forms.Label dt_abertura;
        private System.Windows.Forms.RichTextBox decricao_chamado;
    }
}