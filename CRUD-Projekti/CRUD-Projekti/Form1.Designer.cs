namespace CRUD_Projekti
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
            this.vaihdaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.otsikkoLB.Location = new System.Drawing.Point(172, 9);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(63, 21);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Otsikko";
            // 
            // vaihdaBT
            // 
            this.vaihdaBT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vaihdaBT.Location = new System.Drawing.Point(172, 48);
            this.vaihdaBT.Name = "vaihdaBT";
            this.vaihdaBT.Size = new System.Drawing.Size(106, 30);
            this.vaihdaBT.TabIndex = 1;
            this.vaihdaBT.Text = "Vaihda teksti";
            this.vaihdaBT.UseVisualStyleBackColor = true;
            this.vaihdaBT.Click += new System.EventHandler(this.vaihdaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 99);
            this.Controls.Add(this.vaihdaBT);
            this.Controls.Add(this.otsikkoLB);
            this.Name = "Form1";
            this.Text = "Harjoitus 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkoLB;
        private Button vaihdaBT;
    }
}