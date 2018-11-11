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

        public FecharChamado_Form()
        {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            conexao.updateFecharChamado(Convert.ToInt32(idChamado), Convert.ToInt32(idTecnico), solucao);
            MessageBox.Show("Chamado fechado!");
            this.Close();
        }
    }
}
