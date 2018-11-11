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
    public partial class ListaDeChamados_Form : Form
    {
        Conexao conexao = new Conexao();
        public ListaDeChamados_Form()
        {
            InitializeComponent();
        }

        private void ListaDeChamados_Form_Load(object sender, EventArgs e)
        {
            DataTable chamados = conexao.queryChamados();
            dgChamados.DataSource = chamados;


            //private void Button6_Click(object sender, System.EventArgs e)
            //{

                int rowNumber = 1;
                foreach (DataGridViewRow row in dgChamados.Rows)
                {
                    if (row.IsNewRow) continue;
                    row.HeaderCell.Value = rowNumber;
                    //row.HeaderCell.Value = "Row " + rowNumber;
                    rowNumber = rowNumber + 1;
                }
                dgChamados.AutoResizeRowHeadersWidth(
                    DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            //}
        }

        private void btn_atualiza_Click(object sender, EventArgs e)
        {
            DataTable chamados = conexao.queryChamados();
            dgChamados.DataSource = chamados;
        }

        private void dgChamados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idChamado = Convert.ToInt32(dgChamados["id", e.RowIndex].Value);

            string atual = dgChamados.CurrentCell.ToString();
            Chamado_Form chamadoFrm = new Chamado_Form(atual);
            chamadoFrm.Show();
        }
    }
}
