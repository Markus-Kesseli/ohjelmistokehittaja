namespace SekuntiKello
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
            this.startBT = new System.Windows.Forms.Button();
            this.stopBT = new System.Windows.Forms.Button();
            this.resetBT = new System.Windows.Forms.Button();
            this.aikaLB = new System.Windows.Forms.Label();
            this.ajastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startBT
            // 
            this.startBT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBT.Location = new System.Drawing.Point(12, 151);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(77, 36);
            this.startBT.TabIndex = 0;
            this.startBT.Text = "Start";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // stopBT
            // 
            this.stopBT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopBT.Location = new System.Drawing.Point(118, 151);
            this.stopBT.Name = "stopBT";
            this.stopBT.Size = new System.Drawing.Size(81, 36);
            this.stopBT.TabIndex = 1;
            this.stopBT.Text = "Stop";
            this.stopBT.UseVisualStyleBackColor = true;
            this.stopBT.Click += new System.EventHandler(this.stopBT_Click);
            // 
            // resetBT
            // 
            this.resetBT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetBT.Location = new System.Drawing.Point(225, 151);
            this.resetBT.Name = "resetBT";
            this.resetBT.Size = new System.Drawing.Size(81, 36);
            this.resetBT.TabIndex = 2;
            this.resetBT.Text = "Reset";
            this.resetBT.UseVisualStyleBackColor = true;
            this.resetBT.Click += new System.EventHandler(this.resetBT_Click);
            // 
            // aikaLB
            // 
            this.aikaLB.AutoSize = true;
            this.aikaLB.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aikaLB.Location = new System.Drawing.Point(12, 42);
            this.aikaLB.Name = "aikaLB";
            this.aikaLB.Size = new System.Drawing.Size(292, 65);
            this.aikaLB.TabIndex = 3;
            this.aikaLB.Text = "00:00:00.000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 199);
            this.Controls.Add(this.aikaLB);
            this.Controls.Add(this.resetBT);
            this.Controls.Add(this.stopBT);
            this.Controls.Add(this.startBT);
            this.Name = "Form1";
            this.Text = "Sekuntikello";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startBT;
        private Button stopBT;
        private Button resetBT;
        private Label aikaLB;
        private System.Windows.Forms.Timer ajastinTM;
    }
}