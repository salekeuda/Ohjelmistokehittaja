namespace harjoitus_11
{
    partial class nopaheittoForm
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
            label1 = new Label();
            noppa1PB = new PictureBox();
            noppa2PB = new PictureBox();
            heitaBT = new Button();
            ((System.ComponentModel.ISupportInitialize)noppa1PB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noppa2PB).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 36);
            label1.TabIndex = 0;
            label1.Text = "nopan heitto";
            // 
            // noppa1PB
            // 
            noppa1PB.Image = Properties.Resources.dice01;
            noppa1PB.Location = new Point(10, 48);
            noppa1PB.Name = "noppa1PB";
            noppa1PB.Size = new Size(100, 100);
            noppa1PB.SizeMode = PictureBoxSizeMode.Zoom;
            noppa1PB.TabIndex = 1;
            noppa1PB.TabStop = false;
            // 
            // noppa2PB
            // 
            noppa2PB.Image = Properties.Resources.dice01;
            noppa2PB.Location = new Point(126, 48);
            noppa2PB.Name = "noppa2PB";
            noppa2PB.Size = new Size(100, 100);
            noppa2PB.SizeMode = PictureBoxSizeMode.Zoom;
            noppa2PB.TabIndex = 2;
            noppa2PB.TabStop = false;
            // 
            // heitaBT
            // 
            heitaBT.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            heitaBT.Location = new Point(12, 154);
            heitaBT.Name = "heitaBT";
            heitaBT.Size = new Size(214, 50);
            heitaBT.TabIndex = 3;
            heitaBT.Text = "Heitä";
            heitaBT.UseVisualStyleBackColor = true;
            heitaBT.Click += heitaBT_Click;
            // 
            // nopaheittoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 250);
            Controls.Add(heitaBT);
            Controls.Add(noppa2PB);
            Controls.Add(noppa1PB);
            Controls.Add(label1);
            Name = "nopaheittoForm";
            Text = "nopan heitto";
            ((System.ComponentModel.ISupportInitialize)noppa1PB).EndInit();
            ((System.ComponentModel.ISupportInitialize)noppa2PB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox noppa1PB;
        private PictureBox noppa2PB;
        private Button heitaBT;
    }
}
