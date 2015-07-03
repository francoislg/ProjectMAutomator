namespace ProjectMAutomator {
    partial class ProjectMAutomator {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.initialSetupButton = new System.Windows.Forms.Button();
            this.volumeTrackbar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toNamesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // initialSetupButton
            // 
            this.initialSetupButton.Location = new System.Drawing.Point(12, 12);
            this.initialSetupButton.Name = "initialSetupButton";
            this.initialSetupButton.Size = new System.Drawing.Size(75, 23);
            this.initialSetupButton.TabIndex = 0;
            this.initialSetupButton.Text = "Initial Setup";
            this.initialSetupButton.UseVisualStyleBackColor = true;
            this.initialSetupButton.Click += new System.EventHandler(this.initialSetupButton_Click);
            // 
            // volumeTrackbar
            // 
            this.volumeTrackbar.LargeChange = 2;
            this.volumeTrackbar.Location = new System.Drawing.Point(64, 59);
            this.volumeTrackbar.Name = "volumeTrackbar";
            this.volumeTrackbar.Size = new System.Drawing.Size(104, 45);
            this.volumeTrackbar.TabIndex = 1;
            this.volumeTrackbar.Value = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sound Effects";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Music";
            // 
            // toNamesButton
            // 
            this.toNamesButton.Location = new System.Drawing.Point(175, 12);
            this.toNamesButton.Name = "toNamesButton";
            this.toNamesButton.Size = new System.Drawing.Size(73, 23);
            this.toNamesButton.TabIndex = 5;
            this.toNamesButton.Text = "To Names";
            this.toNamesButton.UseVisualStyleBackColor = true;
            this.toNamesButton.Click += new System.EventHandler(this.toNamesButton_Click);
            // 
            // ProjectMAutomator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 98);
            this.Controls.Add(this.toNamesButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volumeTrackbar);
            this.Controls.Add(this.initialSetupButton);
            this.Name = "ProjectMAutomator";
            this.Text = "ProjectMAutomator";
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button initialSetupButton;
        private System.Windows.Forms.TrackBar volumeTrackbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button toNamesButton;
    }
}

