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
    public partial class frmEditar : Form
    {
        int id_contacto; 
        string nome; 
        string telefone;
        DateTime actualizacao;

        public frmEditar(int id_contacto, string nome, string telefone, DateTime actualizacao)
        {
            InitializeComponent();
            this.id_contacto = id_contacto;
            this.nome = nome;
            this.telefone = telefone;
            this.actualizacao = actualizacao;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditar_Load(object sender, EventArgs e)
        {
            txtEditarNome.Text = nome;
            txtEditarTelefone.Text = telefone;
          
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Conexão coam a Base de Dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=KELSON-PC\SQLEXPRESS;Initial Catalog=agenda;Integrated Security=True";
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            //parametros
            comando.Parameters.AddWithValue("@id_contacto", id_contacto);
            comando.Parameters.AddWithValue("@nome", txtEditarNome.Text);
            comando.Parameters.AddWithValue("@telefone",txtEditarTelefone.Text);
            comando.Parameters.AddWithValue("@actualizacao", DateTime.Now);
            comando.CommandText = "update contactos set nome=@nome,telefone=@telefone,actualizacao=@actualizacao where id_contacto = @id_contacto";
            comando.ExecuteNonQuery();
            comando.Dispose();
            comando.Clone();
            MessageBox.Show("Registro Actualizado com sucesso");
            this.Close();
            
        }
    }
}
