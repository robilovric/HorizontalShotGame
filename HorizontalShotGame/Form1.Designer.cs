namespace HorizontalShotGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ObjectBall = new System.Windows.Forms.PictureBox();
            this.Target = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.Attempt = new System.Windows.Forms.Label();
            this.Velocitiy = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Target)).BeginInit();
            this.SuspendLayout();
            // 
            // ObjectBall
            // 
            this.ObjectBall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ObjectBall.BackColor = System.Drawing.SystemColors.Control;
            this.ObjectBall.Image = ((System.Drawing.Image)(resources.GetObject("ObjectBall.Image")));
            this.ObjectBall.Location = new System.Drawing.Point(10, 10);
            this.ObjectBall.Name = "ObjectBall";
            this.ObjectBall.Size = new System.Drawing.Size(22, 22);
            this.ObjectBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ObjectBall.TabIndex = 0;
            this.ObjectBall.TabStop = false;
            // 
            // Target
            // 
            this.Target.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Target.Image = ((System.Drawing.Image)(resources.GetObject("Target.Image")));
            this.Target.Location = new System.Drawing.Point(688, 373);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(87, 65);
            this.Target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Target.TabIndex = 1;
            this.Target.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 500;
            this.GameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(699, 10);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(61, 17);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score: 0";
            this.Score.TextChanged += new System.EventHandler(this.Score_TextChanged);
            // 
            // Attempt
            // 
            this.Attempt.AutoSize = true;
            this.Attempt.Location = new System.Drawing.Point(699, 27);
            this.Attempt.Name = "Attempt";
            this.Attempt.Size = new System.Drawing.Size(79, 17);
            this.Attempt.TabIndex = 3;
            this.Attempt.Text = "Attempts: 0";
            this.Attempt.TextChanged += new System.EventHandler(this.Attempt_TextChanged);
            // 
            // Velocitiy
            // 
            this.Velocitiy.AutoSize = true;
            this.Velocitiy.Location = new System.Drawing.Point(7, 424);
            this.Velocitiy.Name = "Velocitiy";
            this.Velocitiy.Size = new System.Drawing.Size(65, 17);
            this.Velocitiy.TabIndex = 4;
            this.Velocitiy.Text = "Velocity: ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(66, 424);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0 m/s";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Velocitiy);
            this.Controls.Add(this.Attempt);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Target);
            this.Controls.Add(this.ObjectBall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Horizontal Shot Game";
            this.Shown += new System.EventHandler(this.timer1_Tick);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ObjectBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Target)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ObjectBall;
        private System.Windows.Forms.PictureBox Target;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Attempt;
        private System.Windows.Forms.Label Velocitiy;
        private System.Windows.Forms.TextBox textBox1;
    }
}

 