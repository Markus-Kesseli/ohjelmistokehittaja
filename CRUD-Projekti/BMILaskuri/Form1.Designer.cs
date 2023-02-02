namespace BMILaskuri
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
            this.painoTB = new System.Windows.Forms.TextBox();
            this.pituusTB = new System.Windows.Forms.TextBox();
            this.tulosLB = new System.Windows.Forms.Label();
            this.laskeBT = new System.Windows.Forms.Button();
            this.painoLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna paino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna pituus:";
            // 
            // painoTB
            // 
            this.painoTB.Location = new System.Drawing.Point(112, 32);
            this.painoTB.Name = "painoTB";
            this.painoTB.Size = new System.Drawing.Size(100, 23);
            this.painoTB.TabIndex = 2;
            // 
            // pituusTB
            // 
            this.pituusTB.Location = new System.Drawing.Point(112, 71);
            this.pituusTB.Name = "pituusTB";
            this.pituusTB.Size = new System.Drawing.Size(100, 23);
            this.pituusTB.TabIndex = 3;
            // 
            // tulosLB
            // 
            this.tulosLB.AutoSize = true;
            this.tulosLB.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tulosLB.Location = new System.Drawing.Point(12, 168);
            this.tulosLB.Name = "tulosLB";
            this.tulosLB.Size = new System.Drawing.Size(48, 21);
            this.tulosLB.TabIndex = 4;
            this.tulosLB.Text = "label3";
            this.tulosLB.Visible = false;
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(12, 126);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(200, 23);
            this.laskeBT.TabIndex = 5;
            this.laskeBT.Text = "Laske painoindeksi";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // painoLB
            // 
            this.painoLB.AutoSize = true;
            this.painoLB.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.painoLB.Location = new System.Drawing.Point(11, 189);
            this.painoLB.Name = "painoLB";
            this.painoLB.Size = new System.Drawing.Size(48, 21);
            this.painoLB.TabIndex = 6;
            this.painoLB.Text = "label3";
            this.painoLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 230);
            this.Controls.Add(this.painoLB);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.tulosLB);
            this.Controls.Add(this.pituusTB);
            this.Controls.Add(this.painoTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BMI-Laskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox painoTB;
        private TextBox pituusTB;
        private Label tulosLB;
        private Button laskeBT;
        private Label painoLB;
    }
}