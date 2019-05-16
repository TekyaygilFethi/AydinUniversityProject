namespace TeachLearnDesktop
{
    partial class ConnectionNameForm
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
            this.connectionRequestTimer = new System.Windows.Forms.Timer(this.components);
            this.connectionNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitConnectionName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectionRequestTimer
            // 
            this.connectionRequestTimer.Interval = 2000;
            this.connectionRequestTimer.Tick += new System.EventHandler(this.connectionRequestTimer_Tick);
            // 
            // connectionNameTextBox
            // 
            this.connectionNameTextBox.Location = new System.Drawing.Point(227, 112);
            this.connectionNameTextBox.Name = "connectionNameTextBox";
            this.connectionNameTextBox.Size = new System.Drawing.Size(153, 20);
            this.connectionNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(211, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection Name:";
            // 
            // btnSubmitConnectionName
            // 
            this.btnSubmitConnectionName.Location = new System.Drawing.Point(247, 179);
            this.btnSubmitConnectionName.Name = "btnSubmitConnectionName";
            this.btnSubmitConnectionName.Size = new System.Drawing.Size(111, 23);
            this.btnSubmitConnectionName.TabIndex = 2;
            this.btnSubmitConnectionName.Text = "Create Connection";
            this.btnSubmitConnectionName.UseVisualStyleBackColor = true;
            this.btnSubmitConnectionName.Click += new System.EventHandler(this.btnSubmitConnectionName_Click);
            // 
            // ConnectionNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 338);
            this.Controls.Add(this.btnSubmitConnectionName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectionNameTextBox);
            this.Name = "ConnectionNameForm";
            this.Text = "ConnectionNameForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConnectionNameForm_FormClosed);
            this.Load += new System.EventHandler(this.ConnectionNameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer connectionRequestTimer;
        private System.Windows.Forms.TextBox connectionNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitConnectionName;
    }
}