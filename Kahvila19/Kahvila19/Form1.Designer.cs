namespace Kahvila19
{
    partial class kahvilaFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kahvilaFORM));
            vasenPL = new Panel();
            panel2 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            juomatBT = new Button();
            panel3 = new Panel();
            ruoatBT = new Button();
            meistaBT = new Button();
            ylaPL = new Panel();
            hattuPB = new PictureBox();
            otsikkoLB = new Label();
            meistaPL = new Panel();
            meistaLB = new Label();
            ruoatPL = new Panel();
            juomatPL = new Panel();
            herkutPL = new Panel();
            koriPL = new Panel();
            herkutBT = new Button();
            koriBT = new Button();
            vasenPL.SuspendLayout();
            ylaPL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hattuPB).BeginInit();
            meistaPL.SuspendLayout();
            SuspendLayout();
            // 
            // vasenPL
            // 
            vasenPL.BackColor = Color.DarkRed;
            vasenPL.Controls.Add(panel3);
            vasenPL.Controls.Add(panel2);
            vasenPL.Controls.Add(panel6);
            vasenPL.Controls.Add(panel5);
            vasenPL.Controls.Add(panel4);
            vasenPL.Controls.Add(juomatBT);
            vasenPL.Controls.Add(herkutBT);
            vasenPL.Controls.Add(ruoatBT);
            vasenPL.Controls.Add(meistaBT);
            vasenPL.Controls.Add(koriBT);
            vasenPL.Dock = DockStyle.Left;
            vasenPL.Location = new Point(0, 0);
            vasenPL.Name = "vasenPL";
            vasenPL.Size = new Size(146, 381);
            vasenPL.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(9, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(11, 59);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(9, 309);
            panel6.Name = "panel6";
            panel6.Size = new Size(11, 59);
            panel6.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(9, 244);
            panel5.Name = "panel5";
            panel5.Size = new Size(11, 59);
            panel5.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(9, 179);
            panel4.Name = "panel4";
            panel4.Size = new Size(11, 59);
            panel4.TabIndex = 3;
            // 
            // juomatBT
            // 
            juomatBT.FlatAppearance.BorderSize = 0;
            juomatBT.FlatStyle = FlatStyle.Flat;
            juomatBT.ForeColor = SystemColors.ButtonFace;
            juomatBT.Image = (Image)resources.GetObject("juomatBT.Image");
            juomatBT.Location = new Point(3, 179);
            juomatBT.Name = "juomatBT";
            juomatBT.Size = new Size(137, 59);
            juomatBT.TabIndex = 4;
            juomatBT.Text = "   Juomat";
            juomatBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            juomatBT.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(9, 114);
            panel3.Name = "panel3";
            panel3.Size = new Size(11, 59);
            panel3.TabIndex = 1;
            // 
            // ruoatBT
            // 
            ruoatBT.FlatAppearance.BorderSize = 0;
            ruoatBT.FlatStyle = FlatStyle.Flat;
            ruoatBT.ForeColor = SystemColors.ButtonFace;
            ruoatBT.Image = (Image)resources.GetObject("ruoatBT.Image");
            ruoatBT.Location = new Point(3, 114);
            ruoatBT.Name = "ruoatBT";
            ruoatBT.Size = new Size(137, 59);
            ruoatBT.TabIndex = 2;
            ruoatBT.Text = "   Ruoat";
            ruoatBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            ruoatBT.UseVisualStyleBackColor = true;
            // 
            // meistaBT
            // 
            meistaBT.FlatAppearance.BorderSize = 0;
            meistaBT.FlatStyle = FlatStyle.Flat;
            meistaBT.ForeColor = SystemColors.ControlLightLight;
            meistaBT.Image = Properties.Resources.info;
            meistaBT.Location = new Point(6, 49);
            meistaBT.Name = "meistaBT";
            meistaBT.Size = new Size(137, 59);
            meistaBT.TabIndex = 0;
            meistaBT.Text = "  Meistä";
            meistaBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            meistaBT.UseVisualStyleBackColor = true;
            meistaBT.Click += meistaBT_Click;
            // 
            // ylaPL
            // 
            ylaPL.Controls.Add(hattuPB);
            ylaPL.Controls.Add(otsikkoLB);
            ylaPL.Dock = DockStyle.Top;
            ylaPL.Location = new Point(146, 0);
            ylaPL.Name = "ylaPL";
            ylaPL.Size = new Size(531, 55);
            ylaPL.TabIndex = 1;
            // 
            // hattuPB
            // 
            hattuPB.Image = Properties.Resources.cook_hat;
            hattuPB.InitialImage = (Image)resources.GetObject("hattuPB.InitialImage");
            hattuPB.Location = new Point(459, 9);
            hattuPB.Name = "hattuPB";
            hattuPB.Size = new Size(53, 50);
            hattuPB.TabIndex = 0;
            hattuPB.TabStop = false;
            // 
            // otsikkoLB
            // 
            otsikkoLB.AutoSize = true;
            otsikkoLB.Font = new Font("Segoe UI", 24F);
            otsikkoLB.ForeColor = SystemColors.ButtonFace;
            otsikkoLB.Location = new Point(3, 9);
            otsikkoLB.Name = "otsikkoLB";
            otsikkoLB.Size = new Size(431, 45);
            otsikkoLB.TabIndex = 0;
            otsikkoLB.Text = "Keuda oppilaskunnan kahvila";
            // 
            // meistaPL
            // 
            meistaPL.BackColor = Color.OliveDrab;
            meistaPL.Controls.Add(meistaLB);
            meistaPL.Dock = DockStyle.Fill;
            meistaPL.Location = new Point(146, 55);
            meistaPL.Name = "meistaPL";
            meistaPL.Size = new Size(531, 326);
            meistaPL.TabIndex = 2;
            // 
            // meistaLB
            // 
            meistaLB.AutoSize = true;
            meistaLB.Location = new Point(16, 16);
            meistaLB.Name = "meistaLB";
            meistaLB.Size = new Size(38, 15);
            meistaLB.TabIndex = 0;
            meistaLB.Text = "label1";
            // 
            // ruoatPL
            // 
            ruoatPL.BackColor = Color.OliveDrab;
            ruoatPL.Dock = DockStyle.Fill;
            ruoatPL.Location = new Point(146, 55);
            ruoatPL.Name = "ruoatPL";
            ruoatPL.Size = new Size(531, 326);
            ruoatPL.TabIndex = 3;
            // 
            // juomatPL
            // 
            juomatPL.BackColor = Color.OliveDrab;
            juomatPL.Dock = DockStyle.Fill;
            juomatPL.Location = new Point(146, 55);
            juomatPL.Name = "juomatPL";
            juomatPL.Size = new Size(531, 326);
            juomatPL.TabIndex = 4;
            // 
            // herkutPL
            // 
            herkutPL.BackColor = Color.OliveDrab;
            herkutPL.Dock = DockStyle.Fill;
            herkutPL.Location = new Point(146, 55);
            herkutPL.Name = "herkutPL";
            herkutPL.Size = new Size(531, 326);
            herkutPL.TabIndex = 5;
            // 
            // koriPL
            // 
            koriPL.BackColor = Color.OliveDrab;
            koriPL.Dock = DockStyle.Fill;
            koriPL.Location = new Point(146, 55);
            koriPL.Name = "koriPL";
            koriPL.Size = new Size(531, 326);
            koriPL.TabIndex = 6;
            // 
            // herkutBT
            // 
            herkutBT.FlatAppearance.BorderSize = 0;
            herkutBT.FlatStyle = FlatStyle.Flat;
            herkutBT.ForeColor = SystemColors.ButtonFace;
            herkutBT.Image = (Image)resources.GetObject("herkutBT.Image");
            herkutBT.Location = new Point(3, 244);
            herkutBT.Name = "herkutBT";
            herkutBT.Size = new Size(137, 59);
            herkutBT.TabIndex = 8;
            herkutBT.Text = "Herkut";
            herkutBT.TextAlign = ContentAlignment.MiddleRight;
            herkutBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            herkutBT.UseVisualStyleBackColor = true;
            // 
            // koriBT
            // 
            koriBT.FlatAppearance.BorderSize = 0;
            koriBT.FlatStyle = FlatStyle.Flat;
            koriBT.ForeColor = SystemColors.ButtonFace;
            koriBT.Image = (Image)resources.GetObject("koriBT.Image");
            koriBT.Location = new Point(6, 309);
            koriBT.Name = "koriBT";
            koriBT.Size = new Size(137, 59);
            koriBT.TabIndex = 9;
            koriBT.Text = "Kori";
            koriBT.TextAlign = ContentAlignment.MiddleRight;
            koriBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            koriBT.UseVisualStyleBackColor = true;
            // 
            // kahvilaFORM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(677, 381);
            Controls.Add(meistaPL);
            Controls.Add(koriPL);
            Controls.Add(herkutPL);
            Controls.Add(juomatPL);
            Controls.Add(ruoatPL);
            Controls.Add(ylaPL);
            Controls.Add(vasenPL);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kahvilaFORM";
            Text = "Form1";
            Load += kahvilaFORM_Load;
            vasenPL.ResumeLayout(false);
            ylaPL.ResumeLayout(false);
            ylaPL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hattuPB).EndInit();
            meistaPL.ResumeLayout(false);
            meistaPL.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel vasenPL;
        private Panel ylaPL;
        private Panel meistaPL;
        private Panel ruoatPL;
        private Panel juomatPL;
        private Panel herkutPL;
        private Panel panel2;
        private Panel panel1;
        private Button meistaBT;
        private Panel koriPL;
        private Panel panel6;
        private Button button5;
        private Panel panel5;
        private Button button4;
        private Panel panel4;
        private Button juomatBT;
        private Panel panel3;
        private Button ruoatBT;
        private Label otsikkoLB;
        private PictureBox hattuPB;
        private Label meistaLB;
        private Button herkutBT;
        private Button koriBT;
    }
}
