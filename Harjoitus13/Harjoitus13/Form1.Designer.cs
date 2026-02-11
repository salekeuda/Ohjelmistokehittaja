namespace Harjoitus13
{
    partial class SuosikitFM
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
            this.KysymysLB = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.NimiTB = new System.Windows.Forms.TextBox();
            this.buttonTB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Location = new System.Drawing.Point(60, 36);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(306, 13);
            this.KysymysLB.TabIndex = 0;
            this.KysymysLB.Text = "Anna nimesi, niin tarkastan onko se 50 suosituimman joukossa: ";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(476, 88);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(35, 13);
            this.vastausLB.TabIndex = 1;
            this.vastausLB.Text = "label2";
            this.vastausLB.Visible = false;
            // 
            // NimiTB
            // 
            this.NimiTB.Location = new System.Drawing.Point(380, 33);
            this.NimiTB.Name = "NimiTB";
            this.NimiTB.Size = new System.Drawing.Size(147, 20);
            this.NimiTB.TabIndex = 2;
            // 
            // buttonTB
            // 
            this.buttonTB.Location = new System.Drawing.Point(380, 83);
            this.buttonTB.Name = "buttonTB";
            this.buttonTB.Size = new System.Drawing.Size(75, 23);
            this.buttonTB.TabIndex = 3;
            this.buttonTB.Text = "Tarkasta";
            this.buttonTB.UseVisualStyleBackColor = true;
            this.buttonTB.Click += new System.EventHandler(this.buttonTB_Click);
            // 
            // SuosikitFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 446);
            this.Controls.Add(this.buttonTB);
            this.Controls.Add(this.NimiTB);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.KysymysLB);
            this.Name = "SuosikitFM";
            this.Text = "Onko nimesi suosittujen joukossa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KysymysLB;
        private System.Windows.Forms.Label vastausLB;
        private System.Windows.Forms.TextBox NimiTB;
        private System.Windows.Forms.Button buttonTB;
    }
}

