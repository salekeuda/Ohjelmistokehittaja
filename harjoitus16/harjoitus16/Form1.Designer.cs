namespace harjoitus16
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
            this.components = new System.ComponentModel.Container();
            this.minuutitLB = new System.Windows.Forms.Label();
            this.sekunnitLB = new System.Windows.Forms.Label();
            this.aikaLB = new System.Windows.Forms.Label();
            this.minuuttiCB = new System.Windows.Forms.ComboBox();
            this.sekuntiCB = new System.Windows.Forms.ComboBox();
            this.startBT = new System.Windows.Forms.Button();
            this.stopBT = new System.Windows.Forms.Button();
            this.ajastinTR = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // minuutitLB
            // 
            this.minuutitLB.AutoSize = true;
            this.minuutitLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuutitLB.Location = new System.Drawing.Point(74, 35);
            this.minuutitLB.Name = "minuutitLB";
            this.minuutitLB.Size = new System.Drawing.Size(88, 26);
            this.minuutitLB.TabIndex = 0;
            this.minuutitLB.Text = "Minuutit";
            // 
            // sekunnitLB
            // 
            this.sekunnitLB.AutoSize = true;
            this.sekunnitLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sekunnitLB.Location = new System.Drawing.Point(182, 35);
            this.sekunnitLB.Name = "sekunnitLB";
            this.sekunnitLB.Size = new System.Drawing.Size(97, 26);
            this.sekunnitLB.TabIndex = 1;
            this.sekunnitLB.Text = "Sekunnit";
            // 
            // aikaLB
            // 
            this.aikaLB.AutoSize = true;
            this.aikaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aikaLB.Location = new System.Drawing.Point(89, 119);
            this.aikaLB.Name = "aikaLB";
            this.aikaLB.Size = new System.Drawing.Size(162, 63);
            this.aikaLB.TabIndex = 2;
            this.aikaLB.Text = "00:00";
            // 
            // minuuttiCB
            // 
            this.minuuttiCB.FormattingEnabled = true;
            this.minuuttiCB.Location = new System.Drawing.Point(79, 77);
            this.minuuttiCB.Name = "minuuttiCB";
            this.minuuttiCB.Size = new System.Drawing.Size(83, 21);
            this.minuuttiCB.TabIndex = 3;
            // 
            // sekuntiCB
            // 
            this.sekuntiCB.FormattingEnabled = true;
            this.sekuntiCB.Location = new System.Drawing.Point(187, 77);
            this.sekuntiCB.Name = "sekuntiCB";
            this.sekuntiCB.Size = new System.Drawing.Size(83, 21);
            this.sekuntiCB.TabIndex = 4;
            // 
            // startBT
            // 
            this.startBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBT.Location = new System.Drawing.Point(57, 201);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(105, 50);
            this.startBT.TabIndex = 5;
            this.startBT.Text = "Start";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // stopBT
            // 
            this.stopBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBT.Location = new System.Drawing.Point(187, 201);
            this.stopBT.Name = "stopBT";
            this.stopBT.Size = new System.Drawing.Size(105, 50);
            this.stopBT.TabIndex = 6;
            this.stopBT.Text = "Stop";
            this.stopBT.UseVisualStyleBackColor = true;
            this.stopBT.Click += new System.EventHandler(this.stopBT_Click);
            // 
            // ajastinTR
            // 
            this.ajastinTR.Tick += new System.EventHandler(this.ajastinTR_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 339);
            this.Controls.Add(this.stopBT);
            this.Controls.Add(this.startBT);
            this.Controls.Add(this.sekuntiCB);
            this.Controls.Add(this.minuuttiCB);
            this.Controls.Add(this.aikaLB);
            this.Controls.Add(this.sekunnitLB);
            this.Controls.Add(this.minuutitLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minuutitLB;
        private System.Windows.Forms.Label sekunnitLB;
        private System.Windows.Forms.Label aikaLB;
        private System.Windows.Forms.ComboBox minuuttiCB;
        private System.Windows.Forms.ComboBox sekuntiCB;
        private System.Windows.Forms.Button startBT;
        private System.Windows.Forms.Button stopBT;
        private System.Windows.Forms.Timer ajastinTR;
    }
}

