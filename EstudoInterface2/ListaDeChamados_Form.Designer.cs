namespace EstudoInterface2
{
    partial class ListaDeChamados_Form
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
            this.components = new System.ComponentModel.Container();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstchamados = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lstchamados)).BeginInit();
            this.SuspendLayout();
            // 
            // lstchamados
            // 
            this.lstchamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstchamados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.nome_usuario,
            this.login_usuario});
            this.lstchamados.Location = new System.Drawing.Point(61, 37);
            this.lstchamados.Name = "lstchamados";
            this.lstchamados.Size = new System.Drawing.Size(343, 150);
            this.lstchamados.TabIndex = 0;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "id";
            this.id_usuario.Name = "id_usuario";
            // 
            // nome_usuario
            // 
            this.nome_usuario.HeaderText = "Nome";
            this.nome_usuario.Name = "nome_usuario";
            // 
            // login_usuario
            // 
            this.login_usuario.HeaderText = "Login";
            this.login_usuario.Name = "login_usuario";
            // 
            // ListaDeChamados_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstchamados);
            this.Name = "ListaDeChamados_Form";
            this.Text = "ListaDeChamados_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstchamados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.DataGridView lstchamados;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn login_usuario;
    }
}