namespace Harjoitus4
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
            this.paivaDTB = new System.Windows.Forms.DateTimePicker();
            this.laskeBT = new System.Windows.Forms.Button();
            this.vuosiLB = new System.Windows.Forms.Label();
            this.kuukausiLB = new System.Windows.Forms.Label();
            this.paivaLB = new System.Windows.Forms.Label();
            this.tuntiLB = new System.Windows.Forms.Label();
            this.minuuttiLB = new System.Windows.Forms.Label();
            this.sekunttiLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paivaDTB
            // 
            this.paivaDTB.Location = new System.Drawing.Point(12, 28);
            this.paivaDTB.Name = "paivaDTB";
            this.paivaDTB.Size = new System.Drawing.Size(200, 23);
            this.paivaDTB.TabIndex = 0;
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(247, 28);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(75, 23);
            this.laskeBT.TabIndex = 1;
            this.laskeBT.Text = "Laske";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // vuosiLB
            // 
            this.vuosiLB.AutoSize = true;
            this.vuosiLB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vuosiLB.Location = new System.Drawing.Point(21, 77);
            this.vuosiLB.Name = "vuosiLB";
            this.vuosiLB.Size = new System.Drawing.Size(41, 17);
            this.vuosiLB.TabIndex = 2;
            this.vuosiLB.Text = "vuosi";
            this.vuosiLB.Visible = false;
            // 
            // kuukausiLB
            // 
            this.kuukausiLB.AutoSize = true;
            this.kuukausiLB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kuukausiLB.Location = new System.Drawing.Point(21, 137);
            this.kuukausiLB.Name = "kuukausiLB";
            this.kuukausiLB.Size = new System.Drawing.Size(63, 17);
            this.kuukausiLB.TabIndex = 3;
            this.kuukausiLB.Text = "kuukausi";
            this.kuukausiLB.Visible = false;
            // 
            // paivaLB
            // 
            this.paivaLB.AutoSize = true;
            this.paivaLB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paivaLB.Location = new System.Drawing.Point(21, 200);
            this.paivaLB.Name = "paivaLB";
            this.paivaLB.Size = new System.Drawing.Size(41, 17);
            this.paivaLB.TabIndex = 4;
            this.paivaLB.Text = "päivä";
            this.paivaLB.Visible = false;
            // 
            // tuntiLB
            // 
            this.tuntiLB.AutoSize = true;
            this.tuntiLB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tuntiLB.Location = new System.Drawing.Point(180, 77);
            this.tuntiLB.Name = "tuntiLB";
            this.tuntiLB.Size = new System.Drawing.Size(38, 17);
            this.tuntiLB.TabIndex = 5;
            this.tuntiLB.Text = "tunti";
            this.tuntiLB.Visible = false;
            // 
            // minuuttiLB
            // 
            this.minuuttiLB.AutoSize = true;
            this.minuuttiLB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minuuttiLB.Location = new System.Drawing.Point(180, 137);
            this.minuuttiLB.Name = "minuuttiLB";
            this.minuuttiLB.Size = new System.Drawing.Size(62, 17);
            this.minuuttiLB.TabIndex = 6;
            this.minuuttiLB.Text = "minuutti";
            this.minuuttiLB.Visible = false;
            // 
            // sekunttiLB
            // 
            this.sekunttiLB.AutoSize = true;
            this.sekunttiLB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sekunttiLB.Location = new System.Drawing.Point(180, 200);
            this.sekunttiLB.Name = "sekunttiLB";
            this.sekunttiLB.Size = new System.Drawing.Size(58, 17);
            this.sekunttiLB.TabIndex = 7;
            this.sekunttiLB.Text = "sekuntti";
            this.sekunttiLB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Syötä syntymäaika";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sekunttiLB);
            this.Controls.Add(this.minuuttiLB);
            this.Controls.Add(this.tuntiLB);
            this.Controls.Add(this.paivaLB);
            this.Controls.Add(this.kuukausiLB);
            this.Controls.Add(this.vuosiLB);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.paivaDTB);
            this.Name = "Form1";
            this.Text = "Tehtävä 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker paivaDTB;
        private Button laskeBT;
        private Label vuosiLB;
        private Label kuukausiLB;
        private Label paivaLB;
        private Label tuntiLB;
        private Label minuuttiLB;
        private Label sekunttiLB;
        private Label label1;
    }
}