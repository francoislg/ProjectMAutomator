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
    using DolphinControllerAutomator;
    using DolphinControllerAutomator.Controllers;
    using Core;
    public partial class ProjectMAutomator : Form {
        DolphinAsyncController controller;
        public ProjectMAutomator() {
            InitializeComponent();
            controller = new DolphinAsyncController(new vJoyController(1), 50, 20);
        }

        private async void initialSetupButton_Click(object sender, EventArgs e) {
            await new InitialSetup(controller).execute(volumeTrackbar.Value - 5);
        }

        private void toNamesButton_Click(object sender, EventArgs e) {
            new ProjectMNamesAutomator(controller).ShowDialog();
        }
    }
}
