namespace harjoitus15
{
    partial class sekkariFM
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
            this.components = new System.ComponentModel.Container();
            this.aikaLB = new System.Windows.Forms.Label();
            this.kaynnistaBT = new System.Windows.Forms.Button();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.ajanottoTM = new System.Windows.Forms.Timer(this.components);
            this.lopetaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aikaLB
            // 
            this.aikaLB.AutoSize = true;
            this.aikaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aikaLB.Location = new System.Drawing.Point(71, 25);
            this.aikaLB.Name = "aikaLB";
            this.aikaLB.Size = new System.Drawing.Size(296, 54);
            this.aikaLB.TabIndex = 0;
            this.aikaLB.Text = "00:00:00.000";
            // 
            // kaynnistaBT
            // 
            this.kaynnistaBT.Location = new System.Drawing.Point(67, 114);
            this.kaynnistaBT.Name = "kaynnistaBT";
            this.kaynnistaBT.Size = new System.Drawing.Size(75, 41);
            this.kaynnistaBT.TabIndex = 1;
            this.kaynnistaBT.Text = "käynnistä";
            this.kaynnistaBT.UseVisualStyleBackColor = true;
            this.kaynnistaBT.Click += new System.EventHandler(this.kaynnistaBT_Click);
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Location = new System.Drawing.Point(274, 114);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(75, 43);
            this.tyhjennaBT.TabIndex = 2;
            this.tyhjennaBT.Text = "tyhjennä";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // ajanottoTM
            // 
            this.ajanottoTM.Enabled = true;
            this.ajanottoTM.Tick += new System.EventHandler(this.ajanottoTM_Tick);
            // 
            // lopetaBT
            // 
            this.lopetaBT.Location = new System.Drawing.Point(176, 113);
            this.lopetaBT.Name = "lopetaBT";
            this.lopetaBT.Size = new System.Drawing.Size(75, 41);
            this.lopetaBT.TabIndex = 3;
            this.lopetaBT.Text = "lopeta";
            this.lopetaBT.UseVisualStyleBackColor = true;
            this.lopetaBT.Click += new System.EventHandler(this.lopetaBT_Click);
            // 
            // sekkariFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 180);
            this.Controls.Add(this.lopetaBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.kaynnistaBT);
            this.Controls.Add(this.aikaLB);
            this.Name = "sekkariFM";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.sekkariFM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aikaLB;
        private System.Windows.Forms.Button kaynnistaBT;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Timer ajanottoTM;
        private System.Windows.Forms.Button lopetaBT;
    }
}

