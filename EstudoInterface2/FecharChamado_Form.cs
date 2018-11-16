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
    public partial class FecharChamado_Form : Form
    {
        Conexao conexao = new Conexao();
        private string idChamado { get; set; }
        private string idTecnico { get; set; }
        private string solucao { get; set; }

        public FecharChamado_Form(string idChamadoRecebido,string idTecnicoRecebido)
        {
            InitializeComponent();

            idChamado = idChamadoRecebido;
            idTecnico = idTecnicoRecebido;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            conexao.updateFecharChamado(Convert.ToInt32(idChamado), Convert.ToInt32(idTecnico), txtSolucao.Text);
            MessageBox.Show("Chamado fechado!");
            this.Close();
            ListaDeChamados_Form listaDeChamados = new ListaDeChamados_Form();
            Chamado_Form chamado_Form = new Chamado_Form(Convert.ToInt32(idChamado));
            chamado_Form.Show();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancelar fechamento do chamado?", "Confirmação",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
            {
                this.Close();
                Chamado_Form chamado_Form = new Chamado_Form(Convert.ToInt32(idChamado));
                chamado_Form.Show();
            }
        }
    }
}
