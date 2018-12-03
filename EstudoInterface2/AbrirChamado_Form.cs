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
    public partial class AbrirChamado_Form : Form
    {
        Conexao conexao = new Conexao();

        public int id_usuario { get; set; }
        public int id_tecnico { get; set; }
        public int id_problema { get; set; }
        public string descricao { get; set; }
        public string contato { get; set; }

        public AbrirChamado_Form(string Tecnico)
        {
            InitializeComponent();
            
            // Exibe as opções no dropBox
            Dictionary<string, string> dadosProblemas = new Dictionary<string, string>();

            dadosProblemas.Add("1", "Instalação");
            dadosProblemas.Add("2", "Periféricos");
            dadosProblemas.Add("3", "Hardware");
            dadosProblemas.Add("4", "Reparo no software");
            dadosProblemas.Add("5", "Outros");

            cb_tipoProblema.DataSource = new BindingSource(dadosProblemas, null);
            cb_tipoProblema.DisplayMember = "Value";
            cb_tipoProblema.ValueMember = "Key";

            //Pega valor do comboBox
            //string problema = ((KeyValuePair<string, string>)cb_tipoProblema.SelectedItem).Value;

            id_tecnico = Convert.ToInt32(Tecnico);
        }

        public string retornaDados()
        {
            string problema = (cb_tipoProblema.SelectedItem.ToString()).Substring(1, 1);

            id_usuario = Convert.ToInt32(num_usuarioAfetado.Value);
            
            id_problema = Convert.ToInt32(problema);
            descricao = txt_descricao.Text;
            contato = tb_contato.Text;

            return id_usuario + descricao + contato;
        }

        private void abrirChamado_Click(object sender, EventArgs e)
        {
            retornaDados();
            try
            {
                if (txt_descricao.Text == "Descreva brevemente o problema do usuário" || tb_contato.Text == "Telefone ou email")
                {
                    MessageBox.Show("Campos com * são obrigatórios!");
                    conexao.CloseConnection();
                    id_usuario = 0;
                    retornaDados();
                }
                else
                {
                    conexao.insertChamados(id_tecnico, id_usuario, id_problema, descricao, contato);
                    MessageBox.Show("Chamado aberto com sucesso! \n Numero do chamado: "+ conexao.queryUltimoChamado());
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Usuário não encontrado!");
                conexao.CloseConnection();
                id_usuario = 0;
                retornaDados();
            }
        }

        private void txt_descricao_Enter(object sender, EventArgs e)
        {
            if (txt_descricao.Text == "Descreva brevemente o problema do usuário")
            {
                txt_descricao.Text = "";
                txt_descricao.ForeColor = Color.Black;
            }
        }

        private void txt_descricao_Leave(object sender, EventArgs e)
        {
            if (txt_descricao.Text == "")
            {
                txt_descricao.Text = "Descreva brevemente o problema do usuário";
                txt_descricao.ForeColor = Color.DarkGray;
            }
        }

        private void tb_contato_Enter(object sender, EventArgs e)
        {
            if (tb_contato.Text == "Telefone ou email")
            {
                tb_contato.Text = "";
                tb_contato.ForeColor = Color.Black;
            }
        }

        private void tb_contato_Leave(object sender, EventArgs e)
        {
            if (tb_contato.Text == "")
            {
                tb_contato.Text = "Telefone ou email";
                tb_contato.ForeColor = Color.DarkGray;
            }
        }
    }
}
