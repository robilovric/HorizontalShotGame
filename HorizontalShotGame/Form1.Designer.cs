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
            ((System.ComponentModel.ISupportInitialize)(this.ObjectBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Target)).BeginInit();
            this.SuspendLayout();
            // 
            // ObjectBall
            // 
            this.ObjectBall.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.GameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.Target);
            this.Controls.Add(this.ObjectBall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Horizontal Shot Game";
            ((System.ComponentModel.ISupportInitialize)(this.ObjectBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Target)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ObjectBall;
        private System.Windows.Forms.PictureBox Target;
        private System.Windows.Forms.Timer GameTimer;

      
    }
}

 