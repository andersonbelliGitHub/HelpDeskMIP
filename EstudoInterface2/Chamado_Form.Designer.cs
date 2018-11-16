namespace MIPHelpDesk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chamado_Form));
            this.id_chamado = new System.Windows.Forms.Label();
            this.nome_chamado = new System.Windows.Forms.Label();
            this.sla_chamado = new System.Windows.Forms.Label();
            this.dtAbertura_chamado = new System.Windows.Forms.Label();
            this.decricao_chamado = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.contato_chamado = new System.Windows.Forms.TextBox();
            this.lb_Atualizar = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aplicar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.lb_fechado = new System.Windows.Forms.Label();
            this.solucao_chamado = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_chamado
            // 
            this.id_chamado.AutoSize = true;
            this.id_chamado.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_chamado.Location = new System.Drawing.Point(241, 0);
            this.id_chamado.Name = "id_chamado";
            this.id_chamado.Size = new System.Drawing.Size(122, 26);
            this.id_chamado.TabIndex = 0;
            this.id_chamado.Text = "id_chamado";
            // 
            // nome_chamado
            // 
            this.nome_chamado.AutoSize = true;
            this.nome_chamado.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_chamado.Location = new System.Drawing.Point(241, 41);
            this.nome_chamado.Name = "nome_chamado";
            this.nome_chamado.Size = new System.Drawing.Size(157, 26);
            this.nome_chamado.TabIndex = 1;
            this.nome_chamado.Text = "nome_chamado";
            // 
            // sla_chamado
            // 
            this.sla_chamado.AutoSize = true;
            this.sla_chamado.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sla_chamado.Location = new System.Drawing.Point(241, 121);
            this.sla_chamado.Name = "sla_chamado";
            this.sla_chamado.Size = new System.Drawing.Size(130, 26);
            this.sla_chamado.TabIndex = 3;
            this.sla_chamado.Text = "sla_chamado";
            // 
            // dtAbertura_chamado
            // 
            this.dtAbertura_chamado.AutoSize = true;
            this.dtAbertura_chamado.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAbertura_chamado.Location = new System.Drawing.Point(241, 161);
            this.dtAbertura_chamado.Name = "dtAbertura_chamado";
            this.dtAbertura_chamado.Size = new System.Drawing.Size(120, 26);
            this.dtAbertura_chamado.TabIndex = 4;
            this.dtAbertura_chamado.Text = "dt_abertura";
            // 
            // decricao_chamado
            // 
            this.decricao_chamado.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decricao_chamado.Location = new System.Drawing.Point(487, 35);
            this.decricao_chamado.Name = "decricao_chamado";
            this.decricao_chamado.ReadOnly = true;
            this.decricao_chamado.Size = new System.Drawing.Size(318, 170);
            this.decricao_chamado.TabIndex = 5;
            this.decricao_chamado.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número do chamado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data de abertura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tempo (SLA):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contato:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nome do usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descrição do chamado:";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.AutoSize = true;
            this.btn_Fechar.Font = new System.Drawing.Font("Open Sans", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_Fechar.Location = new System.Drawing.Point(411, 139);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(127, 34);
            this.btn_Fechar.TabIndex = 14;
            this.btn_Fechar.Text = "Fechar chamado";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.AutoSize = true;
            this.btn_Editar.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Location = new System.Drawing.Point(305, 50);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(94, 35);
            this.btn_Editar.TabIndex = 15;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Detalhes do chamado";
            // 
            // contato_chamado
            // 
            this.contato_chamado.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contato_chamado.Location = new System.Drawing.Point(241, 84);
            this.contato_chamado.Name = "contato_chamado";
            this.contato_chamado.ReadOnly = true;
            this.contato_chamado.Size = new System.Drawing.Size(233, 28);
            this.contato_chamado.TabIndex = 17;
            // 
            // lb_Atualizar
            // 
            this.lb_Atualizar.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Atualizar.Location = new System.Drawing.Point(305, 96);
            this.lb_Atualizar.Name = "lb_Atualizar";
            this.lb_Atualizar.Size = new System.Drawing.Size(233, 35);
            this.lb_Atualizar.TabIndex = 18;
            this.lb_Atualizar.Text = "Você está em modo de edição de texto. Edite os campos contato e descrição.";
            this.lb_Atualizar.Visible = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(423, 57);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(80, 23);
            this.btn_Cancelar.TabIndex = 19;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Visible = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aplicar
            // 
            this.btn_Aplicar.AutoSize = true;
            this.btn_Aplicar.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aplicar.Location = new System.Drawing.Point(309, 50);
            this.btn_Aplicar.Name = "btn_Aplicar";
            this.btn_Aplicar.Size = new System.Drawing.Size(94, 35);
            this.btn_Aplicar.TabIndex = 20;
            this.btn_Aplicar.Text = "Aplicar";
            this.btn_Aplicar.UseVisualStyleBackColor = true;
            this.btn_Aplicar.Visible = false;
            this.btn_Aplicar.Click += new System.EventHandler(this.btn_Aplicar_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.AutoSize = true;
            this.btn_Atualizar.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atualizar.Location = new System.Drawing.Point(305, 139);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(94, 35);
            this.btn_Atualizar.TabIndex = 21;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Visible = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // lb_fechado
            // 
            this.lb_fechado.AutoSize = true;
            this.lb_fechado.Font = new System.Drawing.Font("Open Sans Extrabold", 16F, System.Drawing.FontStyle.Bold);
            this.lb_fechado.Location = new System.Drawing.Point(304, 11);
            this.lb_fechado.Name = "lb_fechado";
            this.lb_fechado.Size = new System.Drawing.Size(224, 30);
            this.lb_fechado.TabIndex = 22;
            this.lb_fechado.Text = "Chamado fechado!";
            this.lb_fechado.Visible = false;
            // 
            // solucao_chamado
            // 
            this.solucao_chamado.BackColor = System.Drawing.SystemColors.Control;
            this.solucao_chamado.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solucao_chamado.Location = new System.Drawing.Point(13, 48);
            this.solucao_chamado.Name = "solucao_chamado";
            this.solucao_chamado.Size = new System.Drawing.Size(273, 134);
            this.solucao_chamado.TabIndex = 23;
            this.solucao_chamado.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(13, 38);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.decricao_chamado);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.solucao_chamado);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Fechar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Editar);
            this.splitContainer1.Panel2.Controls.Add(this.lb_fechado);
            this.splitContainer1.Panel2.Controls.Add(this.lb_Atualizar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Atualizar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Cancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Aplicar);
            this.splitContainer1.Size = new System.Drawing.Size(819, 405);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.id_chamado, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nome_chamado, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.contato_chamado, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtAbertura_chamado, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.sla_chamado, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 205);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Solução:";
            // 
            // Chamado_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(844, 451);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Chamado_Form";
            this.Text = "Detalhes do chamado";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_chamado;
        private System.Windows.Forms.Label nome_chamado;
        private System.Windows.Forms.Label sla_chamado;
        private System.Windows.Forms.Label dtAbertura_chamado;
        private System.Windows.Forms.RichTextBox decricao_chamado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox contato_chamado;
        private System.Windows.Forms.Label lb_Atualizar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aplicar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Label lb_fechado;
        private System.Windows.Forms.RichTextBox solucao_chamado;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}