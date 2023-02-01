namespace AutoKuluLaskuri
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lainaTB = new System.Windows.Forms.TextBox();
            this.nesteetTB = new System.Windows.Forms.TextBox();
            this.vakuutusTB = new System.Windows.Forms.TextBox();
            this.muutTB = new System.Windows.Forms.TextBox();
            this.polttoaineTB = new System.Windows.Forms.TextBox();
            this.pesutTB = new System.Windows.Forms.TextBox();
            this.huoltoTB = new System.Windows.Forms.TextBox();
            this.renkaatTB = new System.Windows.Forms.TextBox();
            this.kilometritCB = new System.Windows.Forms.ComboBox();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auton kustannuslaskuri";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lainan lyhennys korkoineen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lisättävät nesteet yms:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vakuutusmaksut:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Muut kulut:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Polttoaine:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(399, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pesut:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(399, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Huollot:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(399, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Renkaat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(377, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Kilometrin/vuosi:";
            // 
            // lainaTB
            // 
            this.lainaTB.Location = new System.Drawing.Point(239, 99);
            this.lainaTB.Name = "lainaTB";
            this.lainaTB.Size = new System.Drawing.Size(100, 23);
            this.lainaTB.TabIndex = 10;
            // 
            // nesteetTB
            // 
            this.nesteetTB.Location = new System.Drawing.Point(239, 145);
            this.nesteetTB.Name = "nesteetTB";
            this.nesteetTB.Size = new System.Drawing.Size(100, 23);
            this.nesteetTB.TabIndex = 11;
            // 
            // vakuutusTB
            // 
            this.vakuutusTB.Location = new System.Drawing.Point(239, 188);
            this.vakuutusTB.Name = "vakuutusTB";
            this.vakuutusTB.Size = new System.Drawing.Size(100, 23);
            this.vakuutusTB.TabIndex = 12;
            // 
            // muutTB
            // 
            this.muutTB.Location = new System.Drawing.Point(239, 232);
            this.muutTB.Name = "muutTB";
            this.muutTB.Size = new System.Drawing.Size(100, 23);
            this.muutTB.TabIndex = 13;
            // 
            // polttoaineTB
            // 
            this.polttoaineTB.Location = new System.Drawing.Point(239, 278);
            this.polttoaineTB.Name = "polttoaineTB";
            this.polttoaineTB.Size = new System.Drawing.Size(100, 23);
            this.polttoaineTB.TabIndex = 14;
            // 
            // pesutTB
            // 
            this.pesutTB.Location = new System.Drawing.Point(523, 99);
            this.pesutTB.Name = "pesutTB";
            this.pesutTB.Size = new System.Drawing.Size(100, 23);
            this.pesutTB.TabIndex = 15;
            // 
            // huoltoTB
            // 
            this.huoltoTB.Location = new System.Drawing.Point(523, 148);
            this.huoltoTB.Name = "huoltoTB";
            this.huoltoTB.Size = new System.Drawing.Size(100, 23);
            this.huoltoTB.TabIndex = 16;
            // 
            // renkaatTB
            // 
            this.renkaatTB.Location = new System.Drawing.Point(523, 191);
            this.renkaatTB.Name = "renkaatTB";
            this.renkaatTB.Size = new System.Drawing.Size(100, 23);
            this.renkaatTB.TabIndex = 17;
            // 
            // kilometritCB
            // 
            this.kilometritCB.FormattingEnabled = true;
            this.kilometritCB.Items.AddRange(new object[] {
            "10000",
            "20000",
            "30000",
            "40000",
            "50000"});
            this.kilometritCB.Location = new System.Drawing.Point(523, 235);
            this.kilometritCB.Name = "kilometritCB";
            this.kilometritCB.Size = new System.Drawing.Size(100, 23);
            this.kilometritCB.TabIndex = 18;
            this.kilometritCB.SelectedIndexChanged += new System.EventHandler(this.kilometritCB_SelectedIndexChanged);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(12, 321);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(72, 28);
            this.vastausLB.TabIndex = 19;
            this.vastausLB.Text = "vastaus";
            this.vastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 358);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.kilometritCB);
            this.Controls.Add(this.renkaatTB);
            this.Controls.Add(this.huoltoTB);
            this.Controls.Add(this.pesutTB);
            this.Controls.Add(this.polttoaineTB);
            this.Controls.Add(this.muutTB);
            this.Controls.Add(this.vakuutusTB);
            this.Controls.Add(this.nesteetTB);
            this.Controls.Add(this.lainaTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Auton kustannuslaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox lainaTB;
        private TextBox nesteetTB;
        private TextBox vakuutusTB;
        private TextBox muutTB;
        private TextBox polttoaineTB;
        private TextBox pesutTB;
        private TextBox huoltoTB;
        private TextBox renkaatTB;
        private ComboBox kilometritCB;
        private Label vastausLB;
    }
}