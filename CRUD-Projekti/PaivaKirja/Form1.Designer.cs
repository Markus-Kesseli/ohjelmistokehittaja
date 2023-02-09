namespace PaivaKirja
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
            this.tekstiTB = new System.Windows.Forms.TextBox();
            this.tallennaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tekstiTB
            // 
            this.tekstiTB.Location = new System.Drawing.Point(12, 12);
            this.tekstiTB.Multiline = true;
            this.tekstiTB.Name = "tekstiTB";
            this.tekstiTB.Size = new System.Drawing.Size(674, 287);
            this.tekstiTB.TabIndex = 0;
            // 
            // tallennaBT
            // 
            this.tallennaBT.Location = new System.Drawing.Point(302, 305);
            this.tallennaBT.Name = "tallennaBT";
            this.tallennaBT.Size = new System.Drawing.Size(105, 35);
            this.tallennaBT.TabIndex = 1;
            this.tallennaBT.Text = "Tallenna";
            this.tallennaBT.UseVisualStyleBackColor = true;
            this.tallennaBT.Click += new System.EventHandler(this.tallennaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 350);
            this.Controls.Add(this.tallennaBT);
            this.Controls.Add(this.tekstiTB);
            this.Name = "Form1";
            this.Text = "Päiväkirja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tekstiTB;
        private Button tallennaBT;
    }
}