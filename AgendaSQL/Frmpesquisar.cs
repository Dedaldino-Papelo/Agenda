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
    public partial class Frmpesquisar : Form
    {
        public string texto_buscar {get;set;}
        public bool Cancelado;

        public Frmpesquisar()
        {
            InitializeComponent();
            
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            //Executa a pesquisa, apenas se existir texto na textbox
            if (txtPesquisar.Text == "")
            {
                Cancelado = true;
            }
            else 
            {
                texto_buscar = txtPesquisar.Text;
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //fecha o quadro, cancelando a operação de pesquisa
            Cancelado = true;
            this.Close();
        }
   
            
        

       
    }
}
