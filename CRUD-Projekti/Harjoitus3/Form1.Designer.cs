namespace Harjoitus3
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
            this.lukuyksiTB = new System.Windows.Forms.TextBox();
            this.lukukaksiTB = new System.Windows.Forms.TextBox();
            this.laskutoimitusCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.laskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lukuyksiTB
            // 
            this.lukuyksiTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lukuyksiTB.Location = new System.Drawing.Point(24, 53);
            this.lukuyksiTB.Name = "lukuyksiTB";
            this.lukuyksiTB.Size = new System.Drawing.Size(100, 35);
            this.lukuyksiTB.TabIndex = 0;
            // 
            // lukukaksiTB
            // 
            this.lukukaksiTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lukukaksiTB.Location = new System.Drawing.Point(187, 53);
            this.lukukaksiTB.Name = "lukukaksiTB";
            this.lukukaksiTB.Size = new System.Drawing.Size(100, 35);
            this.lukukaksiTB.TabIndex = 1;
            // 
            // laskutoimitusCB
            // 
            this.laskutoimitusCB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laskutoimitusCB.FormattingEnabled = true;
            this.laskutoimitusCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.laskutoimitusCB.Location = new System.Drawing.Point(130, 50);
            this.laskutoimitusCB.Name = "laskutoimitusCB";
            this.laskutoimitusCB.Size = new System.Drawing.Size(51, 38);
            this.laskutoimitusCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(293, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(326, 54);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(25, 30);
            this.vastausLB.TabIndex = 4;
            this.vastausLB.Text = "X";
            this.vastausLB.Visible = false;
            // 
            // laskeBT
            // 
            this.laskeBT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laskeBT.Location = new System.Drawing.Point(368, 50);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(90, 37);
            this.laskeBT.TabIndex = 5;
            this.laskeBT.Text = "Laske";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 136);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laskutoimitusCB);
            this.Controls.Add(this.lukukaksiTB);
            this.Controls.Add(this.lukuyksiTB);
            this.Name = "Form1";
            this.Text = "Harjoitus 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox lukuyksiTB;
        private TextBox lukukaksiTB;
        private ComboBox laskutoimitusCB;
        private Label label1;
        private Label vastausLB;
        private Button laskeBT;
    }
}