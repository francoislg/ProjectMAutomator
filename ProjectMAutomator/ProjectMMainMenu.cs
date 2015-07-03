using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMAutomator {
    public partial class ProjectMMainMenu : Form {
        public ProjectMMainMenu() {
            InitializeComponent();
        }

        private void namesManagerButton_Click(object sender, EventArgs e) {
            this.Hide();
            new ProjectMNamesManager().ShowDialog();
            this.Show();
        }

        private void automatorButton_Click(object sender, EventArgs e) {
            this.Hide();
            new ProjectMAutomator().ShowDialog();
            this.Show();
        }
    }
}
