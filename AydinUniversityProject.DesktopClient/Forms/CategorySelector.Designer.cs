namespace TeachLearnDesktop
{
    partial class CategorySelector
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
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.btnSubmitCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelError2 = new System.Windows.Forms.Label();
            this.labelError1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(285, 220);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(269, 21);
            this.categoryComboBox.TabIndex = 6;
            // 
            // btnSubmitCategory
            // 
            this.btnSubmitCategory.Location = new System.Drawing.Point(386, 267);
            this.btnSubmitCategory.Name = "btnSubmitCategory";
            this.btnSubmitCategory.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitCategory.TabIndex = 7;
            this.btnSubmitCategory.Text = "Select";
            this.btnSubmitCategory.UseVisualStyleBackColor = true;
            this.btnSubmitCategory.Click += new System.EventHandler(this.btnSubmitCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(223, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "SELECT A CATEGORY TO MATCH UP!";
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelError2.Location = new System.Drawing.Point(56, 85);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(799, 25);
            this.labelError2.TabIndex = 10;
            this.labelError2.Text = "PLEASE VISIT WEBSITE AND CHOOSE TO CONNECT AS VIEWER OR SHARER!";
            // 
            // labelError1
            // 
            this.labelError1.AutoSize = true;
            this.labelError1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelError1.Location = new System.Drawing.Point(212, 45);
            this.labelError1.Name = "labelError1";
            this.labelError1.Size = new System.Drawing.Size(466, 25);
            this.labelError1.TabIndex = 9;
            this.labelError1.Text = "YOU DO NOT HAVE CONNECTION REQUEST!";
            // 
            // CategorySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 542);
            this.Controls.Add(this.labelError2);
            this.Controls.Add(this.labelError1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmitCategory);
            this.Controls.Add(this.categoryComboBox);
            this.Name = "CategorySelector";
            this.Text = "CategorySelector";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CategorySelector_FormClosed);
            this.Load += new System.EventHandler(this.CategorySelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button btnSubmitCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelError2;
        private System.Windows.Forms.Label labelError1;
    }
}