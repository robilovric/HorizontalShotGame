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
            this.Ratio = new System.Windows.Forms.Label();
            this.gameMode = new System.Windows.Forms.Label();
            this.helper = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Target)).BeginInit();
            this.SuspendLayout();
            // 
            // ObjectBall
            // 
            this.ObjectBall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ObjectBall.BackColor = System.Drawing.SystemColors.Control;
            this.ObjectBall.Image = ((System.Drawing.Image)(resources.GetObject("ObjectBall.Image")));
            this.ObjectBall.Location = new System.Drawing.Point(19, 10);
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
            this.Target.Location = new System.Drawing.Point(358, 277);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(87, 65);
            this.Target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Target.TabIndex = 1;
            this.Target.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(693, 6);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(80, 20);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score: 0";
            this.Score.TextChanged += new System.EventHandler(this.Score_TextChanged);
            // 
            // Attempt
            // 
            this.Attempt.AutoSize = true;
            this.Attempt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attempt.Location = new System.Drawing.Point(693, 26);
            this.Attempt.Name = "Attempt";
            this.Attempt.Size = new System.Drawing.Size(106, 20);
            this.Attempt.TabIndex = 3;
            this.Attempt.Text = "Attempts: 0";
            this.Attempt.TextChanged += new System.EventHandler(this.Attempt_TextChanged);
            // 
            // Velocitiy
            // 
            this.Velocitiy.AutoSize = true;
            this.Velocitiy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Velocitiy.Location = new System.Drawing.Point(3, 438);
            this.Velocitiy.Name = "Velocitiy";
            this.Velocitiy.Size = new System.Drawing.Size(88, 20);
            this.Velocitiy.TabIndex = 4;
            this.Velocitiy.Text = "Velocity: ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(97, 435);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0 m/s";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.EnabledChanged += new System.EventHandler(this.textBox1_EnabledChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Ratio
            // 
            this.Ratio.AutoSize = true;
            this.Ratio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ratio.Location = new System.Drawing.Point(693, 46);
            this.Ratio.Name = "Ratio";
            this.Ratio.Size = new System.Drawing.Size(122, 20);
            this.Ratio.TabIndex = 6;
            this.Ratio.Text = "Ratio: 0,00 %";
            // 
            // gameMode
            // 
            this.gameMode.AutoSize = true;
            this.gameMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameMode.Location = new System.Drawing.Point(693, 441);
            this.gameMode.Name = "gameMode";
            this.gameMode.Size = new System.Drawing.Size(137, 20);
            this.gameMode.TabIndex = 8;
            this.gameMode.Text = "WATCH MODE";
            // 
            // helper
            // 
            this.helper.AutoSize = true;
            this.helper.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helper.Location = new System.Drawing.Point(647, 435);
            this.helper.Name = "helper";
            this.helper.Size = new System.Drawing.Size(40, 30);
            this.helper.TabIndex = 9;
            this.helper.Text = "!";
            this.helper.UseVisualStyleBackColor = true;
            this.helper.Click += new System.EventHandler(this.helper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(849, 467);
            this.Controls.Add(this.helper);
            this.Controls.Add(this.gameMode);
            this.Controls.Add(this.Ratio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Velocitiy);
            this.Controls.Add(this.Attempt);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Target);
            this.Controls.Add(this.ObjectBall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Horizontal Shot Game";
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
        private System.Windows.Forms.Label Ratio;
        private System.Windows.Forms.Label gameMode;
        private System.Windows.Forms.RadioButton helper;
    }
}

 