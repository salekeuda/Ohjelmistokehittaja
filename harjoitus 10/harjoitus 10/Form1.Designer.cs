namespace harjoitus_10
{
    partial class BMIform
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
            label2 = new Label();
            painoTB = new TextBox();
            pituusTB = new TextBox();
            laskeBT = new Button();
            vastausLB = new Label();
            kuvausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 0;
            label1.Text = "anna paino:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 71);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 1;
            label2.Text = "anna pituus:";
            // 
            // painoTB
            // 
            painoTB.Location = new Point(151, 23);
            painoTB.Name = "painoTB";
            painoTB.Size = new Size(100, 33);
            painoTB.TabIndex = 2;
            // 
            // pituusTB
            // 
            pituusTB.Location = new Point(151, 68);
            pituusTB.Name = "pituusTB";
            pituusTB.Size = new Size(100, 33);
            pituusTB.TabIndex = 3;
            // 
            // laskeBT
            // 
            laskeBT.Location = new Point(30, 122);
            laskeBT.Name = "laskeBT";
            laskeBT.Size = new Size(221, 45);
            laskeBT.TabIndex = 4;
            laskeBT.Text = "laskeindeksi";
            laskeBT.UseVisualStyleBackColor = true;
            laskeBT.Click += laskeBT_Click;
            // 
            // vastausLB
            // 
            vastausLB.AutoSize = true;
            vastausLB.Location = new Point(30, 183);
            vastausLB.Name = "vastausLB";
            vastausLB.Size = new Size(74, 25);
            vastausLB.TabIndex = 5;
            vastausLB.Text = "vastaus";
            vastausLB.Visible = false;
            // 
            // kuvausLB
            // 
            kuvausLB.AutoSize = true;
            kuvausLB.Location = new Point(30, 226);
            kuvausLB.Name = "kuvausLB";
            kuvausLB.Size = new Size(70, 25);
            kuvausLB.TabIndex = 6;
            kuvausLB.Text = "kuvaus";
            kuvausLB.Visible = false;
            // 
            // BMIform
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 276);
            Controls.Add(kuvausLB);
            Controls.Add(vastausLB);
            Controls.Add(laskeBT);
            Controls.Add(pituusTB);
            Controls.Add(painoTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "BMIform";
            Text = "painoindeksi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox painoTB;
        private TextBox pituusTB;
        private Button laskeBT;
        private Label vastausLB;
        private Label kuvausLB;
    }
}
