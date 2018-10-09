using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EstudoInterface2
{
    class Conexao
    {
        public string returnNome { get; set; }
        public string returnId { get; set; }
        public string returnSobrenome { get; set; }
        public string returnAcesso { get; set; }
        public Boolean returnBloqueio { get; set; }


        MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=helpdesk_mip;UID=root;PASSWORD=root;SSLMode=none");

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Sem conexão ",ex.ToString());
                        break;
                    case 1046:
                        MessageBox.Show("Usuario ou senha do BD inválidos", ex.ToString());
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public string LoginUser(string login, string senha) {

            string retorno = "";
            string retornoLogin = "";

            if (this.OpenConnection() == true)
            {
                string query = "select acesso, login, senha from tbl_usuario where login = '"+login+"' && senha = '"+senha+"';";
                MySqlCommand queryLogin = new MySqlCommand(query, connection);

                MySqlDataReader autLogin = queryLogin.ExecuteReader();

                if (autLogin.HasRows) {
                    autLogin.Read();
                    retorno = autLogin["acesso"].ToString();
                    retornoLogin = autLogin["login"].ToString();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado!");
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Conexão com bando de dados falhou!");
            }
            return retorno + retornoLogin;

        }

        public string queryUser(string login)
        {
            if (this.OpenConnection() == true)
            {
                string queryUsuario = "select id_usuario,nome,sobrenome,acesso,bloqueio from tbl_usuario where login='"+login+"'";

                MySqlCommand cmd = new MySqlCommand(queryUsuario, connection);
                MySqlDataReader dadosUser = cmd.ExecuteReader();
                dadosUser.Read();
                returnId = dadosUser.GetString("id_usuario");
                returnNome = dadosUser.GetString("nome");
                returnSobrenome = dadosUser.GetString("sobrenome");
                returnAcesso = dadosUser.GetString("acesso");
                returnBloqueio = dadosUser.GetBoolean("bloqueio");

            }
            return returnId + returnNome + returnSobrenome + returnAcesso + returnBloqueio;
        }

        public string queryChamados() {
            if (this.OpenConnection() == true) {
                //string queryChamados = "";
            }

            return null;
        }

        public string insertChamados()
        {
            if (this.OpenConnection() == true)
            {
                //string queryChamados = "";
            }

            return null;
        }
    }
}
