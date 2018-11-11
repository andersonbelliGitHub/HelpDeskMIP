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
    public partial class Login_Form : Form
    {
        String usuario;
        String senha;
        int contSenha=0;

        Conexao conexao = new Conexao();

        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario = textBox1.Text;
            senha = textBox2.Text;
            
            string returnConnection = conexao.LoginUser(usuario, senha);

            if(contSenha >= 4)
            {
                MessageBox.Show("Usuário bloqueado devido a diversas tentativas. \n " +
                    "Solicite desbloqueio ao seu supertior");
            }
            if ((usuario!= string.Empty) &&(senha !=string.Empty))
            {
                if (returnConnection != "")
                {
                    string returnAcess = returnConnection.Substring(0, 1);
                    int returnTamanho = returnConnection.Length;
                    returnTamanho--;
                    string returnLogin = returnConnection.Substring(1, returnTamanho);
                    Menu_Form form2 = new Menu_Form(returnLogin);
                    this.Hide();
                    form2.Show();
                }
            }
            else
            {
                lb_incorreto.Show();
                contSenha++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
