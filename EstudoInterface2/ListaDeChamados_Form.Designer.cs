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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDeChamados_Form));
            this.btn_atualiza = new System.Windows.Forms.Button();
            this.dgChamados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgChamados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_atualiza
            // 
            this.btn_atualiza.Location = new System.Drawing.Point(12, 258);
            this.btn_atualiza.Name = "btn_atualiza";
            this.btn_atualiza.Size = new System.Drawing.Size(75, 23);
            this.btn_atualiza.TabIndex = 0;
            this.btn_atualiza.Text = "Atualizar";
            this.btn_atualiza.UseVisualStyleBackColor = true;
            this.btn_atualiza.Click += new System.EventHandler(this.btn_atualiza_Click);
            // 
            // dgChamados
            // 
            this.dgChamados.AccessibleRole = System.Windows.Forms.AccessibleRole.Row;
            this.dgChamados.AllowUserToAddRows = false;
            this.dgChamados.AllowUserToDeleteRows = false;
            this.dgChamados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChamados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgChamados.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChamados.Location = new System.Drawing.Point(12, 12);
            this.dgChamados.Name = "dgChamados";
            this.dgChamados.ReadOnly = true;
            this.dgChamados.Size = new System.Drawing.Size(641, 229);
            this.dgChamados.TabIndex = 1;
            this.dgChamados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChamados_CellDoubleClick);
            // 
            // ListaDeChamados_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.dgChamados);
            this.Controls.Add(this.btn_atualiza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaDeChamados_Form";
            this.Text = "Lista de chamados";
            this.Load += new System.EventHandler(this.ListaDeChamados_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgChamados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_atualiza;
        private System.Windows.Forms.DataGridView dgChamados;
    }
}