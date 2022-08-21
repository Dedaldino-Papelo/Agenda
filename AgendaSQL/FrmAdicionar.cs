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
    public partial class FrmAdicionar : Form
    {
        public FrmAdicionar()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fechar Janela
            this.Close();
        }

        //====================================================================================================================================
        private void btnGravar_Click(object sender, EventArgs e)
        {
            
            //Conexão com a BD
            SqlConnection conexao = new SqlConnection(@"Data Source=KELSON-PC\SQLEXPRESS;Initial Catalog=agenda;Integrated Security=True");
            conexao.Open();
            //Comandos SQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            //Parametros
            comando.Parameters.AddWithValue("@nome",txtNome.Text);
            comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
            comando.Parameters.AddWithValue("@actualizacao", DateTime.Now);

            //Verifica se já existe um contacto com o mesmo nome e telefone
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataTable dados = new DataTable();
            comando.CommandText = "select * from contactos where nome = @nome and telefone = @telefone";
            adaptador.SelectCommand = comando;
            adaptador.Fill(dados);
            if (dados.Rows.Count != 0)
            {
                if (MessageBox.Show("Já existe um registro com o mesmo número e telefone" + Environment.NewLine +
                                  "Deseja Gravar Ainda Assim?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }

            //Texto da Query
            comando.CommandText = "insert into contactos values(@nome,@telefone,@actualizacao)";
            comando.ExecuteNonQuery();
            conexao.Dispose();
            comando.Dispose();
            MessageBox.Show("Registo inserido com sucesso");
            txtNome.Text = "";
            txtTelefone.Clear();
            txtNome.Focus();
        }

        private void FrmAdicionar_Load(object sender, EventArgs e)
        {

        }
    }
}
