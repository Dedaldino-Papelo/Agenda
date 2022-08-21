namespace AgendaSQL
{
    partial class FrmConsultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFechar = new System.Windows.Forms.Button();
            this.DgvConsultar = new System.Windows.Forms.DataGridView();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnVertudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(536, 406);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(115, 40);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // DgvConsultar
            // 
            this.DgvConsultar.AllowUserToAddRows = false;
            this.DgvConsultar.AllowUserToDeleteRows = false;
            this.DgvConsultar.AllowUserToResizeColumns = false;
            this.DgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsultar.Location = new System.Drawing.Point(27, 30);
            this.DgvConsultar.MultiSelect = false;
            this.DgvConsultar.Name = "DgvConsultar";
            this.DgvConsultar.ReadOnly = true;
            this.DgvConsultar.RowHeadersVisible = false;
            this.DgvConsultar.RowTemplate.Height = 24;
            this.DgvConsultar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvConsultar.Size = new System.Drawing.Size(624, 370);
            this.DgvConsultar.TabIndex = 1;
            this.DgvConsultar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsultar_CellClick);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(24, 406);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(46, 17);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "label1";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(415, 406);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(115, 40);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(294, 406);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 40);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnVertudo
            // 
            this.btnVertudo.Location = new System.Drawing.Point(173, 406);
            this.btnVertudo.Name = "btnVertudo";
            this.btnVertudo.Size = new System.Drawing.Size(115, 40);
            this.btnVertudo.TabIndex = 5;
            this.btnVertudo.Text = "Ver Tudo";
            this.btnVertudo.UseVisualStyleBackColor = true;
            this.btnVertudo.Click += new System.EventHandler(this.btnVertudo_Click);
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 464);
            this.ControlBox = false;
            this.Controls.Add(this.btnVertudo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.DgvConsultar);
            this.Controls.Add(this.btnFechar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.FrmConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView DgvConsultar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnVertudo;
    }
}