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
        /*
         * LÍDER TÉCNICO no banco de dados terá "acesso=1"
         * TÉCNICO "acesso=2"
         * 
         * USUARIO "acesso=4" 
        */
        public string returnNome { get; set; }
        public string returnId { get; set; }
        public int returnIdProblema { get; set; }
        public string returnSobrenome { get; set; }
        public string returnAcesso { get; set; }
        public Boolean returnBloqueio { get; set; }
        public string returnSexo { get; set; }
        public string returnDataNasc { get; set; }
        public string returnNumDocumento { get; set; }
        public string returnEndereco { get; set; }
        public string returnTelefone { get; set; }
        public string returnProblema { get; set; }

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
                string queryUsuario = "select id_usuario,nome,sobrenome,acesso,bloqueio,sexo,data_nasc," +
                    "num_documento,endereco,telefone from tbl_usuario where login='" + login + "'";

                MySqlCommand cmd = new MySqlCommand(queryUsuario, connection);
                MySqlDataReader dadosUser = cmd.ExecuteReader();
                dadosUser.Read();
                returnId = dadosUser.GetString("id_usuario");
                returnNome = dadosUser.GetString("nome");
                returnSobrenome = dadosUser.GetString("sobrenome");
                returnAcesso = dadosUser.GetString("acesso");
                returnBloqueio = dadosUser.GetBoolean("bloqueio");
                returnSexo = dadosUser.GetString("sexo");
                returnDataNasc = dadosUser.GetString("data_nasc");
                returnNumDocumento = dadosUser.GetString("num_documento");
                returnEndereco = dadosUser.GetString("endereco");
                returnTelefone = dadosUser.GetString("telefone");

            }
            return returnId + returnNome + returnSobrenome + returnAcesso + returnBloqueio;
        }

        public string queryChamados() {
            if (this.OpenConnection() == true) {
                //string queryChamados = "";
            }

            return null;
        }

        public void insertChamados(int id_tecnico,int id_usuario,int id_problema, string descricao, string contato)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = "INSERT INTO `helpdesk_mip`.`tbl_listachamados`" +
                    "(`id_usuario_afetado`, `id_tecnico`, `id_problema`, `descricao_chamado`, `data_abertura`, `status`,`contato`)" +
                    "VALUES('" + id_usuario + "', '" + id_tecnico + "', '" + id_problema + "', '" + descricao + "', now(), 'aberto','" + contato + "');";

                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}
