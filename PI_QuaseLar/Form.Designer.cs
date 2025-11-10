namespace PI_QuaseLar
{
    partial class FormDoacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxVacinado = new System.Windows.Forms.ComboBox();
            this.comboBoxCastrado = new System.Windows.Forms.ComboBox();
            this.comboBoxPorte = new System.Windows.Forms.ComboBox();
            this.comboBoxIdade = new System.Windows.Forms.ComboBox();
            this.comboBoxEspecie = new System.Windows.Forms.ComboBox();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.labelEspecie = new System.Windows.Forms.Label();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxMotivo = new System.Windows.Forms.TextBox();
            this.textBoxRaca = new System.Windows.Forms.TextBox();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Animal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Idade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Raça:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(257, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Porte:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 266);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Castrado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(248, 266);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Vacinado:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxVacinado);
            this.panel1.Controls.Add(this.comboBoxCastrado);
            this.panel1.Controls.Add(this.comboBoxPorte);
            this.panel1.Controls.Add(this.comboBoxIdade);
            this.panel1.Controls.Add(this.comboBoxEspecie);
            this.panel1.Controls.Add(this.comboBoxSexo);
            this.panel1.Controls.Add(this.labelEspecie);
            this.panel1.Controls.Add(this.buttonEnviar);
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Controls.Add(this.textBoxMotivo);
            this.panel1.Controls.Add(this.textBoxRaca);
            this.panel1.Controls.Add(this.textBoxIdade);
            this.panel1.Controls.Add(this.textBoxNome);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(168, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 458);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBoxVacinado
            // 
            this.comboBoxVacinado.FormattingEnabled = true;
            this.comboBoxVacinado.Items.AddRange(new object[] {
            "SIm",
            "Não"});
            this.comboBoxVacinado.Location = new System.Drawing.Point(252, 288);
            this.comboBoxVacinado.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVacinado.Name = "comboBoxVacinado";
            this.comboBoxVacinado.Size = new System.Drawing.Size(63, 24);
            this.comboBoxVacinado.TabIndex = 39;
            // 
            // comboBoxCastrado
            // 
            this.comboBoxCastrado.FormattingEnabled = true;
            this.comboBoxCastrado.Items.AddRange(new object[] {
            "SIm",
            "Não"});
            this.comboBoxCastrado.Location = new System.Drawing.Point(45, 288);
            this.comboBoxCastrado.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCastrado.Name = "comboBoxCastrado";
            this.comboBoxCastrado.Size = new System.Drawing.Size(57, 24);
            this.comboBoxCastrado.TabIndex = 38;
            // 
            // comboBoxPorte
            // 
            this.comboBoxPorte.FormattingEnabled = true;
            this.comboBoxPorte.Items.AddRange(new object[] {
            "Pequeno",
            "Medio",
            "Grande"});
            this.comboBoxPorte.Location = new System.Drawing.Point(252, 218);
            this.comboBoxPorte.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPorte.Name = "comboBoxPorte";
            this.comboBoxPorte.Size = new System.Drawing.Size(79, 24);
            this.comboBoxPorte.TabIndex = 37;
            // 
            // comboBoxIdade
            // 
            this.comboBoxIdade.FormattingEnabled = true;
            this.comboBoxIdade.Items.AddRange(new object[] {
            "Semanas",
            "Meses",
            "Anos"});
            this.comboBoxIdade.Location = new System.Drawing.Point(301, 149);
            this.comboBoxIdade.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIdade.Name = "comboBoxIdade";
            this.comboBoxIdade.Size = new System.Drawing.Size(59, 24);
            this.comboBoxIdade.TabIndex = 36;
            // 
            // comboBoxEspecie
            // 
            this.comboBoxEspecie.FormattingEnabled = true;
            this.comboBoxEspecie.Items.AddRange(new object[] {
            "Gato",
            "Cachorro",
            "Roedor",
            "Repteis",
            "Coelho",
            "Outro"});
            this.comboBoxEspecie.Location = new System.Drawing.Point(149, 146);
            this.comboBoxEspecie.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEspecie.Name = "comboBoxEspecie";
            this.comboBoxEspecie.Size = new System.Drawing.Size(67, 24);
            this.comboBoxEspecie.TabIndex = 35;
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Macho",
            "Femêa"});
            this.comboBoxSexo.Location = new System.Drawing.Point(45, 146);
            this.comboBoxSexo.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(57, 24);
            this.comboBoxSexo.TabIndex = 34;
            // 
            // labelEspecie
            // 
            this.labelEspecie.AutoSize = true;
            this.labelEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEspecie.Location = new System.Drawing.Point(145, 124);
            this.labelEspecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEspecie.Name = "labelEspecie";
            this.labelEspecie.Size = new System.Drawing.Size(65, 18);
            this.labelEspecie.TabIndex = 28;
            this.labelEspecie.Text = "Especie:";
            this.labelEspecie.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEnviar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonEnviar.Location = new System.Drawing.Point(261, 415);
            this.buttonEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(100, 28);
            this.buttonEnviar.TabIndex = 27;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = false;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCancelar.Location = new System.Drawing.Point(40, 415);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 28);
            this.buttonCancelar.TabIndex = 26;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxMotivo
            // 
            this.textBoxMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMotivo.Location = new System.Drawing.Point(45, 367);
            this.textBoxMotivo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMotivo.Name = "textBoxMotivo";
            this.textBoxMotivo.Size = new System.Drawing.Size(307, 26);
            this.textBoxMotivo.TabIndex = 24;
            this.textBoxMotivo.TextChanged += new System.EventHandler(this.textBoxMotivo_TextChanged);
            // 
            // textBoxRaca
            // 
            this.textBoxRaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRaca.Location = new System.Drawing.Point(45, 215);
            this.textBoxRaca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRaca.Name = "textBoxRaca";
            this.textBoxRaca.Size = new System.Drawing.Size(93, 26);
            this.textBoxRaca.TabIndex = 19;
            this.textBoxRaca.TextChanged += new System.EventHandler(this.textBoxRaca_TextChanged);
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdade.Location = new System.Drawing.Point(263, 148);
            this.textBoxIdade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(31, 26);
            this.textBoxIdade.TabIndex = 18;
            this.textBoxIdade.TextChanged += new System.EventHandler(this.textBoxIdade_TextChanged);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(189, 78);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(121, 26);
            this.textBoxNome.TabIndex = 15;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 343);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 18);
            this.label12.TabIndex = 14;
            this.label12.Text = "Motivo da Doação:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(232, 47);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 46);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(52, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cadastro para Doação";
            // 
            // FormDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 552);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDoacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro para Doação";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxRaca;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxMotivo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelEspecie;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.ComboBox comboBoxEspecie;
        private System.Windows.Forms.ComboBox comboBoxIdade;
        private System.Windows.Forms.ComboBox comboBoxPorte;
        private System.Windows.Forms.ComboBox comboBoxVacinado;
        private System.Windows.Forms.ComboBox comboBoxCastrado;
    }
}

