using System;

namespace Harjoitus5
{
    partial class LukujenJarjestys
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
            this.VastausLB = new System.Windows.Forms.Label();
            this.uusiLukuTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna luku (-999 lopetus):";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(351, 228);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(35, 13);
            this.VastausLB.TabIndex = 1;
            this.VastausLB.Text = "label2";
            this.VastausLB.Visible = false;
            // 
            // uusiLukuTB
            // 
            this.uusiLukuTB.Location = new System.Drawing.Point(483, 192);
            this.uusiLukuTB.Name = "uusiLukuTB";
            this.uusiLukuTB.Size = new System.Drawing.Size(122, 20);
            this.uusiLukuTB.TabIndex = 2;
            this.uusiLukuTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uusiLukuTB_KeyPress);
            // 
            // LukujenJarjestys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 582);
            this.Controls.Add(this.uusiLukuTB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label1);
            this.Name = "LukujenJarjestys";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.TextBox uusiLukuTB;
    }
}

