namespace OppilaitosAvainHenkilöt
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
            this.oppilaitoksetCB = new System.Windows.Forms.ComboBox();
            this.vastuuhloCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.katuosoiteLB = new System.Windows.Forms.Label();
            this.postinumeroLB = new System.Windows.Forms.Label();
            this.postitoimipaikkaLB = new System.Windows.Forms.Label();
            this.puhelinLB = new System.Windows.Forms.Label();
            this.titteliLB = new System.Windows.Forms.Label();
            this.sijaintiLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.phoneLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oppilaitoksetCB
            // 
            this.oppilaitoksetCB.FormattingEnabled = true;
            this.oppilaitoksetCB.Location = new System.Drawing.Point(29, 110);
            this.oppilaitoksetCB.Name = "oppilaitoksetCB";
            this.oppilaitoksetCB.Size = new System.Drawing.Size(121, 23);
            this.oppilaitoksetCB.TabIndex = 0;
            this.oppilaitoksetCB.SelectedIndexChanged += new System.EventHandler(this.oppilaitoksetCB_SelectedIndexChanged);
            // 
            // vastuuhloCB
            // 
            this.vastuuhloCB.FormattingEnabled = true;
            this.vastuuhloCB.Location = new System.Drawing.Point(238, 110);
            this.vastuuhloCB.Name = "vastuuhloCB";
            this.vastuuhloCB.Size = new System.Drawing.Size(121, 23);
            this.vastuuhloCB.TabIndex = 1;
            this.vastuuhloCB.SelectedIndexChanged += new System.EventHandler(this.vastuuhloCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valitse vastuuhenkilö:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valitse oppilaitos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Oppilaitosten avainhenkilöt";
            // 
            // katuosoiteLB
            // 
            this.katuosoiteLB.AutoSize = true;
            this.katuosoiteLB.Location = new System.Drawing.Point(29, 163);
            this.katuosoiteLB.Name = "katuosoiteLB";
            this.katuosoiteLB.Size = new System.Drawing.Size(62, 15);
            this.katuosoiteLB.TabIndex = 5;
            this.katuosoiteLB.Text = "katuosoite";
            // 
            // postinumeroLB
            // 
            this.postinumeroLB.AutoSize = true;
            this.postinumeroLB.Location = new System.Drawing.Point(29, 200);
            this.postinumeroLB.Name = "postinumeroLB";
            this.postinumeroLB.Size = new System.Drawing.Size(75, 15);
            this.postinumeroLB.TabIndex = 6;
            this.postinumeroLB.Text = "postinumero";
            // 
            // postitoimipaikkaLB
            // 
            this.postitoimipaikkaLB.AutoSize = true;
            this.postitoimipaikkaLB.Location = new System.Drawing.Point(29, 240);
            this.postitoimipaikkaLB.Name = "postitoimipaikkaLB";
            this.postitoimipaikkaLB.Size = new System.Drawing.Size(95, 15);
            this.postitoimipaikkaLB.TabIndex = 7;
            this.postitoimipaikkaLB.Text = "postitoimipaikka";
            // 
            // puhelinLB
            // 
            this.puhelinLB.AutoSize = true;
            this.puhelinLB.Location = new System.Drawing.Point(29, 278);
            this.puhelinLB.Name = "puhelinLB";
            this.puhelinLB.Size = new System.Drawing.Size(47, 15);
            this.puhelinLB.TabIndex = 8;
            this.puhelinLB.Text = "puhelin";
            // 
            // titteliLB
            // 
            this.titteliLB.AutoSize = true;
            this.titteliLB.Location = new System.Drawing.Point(238, 163);
            this.titteliLB.Name = "titteliLB";
            this.titteliLB.Size = new System.Drawing.Size(34, 15);
            this.titteliLB.TabIndex = 9;
            this.titteliLB.Text = "titteli";
            // 
            // sijaintiLB
            // 
            this.sijaintiLB.AutoSize = true;
            this.sijaintiLB.Location = new System.Drawing.Point(238, 200);
            this.sijaintiLB.Name = "sijaintiLB";
            this.sijaintiLB.Size = new System.Drawing.Size(41, 15);
            this.sijaintiLB.TabIndex = 10;
            this.sijaintiLB.Text = "sijainti";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Location = new System.Drawing.Point(238, 240);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(64, 15);
            this.emailLB.TabIndex = 11;
            this.emailLB.Text = "sähköposti";
            // 
            // phoneLB
            // 
            this.phoneLB.AutoSize = true;
            this.phoneLB.Location = new System.Drawing.Point(238, 278);
            this.phoneLB.Name = "phoneLB";
            this.phoneLB.Size = new System.Drawing.Size(28, 15);
            this.phoneLB.TabIndex = 12;
            this.phoneLB.Text = "puh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 308);
            this.Controls.Add(this.phoneLB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.sijaintiLB);
            this.Controls.Add(this.titteliLB);
            this.Controls.Add(this.puhelinLB);
            this.Controls.Add(this.postitoimipaikkaLB);
            this.Controls.Add(this.postinumeroLB);
            this.Controls.Add(this.katuosoiteLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vastuuhloCB);
            this.Controls.Add(this.oppilaitoksetCB);
            this.Name = "Form1";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox oppilaitoksetCB;
        private ComboBox vastuuhloCB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label katuosoiteLB;
        private Label postinumeroLB;
        private Label postitoimipaikkaLB;
        private Label puhelinLB;
        private Label titteliLB;
        private Label sijaintiLB;
        private Label emailLB;
        private Label phoneLB;
    }
}