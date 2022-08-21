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
    public partial class FrmConsultar : Form
    {
        int id_contacto;
        string item_pesquisa;

        public FrmConsultar(string item_pesquisa = "")
        {
            InitializeComponent();
            this.item_pesquisa = item_pesquisa;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fechar Janela
            this.Close();
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            ConstruirGrelha();
        }

        private void ConstruirGrelha()
        {
            //Procedimentos para a conexão com a BD
            SqlConnection conexao = new SqlConnection(@"Data Source=KELSON-PC\SQLEXPRESS;Initial Catalog=agenda;Integrated Security=True");
            conexao.Open();

            string query = "select * from contactos";
            if(item_pesquisa != "")
            {
                query = "select * from contactos " +
                         "where nome like @item OR telefone like @item";

            }

            SqlCommand comando = new SqlCommand();
            comando.Parameters.AddWithValue("@item","%" + item_pesquisa + "%");
            comando.CommandText = query;
            comando.Connection = conexao;
           
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dados = new DataTable();
            adaptador.Fill(dados);
            DgvConsultar.DataSource = dados;

            //Apresentar número de registros na dataGrid View
            lblResultado.Text = "Resultado: " + DgvConsultar.Rows.Count;
            //Esconder colunas
            DgvConsultar.Columns[0].Visible = false;
            DgvConsultar.Columns["actualizacao"].Visible = false;
            //btnApagar.Enabled = false;
            btnApagar.Enabled = false;
            btnEditar.Enabled = false;
            DgvConsultar.Columns[0].Width = CaucularLargura(60);
            DgvConsultar.Columns["telefone"].Width = CaucularLargura(40);

            //Constrola a disponibilade dos comandos
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            //ELiminar a linha selecionada
            SqlConnection conexao = new SqlConnection(@"Data Source=KELSON-PC\SQLEXPRESS;Initial Catalog=agenda;Integrated Security=True");
            conexao.Open();
            SqlCommand comando = new SqlCommand("delete from contactos where id_contacto = " + id_contacto,conexao);
            comando.ExecuteNonQuery();
            conexao.Close();
            comando.Dispose();
            ConstruirGrelha();
            
        }

        private void DgvConsultar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //id_contacto = Convert.ToInt16(DgvConsultar.CurrentRow.Cells[0].Value);
            id_contacto = Convert.ToInt16(DgvConsultar.Rows[e.RowIndex].Cells["id_contacto"].Value);
            btnApagar.Enabled = true;
            btnEditar.Enabled = true;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id_contacto = Convert.ToInt16(DgvConsultar.CurrentRow.Cells[0].Value);
            string nome = DgvConsultar.CurrentRow.Cells[1].Value.ToString();
            string telefone = DgvConsultar.CurrentRow.Cells[2].Value.ToString();
            DateTime actualizacao = Convert.ToDateTime(DgvConsultar.CurrentRow.Cells[3].Value);
            //Instancia da classe Editar
            frmEditar Editar = new frmEditar(id_contacto,nome,telefone,actualizacao);
            Editar.ShowDialog();

            //Construir a grelha
            ConstruirGrelha();
            
        }

        private void btnVertudo_Click(object sender, EventArgs e)
        {
            item_pesquisa = "";
            ConstruirGrelha();
            
        }

        private int CaucularLargura(int percentagem)
        {
            int largura_grelha = DgvConsultar.Width - 20;
            int resultado = (largura_grelha * percentagem) / 100;
            return resultado;
        }

    }
}
