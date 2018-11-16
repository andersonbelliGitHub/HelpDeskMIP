using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIPHelpDesk
{
    public partial class Menu_Form : Form
    {
        Conexao conexao = new Conexao();
        public string conexaoUsuario { get; set; }

        public Menu_Form(string DadosUsuario)
        {
            InitializeComponent();

            conexaoUsuario = DadosUsuario;

            conexao.queryUser(DadosUsuario);

            string id = conexao.returnId.ToString();
            string nome = conexao.returnNome.ToString();
            string sobrenome = conexao.returnSobrenome.ToString();
            string acesso = conexao.returnAcesso.ToString();
            Boolean bloqueio = conexao.returnBloqueio;

            lbNome.Text = nome + " " + sobrenome;
        }

        private void sair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login_Form loginForm = new Login_Form();
            loginForm.Show();
        }

        private void alterar_perfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                tableLayoutPanel2.Visible = true;
                tableLayoutPanel1.Visible = false;
        }

        private void lista_de_chamados_Click(object sender, EventArgs e)
        {
            ListaDeChamados_Form lstChamadosForm = new ListaDeChamados_Form();
            lstChamadosForm.Show();
        }

        private void abrir_chamado_Click(object sender, EventArgs e)
        {
            AbrirChamado_Form abrirChamadoForm = new AbrirChamado_Form(conexao.returnId.ToString());
            abrirChamadoForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consultar_Chamado consultar_Chamado = new Consultar_Chamado();
            consultar_Chamado.Show();
        }
    }
}
