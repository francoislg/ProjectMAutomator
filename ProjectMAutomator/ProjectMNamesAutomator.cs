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
    using Core;
    public partial class ProjectMNamesAutomator : Form {
        DolphinAsyncController controller;
        public ProjectMNamesAutomator(DolphinAsyncController controller) {
            this.controller = controller;
            InitializeComponent();
        }

        private async void testNameButton_Click(object sender, EventArgs e) {
            await controller.press(DolphinButton.A).execute();
            await new NameConfigurer(controller).InputName(nameTextbox.Text);
            await controller.wait(1000).then().press(DolphinButton.A).execute();
        }
    }
}
