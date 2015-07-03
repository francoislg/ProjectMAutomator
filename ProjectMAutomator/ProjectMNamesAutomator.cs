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
    using MongoDB.Driver;
    using Core;
    using System.Threading;
    public partial class ProjectMNamesAutomator : Form {
        private DolphinAsyncController controller;
        private GamecubeControllerConfig config;
        private IMongoClient client;
        private bool usernameExists = false;
        public ProjectMNamesAutomator(DolphinAsyncController controller) {
            this.controller = controller;
            this.config = new GamecubeControllerConfig();
            InitializeComponent();
            bindComboBox(LButtonCombobox, "LButton");
            bindComboBox(RButtonCombobox, "RButton");
            bindComboBox(ZButtonCombobox, "ZButton");
            bindComboBox(YButtonCombobox, "YButton");
            bindComboBox(XButtonCombobox, "XButton");
            bindComboBox(AButtonCombobox, "AButton");
            bindComboBox(BButtonCombobox, "BButton");
            bindComboBox(CStickCombobox, "CStick");
            bindComboBox(UpCombobox, "UpButton");
            bindComboBox(SideCombobox, "SideButton");
            bindComboBox(DownCombobox, "DownButton");
            tapJumpCheckbox.DataBindings.Add("Checked", config, "TapJump", false, DataSourceUpdateMode.OnPropertyChanged);
            nameTextbox.DataBindings.Add("Text", config, "name", false, DataSourceUpdateMode.OnPropertyChanged);
            usernameTextbox.DataBindings.Add("Text", config, "username", false, DataSourceUpdateMode.OnPropertyChanged);
            client = new MongoClient("mongodb://" + MongoResources.dbuser + ":" + MongoResources.dbpassword + "@ds036648.mongolab.com:36648/projectmcontrollers");
        }

        private void bindComboBox(ComboBox comboBox, string button){
            comboBox.DataSource = Enum.GetValues(typeof(Command));
            comboBox.DataBindings.Add("SelectedItem", config, button, false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private async void gcConfigurerButton_Click(object sender, EventArgs e) {
            await controller.press(DolphinButton.A).execute();
            await new NameConfigurer(controller).InputName(nameTextbox.Text);
            await controller.wait(1000).then()
                .press(DolphinButton.A).then()
                .wait(3000).then()
                .press(DolphinButton.A).then()
                .wait(1000).execute();
            await new GamecubeControllerConfigurer(controller).ApplyConfig(config);
        }

        private async void saveProfileButton_Click(object sender, EventArgs e) {
            var db = client.GetDatabase("projectmcontrollers");
            IMongoCollection<GamecubeControllerConfig> collection = db.GetCollection<GamecubeControllerConfig>("controllers");
            if (usernameExists) {
                await collection.FindOneAndReplaceAsync<GamecubeControllerConfig>(x => x.username == config.username, config);
            } else {
                await collection.InsertOneAsync(config);
            }
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e) {
            timeoutUsername.Stop();
            timeoutUsername.Start();
        }

        private async void loadProfileButton_Click(object sender, EventArgs e) {
            loadingLoadProfile.Show();
            loadingProfile.Start();
            var db = client.GetDatabase("projectmcontrollers");
            IMongoCollection<GamecubeControllerConfig> collection = db.GetCollection<GamecubeControllerConfig>("controllers");
            GamecubeControllerConfig newConfig = await collection.Find<GamecubeControllerConfig>(x => x.username == config.username).FirstAsync();
            config._id = newConfig._id;
            config.AButton = newConfig.AButton;
            config.BButton = newConfig.BButton;
            config.CStick = newConfig.CStick;
            config.DownButton = newConfig.DownButton;
            config.LButton = newConfig.LButton;
            config.name = newConfig.name;
            config.RButton = newConfig.RButton;
            config.SideButton = newConfig.SideButton;
            config.TapJump = newConfig.TapJump;
            config.UpButton = newConfig.UpButton;
            config.username = newConfig.username;
            config.XButton = newConfig.XButton;
            config.YButton = newConfig.YButton;
            config.ZButton = newConfig.ZButton;
            this.Invalidate();
            loadingProfile.Stop();
            loadingLoadProfile.Hide();
        }

        private async void timeoutUsername_Tick(object sender, EventArgs e) {
            timeoutUsername.Stop();
            saveProfileButton.Hide();
            usernameStatusLabel.Text = "Now checking username";
            checkingUsername.Start();
            loadingWhileUsername.Show();
            var db = client.GetDatabase("projectmcontrollers");
            IMongoCollection<GamecubeControllerConfig> collection = db.GetCollection<GamecubeControllerConfig>("controllers");
            var found = await collection.CountAsync<GamecubeControllerConfig>(x => x.username == usernameTextbox.Text);
            if (found > 0) {
                usernameExists = true;
                usernameStatusLabel.Text = "Username exists";
                saveProfileButton.Text = "Update profile";
                loadProfileButton.Show();
            } else {
                usernameExists = false;
                usernameStatusLabel.Text = "Username is free !";
                saveProfileButton.Text = "Create profile";
                loadProfileButton.Hide();
            }
            loadingWhileUsername.Hide();
            checkingUsername.Stop();
            saveProfileButton.Show();
        }

        private void checkingUsername_Tick(object sender, EventArgs e) {
            incrementLoading(loadingWhileUsername);
        }

        private void loadingProfile_Tick(object sender, EventArgs e) {
            incrementLoading(loadingLoadProfile);
        }

        private void incrementLoading(ProgressBar bar) {
            if (bar.Value >= bar.Maximum) {
                bar.Value = bar.Minimum;
            }
            bar.Increment(5);
        }
    }
}
