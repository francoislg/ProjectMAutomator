namespace ProjectMAutomator {
    partial class ProjectMNamesAutomator {
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
            this.testNameButton = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // testNameButton
            // 
            this.testNameButton.Location = new System.Drawing.Point(12, 12);
            this.testNameButton.Name = "testNameButton";
            this.testNameButton.Size = new System.Drawing.Size(75, 23);
            this.testNameButton.TabIndex = 0;
            this.testNameButton.Text = "Test Name";
            this.testNameButton.UseVisualStyleBackColor = true;
            this.testNameButton.Click += new System.EventHandler(this.testNameButton_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(93, 14);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(100, 20);
            this.nameTextbox.TabIndex = 1;
            this.nameTextbox.Text = "Test";
            // 
            // ProjectMNamesAutomator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 296);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.testNameButton);
            this.Name = "ProjectMNamesAutomator";
            this.Text = "ProjectMNamesAutomator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testNameButton;
        private System.Windows.Forms.TextBox nameTextbox;
    }
}