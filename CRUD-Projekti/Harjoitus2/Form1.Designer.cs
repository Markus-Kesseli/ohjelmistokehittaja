namespace Harjoitus2
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
            this.otsikkoLB = new System.Windows.Forms.Label();
            this.viestiTB = new System.Windows.Forms.TextBox();
            this.tulostusLB = new System.Windows.Forms.Label();
            this.tulostaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.otsikkoLB.Location = new System.Drawing.Point(16, 50);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(283, 34);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Anna tulostettava teksti";
            // 
            // viestiTB
            // 
            this.viestiTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viestiTB.Location = new System.Drawing.Point(336, 50);
            this.viestiTB.Name = "viestiTB";
            this.viestiTB.Size = new System.Drawing.Size(440, 35);
            this.viestiTB.TabIndex = 1;
            // 
            // tulostusLB
            // 
            this.tulostusLB.AutoSize = true;
            this.tulostusLB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tulostusLB.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tulostusLB.Location = new System.Drawing.Point(49, 137);
            this.tulostusLB.Name = "tulostusLB";
            this.tulostusLB.Size = new System.Drawing.Size(48, 28);
            this.tulostusLB.TabIndex = 2;
            this.tulostusLB.Text = "XXX";
            this.tulostusLB.Visible = false;
            // 
            // tulostaBT
            // 
            this.tulostaBT.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tulostaBT.ForeColor = System.Drawing.Color.Green;
            this.tulostaBT.Location = new System.Drawing.Point(663, 137);
            this.tulostaBT.Name = "tulostaBT";
            this.tulostaBT.Size = new System.Drawing.Size(128, 36);
            this.tulostaBT.TabIndex = 3;
            this.tulostaBT.Text = "Tulosta teksti";
            this.tulostaBT.UseVisualStyleBackColor = true;
            this.tulostaBT.Click += new System.EventHandler(this.tulostaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(803, 189);
            this.Controls.Add(this.tulostaBT);
            this.Controls.Add(this.tulostusLB);
            this.Controls.Add(this.viestiTB);
            this.Controls.Add(this.otsikkoLB);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Name = "Form1";
            this.Text = "Harjoitus 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkoLB;
        private TextBox viestiTB;
        private Label tulostusLB;
        private Button tulostaBT;
    }
}