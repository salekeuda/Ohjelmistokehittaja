namespace harjoitus18
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oppilaitosCB = new System.Windows.Forms.ComboBox();
            this.vastuuhenkiloCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.osoiteLB = new System.Windows.Forms.Label();
            this.postinumeroLB = new System.Windows.Forms.Label();
            this.postitoimipaikkaLB = new System.Windows.Forms.Label();
            this.puhelinLB = new System.Windows.Forms.Label();
            this.puhLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.osastoLB = new System.Windows.Forms.Label();
            this.titteliLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valitse oppilaitos";
            // 
            // oppilaitosCB
            // 
            this.oppilaitosCB.FormattingEnabled = true;
            this.oppilaitosCB.Location = new System.Drawing.Point(27, 99);
            this.oppilaitosCB.Name = "oppilaitosCB";
            this.oppilaitosCB.Size = new System.Drawing.Size(121, 21);
            this.oppilaitosCB.TabIndex = 2;
            // 
            // vastuuhenkiloCB
            // 
            this.vastuuhenkiloCB.FormattingEnabled = true;
            this.vastuuhenkiloCB.Location = new System.Drawing.Point(234, 99);
            this.vastuuhenkiloCB.Name = "vastuuhenkiloCB";
            this.vastuuhenkiloCB.Size = new System.Drawing.Size(178, 21);
            this.vastuuhenkiloCB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valitse vastuuhenkilö";
            // 
            // osoiteLB
            // 
            this.osoiteLB.AutoSize = true;
            this.osoiteLB.Location = new System.Drawing.Point(27, 137);
            this.osoiteLB.Name = "osoiteLB";
            this.osoiteLB.Size = new System.Drawing.Size(37, 13);
            this.osoiteLB.TabIndex = 5;
            this.osoiteLB.Text = "Osoite";
            this.osoiteLB.Click += new System.EventHandler(this.osoiteLB_Click);
            // 
            // postinumeroLB
            // 
            this.postinumeroLB.AutoSize = true;
            this.postinumeroLB.Location = new System.Drawing.Point(27, 165);
            this.postinumeroLB.Name = "postinumeroLB";
            this.postinumeroLB.Size = new System.Drawing.Size(65, 13);
            this.postinumeroLB.TabIndex = 6;
            this.postinumeroLB.Text = "Postinumero";
            this.postinumeroLB.Click += new System.EventHandler(this.postinumeroLB_Click);
            // 
            // postitoimipaikkaLB
            // 
            this.postitoimipaikkaLB.AutoSize = true;
            this.postitoimipaikkaLB.Location = new System.Drawing.Point(27, 194);
            this.postitoimipaikkaLB.Name = "postitoimipaikkaLB";
            this.postitoimipaikkaLB.Size = new System.Drawing.Size(83, 13);
            this.postitoimipaikkaLB.TabIndex = 7;
            this.postitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // puhelinLB
            // 
            this.puhelinLB.AutoSize = true;
            this.puhelinLB.Location = new System.Drawing.Point(27, 218);
            this.puhelinLB.Name = "puhelinLB";
            this.puhelinLB.Size = new System.Drawing.Size(42, 13);
            this.puhelinLB.TabIndex = 8;
            this.puhelinLB.Text = "Puhelin";
            // 
            // puhLB
            // 
            this.puhLB.AutoSize = true;
            this.puhLB.Location = new System.Drawing.Point(231, 218);
            this.puhLB.Name = "puhLB";
            this.puhLB.Size = new System.Drawing.Size(42, 13);
            this.puhLB.TabIndex = 12;
            this.puhLB.Text = "Puhelin";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Location = new System.Drawing.Point(231, 194);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(60, 13);
            this.emailLB.TabIndex = 11;
            this.emailLB.Text = "Sähköposti";
            // 
            // osastoLB
            // 
            this.osastoLB.AutoSize = true;
            this.osastoLB.Location = new System.Drawing.Point(231, 165);
            this.osastoLB.Name = "osastoLB";
            this.osastoLB.Size = new System.Drawing.Size(40, 13);
            this.osastoLB.TabIndex = 10;
            this.osastoLB.Text = "Osasto";
            // 
            // titteliLB
            // 
            this.titteliLB.AutoSize = true;
            this.titteliLB.Location = new System.Drawing.Point(231, 137);
            this.titteliLB.Name = "titteliLB";
            this.titteliLB.Size = new System.Drawing.Size(32, 13);
            this.titteliLB.TabIndex = 9;
            this.titteliLB.Text = "Titteli";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 252);
            this.Controls.Add(this.puhLB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.osastoLB);
            this.Controls.Add(this.titteliLB);
            this.Controls.Add(this.puhelinLB);
            this.Controls.Add(this.postitoimipaikkaLB);
            this.Controls.Add(this.postinumeroLB);
            this.Controls.Add(this.osoiteLB);
            this.Controls.Add(this.vastuuhenkiloCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oppilaitosCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox oppilaitosCB;
        private System.Windows.Forms.ComboBox vastuuhenkiloCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label osoiteLB;
        private System.Windows.Forms.Label postinumeroLB;
        private System.Windows.Forms.Label postitoimipaikkaLB;
        private System.Windows.Forms.Label puhelinLB;
        private System.Windows.Forms.Label puhLB;
        private System.Windows.Forms.Label emailLB;
        private System.Windows.Forms.Label osastoLB;
        private System.Windows.Forms.Label titteliLB;
    }
}

