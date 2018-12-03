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

            if (acesso == "2") {
                controle_usuarios.Visible = false;
            }else if(acesso == "3"){
                controle_usuarios.Visible = false;
                lista_de_chamados.Visible = false;
            }
        }

        private void sair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login_Form loginForm = new Login_Form();
            loginForm.Show();
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

        private void consultar_chamado_Click(object sender, EventArgs e)
        {
            Consultar_Chamado consultar_Chamado = new Consultar_Chamado();
            consultar_Chamado.Show();
        }

        private void controle_usuarios_Click(object sender, EventArgs e)
        {
            ConsultarUsuario_Form consultarUsuario = new ConsultarUsuario_Form();
            consultarUsuario.Show();
        }
    }
}
