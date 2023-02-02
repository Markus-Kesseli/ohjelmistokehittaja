namespace CelciusToFahrenheit
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
            this.lukuTB = new System.Windows.Forms.TextBox();
            this.muunnaBT = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.celsiusRB = new System.Windows.Forms.RadioButton();
            this.fahrenheitRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lukuTB
            // 
            this.lukuTB.Location = new System.Drawing.Point(127, 58);
            this.lukuTB.Name = "lukuTB";
            this.lukuTB.Size = new System.Drawing.Size(73, 23);
            this.lukuTB.TabIndex = 0;
            // 
            // muunnaBT
            // 
            this.muunnaBT.Location = new System.Drawing.Point(379, 58);
            this.muunnaBT.Name = "muunnaBT";
            this.muunnaBT.Size = new System.Drawing.Size(75, 23);
            this.muunnaBT.TabIndex = 3;
            this.muunnaBT.Text = "Muunna";
            this.muunnaBT.UseVisualStyleBackColor = true;
            this.muunnaBT.Click += new System.EventHandler(this.muunnaBT_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(230, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(117, 90);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Anna lämpötila:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(243, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mitä muunnat?";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.BackColor = System.Drawing.Color.Transparent;
            this.vastausLB.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(12, 105);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(71, 28);
            this.vastausLB.TabIndex = 7;
            this.vastausLB.Text = "vastaus";
            this.vastausLB.Visible = false;
            // 
            // celsiusRB
            // 
            this.celsiusRB.AutoSize = true;
            this.celsiusRB.BackColor = System.Drawing.Color.Transparent;
            this.celsiusRB.Location = new System.Drawing.Point(243, 45);
            this.celsiusRB.Name = "celsiusRB";
            this.celsiusRB.Size = new System.Drawing.Size(62, 19);
            this.celsiusRB.TabIndex = 8;
            this.celsiusRB.TabStop = true;
            this.celsiusRB.Text = "Celsius";
            this.celsiusRB.UseVisualStyleBackColor = false;
            // 
            // fahrenheitRB
            // 
            this.fahrenheitRB.AutoSize = true;
            this.fahrenheitRB.BackColor = System.Drawing.Color.Transparent;
            this.fahrenheitRB.Location = new System.Drawing.Point(243, 70);
            this.fahrenheitRB.Name = "fahrenheitRB";
            this.fahrenheitRB.Size = new System.Drawing.Size(81, 19);
            this.fahrenheitRB.TabIndex = 9;
            this.fahrenheitRB.TabStop = true;
            this.fahrenheitRB.Text = "Fahrenheit";
            this.fahrenheitRB.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 142);
            this.Controls.Add(this.fahrenheitRB);
            this.Controls.Add(this.celsiusRB);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.muunnaBT);
            this.Controls.Add(this.lukuTB);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox lukuTB;
        private Button muunnaBT;
        private ListView listView1;
        private Label label1;
        private Label label2;
        private Label vastausLB;
        private RadioButton celsiusRB;
        private RadioButton fahrenheitRB;
    }
}