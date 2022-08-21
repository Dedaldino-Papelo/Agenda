namespace AgendaSQL
{
    partial class frmEditar
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
            this.txtEditarTelefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtEditarNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEditarTelefone
            // 
            this.txtEditarTelefone.Location = new System.Drawing.Point(60, 179);
            this.txtEditarTelefone.Name = "txtEditarTelefone";
            this.txtEditarTelefone.Size = new System.Drawing.Size(170, 22);
            this.txtEditarTelefone.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(57, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Telefone:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(194, 271);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(103, 38);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtEditarNome
            // 
            this.txtEditarNome.Location = new System.Drawing.Point(60, 112);
            this.txtEditarNome.Name = "txtEditarNome";
            this.txtEditarNome.Size = new System.Drawing.Size(346, 22);
            this.txtEditarNome.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(57, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(303, 271);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 38);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 358);
            this.Controls.Add(this.txtEditarTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtEditarNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDITAR";
            this.Load += new System.EventHandler(this.frmEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEditarTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtEditarNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;

    }
}