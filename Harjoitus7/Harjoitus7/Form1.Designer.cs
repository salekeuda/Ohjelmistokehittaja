namespace Harjoitus7
{
    partial class Form1
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
            this.OtsikkoTB = new System.Windows.Forms.Label();
            this.LainaLB = new System.Windows.Forms.Label();
            this.NesteLB = new System.Windows.Forms.Label();
            this.VakuutusLB = new System.Windows.Forms.Label();
            this.MuutLB = new System.Windows.Forms.Label();
            this.LopoLB = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.PesuLB = new System.Windows.Forms.Label();
            this.HuoltoLB = new System.Windows.Forms.Label();
            this.RengasLB = new System.Windows.Forms.Label();
            this.KilsatLB = new System.Windows.Forms.Label();
            this.LainaTB = new System.Windows.Forms.TextBox();
            this.NesteetTB = new System.Windows.Forms.TextBox();
            this.VakuutusTB = new System.Windows.Forms.TextBox();
            this.MuutTB = new System.Windows.Forms.TextBox();
            this.LopoTB = new System.Windows.Forms.TextBox();
            this.PesuTB = new System.Windows.Forms.TextBox();
            this.HuoltoTB = new System.Windows.Forms.TextBox();
            this.RenkaatTB = new System.Windows.Forms.TextBox();
            this.KilsatCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OtsikkoTB
            // 
            this.OtsikkoTB.AutoSize = true;
            this.OtsikkoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtsikkoTB.Location = new System.Drawing.Point(243, 9);
            this.OtsikkoTB.Name = "OtsikkoTB";
            this.OtsikkoTB.Size = new System.Drawing.Size(296, 31);
            this.OtsikkoTB.TabIndex = 0;
            this.OtsikkoTB.Text = "Auton kustannuslaskuri";
            this.OtsikkoTB.Click += new System.EventHandler(this.OtsikkoTB_Click);
            // 
            // LainaLB
            // 
            this.LainaLB.AutoSize = true;
            this.LainaLB.Location = new System.Drawing.Point(125, 59);
            this.LainaLB.Name = "LainaLB";
            this.LainaLB.Size = new System.Drawing.Size(139, 13);
            this.LainaLB.TabIndex = 1;
            this.LainaLB.Text = "Lainan lyhennys korkoineen";
            // 
            // NesteLB
            // 
            this.NesteLB.AutoSize = true;
            this.NesteLB.Location = new System.Drawing.Point(125, 100);
            this.NesteLB.Name = "NesteLB";
            this.NesteLB.Size = new System.Drawing.Size(91, 13);
            this.NesteLB.TabIndex = 2;
            this.NesteLB.Text = "Lisättävät nesteet";
            // 
            // VakuutusLB
            // 
            this.VakuutusLB.AutoSize = true;
            this.VakuutusLB.Location = new System.Drawing.Point(125, 144);
            this.VakuutusLB.Name = "VakuutusLB";
            this.VakuutusLB.Size = new System.Drawing.Size(86, 13);
            this.VakuutusLB.TabIndex = 3;
            this.VakuutusLB.Text = "Vakuutusmaksut";
            // 
            // MuutLB
            // 
            this.MuutLB.AutoSize = true;
            this.MuutLB.Location = new System.Drawing.Point(128, 187);
            this.MuutLB.Name = "MuutLB";
            this.MuutLB.Size = new System.Drawing.Size(57, 13);
            this.MuutLB.TabIndex = 4;
            this.MuutLB.Text = "Muut kulut";
            // 
            // LopoLB
            // 
            this.LopoLB.AutoSize = true;
            this.LopoLB.Location = new System.Drawing.Point(125, 226);
            this.LopoLB.Name = "LopoLB";
            this.LopoLB.Size = new System.Drawing.Size(60, 13);
            this.LopoLB.TabIndex = 5;
            this.LopoLB.Text = "Polttoneste";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(125, 295);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(35, 13);
            this.VastausLB.TabIndex = 6;
            this.VastausLB.Text = "label6";
            this.VastausLB.Visible = false;
            // 
            // PesuLB
            // 
            this.PesuLB.AutoSize = true;
            this.PesuLB.Location = new System.Drawing.Point(437, 59);
            this.PesuLB.Name = "PesuLB";
            this.PesuLB.Size = new System.Drawing.Size(34, 13);
            this.PesuLB.TabIndex = 7;
            this.PesuLB.Text = "Pesut";
            // 
            // HuoltoLB
            // 
            this.HuoltoLB.AutoSize = true;
            this.HuoltoLB.Location = new System.Drawing.Point(437, 100);
            this.HuoltoLB.Name = "HuoltoLB";
            this.HuoltoLB.Size = new System.Drawing.Size(40, 13);
            this.HuoltoLB.TabIndex = 8;
            this.HuoltoLB.Text = "Huollot";
            // 
            // RengasLB
            // 
            this.RengasLB.AutoSize = true;
            this.RengasLB.Location = new System.Drawing.Point(437, 144);
            this.RengasLB.Name = "RengasLB";
            this.RengasLB.Size = new System.Drawing.Size(48, 13);
            this.RengasLB.TabIndex = 9;
            this.RengasLB.Text = "Renkaat";
            // 
            // KilsatLB
            // 
            this.KilsatLB.AutoSize = true;
            this.KilsatLB.Location = new System.Drawing.Point(437, 187);
            this.KilsatLB.Name = "KilsatLB";
            this.KilsatLB.Size = new System.Drawing.Size(79, 13);
            this.KilsatLB.TabIndex = 10;
            this.KilsatLB.Text = "Kilometrit/vuosi";
            // 
            // LainaTB
            // 
            this.LainaTB.Location = new System.Drawing.Point(282, 56);
            this.LainaTB.Name = "LainaTB";
            this.LainaTB.Size = new System.Drawing.Size(70, 20);
            this.LainaTB.TabIndex = 11;
            // 
            // NesteetTB
            // 
            this.NesteetTB.Location = new System.Drawing.Point(282, 97);
            this.NesteetTB.Name = "NesteetTB";
            this.NesteetTB.Size = new System.Drawing.Size(70, 20);
            this.NesteetTB.TabIndex = 12;
            // 
            // VakuutusTB
            // 
            this.VakuutusTB.Location = new System.Drawing.Point(282, 141);
            this.VakuutusTB.Name = "VakuutusTB";
            this.VakuutusTB.Size = new System.Drawing.Size(70, 20);
            this.VakuutusTB.TabIndex = 13;
            // 
            // MuutTB
            // 
            this.MuutTB.Location = new System.Drawing.Point(282, 184);
            this.MuutTB.Name = "MuutTB";
            this.MuutTB.Size = new System.Drawing.Size(70, 20);
            this.MuutTB.TabIndex = 14;
            // 
            // LopoTB
            // 
            this.LopoTB.Location = new System.Drawing.Point(282, 223);
            this.LopoTB.Name = "LopoTB";
            this.LopoTB.Size = new System.Drawing.Size(70, 20);
            this.LopoTB.TabIndex = 15;
            // 
            // PesuTB
            // 
            this.PesuTB.Location = new System.Drawing.Point(548, 56);
            this.PesuTB.Name = "PesuTB";
            this.PesuTB.Size = new System.Drawing.Size(70, 20);
            this.PesuTB.TabIndex = 16;
            // 
            // HuoltoTB
            // 
            this.HuoltoTB.Location = new System.Drawing.Point(548, 97);
            this.HuoltoTB.Name = "HuoltoTB";
            this.HuoltoTB.Size = new System.Drawing.Size(70, 20);
            this.HuoltoTB.TabIndex = 17;
            // 
            // RenkaatTB
            // 
            this.RenkaatTB.Location = new System.Drawing.Point(548, 141);
            this.RenkaatTB.Name = "RenkaatTB";
            this.RenkaatTB.Size = new System.Drawing.Size(70, 20);
            this.RenkaatTB.TabIndex = 18;
            // 
            // KilsatCB
            // 
            this.KilsatCB.FormattingEnabled = true;
            this.KilsatCB.Items.AddRange(new object[] {
            "5000",
            "10000",
            "15000",
            "20000",
            "25000",
            "30000",
            "35000",
            "40000",
            "1000000",
            "",
            ""});
            this.KilsatCB.Location = new System.Drawing.Point(548, 187);
            this.KilsatCB.Name = "KilsatCB";
            this.KilsatCB.Size = new System.Drawing.Size(97, 21);
            this.KilsatCB.TabIndex = 19;
            this.KilsatCB.SelectedIndexChanged += new System.EventHandler(this.KilsatCB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KilsatCB);
            this.Controls.Add(this.RenkaatTB);
            this.Controls.Add(this.HuoltoTB);
            this.Controls.Add(this.PesuTB);
            this.Controls.Add(this.LopoTB);
            this.Controls.Add(this.MuutTB);
            this.Controls.Add(this.VakuutusTB);
            this.Controls.Add(this.NesteetTB);
            this.Controls.Add(this.LainaTB);
            this.Controls.Add(this.KilsatLB);
            this.Controls.Add(this.RengasLB);
            this.Controls.Add(this.HuoltoLB);
            this.Controls.Add(this.PesuLB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.LopoLB);
            this.Controls.Add(this.MuutLB);
            this.Controls.Add(this.VakuutusLB);
            this.Controls.Add(this.NesteLB);
            this.Controls.Add(this.LainaLB);
            this.Controls.Add(this.OtsikkoTB);
            this.Name = "Form1";
            this.Text = "Auton kustannuslaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OtsikkoTB;
        private System.Windows.Forms.Label LainaLB;
        private System.Windows.Forms.Label NesteLB;
        private System.Windows.Forms.Label VakuutusLB;
        private System.Windows.Forms.Label MuutLB;
        private System.Windows.Forms.Label LopoLB;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Label PesuLB;
        private System.Windows.Forms.Label HuoltoLB;
        private System.Windows.Forms.Label RengasLB;
        private System.Windows.Forms.Label KilsatLB;
        private System.Windows.Forms.TextBox LainaTB;
        private System.Windows.Forms.TextBox NesteetTB;
        private System.Windows.Forms.TextBox VakuutusTB;
        private System.Windows.Forms.TextBox MuutTB;
        private System.Windows.Forms.TextBox LopoTB;
        private System.Windows.Forms.TextBox PesuTB;
        private System.Windows.Forms.TextBox HuoltoTB;
        private System.Windows.Forms.TextBox RenkaatTB;
        private System.Windows.Forms.ComboBox KilsatCB;
    }
}

