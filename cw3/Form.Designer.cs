namespace cw3
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.btn_Wybierz = new System.Windows.Forms.Button();
            this.tb_Sciezka = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btn_Oblicz = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_LiczbaAtrybutow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Wybierz
            // 
            this.btn_Wybierz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Wybierz.Location = new System.Drawing.Point(377, 13);
            this.btn_Wybierz.Name = "btn_Wybierz";
            this.btn_Wybierz.Size = new System.Drawing.Size(49, 20);
            this.btn_Wybierz.TabIndex = 0;
            this.btn_Wybierz.Text = "...";
            this.btn_Wybierz.UseVisualStyleBackColor = true;
            this.btn_Wybierz.Click += new System.EventHandler(this.btn_Wybierz_Click);
            // 
            // tb_Sciezka
            // 
            this.tb_Sciezka.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Sciezka.Location = new System.Drawing.Point(12, 13);
            this.tb_Sciezka.Name = "tb_Sciezka";
            this.tb_Sciezka.Size = new System.Drawing.Size(359, 20);
            this.tb_Sciezka.TabIndex = 1;
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // btn_Oblicz
            // 
            this.btn_Oblicz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Oblicz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Oblicz.Location = new System.Drawing.Point(40, 475);
            this.btn_Oblicz.Name = "btn_Oblicz";
            this.btn_Oblicz.Size = new System.Drawing.Size(352, 63);
            this.btn_Oblicz.TabIndex = 2;
            this.btn_Oblicz.Text = "Oblicz";
            this.btn_Oblicz.UseVisualStyleBackColor = true;
            this.btn_Oblicz.Click += new System.EventHandler(this.btn_Oblicz_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(12, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(414, 404);
            this.textBox1.TabIndex = 3;
            // 
            // tb_LiczbaAtrybutow
            // 
            this.tb_LiczbaAtrybutow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_LiczbaAtrybutow.Location = new System.Drawing.Point(168, 39);
            this.tb_LiczbaAtrybutow.Name = "tb_LiczbaAtrybutow";
            this.tb_LiczbaAtrybutow.Size = new System.Drawing.Size(100, 20);
            this.tb_LiczbaAtrybutow.TabIndex = 4;
            this.tb_LiczbaAtrybutow.Text = "1";
            this.tb_LiczbaAtrybutow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liczba Atrybutów do Separacji";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_LiczbaAtrybutow);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Oblicz);
            this.Controls.Add(this.tb_Sciezka);
            this.Controls.Add(this.btn_Wybierz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(457, 587);
            this.MinimumSize = new System.Drawing.Size(457, 587);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Separacja Atrybutów - Piotr Uszler";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Wybierz;
        private System.Windows.Forms.TextBox tb_Sciezka;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btn_Oblicz;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_LiczbaAtrybutow;
        private System.Windows.Forms.Label label1;
    }
}

