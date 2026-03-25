namespace harjoitus_12
{
    partial class vastauslomakeForm
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
            kysymysLB = new Label();
            groupBox1 = new GroupBox();
            dummyRB = new RadioButton();
            vastausARB = new RadioButton();
            vastausBRB = new RadioButton();
            vastausCRB = new RadioButton();
            vastausDRB = new RadioButton();
            vastausLB = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // kysymysLB
            // 
            kysymysLB.AutoSize = true;
            kysymysLB.Location = new Point(12, 28);
            kysymysLB.Name = "kysymysLB";
            kysymysLB.Size = new Size(206, 25);
            kysymysLB.TabIndex = 0;
            kysymysLB.Text = "vastaus 1. kysymykseen";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(vastausDRB);
            groupBox1.Controls.Add(vastausCRB);
            groupBox1.Controls.Add(vastausBRB);
            groupBox1.Controls.Add(vastausARB);
            groupBox1.Controls.Add(dummyRB);
            groupBox1.Location = new Point(256, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(135, 207);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "vastaus";
            // 
            // dummyRB
            // 
            dummyRB.AutoCheck = false;
            dummyRB.AutoSize = true;
            dummyRB.Location = new Point(6, 32);
            dummyRB.Name = "dummyRB";
            dummyRB.Size = new Size(40, 29);
            dummyRB.TabIndex = 0;
            dummyRB.TabStop = true;
            dummyRB.Text = "e";
            dummyRB.UseVisualStyleBackColor = true;
            dummyRB.Visible = false;
            // 
            // vastausARB
            // 
            vastausARB.AutoSize = true;
            vastausARB.Location = new Point(6, 32);
            vastausARB.Name = "vastausARB";
            vastausARB.Size = new Size(40, 29);
            vastausARB.TabIndex = 1;
            vastausARB.TabStop = true;
            vastausARB.Text = "a";
            vastausARB.UseVisualStyleBackColor = true;
            // 
            // vastausBRB
            // 
            vastausBRB.AutoSize = true;
            vastausBRB.Location = new Point(6, 67);
            vastausBRB.Name = "vastausBRB";
            vastausBRB.Size = new Size(41, 29);
            vastausBRB.TabIndex = 2;
            vastausBRB.TabStop = true;
            vastausBRB.Text = "b";
            vastausBRB.UseVisualStyleBackColor = true;
            // 
            // vastausCRB
            // 
            vastausCRB.AutoSize = true;
            vastausCRB.Location = new Point(6, 102);
            vastausCRB.Name = "vastausCRB";
            vastausCRB.Size = new Size(39, 29);
            vastausCRB.TabIndex = 3;
            vastausCRB.TabStop = true;
            vastausCRB.Text = "c";
            vastausCRB.UseVisualStyleBackColor = true;
            // 
            // vastausDRB
            // 
            vastausDRB.AutoSize = true;
            vastausDRB.Location = new Point(6, 137);
            vastausDRB.Name = "vastausDRB";
            vastausDRB.Size = new Size(41, 29);
            vastausDRB.TabIndex = 4;
            vastausDRB.TabStop = true;
            vastausDRB.Text = "d";
            vastausDRB.UseVisualStyleBackColor = true;
            // 
            // vastausLB
            // 
            vastausLB.AutoSize = true;
            vastausLB.Location = new Point(12, 210);
            vastausLB.Name = "vastausLB";
            vastausLB.Size = new Size(74, 25);
            vastausLB.TabIndex = 2;
            vastausLB.Text = "vastaus";
            vastausLB.Visible = false;
            // 
            // vastauslomakeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 311);
            Controls.Add(vastausLB);
            Controls.Add(groupBox1);
            Controls.Add(kysymysLB);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "vastauslomakeForm";
            Text = "vastauslomake";
            Load += vastauslomakeForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kysymysLB;
        private GroupBox groupBox1;
        private RadioButton vastausARB;
        private RadioButton dummyRB;
        private RadioButton vastausDRB;
        private RadioButton vastausCRB;
        private RadioButton vastausBRB;
        private Label vastausLB;
    }
}
