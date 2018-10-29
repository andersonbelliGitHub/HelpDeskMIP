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
            string problema = (cb_tipoProblema.SelectedItem.ToString()).Substring(1,1);


            id_usuario = Convert.ToInt32(num_usuarioAfetado.Value);
            id_tecnico = Convert.ToInt32(Tecnico);
            id_problema = Convert.ToInt32(problema);
            descricao = txt_descricao.Text;
            contato = tb_contato.Text;
        }

        private void abrirChamado_Click(object sender, EventArgs e)
        {
            conexao.insertChamados(id_usuario, id_tecnico, id_problema, descricao, contato);
        }
    }
}
