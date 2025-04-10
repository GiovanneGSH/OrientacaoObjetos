namespace ProjetoOrientacaoObjeto
{
    partial class frmEstruturaRepeticao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstruturaRepeticao));
            this.cbbEstados = new System.Windows.Forms.ComboBox();
            this.ltbListaDesejos = new System.Windows.Forms.ListBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblListaDeDesejos = new System.Windows.Forms.Label();
            this.btnCarregaEstado = new System.Windows.Forms.Button();
            this.btnCarregaListaDesejos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbEstados
            // 
            this.cbbEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstados.FormattingEnabled = true;
            this.cbbEstados.Location = new System.Drawing.Point(47, 59);
            this.cbbEstados.Name = "cbbEstados";
            this.cbbEstados.Size = new System.Drawing.Size(163, 28);
            this.cbbEstados.TabIndex = 0;
            // 
            // ltbListaDesejos
            // 
            this.ltbListaDesejos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaDesejos.FormattingEnabled = true;
            this.ltbListaDesejos.ItemHeight = 20;
            this.ltbListaDesejos.Location = new System.Drawing.Point(279, 59);
            this.ltbListaDesejos.Name = "ltbListaDesejos";
            this.ltbListaDesejos.Size = new System.Drawing.Size(163, 264);
            this.ltbListaDesejos.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(43, 36);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado";
            // 
            // lblListaDeDesejos
            // 
            this.lblListaDeDesejos.AutoSize = true;
            this.lblListaDeDesejos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDeDesejos.Location = new System.Drawing.Point(275, 36);
            this.lblListaDeDesejos.Name = "lblListaDeDesejos";
            this.lblListaDeDesejos.Size = new System.Drawing.Size(127, 20);
            this.lblListaDeDesejos.TabIndex = 3;
            this.lblListaDeDesejos.Text = "Lista de Desejos";
            // 
            // btnCarregaEstado
            // 
            this.btnCarregaEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaEstado.Location = new System.Drawing.Point(47, 354);
            this.btnCarregaEstado.Name = "btnCarregaEstado";
            this.btnCarregaEstado.Size = new System.Drawing.Size(113, 50);
            this.btnCarregaEstado.TabIndex = 4;
            this.btnCarregaEstado.Text = "Carrega Estados";
            this.btnCarregaEstado.UseVisualStyleBackColor = true;
            this.btnCarregaEstado.Click += new System.EventHandler(this.btnCarregaEstado_Click);
            // 
            // btnCarregaListaDesejos
            // 
            this.btnCarregaListaDesejos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaListaDesejos.Location = new System.Drawing.Point(279, 354);
            this.btnCarregaListaDesejos.Name = "btnCarregaListaDesejos";
            this.btnCarregaListaDesejos.Size = new System.Drawing.Size(113, 50);
            this.btnCarregaListaDesejos.TabIndex = 5;
            this.btnCarregaListaDesejos.Text = "Carrega Lista de Desejos";
            this.btnCarregaListaDesejos.UseVisualStyleBackColor = true;
            // 
            // frmEstruturaRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 437);
            this.Controls.Add(this.btnCarregaListaDesejos);
            this.Controls.Add(this.btnCarregaEstado);
            this.Controls.Add(this.lblListaDeDesejos);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.ltbListaDesejos);
            this.Controls.Add(this.cbbEstados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstruturaRepeticao";
            this.Text = "frmEstruturaRepeticao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbEstados;
        private System.Windows.Forms.ListBox ltbListaDesejos;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblListaDeDesejos;
        private System.Windows.Forms.Button btnCarregaEstado;
        private System.Windows.Forms.Button btnCarregaListaDesejos;
    }
}