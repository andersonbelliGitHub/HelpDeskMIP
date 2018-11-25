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
        private string status { get; set; }
        private string tecnicoFechou { get; set; }

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
            status = conexao.returnStatus.ToString();
            tecnicoFechou = conexao.returnTecnicoFechou.ToString();
            string dtFechamento = conexao.returnDTFechamento.ToString();

            id_chamado.Text = idChamado;
            nome_chamado.Text = nome;
            contato_chamado.Text = contato;
            descricao_chamado.Text = descricao;
            dtAbertura_chamado.Text = dtAbertura;
            sla_chamado.Text = tempoSLA + " horas";

            if (status=="fechado")
            {
                lb_fechado.Text = "Fechado por: "+ tecnicoFechou;
                lb_dtFechamento.Visible = true;
                lb_dtFechamento.Text = "Data de fechamento: " + dtFechamento;
                solucao_chamado.Text = solucao;
                lb_fechado.Visible = true;
                btn_Editar.Visible = false;
                btn_Fechar.Visible = false;
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            contato_chamado.ReadOnly = false;
            descricao_chamado.ReadOnly = false;
            descricao_chamado.BackColor = Color.White;
            lb_Atualizar.Visible = true;
            btn_Cancelar.Visible = true;
            btn_Fechar.Visible = false;
            btn_Atualizar.Visible = false;
            btn_Aplicar.Visible = true;
            btn_Editar.Visible = false;
        }

        private void btn_Aplicar_Click(object sender, EventArgs e)
        {
            if (status == "fechado")
            {
                MessageBox.Show("Chamado já fechado!","Informativo",MessageBoxButtons.OK);
            }
            else
            { 
                if (MessageBox.Show("Deseja aplicar as atualizaçoes?", "Confirmação",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
                {
                    contato_chamado.ReadOnly = true;
                    descricao_chamado.ReadOnly = true;
                    lb_Atualizar.Visible = true;
                    lb_Atualizar.Text = "Clique em atualizar para aplicar as mudanças";
                    btn_Cancelar.Visible = false;
                    btn_Fechar.Visible = true;
                    btn_Atualizar.Visible = true;
                    btn_Editar.Visible = true;
                    btn_Aplicar.Visible = false;

                    contato = contato_chamado.Text;
                    descricao = descricao_chamado.Text;
                }
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            conexao.updateChamado(Convert.ToInt32(idChamado),contato,descricao);
            MessageBox.Show("Chamado atualizado com sucesso!");
            btn_Atualizar.Visible = false;
            lb_Atualizar.Visible = false;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            if (status == "fechado")
            {
                MessageBox.Show("Chamado já fechado!", "Informativo", MessageBoxButtons.OK);
            }
            else
            {
                FecharChamado_Form fecharForm = new FecharChamado_Form(idChamado, idTecnico);
                fecharForm.Show();
                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            contato_chamado.ReadOnly = true;
            descricao_chamado.ReadOnly = true;
            lb_Atualizar.Visible = false;
            btn_Cancelar.Visible = false;
            btn_Fechar.Visible = true;
            btn_Atualizar.Visible = false;
            btn_Aplicar.Visible = false;
            btn_Editar.Visible = true;
        }
    }
}

