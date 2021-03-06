﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace MIPHelpDesk
{
    class Conexao
    {
        /*
         * LÍDER TÉCNICO (administrador) no banco de dados terá "acesso=1"
         * TÉCNICO "acesso=2"
         * USUARIO "acesso=4" 
         * 
        */
        public int returnIdProblema { get; set; }
        public string returnNome { get; set; }
        public string returnId { get; set; }
        public string returnSobrenome { get; set; }
        public string returnAcesso { get; set; }
        public Boolean returnBloqueio { get; set; }
        public string returnSexo { get; set; }
        public string returnStatus { get; set; }
        public string returnDataNasc { get; set; }
        public string returnNumDocumento { get; set; }
        public string returnEndereco { get; set; }
        public string returnTelefone { get; set; }
        public string returnProblema { get; set; }
        public string returnContato { get; set; }
        public string returnDescricao { get; set; }
        public string returnDTAbertura { get; set; }
        public string returnTempoSLA { get; set; }
        public string returnIdTecnico { get; set; }
        public string returnTecnicoFechou { get; set; }
        public string returnIdUsuario { get; set; }
        public string returnSolucao { get; set; }
        public string returnDTFechamento { get; set; }

        public Conexao (){
            returnNome = "";
            returnId = "";
            returnIdProblema = 0;
            returnSobrenome = "";
            returnAcesso = "";
            returnBloqueio = false;
            returnSexo = "";
            returnStatus = "";
            returnDataNasc = "";
            returnNumDocumento = "";
            returnEndereco = "";
            returnTelefone = "";
            returnProblema = "";
            returnContato = "";
            returnDescricao = "";
            returnDTAbertura = "";
            returnTempoSLA = "";
            returnIdTecnico = "";
            returnTecnicoFechou = "";
            returnIdUsuario = "";
            returnSolucao = "";
            returnDTFechamento = "";
    }

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

        public bool CloseConnection()
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
                MessageBox.Show("Conexão com banco de dados falhou!");
            }
            return retorno + retornoLogin;

        }

        public string queryUser(string login)
        {
            if (this.OpenConnection() == true)
            {
                limpaValores();
                string queryUsuario = "select id_usuario,nome,sobrenome,sexo,num_documento,telefone,acesso,bloqueio" +
                    " from tbl_usuario where login='" + login + "'";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(queryUsuario, connection);
                    MySqlDataReader dadosUser = cmd.ExecuteReader();
                    dadosUser.Read();
                    returnId = dadosUser.GetString("id_usuario");
                    returnNome = dadosUser.GetString("nome");
                    returnSobrenome = dadosUser.GetString("sobrenome");
                    returnSexo = dadosUser.GetString("sexo");
                    returnNumDocumento = dadosUser.GetString("num_documento");
                    returnTelefone = dadosUser.GetString("telefone");
                    returnAcesso = dadosUser.GetString("acesso");
                    returnBloqueio = dadosUser.GetBoolean("bloqueio");
                    CloseConnection();
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("Erro ao consultar usuário. \n Digite um LOGIN válido");
                    CloseConnection();
                }
            }
            return returnId + returnNome + returnSobrenome + returnAcesso + returnBloqueio;
        }

        public string queryChamado(int idChamado)
        {
            if (this.OpenConnection() == true)
            {
                limpaValores();
                string queryChamado = "SELECT `Id usuario`,`Id tecnico`,`Id chamado`,`Nome`,`Contato`,`Descrição`,`Data de abertura`,`Tempo SLA`,`Status`,`solucao`,`Tecnico fechou`,`Data de fechamento`" + 
                    "FROM view_chamados where `Id chamado` = " + idChamado + ";";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(queryChamado, connection);
                    MySqlDataReader dadosChamado = cmd.ExecuteReader();
                    dadosChamado.Read();

                    returnId = dadosChamado.GetString("Id chamado");
                    returnIdTecnico = dadosChamado.GetString("Id tecnico");
                    returnIdUsuario = dadosChamado.GetString("Id usuario");
                    returnNome = dadosChamado.GetString("Nome");
                    returnContato = dadosChamado.GetString("Contato");
                    returnDescricao = dadosChamado.GetString("Descrição");
                    returnDTAbertura = dadosChamado.GetString("Data de abertura");
                    returnTempoSLA = dadosChamado.GetString("Tempo SLA");
                    returnStatus = dadosChamado.GetString("Status");
                    returnSolucao = dadosChamado.GetString("Solucao");
                    returnTecnicoFechou = dadosChamado.GetString("Tecnico fechou");
                    returnDTFechamento = dadosChamado.GetString("Data de fechamento");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Chamado não encontrado!");
                    returnId = "0";
                    returnIdTecnico = "";
                    returnIdUsuario = "";
                    returnNome = "";
                    returnContato = "";
                    returnDescricao = "";
                    returnDTAbertura = "";
                    returnTempoSLA = "";
                    returnStatus = "";
                    returnSolucao = "";
                    returnTecnicoFechou = "";
                    returnDTFechamento = "";
                }

                CloseConnection();
            }
            return returnId + returnNome + returnContato + returnDescricao + returnDTAbertura + returnDTAbertura + returnTempoSLA;
        }

        public string queryUltimoChamado()
        {
            if (this.OpenConnection() == true)
            {
                string queryUltimoChamado = "SELECT `Id chamado`,`Nome`,`Contato`,`Descrição`,`Data de abertura`,`Tempo SLA` FROM view_chamados where `status` = 'aberto' order by `Id chamado` desc limit 1;";
                MySqlCommand cmd = new MySqlCommand(queryUltimoChamado, connection);
                MySqlDataReader dadosChamado = cmd.ExecuteReader();
                dadosChamado.Read();
                returnId = dadosChamado.GetString("Id chamado");
                CloseConnection();
            }
            return returnId;
        }

        public string queryUltimoUsuario()
        {
            if (this.OpenConnection() == true)
            {
                string queryUltimoUsuario = "SELECT id_usuario FROM tbl_usuario order by id_usuario desc limit 1;";
                MySqlCommand cmd = new MySqlCommand(queryUltimoUsuario, connection);
                MySqlDataReader dadosUsuario = cmd.ExecuteReader();
                dadosUsuario.Read();
                returnId = dadosUsuario.GetString("id_usuario");
                CloseConnection();
            }
            return returnId;
        }

        public DataTable queryChamados()
        {
            DataTable dtChamados = null;
            if (this.OpenConnection() == true)
            {
                string queryChamados = "SELECT `Id chamado`,`Nome`,`Contato`,`Descrição`,`Data de abertura`,`Tempo SLA` FROM view_chamados where `status` = 'aberto' order by `Id chamado` desc;";
                MySqlCommand cmd = new MySqlCommand(queryChamados, connection);

                try
                {
                    MySqlDataAdapter objAdp = new MySqlDataAdapter(cmd);
                    dtChamados = new DataTable();

                    objAdp.Fill(dtChamados);
                    CloseConnection();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ops! Algo deu errado \n\n" + ex, " Erro conhecido!");
                    CloseConnection();
                }
            }
            return dtChamados;
        }

        public void insertChamados(int id_tecnico,int id_usuario,int id_problema, 
            string descricao, string contato)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = "INSERT INTO `helpdesk_mip`.`tbl_listachamados`" +
                                        "(`id_usuario_afetado`, `id_tecnico`, `id_problema`, `descricao_chamado`, `data_abertura`, `status`,`contato`,`solucao`)" +
                                        "VALUES('" + id_usuario + "', '" + id_tecnico + "', '" + id_problema + "', '" + descricao + "', now(), 'aberto','" + contato + "', 'Chamado ainda aberto. Sem solução.');";

                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void updateChamado(int id,string contato, string descricao)
        {
            if (this.OpenConnection() == true)
            {
                limpaValores();
                try
                {
                    MySqlCommand cmd = connection.CreateCommand();

                    cmd.CommandText = "UPDATE `helpdesk_mip`.`tbl_listachamados`" +
                     "SET `descricao_chamado`= '" + descricao +
                     "', `contato`='" + contato + "' WHERE `id_chamados`='" + id + "';";

                    cmd.ExecuteNonQuery();
                    CloseConnection();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ops! Algo deu errado \n\n" + ex, " Erro conhecido!");
                    CloseConnection();
                }
            }
        }

        public void updateFecharChamado(int id_chamado,int id_tecnico, string solucao)
        {
            if (this.OpenConnection() == true)
            {
                limpaValores();
                try
                {
                    MySqlCommand cmd = connection.CreateCommand();

                    cmd.CommandText = "UPDATE `helpdesk_mip`.`tbl_listachamados` SET"+
                        "`id_tecnico_fechou`='"+id_tecnico+"', `data_fechamento`=now(), `status`='fechado', `solucao`='"+solucao+"'"+
                        "WHERE `id_chamados`='"+id_chamado+"';";

                    cmd.ExecuteNonQuery();
                    CloseConnection();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ops! Algo deu errado \n\n" + ex, " Erro conhecido!");
                    CloseConnection();
                }
            }
        }

        public void insertUsuario(string nome, string sobrenome, string sexo, string telefone, 
            string num_doc, string login, string senha,string acesso)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandText =
                    "INSERT INTO `helpdesk_mip`.`tbl_usuario`" +
                        "(`nome`,`sobrenome`, `sexo`, `telefone`, `num_documento`, `login`, `senha`, `bloqueio`, `acesso`)" +
                        "VALUES('" + nome + "', '" + sobrenome + "', '" + sexo + "','" + telefone + "','" + num_doc + "','" + login + "','" + senha + "', '0', '" + acesso + "');";
                
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void updateUsuario(int id, string nome, string sobrenome, string sexo, 
            string telefone, string num_doc, string login, string senha, string acesso)
        {
            if (this.OpenConnection() == true)
            {
                limpaValores();
                try
                {
                    MySqlCommand cmd = connection.CreateCommand();

                    cmd.CommandText = "UPDATE `helpdesk_mip`.`tbl_usuario`" +
                     "SET `nome`='" + nome + "', `sobrenome`='" + sobrenome + "', `sexo`='" + sexo + "', `num_documento`='" + num_doc +
                     "', `telefone`='" + telefone + "', `login`='" + login + "', `senha`='" + senha + "', `acesso`='" + acesso + "' WHERE `id_usuario`='" + id + "';";

                    cmd.ExecuteNonQuery();
                    CloseConnection();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ops! Algo deu errado \n\n" + ex, " Erro conhecido!");
                    CloseConnection();
                }
            }
        }

        public void limpaValores()
        {
            returnNome = "";
            returnId = "";
            returnIdProblema = 0;
            returnSobrenome = "";
            returnAcesso = "";
            returnBloqueio = false;
            returnDataNasc = "";
            returnNumDocumento = "";
            returnEndereco = "";
            returnTelefone = "";
            returnProblema = "";
            returnDescricao = "";
            returnDTAbertura = "";
            returnTempoSLA = "";
            returnIdTecnico = "";
            returnIdUsuario = "";
            returnSolucao = "";
        }
    }
}
