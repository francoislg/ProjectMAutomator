namespace ProjectMAutomator {
    partial class ProjectMMainMenu {
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
            this.namesManagerButton = new System.Windows.Forms.Button();
            this.automatorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namesManagerButton
            // 
            this.namesManagerButton.Location = new System.Drawing.Point(13, 12);
            this.namesManagerButton.Name = "namesManagerButton";
            this.namesManagerButton.Size = new System.Drawing.Size(134, 50);
            this.namesManagerButton.TabIndex = 0;
            this.namesManagerButton.Text = "Names Manager";
            this.namesManagerButton.UseVisualStyleBackColor = true;
            this.namesManagerButton.Click += new System.EventHandler(this.namesManagerButton_Click);
            // 
            // automatorButton
            // 
            this.automatorButton.Location = new System.Drawing.Point(156, 12);
            this.automatorButton.Name = "automatorButton";
            this.automatorButton.Size = new System.Drawing.Size(134, 50);
            this.automatorButton.TabIndex = 1;
            this.automatorButton.Text = "ProjectM Automator";
            this.automatorButton.UseVisualStyleBackColor = true;
            this.automatorButton.Click += new System.EventHandler(this.automatorButton_Click);
            // 
            // ProjectMMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 71);
            this.Controls.Add(this.automatorButton);
            this.Controls.Add(this.namesManagerButton);
            this.Name = "ProjectMMainMenu";
            this.Text = "ProjectMAutomator Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button namesManagerButton;
        private System.Windows.Forms.Button automatorButton;
    }
}