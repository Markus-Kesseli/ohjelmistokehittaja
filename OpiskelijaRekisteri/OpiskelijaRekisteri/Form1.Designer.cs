namespace OpiskelijaRekisteri
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tietotauluDG = new System.Windows.Forms.DataGridView();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.tallennaBT = new System.Windows.Forms.Button();
            this.paivitaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.idLB = new System.Windows.Forms.TextBox();
            this.enimiLB = new System.Windows.Forms.TextBox();
            this.snimiLB = new System.Windows.Forms.TextBox();
            this.puhLB = new System.Windows.Forms.TextBox();
            this.emailLB = new System.Windows.Forms.TextBox();
            this.onroLB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // tietotauluDG
            // 
            this.tietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tietotauluDG.Location = new System.Drawing.Point(12, 188);
            this.tietotauluDG.Name = "tietotauluDG";
            this.tietotauluDG.Size = new System.Drawing.Size(776, 250);
            this.tietotauluDG.TabIndex = 0;
            this.tietotauluDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tietotauluDG_CellContentClick);
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Location = new System.Drawing.Point(12, 138);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(110, 40);
            this.tyhjennaBT.TabIndex = 1;
            this.tyhjennaBT.Text = "Tyhjennä";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // tallennaBT
            // 
            this.tallennaBT.Location = new System.Drawing.Point(128, 138);
            this.tallennaBT.Name = "tallennaBT";
            this.tallennaBT.Size = new System.Drawing.Size(110, 40);
            this.tallennaBT.TabIndex = 2;
            this.tallennaBT.Text = "Tallenna";
            this.tallennaBT.UseVisualStyleBackColor = true;
            // 
            // paivitaBT
            // 
            this.paivitaBT.Location = new System.Drawing.Point(244, 138);
            this.paivitaBT.Name = "paivitaBT";
            this.paivitaBT.Size = new System.Drawing.Size(110, 40);
            this.paivitaBT.TabIndex = 3;
            this.paivitaBT.Text = "Päivitä";
            this.paivitaBT.UseVisualStyleBackColor = true;
            // 
            // poistaBT
            // 
            this.poistaBT.Location = new System.Drawing.Point(360, 138);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(110, 40);
            this.poistaBT.TabIndex = 4;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            // 
            // idLB
            // 
            this.idLB.Location = new System.Drawing.Point(128, 25);
            this.idLB.Name = "idLB";
            this.idLB.Size = new System.Drawing.Size(125, 20);
            this.idLB.TabIndex = 5;
            // 
            // enimiLB
            // 
            this.enimiLB.Location = new System.Drawing.Point(128, 51);
            this.enimiLB.Name = "enimiLB";
            this.enimiLB.Size = new System.Drawing.Size(125, 20);
            this.enimiLB.TabIndex = 6;
            // 
            // snimiLB
            // 
            this.snimiLB.Location = new System.Drawing.Point(128, 78);
            this.snimiLB.Name = "snimiLB";
            this.snimiLB.Size = new System.Drawing.Size(125, 20);
            this.snimiLB.TabIndex = 7;
            // 
            // puhLB
            // 
            this.puhLB.Location = new System.Drawing.Point(401, 24);
            this.puhLB.Name = "puhLB";
            this.puhLB.Size = new System.Drawing.Size(125, 20);
            this.puhLB.TabIndex = 8;
            // 
            // emailLB
            // 
            this.emailLB.Location = new System.Drawing.Point(401, 51);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(125, 20);
            this.emailLB.TabIndex = 9;
            // 
            // onroLB
            // 
            this.onroLB.Location = new System.Drawing.Point(401, 78);
            this.onroLB.Name = "onroLB";
            this.onroLB.Size = new System.Drawing.Size(125, 20);
            this.onroLB.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Etunimi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sukunimi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(277, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Puhelin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(277, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sähköposti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(277, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Opiskelijanro:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onroLB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.puhLB);
            this.Controls.Add(this.snimiLB);
            this.Controls.Add(this.enimiLB);
            this.Controls.Add(this.idLB);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.paivitaBT);
            this.Controls.Add(this.tallennaBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.tietotauluDG);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tietotauluDG;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button tallennaBT;
        private System.Windows.Forms.Button paivitaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.TextBox idLB;
        private System.Windows.Forms.TextBox enimiLB;
        private System.Windows.Forms.TextBox snimiLB;
        private System.Windows.Forms.TextBox puhLB;
        private System.Windows.Forms.TextBox emailLB;
        private System.Windows.Forms.TextBox onroLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

