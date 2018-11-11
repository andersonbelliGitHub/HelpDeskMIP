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
    public partial class Chamado_Form : Form
    {
        Conexao conexao = new Conexao();

        private string idChamado { get; set; }
        private string idTecnico { get; set; }
        private string solucao { get; set; }
        private string contato { get; set; }
        private string descricao { get; set; }


        public Chamado_Form(int idCelula)
        {
            InitializeComponent();
            
            conexao.queryChamado(idCelula);

            idChamado = conexao.returnId.ToString();
            idTecnico = conexao.returnIdTecnico.ToString();
            string nome = conexao.returnNome.ToString();
            contato = conexao.returnContato.ToString();
            descricao = conexao.returnDescricao.ToString();
            string dtAbertura = conexao.returnDTAbertura.ToString();
            string tempoSLA = conexao.returnTempoSLA.ToString();
            solucao = conexao.returnSolucao.ToString();

            id_chamado.Text = idChamado;
            nome_chamado.Text = nome;
            contato_chamado.Text = contato;
            decricao_chamado.Text = descricao;
            dtAbertura_chamado.Text = dtAbertura;
            sla_chamado.Text = tempoSLA + " horas";
        }

        private void Chamado_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            contato_chamado.ReadOnly = false;
            decricao_chamado.ReadOnly = false;
            lb_Atualizar.Visible = true;
            btn_Cancelar.Visible = true;
            btn_Fechar.Visible = false;
            btn_Atualizar.Visible = false;
            btn_Aplicar.Visible = true;
            btn_Editar.Visible = false;
        }

        private void btn_Aplicar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja aplicar as atualizaçoes?", "Confirmação",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
            {
                contato_chamado.ReadOnly = true;
                decricao_chamado.ReadOnly = true;
                lb_Atualizar.Visible = false;
                btn_Cancelar.Visible = false;
                btn_Fechar.Visible = true;
                btn_Atualizar.Visible = true;
                btn_Editar.Visible = true;
                btn_Aplicar.Visible = false;

                contato = contato_chamado.Text;
                descricao = decricao_chamado.Text;
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            conexao.updateChamado(Convert.ToInt32(idChamado),contato,descricao);
            MessageBox.Show("Chamado atualizado com sucesso!");
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            FecharChamado_Form fecharForm = new FecharChamado_Form();
            fecharForm.Show();
        }
    }
}

