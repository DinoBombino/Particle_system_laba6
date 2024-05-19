namespace ParticleSystem
{
    partial class Rainbow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBarForRed = new System.Windows.Forms.TrackBar();
            this.trackBarForOrange = new System.Windows.Forms.TrackBar();
            this.trackBarForYellow = new System.Windows.Forms.TrackBar();
            this.trackBarForGreen = new System.Windows.Forms.TrackBar();
            this.trackBarForBlue = new System.Windows.Forms.TrackBar();
            this.trackBarForViolet = new System.Windows.Forms.TrackBar();
            this.trackBarForIndigo = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForViolet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForIndigo)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.BackColor = System.Drawing.Color.Black;
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(710, 426);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBarForRed
            // 
            this.trackBarForRed.Location = new System.Drawing.Point(744, 21);
            this.trackBarForRed.Maximum = 426;
            this.trackBarForRed.Name = "trackBarForRed";
            this.trackBarForRed.Size = new System.Drawing.Size(272, 45);
            this.trackBarForRed.TabIndex = 1;
            this.trackBarForRed.Value = 50;
            this.trackBarForRed.Scroll += new System.EventHandler(this.trackBarForRed_Scroll);
            // 
            // trackBarForOrange
            // 
            this.trackBarForOrange.Location = new System.Drawing.Point(744, 82);
            this.trackBarForOrange.Maximum = 426;
            this.trackBarForOrange.Name = "trackBarForOrange";
            this.trackBarForOrange.Size = new System.Drawing.Size(272, 45);
            this.trackBarForOrange.TabIndex = 2;
            this.trackBarForOrange.Value = 60;
            this.trackBarForOrange.Scroll += new System.EventHandler(this.trackBarForOrange_Scroll);
            // 
            // trackBarForYellow
            // 
            this.trackBarForYellow.Location = new System.Drawing.Point(744, 146);
            this.trackBarForYellow.Maximum = 426;
            this.trackBarForYellow.Name = "trackBarForYellow";
            this.trackBarForYellow.Size = new System.Drawing.Size(272, 45);
            this.trackBarForYellow.TabIndex = 3;
            this.trackBarForYellow.Value = 70;
            this.trackBarForYellow.Scroll += new System.EventHandler(this.trackBarForYellow_Scroll);
            // 
            // trackBarForGreen
            // 
            this.trackBarForGreen.Location = new System.Drawing.Point(744, 210);
            this.trackBarForGreen.Maximum = 426;
            this.trackBarForGreen.Name = "trackBarForGreen";
            this.trackBarForGreen.Size = new System.Drawing.Size(272, 45);
            this.trackBarForGreen.TabIndex = 4;
            this.trackBarForGreen.Value = 80;
            this.trackBarForGreen.Scroll += new System.EventHandler(this.trackBarForGreen_Scroll);
            // 
            // trackBarForBlue
            // 
            this.trackBarForBlue.Location = new System.Drawing.Point(744, 274);
            this.trackBarForBlue.Maximum = 426;
            this.trackBarForBlue.Name = "trackBarForBlue";
            this.trackBarForBlue.Size = new System.Drawing.Size(272, 45);
            this.trackBarForBlue.TabIndex = 5;
            this.trackBarForBlue.Value = 70;
            this.trackBarForBlue.Scroll += new System.EventHandler(this.trackBarForBlue_Scroll);
            // 
            // trackBarForViolet
            // 
            this.trackBarForViolet.Location = new System.Drawing.Point(744, 338);
            this.trackBarForViolet.Maximum = 426;
            this.trackBarForViolet.Name = "trackBarForViolet";
            this.trackBarForViolet.Size = new System.Drawing.Size(272, 45);
            this.trackBarForViolet.TabIndex = 6;
            this.trackBarForViolet.Value = 60;
            this.trackBarForViolet.Scroll += new System.EventHandler(this.trackBarForViolet_Scroll);
            // 
            // trackBarForIndigo
            // 
            this.trackBarForIndigo.Location = new System.Drawing.Point(744, 402);
            this.trackBarForIndigo.Maximum = 426;
            this.trackBarForIndigo.Name = "trackBarForIndigo";
            this.trackBarForIndigo.Size = new System.Drawing.Size(272, 45);
            this.trackBarForIndigo.TabIndex = 7;
            this.trackBarForIndigo.Value = 50;
            this.trackBarForIndigo.Scroll += new System.EventHandler(this.trackBarForIndigo_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(859, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(859, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Orange";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(859, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yellow";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(859, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Green";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(859, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Blue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Violet;
            this.label6.Location = new System.Drawing.Point(855, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Violet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(852, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Indigo";
            // 
            // Rainbow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarForIndigo);
            this.Controls.Add(this.trackBarForViolet);
            this.Controls.Add(this.trackBarForBlue);
            this.Controls.Add(this.trackBarForGreen);
            this.Controls.Add(this.trackBarForYellow);
            this.Controls.Add(this.trackBarForOrange);
            this.Controls.Add(this.trackBarForRed);
            this.Controls.Add(this.picDisplay);
            this.Name = "Rainbow";
            this.Text = "Rainbow";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForViolet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarForIndigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBarForRed;
        private System.Windows.Forms.TrackBar trackBarForOrange;
        private System.Windows.Forms.TrackBar trackBarForYellow;
        private System.Windows.Forms.TrackBar trackBarForGreen;
        private System.Windows.Forms.TrackBar trackBarForBlue;
        private System.Windows.Forms.TrackBar trackBarForViolet;
        private System.Windows.Forms.TrackBar trackBarForIndigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

