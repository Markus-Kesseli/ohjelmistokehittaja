﻿namespace NopanHeitto
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
            this.noppa01PB = new System.Windows.Forms.PictureBox();
            this.noppa02PB = new System.Windows.Forms.PictureBox();
            this.heittoBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).BeginInit();
            this.SuspendLayout();
            // 
            // noppa01PB
            // 
            this.noppa01PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.noppa01PB.Image = global::NopanHeitto.Properties.Resources.dice01;
            this.noppa01PB.Location = new System.Drawing.Point(12, 49);
            this.noppa01PB.Name = "noppa01PB";
            this.noppa01PB.Size = new System.Drawing.Size(122, 133);
            this.noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.noppa01PB.TabIndex = 0;
            this.noppa01PB.TabStop = false;
            // 
            // noppa02PB
            // 
            this.noppa02PB.Image = global::NopanHeitto.Properties.Resources.dice01;
            this.noppa02PB.Location = new System.Drawing.Point(141, 49);
            this.noppa02PB.Name = "noppa02PB";
            this.noppa02PB.Size = new System.Drawing.Size(122, 133);
            this.noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.noppa02PB.TabIndex = 1;
            this.noppa02PB.TabStop = false;
            // 
            // heittoBT
            // 
            this.heittoBT.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heittoBT.Location = new System.Drawing.Point(12, 207);
            this.heittoBT.Name = "heittoBT";
            this.heittoBT.Size = new System.Drawing.Size(251, 30);
            this.heittoBT.TabIndex = 2;
            this.heittoBT.Text = "Heitä";
            this.heittoBT.UseVisualStyleBackColor = true;
            this.heittoBT.Click += new System.EventHandler(this.heittoBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nopan heitto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heittoBT);
            this.Controls.Add(this.noppa02PB);
            this.Controls.Add(this.noppa01PB);
            this.Name = "Form1";
            this.Text = "Nopan heitto";
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox noppa01PB;
        private PictureBox noppa02PB;
        private Button heittoBT;
        private Label label1;
    }
}