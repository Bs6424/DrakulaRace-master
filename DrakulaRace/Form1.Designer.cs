namespace DrakulaRace
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
            this.TrackLengthPanel = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.PlaceBet = new System.Windows.Forms.Button();
            this.StartRace = new System.Windows.Forms.Button();
            this.VampBlack = new System.Windows.Forms.PictureBox();
            this.VampGreen = new System.Windows.Forms.PictureBox();
            this.VampPurple = new System.Windows.Forms.PictureBox();
            this.VampBlue = new System.Windows.Forms.PictureBox();
            this.RaceTime = new System.Windows.Forms.Timer(this.components);
            this.TrackLengthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VampBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VampGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VampPurple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VampBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // TrackLengthPanel
            // 
            this.TrackLengthPanel.Controls.Add(this.VampBlue);
            this.TrackLengthPanel.Controls.Add(this.VampPurple);
            this.TrackLengthPanel.Controls.Add(this.VampGreen);
            this.TrackLengthPanel.Controls.Add(this.VampBlack);
            this.TrackLengthPanel.Location = new System.Drawing.Point(13, 13);
            this.TrackLengthPanel.Name = "TrackLengthPanel";
            this.TrackLengthPanel.Size = new System.Drawing.Size(905, 380);
            this.TrackLengthPanel.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 400);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 424);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(13, 448);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bet Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bet On:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(574, 409);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            995,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(574, 435);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 10;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PlaceBet
            // 
            this.PlaceBet.Location = new System.Drawing.Point(701, 409);
            this.PlaceBet.Name = "PlaceBet";
            this.PlaceBet.Size = new System.Drawing.Size(217, 46);
            this.PlaceBet.TabIndex = 11;
            this.PlaceBet.Text = "Place Bet";
            this.PlaceBet.UseVisualStyleBackColor = true;
            this.PlaceBet.Click += new System.EventHandler(this.PlaceBet_Click);
            // 
            // StartRace
            // 
            this.StartRace.Location = new System.Drawing.Point(506, 456);
            this.StartRace.Name = "StartRace";
            this.StartRace.Size = new System.Drawing.Size(412, 92);
            this.StartRace.TabIndex = 12;
            this.StartRace.Text = "RACE";
            this.StartRace.UseVisualStyleBackColor = true;
            this.StartRace.Click += new System.EventHandler(this.StartRace_Click);
            // 
            // VampBlack
            // 
            this.VampBlack.Image = global::DrakulaRace.Properties.Resources.VampBlack;
            this.VampBlack.Location = new System.Drawing.Point(3, 3);
            this.VampBlack.Name = "VampBlack";
            this.VampBlack.Size = new System.Drawing.Size(75, 75);
            this.VampBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VampBlack.TabIndex = 0;
            this.VampBlack.TabStop = false;
            // 
            // VampGreen
            // 
            this.VampGreen.Image = global::DrakulaRace.Properties.Resources.VampGreen;
            this.VampGreen.Location = new System.Drawing.Point(3, 103);
            this.VampGreen.Name = "VampGreen";
            this.VampGreen.Size = new System.Drawing.Size(75, 75);
            this.VampGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VampGreen.TabIndex = 1;
            this.VampGreen.TabStop = false;
            // 
            // VampPurple
            // 
            this.VampPurple.Image = global::DrakulaRace.Properties.Resources.VampPurple;
            this.VampPurple.Location = new System.Drawing.Point(3, 203);
            this.VampPurple.Name = "VampPurple";
            this.VampPurple.Size = new System.Drawing.Size(75, 75);
            this.VampPurple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VampPurple.TabIndex = 2;
            this.VampPurple.TabStop = false;
            // 
            // VampBlue
            // 
            this.VampBlue.Image = global::DrakulaRace.Properties.Resources.VampBlue;
            this.VampBlue.Location = new System.Drawing.Point(3, 302);
            this.VampBlue.Name = "VampBlue";
            this.VampBlue.Size = new System.Drawing.Size(75, 75);
            this.VampBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VampBlue.TabIndex = 3;
            this.VampBlue.TabStop = false;
            // 
            // RaceTime
            // 
            this.RaceTime.Tick += new System.EventHandler(this.RaceTime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 560);
            this.Controls.Add(this.StartRace);
            this.Controls.Add(this.PlaceBet);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.TrackLengthPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TrackLengthPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VampBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VampGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VampPurple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VampBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TrackLengthPanel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button PlaceBet;
        private System.Windows.Forms.Button StartRace;
        private System.Windows.Forms.PictureBox VampBlue;
        private System.Windows.Forms.PictureBox VampPurple;
        private System.Windows.Forms.PictureBox VampGreen;
        private System.Windows.Forms.PictureBox VampBlack;
        private System.Windows.Forms.Timer RaceTime;
    }
}

