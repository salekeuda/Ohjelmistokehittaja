namespace harjoitus19
{
    partial class ruokalistaForm
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

        private Button GetMeistaBT1()
        {
            return meistaBT;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Button meistaBT1)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ruokalistaForm));
            vasenPL = new Panel();
            ylaPL = new Panel();
            meistaPL = new Panel();
            ruoatPL = new Panel();
            juomatPL = new Panel();
            herkkuPL = new Panel();
            koriPL = new Panel();
            meistaBT = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            meistaLB = new Label();
            vasenPL.SuspendLayout();
            ylaPL.SuspendLayout();
            meistaPL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // vasenPL
            // 
            vasenPL.BackColor = Color.ForestGreen;
            vasenPL.Controls.Add(panel5);
            vasenPL.Controls.Add(button4);
            vasenPL.Controls.Add(panel4);
            vasenPL.Controls.Add(button3);
            vasenPL.Controls.Add(panel3);
            vasenPL.Controls.Add(button2);
            vasenPL.Controls.Add(panel2);
            vasenPL.Controls.Add(button1);
            vasenPL.Controls.Add(panel1);
            vasenPL.Controls.Add(meistaBT);
            vasenPL.Dock = DockStyle.Left;
            vasenPL.Location = new Point(0, 0);
            vasenPL.Name = "vasenPL";
            vasenPL.Size = new Size(141, 300);
            vasenPL.TabIndex = 0;
            // 
            // ylaPL
            // 
            ylaPL.BackColor = Color.DarkOrange;
            ylaPL.Controls.Add(pictureBox1);
            ylaPL.Controls.Add(label1);
            ylaPL.Dock = DockStyle.Top;
            ylaPL.Location = new Point(141, 0);
            ylaPL.Name = "ylaPL";
            ylaPL.Size = new Size(531, 63);
            ylaPL.TabIndex = 1;
            // 
            // meistaPL
            // 
            meistaPL.Controls.Add(meistaLB);
            meistaPL.Dock = DockStyle.Fill;
            meistaPL.Location = new Point(141, 63);
            meistaPL.Name = "meistaPL";
            meistaPL.Size = new Size(531, 237);
            meistaPL.TabIndex = 2;
            // 
            // ruoatPL
            // 
            ruoatPL.Dock = DockStyle.Fill;
            ruoatPL.Location = new Point(141, 63);
            ruoatPL.Name = "ruoatPL";
            ruoatPL.Size = new Size(531, 237);
            ruoatPL.TabIndex = 3;
            // 
            // juomatPL
            // 
            juomatPL.Dock = DockStyle.Fill;
            juomatPL.Location = new Point(141, 63);
            juomatPL.Name = "juomatPL";
            juomatPL.Size = new Size(531, 237);
            juomatPL.TabIndex = 4;
            // 
            // herkkuPL
            // 
            herkkuPL.Dock = DockStyle.Fill;
            herkkuPL.Location = new Point(141, 63);
            herkkuPL.Name = "herkkuPL";
            herkkuPL.Size = new Size(531, 237);
            herkkuPL.TabIndex = 5;
            // 
            // koriPL
            // 
            koriPL.Dock = DockStyle.Fill;
            koriPL.Location = new Point(141, 63);
            koriPL.Name = "koriPL";
            koriPL.Size = new Size(531, 237);
            koriPL.TabIndex = 6;
            // 
            // meistaBT
            // 
            meistaBT.FlatAppearance.BorderSize = 0;
            meistaBT.FlatStyle = FlatStyle.Flat;
            meistaBT.Font = new Font("Segoe UI", 16F);
            meistaBT.ForeColor = SystemColors.ControlLightLight;
            meistaBT.Location = new Point(3, 50);
            meistaBT.Name = "meistaBT";
            meistaBT.Size = new Size(132, 40);
            meistaBT.TabIndex = 0;
            meistaBT.Text = "Meistä";
            meistaBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            meistaBT.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GreenYellow;
            panel1.Location = new Point(3, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 40);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.GreenYellow;
            panel2.Location = new Point(3, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 40);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(3, 96);
            button1.Name = "button1";
            button1.Size = new Size(132, 40);
            button1.TabIndex = 2;
            button1.Text = "Ruoat";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            
            // 
            // panel3
            // 
            panel3.BackColor = Color.GreenYellow;
            panel3.Location = new Point(3, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 40);
            panel3.TabIndex = 3;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 16F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(3, 142);
            button2.Name = "button2";
            button2.Size = new Size(132, 40);
            button2.TabIndex = 4;
            button2.Text = "Juomat";
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.GreenYellow;
            panel4.Location = new Point(3, 188);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 40);
            panel4.TabIndex = 5;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 16F);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(3, 188);
            button3.Name = "button3";
            button3.Size = new Size(132, 40);
            button3.TabIndex = 6;
            button3.Text = "Herkut";
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.GreenYellow;
            panel5.Location = new Point(3, 234);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 40);
            panel5.TabIndex = 7;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 16F);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(3, 234);
            button4.Name = "button4";
            button4.Size = new Size(132, 40);
            button4.TabIndex = 8;
            button4.Text = "Kori";
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(449, 45);
            label1.TabIndex = 0;
            label1.Text = "Keudan oppilaskunnan kahvila";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.cook_hat;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(461, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // meistaLB
            // 
            meistaLB.AutoSize = true;
            meistaLB.Location = new Point(6, 4);
            meistaLB.Name = "meistaLB";
            meistaLB.Size = new Size(38, 15);
            meistaLB.TabIndex = 0;
            meistaLB.Text = "label2";
            // 
            // ruokalistaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(672, 300);
            Controls.Add(meistaPL);
            Controls.Add(ruoatPL);
            Controls.Add(koriPL);
            Controls.Add(herkkuPL);
            Controls.Add(juomatPL);
            Controls.Add(ylaPL);
            Controls.Add(vasenPL);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ruokalistaForm";
            Text = "Form1";
            Load += ruokalistaForm_Load;
            vasenPL.ResumeLayout(false);
            ylaPL.ResumeLayout(false);
            ylaPL.PerformLayout();
            meistaPL.ResumeLayout(false);
            meistaPL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel vasenPL;
        private Panel ylaPL;
        private Button meistaBT;
        private Panel meistaPL;
        private Panel ruoatPL;
        private Panel juomatPL;
        private Panel herkkuPL;
        private Panel koriPL;
        private Panel panel2;
        private Button button1;
        private Panel panel1;
        private Panel panel5;
        private Button button4;
        private Panel panel4;
        private Button button3;
        private Panel panel3;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label meistaLB;
    }
}
