namespace Harjoitus_2
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
            OtsikkoLB = new Label();
            TulostusLB = new Label();
            ViestiTB = new TextBox();
            TulostaBT = new Button();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Font = new Font("Segoe Script", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OtsikkoLB.Location = new Point(77, 120);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(283, 33);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "anna tulostettava teksti:";
            // 
            // TulostusLB
            // 
            TulostusLB.AutoSize = true;
            TulostusLB.Font = new Font("Segoe Script", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TulostusLB.Location = new Point(77, 153);
            TulostusLB.Name = "TulostusLB";
            TulostusLB.Size = new Size(72, 33);
            TulostusLB.TabIndex = 1;
            TulostusLB.Text = "xxxx";
            TulostusLB.Visible = false;
            TulostusLB.Click += label1_Click;
            // 
            // ViestiTB
            // 
            ViestiTB.Font = new Font("Segoe UI", 16F);
            ViestiTB.Location = new Point(355, 116);
            ViestiTB.Name = "ViestiTB";
            ViestiTB.Size = new Size(334, 36);
            ViestiTB.TabIndex = 2;
            // 
            // TulostaBT
            // 
            TulostaBT.Location = new Point(547, 158);
            TulostaBT.Name = "TulostaBT";
            TulostaBT.Size = new Size(142, 23);
            TulostaBT.TabIndex = 3;
            TulostaBT.Text = "FlatStyleksi System";
            TulostaBT.UseVisualStyleBackColor = true;
            TulostaBT.Click += TulostaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(800, 450);
            Controls.Add(TulostaBT);
            Controls.Add(ViestiTB);
            Controls.Add(TulostusLB);
            Controls.Add(OtsikkoLB);
            ForeColor = Color.MintCream;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLB;
        private Label TulostusLB;
        private TextBox ViestiTB;
        private Button TulostaBT;
    }
}
