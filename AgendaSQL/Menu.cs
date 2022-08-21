using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgendaSQL
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            //Apresentar Versão do projecto
            lblversao.Text = vars.versao;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da Aplicação", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            //Sair da Aplicação
            Application.Exit();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Abrir um quadro para Adicionar Registros
            FrmAdicionar Adicionar = new FrmAdicionar();
            Adicionar.ShowDialog();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //Abrir um quadro para apresentação de todos os resultados
            FrmConsultar c = new FrmConsultar();
            c.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Abrir um quadro para Pesquisar Registros 
            Frmpesquisar pesquisar = new Frmpesquisar();
            pesquisar.ShowDialog();

            if (pesquisar.Cancelado)
            {
                pesquisar.Dispose();
                return;
            }
                

            //Abrir o quadro para o resultado da pesquisa
            FrmConsultar consultar = new FrmConsultar(pesquisar.texto_buscar);
            consultar.ShowDialog();
        }
    }
}
