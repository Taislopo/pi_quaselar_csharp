namespace PI_QuaseLar
{
    partial class TelaAdocao
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonMais = new System.Windows.Forms.Button();
            this.labelUltima = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Controls.Add(this.buttonMais);
            this.panel3.Controls.Add(this.labelUltima);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.labelNome);
            this.panel3.Location = new System.Drawing.Point(56, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 74);
            this.panel3.TabIndex = 30;
            // 
            // buttonMais
            // 
            this.buttonMais.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonMais.Location = new System.Drawing.Point(40, 13);
            this.buttonMais.Name = "buttonMais";
            this.buttonMais.Size = new System.Drawing.Size(115, 31);
            this.buttonMais.TabIndex = 28;
            this.buttonMais.Text = "Mais Informações";
            this.buttonMais.UseVisualStyleBackColor = false;
            // 
            // labelUltima
            // 
            this.labelUltima.AutoSize = true;
            this.labelUltima.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUltima.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelUltima.Location = new System.Drawing.Point(104, 47);
            this.labelUltima.Name = "labelUltima";
            this.labelUltima.Size = new System.Drawing.Size(61, 12);
            this.labelUltima.TabIndex = 30;
            this.labelUltima.Text = "2025/11/03";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Location = new System.Drawing.Point(4, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ultima Atulização:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelNome.Location = new System.Drawing.Point(4, 16);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(30, 16);
            this.labelNome.TabIndex = 28;
            this.labelNome.Text = "Leo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(56, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 56);
            this.panel1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mude um destino: adote um pet hoje!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Adoção";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxImg.Location = new System.Drawing.Point(56, 118);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Size = new System.Drawing.Size(168, 113);
            this.pictureBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImg.TabIndex = 28;
            this.pictureBoxImg.TabStop = false;
            // 
            // TelaAdocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxImg);
            this.Name = "TelaAdocao";
            this.Text = "TelaAdocao";
            this.Load += new System.EventHandler(this.TelaAdocao_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonMais;
        private System.Windows.Forms.Label labelUltima;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxImg;
    }
}