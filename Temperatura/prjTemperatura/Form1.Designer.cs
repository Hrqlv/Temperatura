namespace prjTemperatura
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFrom = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbFromK = new System.Windows.Forms.RadioButton();
            this.rbFromF = new System.Windows.Forms.RadioButton();
            this.rbFromC = new System.Windows.Forms.RadioButton();
            this.gbTo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbToK = new System.Windows.Forms.RadioButton();
            this.rbToF = new System.Windows.Forms.RadioButton();
            this.rbToC = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lbResposta = new System.Windows.Forms.Label();
            this.gbFrom.SuspendLayout();
            this.gbTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFrom
            // 
            this.gbFrom.Controls.Add(this.label1);
            this.gbFrom.Controls.Add(this.rbFromK);
            this.gbFrom.Controls.Add(this.rbFromF);
            this.gbFrom.Controls.Add(this.rbFromC);
            this.gbFrom.Location = new System.Drawing.Point(12, 11);
            this.gbFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFrom.Name = "gbFrom";
            this.gbFrom.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbFrom.Size = new System.Drawing.Size(103, 94);
            this.gbFrom.TabIndex = 0;
            this.gbFrom.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ORIGEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbFromK
            // 
            this.rbFromK.AutoSize = true;
            this.rbFromK.Location = new System.Drawing.Point(7, 74);
            this.rbFromK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFromK.Name = "rbFromK";
            this.rbFromK.Size = new System.Drawing.Size(65, 16);
            this.rbFromK.TabIndex = 2;
            this.rbFromK.Text = "KELVIN";
            this.rbFromK.UseVisualStyleBackColor = true;
            // 
            // rbFromF
            // 
            this.rbFromF.AutoSize = true;
            this.rbFromF.ForeColor = System.Drawing.Color.DarkOrange;
            this.rbFromF.Location = new System.Drawing.Point(7, 45);
            this.rbFromF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFromF.Name = "rbFromF";
            this.rbFromF.Size = new System.Drawing.Size(93, 16);
            this.rbFromF.TabIndex = 1;
            this.rbFromF.Text = "FAHRENHEIT";
            this.rbFromF.UseVisualStyleBackColor = true;
            // 
            // rbFromC
            // 
            this.rbFromC.AutoSize = true;
            this.rbFromC.Checked = true;
            this.rbFromC.Location = new System.Drawing.Point(7, 17);
            this.rbFromC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFromC.Name = "rbFromC";
            this.rbFromC.Size = new System.Drawing.Size(68, 16);
            this.rbFromC.TabIndex = 0;
            this.rbFromC.TabStop = true;
            this.rbFromC.Text = "CELSIUS";
            this.rbFromC.UseVisualStyleBackColor = true;
            // 
            // gbTo
            // 
            this.gbTo.Controls.Add(this.label2);
            this.gbTo.Controls.Add(this.rbToK);
            this.gbTo.Controls.Add(this.rbToF);
            this.gbTo.Controls.Add(this.rbToC);
            this.gbTo.Location = new System.Drawing.Point(12, 121);
            this.gbTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTo.Name = "gbTo";
            this.gbTo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTo.Size = new System.Drawing.Size(103, 94);
            this.gbTo.TabIndex = 0;
            this.gbTo.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESTINO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbToK
            // 
            this.rbToK.AutoSize = true;
            this.rbToK.Checked = true;
            this.rbToK.Location = new System.Drawing.Point(7, 74);
            this.rbToK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbToK.Name = "rbToK";
            this.rbToK.Size = new System.Drawing.Size(65, 16);
            this.rbToK.TabIndex = 2;
            this.rbToK.TabStop = true;
            this.rbToK.Text = "KELVIN";
            this.rbToK.UseVisualStyleBackColor = true;
            // 
            // rbToF
            // 
            this.rbToF.AutoSize = true;
            this.rbToF.ForeColor = System.Drawing.Color.DarkOrange;
            this.rbToF.Location = new System.Drawing.Point(7, 45);
            this.rbToF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbToF.Name = "rbToF";
            this.rbToF.Size = new System.Drawing.Size(93, 16);
            this.rbToF.TabIndex = 1;
            this.rbToF.Text = "FAHRENHEIT";
            this.rbToF.UseVisualStyleBackColor = true;
            // 
            // rbToC
            // 
            this.rbToC.AutoSize = true;
            this.rbToC.Location = new System.Drawing.Point(7, 17);
            this.rbToC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbToC.Name = "rbToC";
            this.rbToC.Size = new System.Drawing.Size(68, 16);
            this.rbToC.TabIndex = 0;
            this.rbToC.Text = "CELSIUS";
            this.rbToC.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(148, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "TEMPERATURA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(142, 27);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(103, 20);
            this.txtTemperatura.TabIndex = 2;
            this.txtTemperatura.Text = "0";
            this.txtTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.Black;
            this.btnConverter.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnConverter.Location = new System.Drawing.Point(142, 53);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(103, 23);
            this.btnConverter.TabIndex = 3;
            this.btnConverter.Text = "CONVERTER";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lbResposta
            // 
            this.lbResposta.Location = new System.Drawing.Point(148, 121);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(97, 94);
            this.lbResposta.TabIndex = 1;
            this.lbResposta.Text = "RESPOSTA";
            this.lbResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbResposta.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(260, 226);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.lbResposta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbTo);
            this.Controls.Add(this.gbFrom);
            this.Font = new System.Drawing.Font("Romantic", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA TEMPERATURA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbFrom.ResumeLayout(false);
            this.gbFrom.PerformLayout();
            this.gbTo.ResumeLayout(false);
            this.gbTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFromK;
        private System.Windows.Forms.RadioButton rbFromF;
        private System.Windows.Forms.RadioButton rbFromC;
        private System.Windows.Forms.GroupBox gbTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbToK;
        private System.Windows.Forms.RadioButton rbToF;
        private System.Windows.Forms.RadioButton rbToC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lbResposta;
    }
}

