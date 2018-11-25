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
    public partial class ListaDeChamados_Form : Form
    {
        Conexao conexao = new Conexao();

        public ListaDeChamados_Form()
        {
            InitializeComponent();
        }

        private void ListaDeChamados_Form_Load(object sender, EventArgs e)
        {
            PreencheChamados();
        }

        private void btn_atualiza_Click(object sender, EventArgs e)
        {
            PreencheChamados();
        }

        private void dgChamados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idChamado = Convert.ToInt32(dgChamados["Id chamado", e.RowIndex].Value);

            string atual = dgChamados.CurrentCell.ToString();
            Chamado_Form chamadoFrm = new Chamado_Form(idChamado);
            chamadoFrm.Show();
            this.Close();
        }

        private void PreencheChamados()
        {
            DataTable chamados = conexao.queryChamados();
            dgChamados.DataSource = chamados;

            int rowNumber = 1;
            foreach (DataGridViewRow row in dgChamados.Rows)
            {
                if (row.IsNewRow) continue;
                //row.HeaderCell.Value = rowNumber;
                row.HeaderCell.Value = " " + rowNumber;
                rowNumber = rowNumber + 1;
            }
            dgChamados.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
