namespace Harjoitus_4
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
            SyntymaAikaDTP = new DateTimePicker();
            LaskeBT = new Button();
            VuodetLB = new Label();
            KuukaudetLB = new Label();
            PaivatLB = new Label();
            TunnitLB = new Label();
            MinuutitLB = new Label();
            SekunnitLB = new Label();
            SuspendLayout();
            // 
            // SyntymaAikaDTP
            // 
            SyntymaAikaDTP.Location = new Point(129, 73);
            SyntymaAikaDTP.Name = "SyntymaAikaDTP";
            SyntymaAikaDTP.Size = new Size(200, 23);
            SyntymaAikaDTP.TabIndex = 0;
            // 
            // LaskeBT
            // 
            LaskeBT.Location = new Point(378, 73);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(75, 23);
            LaskeBT.TabIndex = 1;
            LaskeBT.Text = "Laske";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // VuodetLB
            // 
            VuodetLB.AutoSize = true;
            VuodetLB.Location = new Point(129, 118);
            VuodetLB.Name = "VuodetLB";
            VuodetLB.Size = new Size(38, 15);
            VuodetLB.TabIndex = 2;
            VuodetLB.Text = "label1";
            // 
            // KuukaudetLB
            // 
            KuukaudetLB.AutoSize = true;
            KuukaudetLB.Location = new Point(129, 148);
            KuukaudetLB.Name = "KuukaudetLB";
            KuukaudetLB.Size = new Size(38, 15);
            KuukaudetLB.TabIndex = 3;
            KuukaudetLB.Text = "label2";
            // 
            // PaivatLB
            // 
            PaivatLB.AutoSize = true;
            PaivatLB.Location = new Point(129, 177);
            PaivatLB.Name = "PaivatLB";
            PaivatLB.Size = new Size(38, 15);
            PaivatLB.TabIndex = 4;
            PaivatLB.Text = "label3";
            // 
            // TunnitLB
            // 
            TunnitLB.AutoSize = true;
            TunnitLB.Location = new Point(291, 118);
            TunnitLB.Name = "TunnitLB";
            TunnitLB.Size = new Size(38, 15);
            TunnitLB.TabIndex = 5;
            TunnitLB.Text = "label4";
            // 
            // MinuutitLB
            // 
            MinuutitLB.AutoSize = true;
            MinuutitLB.Location = new Point(291, 148);
            MinuutitLB.Name = "MinuutitLB";
            MinuutitLB.Size = new Size(38, 15);
            MinuutitLB.TabIndex = 6;
            MinuutitLB.Text = "label5";
            // 
            // SekunnitLB
            // 
            SekunnitLB.AutoSize = true;
            SekunnitLB.Location = new Point(291, 177);
            SekunnitLB.Name = "SekunnitLB";
            SekunnitLB.Size = new Size(38, 15);
            SekunnitLB.TabIndex = 7;
            SekunnitLB.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SekunnitLB);
            Controls.Add(MinuutitLB);
            Controls.Add(TunnitLB);
            Controls.Add(PaivatLB);
            Controls.Add(KuukaudetLB);
            Controls.Add(VuodetLB);
            Controls.Add(LaskeBT);
            Controls.Add(SyntymaAikaDTP);
            Name = "Form1";
            Text = "Form1";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker SyntymaAikaDTP;
        private Button LaskeBT;
        private Label VuodetLB;
        private Label KuukaudetLB;
        private Label PaivatLB;
        private Label TunnitLB;
        private Label MinuutitLB;
        private Label SekunnitLB;
    }
}
