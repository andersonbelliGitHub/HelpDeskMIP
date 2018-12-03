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
    public partial class ConsultarUsuario_Form : Form
    {
        Conexao conexao = new Conexao();

        private int id { get; set; }
        private string nome { get; set; }
        private string sobrenome { get; set; }
        private string sexo { get; set; }
        private string telefone { get; set; }
        private string num_doc { get; set; }
        private string login { get; set; }
        private string senha { get; set; }
        private string senha1 { get; set; }
        private string acesso { get; set; }
        private int cont { get; set; }
        
        public ConsultarUsuario_Form()
        {
            InitializeComponent();

            cont = 0;

            btn_edit_usuario.Visible = false;

            // Exibe as opções no dropBox
            Dictionary<string, string> acessoUsuario = new Dictionary<string, string>();

            acessoUsuario.Add("1", "1 - Administrador");
            acessoUsuario.Add("2", "2 - Técnico");
            acessoUsuario.Add("3", "3 - Usuário");

            cb_acesso.DataSource = new BindingSource(acessoUsuario, null);
            cb_acesso.DisplayMember = "Value";
            cb_acesso.ValueMember = "Key";
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            btn_edit_usuario.Visible = true;
            btn_cad_usuario.Visible = false;

            login = login_user.Text;
            conexao.queryUser(login);

            if (conexao.returnNome == "")
            {
                MessageBox.Show("Usuário não encontrado!");
            }
            else
            {
                txt_login.Text = login;
                txt_nome.Text = conexao.returnNome.ToString();
                txt_sobrenome.Text = conexao.returnSobrenome.ToString();
                txt_sexo.Text = conexao.returnSexo.ToString();
                txt_telefone.Text = conexao.returnTelefone.ToString();
                txt_numDoc.Text = conexao.returnNumDocumento.ToString();
                cb_acesso.SelectedValue = conexao.returnAcesso.ToString();
            }
        }

        private string retornaDados()
        {
            try
            {
                acesso = (cb_acesso.SelectedItem.ToString().Substring(0,1));
            }
            catch(Exception ex)
            {
                acesso = "3";
                cont++; 
            }
            
            
            nome = txt_nome.Text;
            sobrenome = txt_sobrenome.Text;
            sexo = txt_sexo.Text;
            telefone = txt_telefone.Text;
            num_doc = txt_numDoc.Text;
            login = txt_login.Text;
            senha = txt_senha.Text;
            senha1 = txt_senha1.Text;

            return nome + sobrenome + sexo + telefone + num_doc + login + senha + senha1;
        }

        private void edit_usuario_Click(object sender, EventArgs e)
        {
            retornaDados();
            if (txt_nome.Text == "" || txt_login.Text == "" || txt_senha.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatórios!");
                conexao.CloseConnection();
                retornaDados();
            }
            else
            {
                id = Convert.ToInt32(conexao.returnId);
                conexao.updateUsuario(id,nome, sobrenome, sexo, telefone, num_doc, login, senha, acesso);
                MessageBox.Show("Usuário editado com sucesso!");
                this.Close();
            }
        }

        private void cad_usuario_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "" || txt_login.Text == "" || txt_senha.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatórios!");
                conexao.CloseConnection();
                retornaDados();
            }
            else
            {
                nome = txt_nome.Text;
                sobrenome = txt_sobrenome.Text;
                sexo = txt_sexo.Text;
                telefone = txt_telefone.Text;
                num_doc = txt_numDoc.Text;
                login = txt_login.Text;
                senha = txt_senha.Text;
                if (cont == 0) {
                    acesso = (cb_acesso.SelectedItem.ToString().Substring(0, 1));
                }
                
                conexao.insertUsuario(nome, sobrenome, sexo, telefone, num_doc, login, senha, acesso);
                MessageBox.Show("Usuário cadastrado com sucesso!");
                this.Close();
            }
        }
    }
}
