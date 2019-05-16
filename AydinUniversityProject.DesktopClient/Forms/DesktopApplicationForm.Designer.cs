namespace TeachLearnDesktop
{
    partial class DesktopApplicationForm
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
            this.connectionCheckerTimer = new System.Windows.Forms.Timer(this.components);
            this.secondConnectionCheckerTimer = new System.Windows.Forms.Timer(this.components);
            this.lblException = new System.Windows.Forms.Label();
            this.backgroundImage = new System.Windows.Forms.PictureBox();
            this.requestedConnectionTimer = new System.Windows.Forms.Timer(this.components);
            this.connectAcceptedConnectionTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // connectionCheckerTimer
            // 
            this.connectionCheckerTimer.Interval = 5000;
            this.connectionCheckerTimer.Tick += new System.EventHandler(this.connectionCheckerTimer_Tick);
            // 
            // secondConnectionCheckerTimer
            // 
            this.secondConnectionCheckerTimer.Interval = 2000;
            this.secondConnectionCheckerTimer.Tick += new System.EventHandler(this.secondConnectionCheckerTimer_Tick);
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblException.Location = new System.Drawing.Point(241, 241);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(307, 33);
            this.lblException.TabIndex = 2;
            this.lblException.Text = "Waiting For Connection";
            // 
            // backgroundImage
            // 
            this.backgroundImage.Location = new System.Drawing.Point(-1, -3);
            this.backgroundImage.Name = "backgroundImage";
            this.backgroundImage.Size = new System.Drawing.Size(810, 546);
            this.backgroundImage.TabIndex = 3;
            this.backgroundImage.TabStop = false;
            // 
            // requestedConnectionTimer
            // 
            this.requestedConnectionTimer.Interval = 500;
            this.requestedConnectionTimer.Tick += new System.EventHandler(this.requestedConnectionTimer_Tick);
            // 
            // connectAcceptedConnectionTimer
            // 
            this.connectAcceptedConnectionTimer.Interval = 2000;
            this.connectAcceptedConnectionTimer.Tick += new System.EventHandler(this.connectAcceptedConnectionTimer_Tick);
            // 
            // DesktopApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 535);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.backgroundImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DesktopApplicationForm";
            this.Text = "DesktopApplicationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DesktopApplicationForm_FormClosed);
            this.Load += new System.EventHandler(this.DesktopApplicationForm_Load);
            this.Shown += new System.EventHandler(this.DesktopApplicationForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer connectionCheckerTimer;
        private System.Windows.Forms.Timer secondConnectionCheckerTimer;
        private System.Windows.Forms.Label lblException;
        private System.Windows.Forms.PictureBox backgroundImage;
        private System.Windows.Forms.Timer requestedConnectionTimer;
        private System.Windows.Forms.Timer connectAcceptedConnectionTimer;
    }
}