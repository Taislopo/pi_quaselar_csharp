namespace PI_QuaseLar
{
    partial class ListaAnimaisProcurados
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
            this.dataGridViewAnimais = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonProcurase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAnimais
            // 
            this.dataGridViewAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimais.Location = new System.Drawing.Point(109, 82);
            this.dataGridViewAnimais.Name = "dataGridViewAnimais";
            this.dataGridViewAnimais.RowHeadersWidth = 51;
            this.dataGridViewAnimais.RowTemplate.Height = 24;
            this.dataGridViewAnimais.Size = new System.Drawing.Size(583, 319);
            this.dataGridViewAnimais.TabIndex = 10;
            this.dataGridViewAnimais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAnimais_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(198, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Consultar Animais Desaparecidos";
            // 
            // buttonProcurase
            // 
            this.buttonProcurase.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonProcurase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcurase.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonProcurase.Location = new System.Drawing.Point(60, 11);
            this.buttonProcurase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonProcurase.Name = "buttonProcurase";
            this.buttonProcurase.Size = new System.Drawing.Size(249, 30);
            this.buttonProcurase.TabIndex = 11;
            this.buttonProcurase.Text = "Cadastrar Animal desaparerido";
            this.buttonProcurase.UseVisualStyleBackColor = false;
            this.buttonProcurase.Click += new System.EventHandler(this.buttonProcurase_Click);
            // 
            // ListaAnimaisProcurados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonProcurase);
            this.Controls.Add(this.dataGridViewAnimais);
            this.Controls.Add(this.label1);
            this.Name = "ListaAnimaisProcurados";
            this.Text = "ListaAnimaisProcurados";
            this.Load += new System.EventHandler(this.ListaAnimaisProcurados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAnimais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonProcurase;
    }
}