namespace RoomalaisetNro
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
            this.muutaBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nroTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // muutaBT
            // 
            this.muutaBT.Location = new System.Drawing.Point(595, 109);
            this.muutaBT.Name = "muutaBT";
            this.muutaBT.Size = new System.Drawing.Size(76, 23);
            this.muutaBT.TabIndex = 0;
            this.muutaBT.Text = "Muuta";
            this.muutaBT.UseVisualStyleBackColor = true;
            this.muutaBT.Click += new System.EventHandler(this.muutaBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 88);
            this.label1.TabIndex = 1;
            this.label1.Text = "Roomalaiset numerot";
            // 
            // nroTB
            // 
            this.nroTB.Location = new System.Drawing.Point(481, 109);
            this.nroTB.Name = "nroTB";
            this.nroTB.Size = new System.Drawing.Size(108, 23);
            this.nroTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anna numero välillä 1-3999, niin muutan sen roomalaiseksi:";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(300, 193);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(88, 59);
            this.vastausLB.TabIndex = 4;
            this.vastausLB.Text = "label3";
            this.vastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 306);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nroTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.muutaBT);
            this.Name = "Form1";
            this.Text = "Roomalaiset numerot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button muutaBT;
        private Label label1;
        private TextBox nroTB;
        private Label label2;
        private Label vastausLB;
    }
}