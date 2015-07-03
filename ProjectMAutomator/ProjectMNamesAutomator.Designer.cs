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
            this.components = new System.ComponentModel.Container();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.configList = new System.Windows.Forms.ListBox();
            this.searchName = new System.Windows.Forms.Timer(this.components);
            this.loadingWhileSearching = new System.Windows.Forms.ProgressBar();
            this.timerLoadingSearch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(12, 31);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(203, 20);
            this.nameTextbox.TabIndex = 0;
            this.nameTextbox.TextChanged += new System.EventHandler(this.nameTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Double click on a name to automate it\'s config";
            // 
            // configList
            // 
            this.configList.FormattingEnabled = true;
            this.configList.Location = new System.Drawing.Point(12, 74);
            this.configList.Name = "configList";
            this.configList.Size = new System.Drawing.Size(259, 173);
            this.configList.TabIndex = 3;
            this.configList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.configList_MouseDoubleClick);
            // 
            // searchName
            // 
            this.searchName.Interval = 1000;
            this.searchName.Tick += new System.EventHandler(this.searchName_Tick);
            // 
            // loadingWhileSearching
            // 
            this.loadingWhileSearching.Location = new System.Drawing.Point(221, 28);
            this.loadingWhileSearching.Name = "loadingWhileSearching";
            this.loadingWhileSearching.Size = new System.Drawing.Size(51, 23);
            this.loadingWhileSearching.TabIndex = 4;
            // 
            // timerLoadingSearch
            // 
            this.timerLoadingSearch.Tick += new System.EventHandler(this.timerLoadingSearch_Tick);
            // 
            // ProjectMNamesAutomator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.loadingWhileSearching);
            this.Controls.Add(this.configList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextbox);
            this.Name = "ProjectMNamesAutomator";
            this.Text = "ProjectMNamesAutomator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox configList;
        private System.Windows.Forms.Timer searchName;
        private System.Windows.Forms.ProgressBar loadingWhileSearching;
        private System.Windows.Forms.Timer timerLoadingSearch;
    }
}