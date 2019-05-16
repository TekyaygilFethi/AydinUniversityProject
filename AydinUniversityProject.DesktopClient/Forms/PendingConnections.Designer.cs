namespace TeachLearnDesktop
{
    partial class PendingConnections
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
            this.label1 = new System.Windows.Forms.Label();
            this.pConnectionsGridView = new System.Windows.Forms.DataGridView();
            this.rConnectionsGridView = new System.Windows.Forms.DataGridView();
            this.btnSkipRequests = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.acceptedRequestTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pConnectionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rConnectionsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(104, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "PENDING CONNECTIONS";
            // 
            // pConnectionsGridView
            // 
            this.pConnectionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pConnectionsGridView.Location = new System.Drawing.Point(12, 95);
            this.pConnectionsGridView.Name = "pConnectionsGridView";
            this.pConnectionsGridView.Size = new System.Drawing.Size(575, 384);
            this.pConnectionsGridView.TabIndex = 1;
            this.pConnectionsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pConnectionsGridView_CellContentClick);
            // 
            // rConnectionsGridView
            // 
            this.rConnectionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rConnectionsGridView.Location = new System.Drawing.Point(619, 95);
            this.rConnectionsGridView.Name = "rConnectionsGridView";
            this.rConnectionsGridView.Size = new System.Drawing.Size(558, 384);
            this.rConnectionsGridView.TabIndex = 2;
            // 
            // btnSkipRequests
            // 
            this.btnSkipRequests.Location = new System.Drawing.Point(1102, 494);
            this.btnSkipRequests.Name = "btnSkipRequests";
            this.btnSkipRequests.Size = new System.Drawing.Size(75, 23);
            this.btnSkipRequests.TabIndex = 3;
            this.btnSkipRequests.Text = "Skip";
            this.btnSkipRequests.UseVisualStyleBackColor = true;
            this.btnSkipRequests.Click += new System.EventHandler(this.btnSkipRequests_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(672, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "REQUESTED CONNECTIONS";
            // 
            // acceptedRequestTimer
            // 
            this.acceptedRequestTimer.Interval = 2000;
            this.acceptedRequestTimer.Tick += new System.EventHandler(this.acceptedRequestTimer_Tick);
            // 
            // PendingConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 586);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSkipRequests);
            this.Controls.Add(this.rConnectionsGridView);
            this.Controls.Add(this.pConnectionsGridView);
            this.Controls.Add(this.label1);
            this.Name = "PendingConnections";
            this.Text = "PendingConnections";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PendingConnections_FormClosed);
            this.Load += new System.EventHandler(this.PendingConnections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pConnectionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rConnectionsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pConnectionsGridView;
        private System.Windows.Forms.DataGridView rConnectionsGridView;
        private System.Windows.Forms.Button btnSkipRequests;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer acceptedRequestTimer;
    }
}