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
    public partial class Consultar_Chamado : Form
    {
        Conexao conexao = new Conexao();

        string idUsuario;
        string idChamado;
        string retorno;

        public Consultar_Chamado()
        {
            InitializeComponent();
        }

        private void btn_chamado_Click(object sender, EventArgs e)
        {
            retorno = conexao.queryChamado(Convert.ToInt32(num_idChamado.Value));
            idChamado = conexao.returnId.ToString();

            
            Chamado_Form chamado = new Chamado_Form(Convert.ToInt32(idChamado));
            if (chamado != null)
            {
                if(Convert.ToInt32(idChamado) != 0)
                {
                    chamado.Show();
                    this.Close();
                }
            }
            else
            {
                if (idChamado == null)
                {
                    this.Close();
                }
                MessageBox.Show("Id não pode ficar vazio!");
            }
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            retorno = conexao.queryChamado(Convert.ToInt32(num_idUsuario.Value));
            idUsuario = conexao.returnId.ToString();

            Chamado_Form chamado = new Chamado_Form(Convert.ToInt32(idUsuario));
            chamado.Show();
            this.Close();
        }
    }
}
