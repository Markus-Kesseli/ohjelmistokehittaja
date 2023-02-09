namespace Ajastin
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
            this.components = new System.ComponentModel.Container();
            this.minuutitCB = new System.Windows.Forms.ComboBox();
            this.sekunnitCB = new System.Windows.Forms.ComboBox();
            this.aloitaBT = new System.Windows.Forms.Button();
            this.lopetaBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aikaLB = new System.Windows.Forms.Label();
            this.aikaTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // minuutitCB
            // 
            this.minuutitCB.FormattingEnabled = true;
            this.minuutitCB.Location = new System.Drawing.Point(12, 35);
            this.minuutitCB.Name = "minuutitCB";
            this.minuutitCB.Size = new System.Drawing.Size(85, 23);
            this.minuutitCB.TabIndex = 0;
            // 
            // sekunnitCB
            // 
            this.sekunnitCB.FormattingEnabled = true;
            this.sekunnitCB.Location = new System.Drawing.Point(124, 35);
            this.sekunnitCB.Name = "sekunnitCB";
            this.sekunnitCB.Size = new System.Drawing.Size(85, 23);
            this.sekunnitCB.TabIndex = 1;
            // 
            // aloitaBT
            // 
            this.aloitaBT.Location = new System.Drawing.Point(12, 143);
            this.aloitaBT.Name = "aloitaBT";
            this.aloitaBT.Size = new System.Drawing.Size(75, 23);
            this.aloitaBT.TabIndex = 2;
            this.aloitaBT.Text = "Aloita";
            this.aloitaBT.UseVisualStyleBackColor = true;
            this.aloitaBT.Click += new System.EventHandler(this.aloitaBT_Click);
            // 
            // lopetaBT
            // 
            this.lopetaBT.Location = new System.Drawing.Point(135, 143);
            this.lopetaBT.Name = "lopetaBT";
            this.lopetaBT.Size = new System.Drawing.Size(75, 23);
            this.lopetaBT.TabIndex = 3;
            this.lopetaBT.Text = "Lopeta";
            this.lopetaBT.UseVisualStyleBackColor = true;
            this.lopetaBT.Click += new System.EventHandler(this.lopetaBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Minuutit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sekunnit";
            // 
            // aikaLB
            // 
            this.aikaLB.AutoSize = true;
            this.aikaLB.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aikaLB.Location = new System.Drawing.Point(56, 78);
            this.aikaLB.Name = "aikaLB";
            this.aikaLB.Size = new System.Drawing.Size(109, 47);
            this.aikaLB.TabIndex = 6;
            this.aikaLB.Text = "00:00";
            // 
            // aikaTM
            // 
            this.aikaTM.Tick += new System.EventHandler(this.aikaTM_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 178);
            this.Controls.Add(this.aikaLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lopetaBT);
            this.Controls.Add(this.aloitaBT);
            this.Controls.Add(this.sekunnitCB);
            this.Controls.Add(this.minuutitCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox minuutitCB;
        private ComboBox sekunnitCB;
        private Button aloitaBT;
        private Button lopetaBT;
        private Label label1;
        private Label label2;
        private Label aikaLB;
        private System.Windows.Forms.Timer aikaTM;
    }
}