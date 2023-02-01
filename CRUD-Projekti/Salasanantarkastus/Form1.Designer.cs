namespace Salasanantarkastus
{
    partial class salasanaForm
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
            this.salasanaPanel = new System.Windows.Forms.Panel();
            this.virheviestiLB = new System.Windows.Forms.Label();
            this.tarkistaBT = new System.Windows.Forms.Button();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.salasanaLB = new System.Windows.Forms.Label();
            this.kayttajaLB = new System.Windows.Forms.Label();
            this.SalasanaOikeinPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.salasanaPanel.SuspendLayout();
            this.SalasanaOikeinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // salasanaPanel
            // 
            this.salasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.salasanaPanel.Controls.Add(this.virheviestiLB);
            this.salasanaPanel.Controls.Add(this.tarkistaBT);
            this.salasanaPanel.Controls.Add(this.salasanaTB);
            this.salasanaPanel.Controls.Add(this.kayttajaTB);
            this.salasanaPanel.Controls.Add(this.salasanaLB);
            this.salasanaPanel.Controls.Add(this.kayttajaLB);
            this.salasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salasanaPanel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.salasanaPanel.Name = "salasanaPanel";
            this.salasanaPanel.Size = new System.Drawing.Size(570, 191);
            this.salasanaPanel.TabIndex = 0;
            // 
            // virheviestiLB
            // 
            this.virheviestiLB.AutoSize = true;
            this.virheviestiLB.ForeColor = System.Drawing.Color.Orange;
            this.virheviestiLB.Location = new System.Drawing.Point(12, 134);
            this.virheviestiLB.Name = "virheviestiLB";
            this.virheviestiLB.Size = new System.Drawing.Size(78, 32);
            this.virheviestiLB.TabIndex = 5;
            this.virheviestiLB.Text = "label1";
            this.virheviestiLB.Visible = false;
            // 
            // tarkistaBT
            // 
            this.tarkistaBT.Location = new System.Drawing.Point(10, 65);
            this.tarkistaBT.Name = "tarkistaBT";
            this.tarkistaBT.Size = new System.Drawing.Size(102, 42);
            this.tarkistaBT.TabIndex = 4;
            this.tarkistaBT.Text = "Tarkista";
            this.tarkistaBT.UseVisualStyleBackColor = true;
            this.tarkistaBT.Click += new System.EventHandler(this.tarkistaBT_Click);
            // 
            // salasanaTB
            // 
            this.salasanaTB.Location = new System.Drawing.Point(234, 68);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(316, 39);
            this.salasanaTB.TabIndex = 3;
            this.salasanaTB.TextChanged += new System.EventHandler(this.salasanaTB_TextChanged);
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Location = new System.Drawing.Point(234, 23);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(316, 39);
            this.kayttajaTB.TabIndex = 2;
            this.kayttajaTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // salasanaLB
            // 
            this.salasanaLB.AutoSize = true;
            this.salasanaLB.ForeColor = System.Drawing.Color.Orange;
            this.salasanaLB.Location = new System.Drawing.Point(118, 71);
            this.salasanaLB.Name = "salasanaLB";
            this.salasanaLB.Size = new System.Drawing.Size(110, 32);
            this.salasanaLB.TabIndex = 1;
            this.salasanaLB.Text = "Salasana:";
            // 
            // kayttajaLB
            // 
            this.kayttajaLB.AutoSize = true;
            this.kayttajaLB.ForeColor = System.Drawing.Color.Orange;
            this.kayttajaLB.Location = new System.Drawing.Point(51, 26);
            this.kayttajaLB.Name = "kayttajaLB";
            this.kayttajaLB.Size = new System.Drawing.Size(177, 32);
            this.kayttajaLB.TabIndex = 0;
            this.kayttajaLB.Text = "Käyttäjätunnus:";
            // 
            // SalasanaOikeinPanel
            // 
            this.SalasanaOikeinPanel.BackColor = System.Drawing.Color.DarkRed;
            this.SalasanaOikeinPanel.Controls.Add(this.label1);
            this.SalasanaOikeinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaOikeinPanel.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SalasanaOikeinPanel.ForeColor = System.Drawing.Color.Snow;
            this.SalasanaOikeinPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            this.SalasanaOikeinPanel.Size = new System.Drawing.Size(570, 191);
            this.SalasanaOikeinPanel.TabIndex = 6;
            this.SalasanaOikeinPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tervetuloa Sivuilleni";
            // 
            // salasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 191);
            this.Controls.Add(this.salasanaPanel);
            this.Controls.Add(this.SalasanaOikeinPanel);
            this.Name = "salasanaForm";
            this.Text = "Salasanan tarkastus";
            this.salasanaPanel.ResumeLayout(false);
            this.salasanaPanel.PerformLayout();
            this.SalasanaOikeinPanel.ResumeLayout(false);
            this.SalasanaOikeinPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Panel salasanaPanel;
        private Label virheviestiLB;
        private Button tarkistaBT;
        private TextBox salasanaTB;
        private TextBox kayttajaTB;
        private Label salasanaLB;
        private Label kayttajaLB;
        private Panel SalasanaOikeinPanel;
        private Label label1;
    }
}