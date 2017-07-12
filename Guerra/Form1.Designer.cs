namespace Guerra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scrlTimer = new System.Windows.Forms.HScrollBar();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.imgMazoB = new System.Windows.Forms.PictureBox();
            this.imgPilaB = new System.Windows.Forms.PictureBox();
            this.imgAside = new System.Windows.Forms.PictureBox();
            this.imgBside = new System.Windows.Forms.PictureBox();
            this.imgB = new System.Windows.Forms.PictureBox();
            this.imgA = new System.Windows.Forms.PictureBox();
            this.imgPilaA = new System.Windows.Forms.PictureBox();
            this.imgMazoA = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblMazoA = new System.Windows.Forms.Label();
            this.lblPilaA = new System.Windows.Forms.Label();
            this.lblMazoB = new System.Windows.Forms.Label();
            this.lblPilaB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMazoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPilaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPilaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMazoA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scrlTimer);
            this.groupBox1.Controls.Add(this.lblTimer);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnPause);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Location = new System.Drawing.Point(523, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiempo";
            // 
            // scrlTimer
            // 
            this.scrlTimer.Location = new System.Drawing.Point(3, 111);
            this.scrlTimer.Maximum = 1000;
            this.scrlTimer.Minimum = 1;
            this.scrlTimer.Name = "scrlTimer";
            this.scrlTimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scrlTimer.Size = new System.Drawing.Size(267, 22);
            this.scrlTimer.TabIndex = 4;
            this.scrlTimer.Value = 1000;
            this.scrlTimer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlTimer_Scroll);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(80, 19);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(127, 33);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPilaA);
            this.groupBox2.Controls.Add(this.lblMazoA);
            this.groupBox2.Controls.Add(this.imgPilaA);
            this.groupBox2.Controls.Add(this.imgMazoA);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jugador A";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.imgAside);
            this.groupBox3.Controls.Add(this.imgBside);
            this.groupBox3.Controls.Add(this.imgB);
            this.groupBox3.Controls.Add(this.imgA);
            this.groupBox3.Location = new System.Drawing.Point(12, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 153);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tablero";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPilaB);
            this.groupBox4.Controls.Add(this.lblMazoB);
            this.groupBox4.Controls.Add(this.imgMazoB);
            this.groupBox4.Controls.Add(this.imgPilaB);
            this.groupBox4.Location = new System.Drawing.Point(12, 330);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(504, 153);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Jugador B";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(724, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstLog);
            this.groupBox5.Location = new System.Drawing.Point(523, 171);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(276, 284);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Log";
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(7, 20);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(263, 251);
            this.lstLog.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(622, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Acerca de";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(522, 461);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear Log";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // imgMazoB
            // 
            this.imgMazoB.Location = new System.Drawing.Point(410, 13);
            this.imgMazoB.Name = "imgMazoB";
            this.imgMazoB.Size = new System.Drawing.Size(88, 134);
            this.imgMazoB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMazoB.TabIndex = 3;
            this.imgMazoB.TabStop = false;
            // 
            // imgPilaB
            // 
            this.imgPilaB.Location = new System.Drawing.Point(6, 13);
            this.imgPilaB.Name = "imgPilaB";
            this.imgPilaB.Size = new System.Drawing.Size(88, 134);
            this.imgPilaB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPilaB.TabIndex = 2;
            this.imgPilaB.TabStop = false;
            // 
            // imgAside
            // 
            this.imgAside.Location = new System.Drawing.Point(45, 13);
            this.imgAside.Name = "imgAside";
            this.imgAside.Size = new System.Drawing.Size(88, 134);
            this.imgAside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAside.TabIndex = 4;
            this.imgAside.TabStop = false;
            // 
            // imgBside
            // 
            this.imgBside.Location = new System.Drawing.Point(385, 13);
            this.imgBside.Name = "imgBside";
            this.imgBside.Size = new System.Drawing.Size(88, 134);
            this.imgBside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBside.TabIndex = 3;
            this.imgBside.TabStop = false;
            // 
            // imgB
            // 
            this.imgB.Location = new System.Drawing.Point(274, 13);
            this.imgB.Name = "imgB";
            this.imgB.Size = new System.Drawing.Size(88, 134);
            this.imgB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgB.TabIndex = 2;
            this.imgB.TabStop = false;
            // 
            // imgA
            // 
            this.imgA.Location = new System.Drawing.Point(162, 13);
            this.imgA.Name = "imgA";
            this.imgA.Size = new System.Drawing.Size(88, 134);
            this.imgA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgA.TabIndex = 1;
            this.imgA.TabStop = false;
            // 
            // imgPilaA
            // 
            this.imgPilaA.Location = new System.Drawing.Point(410, 13);
            this.imgPilaA.Name = "imgPilaA";
            this.imgPilaA.Size = new System.Drawing.Size(88, 134);
            this.imgPilaA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPilaA.TabIndex = 2;
            this.imgPilaA.TabStop = false;
            // 
            // imgMazoA
            // 
            this.imgMazoA.Location = new System.Drawing.Point(7, 20);
            this.imgMazoA.Name = "imgMazoA";
            this.imgMazoA.Size = new System.Drawing.Size(88, 127);
            this.imgMazoA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMazoA.TabIndex = 0;
            this.imgMazoA.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Image = global::Guerra.Properties.Resources.stop_s;
            this.btnStop.Location = new System.Drawing.Point(167, 55);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(40, 40);
            this.btnStop.TabIndex = 2;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPause
            // 
            this.btnPause.Image = global::Guerra.Properties.Resources.pause_s;
            this.btnPause.Location = new System.Drawing.Point(121, 55);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(40, 40);
            this.btnPause.TabIndex = 1;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::Guerra.Properties.Resources.play_s;
            this.btnPlay.Location = new System.Drawing.Point(75, 55);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblMazoA
            // 
            this.lblMazoA.AutoSize = true;
            this.lblMazoA.Location = new System.Drawing.Point(141, 67);
            this.lblMazoA.Name = "lblMazoA";
            this.lblMazoA.Size = new System.Drawing.Size(50, 13);
            this.lblMazoA.TabIndex = 3;
            this.lblMazoA.Text = "lblMazoA";
            // 
            // lblPilaA
            // 
            this.lblPilaA.AutoSize = true;
            this.lblPilaA.Location = new System.Drawing.Point(141, 82);
            this.lblPilaA.Name = "lblPilaA";
            this.lblPilaA.Size = new System.Drawing.Size(41, 13);
            this.lblPilaA.TabIndex = 4;
            this.lblPilaA.Text = "lblPilaA";
            // 
            // lblMazoB
            // 
            this.lblMazoB.AutoSize = true;
            this.lblMazoB.Location = new System.Drawing.Point(271, 53);
            this.lblMazoB.Name = "lblMazoB";
            this.lblMazoB.Size = new System.Drawing.Size(50, 13);
            this.lblMazoB.TabIndex = 4;
            this.lblMazoB.Text = "lblMazoB";
            // 
            // lblPilaB
            // 
            this.lblPilaB.AutoSize = true;
            this.lblPilaB.Location = new System.Drawing.Point(271, 72);
            this.lblPilaB.Name = "lblPilaB";
            this.lblPilaB.Size = new System.Drawing.Size(41, 13);
            this.lblPilaB.TabIndex = 5;
            this.lblPilaB.Text = "lblPilaB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 496);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Guerra - un juego de cartas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgMazoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPilaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPilaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMazoA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.HScrollBar scrlTimer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox imgPilaA;
        private System.Windows.Forms.PictureBox imgMazoA;
        private System.Windows.Forms.PictureBox imgAside;
        private System.Windows.Forms.PictureBox imgBside;
        private System.Windows.Forms.PictureBox imgB;
        private System.Windows.Forms.PictureBox imgA;
        private System.Windows.Forms.PictureBox imgMazoB;
        private System.Windows.Forms.PictureBox imgPilaB;
        private System.Windows.Forms.Label lblPilaA;
        private System.Windows.Forms.Label lblMazoA;
        private System.Windows.Forms.Label lblPilaB;
        private System.Windows.Forms.Label lblMazoB;
    }
}

