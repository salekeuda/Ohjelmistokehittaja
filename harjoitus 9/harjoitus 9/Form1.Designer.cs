namespace harjoitus_9
{
    partial class AsteMuunninForm
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
            groupBox1 = new GroupBox();
            celciusRB = new RadioButton();
            fahreRB = new RadioButton();
            label1 = new Label();
            asteetTB = new TextBox();
            muunnaBT = new Button();
            vastausLB = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fahreRB);
            groupBox1.Controls.Add(celciusRB);
            groupBox1.Location = new Point(293, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 107);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "miten muunnat?";
            // 
            // celciusRB
            // 
            celciusRB.AutoSize = true;
            celciusRB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            celciusRB.Location = new Point(6, 32);
            celciusRB.Name = "celciusRB";
            celciusRB.Size = new Size(88, 29);
            celciusRB.TabIndex = 0;
            celciusRB.TabStop = true;
            celciusRB.Text = "celcius";
            celciusRB.UseVisualStyleBackColor = true;
            // 
            // fahreRB
            // 
            fahreRB.AutoSize = true;
            fahreRB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            fahreRB.Location = new Point(6, 67);
            fahreRB.Name = "fahreRB";
            fahreRB.Size = new Size(151, 29);
            fahreRB.TabIndex = 1;
            fahreRB.TabStop = true;
            fahreRB.Text = "fahrenheitteri";
            fahreRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 36);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 1;
            label1.Text = "anna asteet:";
            // 
            // asteetTB
            // 
            asteetTB.Location = new Point(172, 33);
            asteetTB.Name = "asteetTB";
            asteetTB.Size = new Size(100, 33);
            asteetTB.TabIndex = 2;
            // 
            // muunnaBT
            // 
            muunnaBT.Location = new Point(515, 38);
            muunnaBT.Name = "muunnaBT";
            muunnaBT.Size = new Size(75, 37);
            muunnaBT.TabIndex = 3;
            muunnaBT.Text = "muunna";
            muunnaBT.UseVisualStyleBackColor = true;
            muunnaBT.Click += muunnaBT_Click;
            // 
            // vastausLB
            // 
            vastausLB.AutoSize = true;
            vastausLB.Location = new Point(55, 193);
            vastausLB.Name = "vastausLB";
            vastausLB.Size = new Size(74, 25);
            vastausLB.TabIndex = 4;
            vastausLB.Text = "vastaus";
            vastausLB.Visible = false;
            // 
            // AsteMuunninForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 282);
            Controls.Add(vastausLB);
            Controls.Add(muunnaBT);
            Controls.Add(asteetTB);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "AsteMuunninForm";
            Text = "aste muunnin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton fahreRB;
        private RadioButton celciusRB;
        private Label label1;
        private TextBox asteetTB;
        private Button muunnaBT;
        private Label vastausLB;
    }
}
