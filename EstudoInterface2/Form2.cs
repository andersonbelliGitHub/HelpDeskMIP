using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoInterface2
{
    public partial class Form2 : Form
    {
        Conexao conexao = new Conexao();

        public Form2(string login)
        {
            InitializeComponent();

            string returnDados = conexao.queryUser(login);
            string id = conexao.returnId.ToString();
            string nome = conexao.returnNome.ToString();
            string sobrenome = conexao.returnSobrenome.ToString();
            string acesso = conexao.returnAcesso.ToString();
            Boolean bloqueio = conexao.returnBloqueio;

            lbNome.Text = nome + " " + sobrenome;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                tableLayoutPanel2.Visible = true;
                tableLayoutPanel1.Visible = false;
        }
    }
}
