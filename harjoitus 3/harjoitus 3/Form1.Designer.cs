namespace harjoitus_3
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
            lukuiksiTB = new TextBox();
            lukukaksiTB = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            vastausLB = new Label();
            laskeBT = new Button();
            SuspendLayout();
            // 
            // lukuiksiTB
            // 
            lukuiksiTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lukuiksiTB.Location = new Point(12, 31);
            lukuiksiTB.Name = "lukuiksiTB";
            lukuiksiTB.Size = new Size(100, 35);
            lukuiksiTB.TabIndex = 0;
            // 
            // lukukaksiTB
            // 
            lukukaksiTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lukukaksiTB.Location = new Point(172, 31);
            lukukaksiTB.Name = "lukukaksiTB";
            lukukaksiTB.Size = new Size(100, 35);
            lukukaksiTB.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(118, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(48, 38);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 33);
            label1.Name = "label1";
            label1.Size = new Size(27, 30);
            label1.TabIndex = 3;
            label1.Text = "=";
            // 
            // vastausLB
            // 
            vastausLB.AutoSize = true;
            vastausLB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vastausLB.Location = new Point(320, 33);
            vastausLB.Name = "vastausLB";
            vastausLB.Size = new Size(25, 30);
            vastausLB.TabIndex = 4;
            vastausLB.Text = "X";
            vastausLB.Visible = false;
            // 
            // laskeBT
            // 
            laskeBT.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            laskeBT.Location = new Point(360, 25);
            laskeBT.Name = "laskeBT";
            laskeBT.Size = new Size(94, 44);
            laskeBT.TabIndex = 5;
            laskeBT.Text = "laske";
            laskeBT.UseVisualStyleBackColor = true;
            laskeBT.Click += laskeBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 116);
            Controls.Add(laskeBT);
            Controls.Add(vastausLB);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(lukukaksiTB);
            Controls.Add(lukuiksiTB);
            Name = "Form1";
            Text = "Yksinkertainen nelilaskin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lukuiksiTB;
        private TextBox lukukaksiTB;
        private ComboBox comboBox1;
        private Label label1;
        private Label vastausLB;
        private Button laskeBT;
    }
}
