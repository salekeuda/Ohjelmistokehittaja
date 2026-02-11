namespace Harjoitus14
{
    partial class paivakirjaFM
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
            this.tallennaBT = new System.Windows.Forms.Button();
            this.kirjaTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tallennaBT
            // 
            this.tallennaBT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tallennaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallennaBT.Location = new System.Drawing.Point(12, 318);
            this.tallennaBT.Name = "tallennaBT";
            this.tallennaBT.Size = new System.Drawing.Size(735, 94);
            this.tallennaBT.TabIndex = 1;
            this.tallennaBT.Text = "Tallenna päiväkirjaan";
            this.tallennaBT.UseVisualStyleBackColor = false;
            this.tallennaBT.Click += new System.EventHandler(this.tallennaBT_Click);
            // 
            // kirjaTB
            // 
            this.kirjaTB.Location = new System.Drawing.Point(12, 12);
            this.kirjaTB.Multiline = true;
            this.kirjaTB.Name = "kirjaTB";
            this.kirjaTB.Size = new System.Drawing.Size(735, 300);
            this.kirjaTB.TabIndex = 2;
            // 
            // paivakirjaFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(759, 566);
            this.Controls.Add(this.kirjaTB);
            this.Controls.Add(this.tallennaBT);
            this.Name = "paivakirjaFM";
            this.Text = "Päiväkirja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tallennaBT;
        private System.Windows.Forms.TextBox kirjaTB;
    }
}

