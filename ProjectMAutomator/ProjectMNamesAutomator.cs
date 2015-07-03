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
    using MongoDB.Driver;
    public partial class ProjectMNamesAutomator : Form {
        private DolphinAsyncController controller;
        private IMongoClient client;
        private IMongoCollection<GamecubeControllerConfig> collection;

        private class FormattedConfig {
            public GamecubeControllerConfig config { get; private set; }
            public String name {
                get {
                    return config.username + " (" + config.name + ")";
                }
            }
            public FormattedConfig(GamecubeControllerConfig config) {
                this.config = config;
            }
        }

        public ProjectMNamesAutomator(DolphinAsyncController controller) {
            this.controller = controller;
            this.client = new MongoClient(MongoResources.mongourl);
            var db = client.GetDatabase(MongoResources.database);
            this.collection = db.GetCollection<GamecubeControllerConfig>(MongoResources.controllersCollection);
            InitializeComponent();
            configList.DisplayMember = "Name";
            configList.ValueMember = "config";
        }

        private void nameTextbox_TextChanged(object sender, EventArgs e) {
            searchName.Stop();
            searchName.Start();
        }

        private async void configList_MouseDoubleClick(object sender, MouseEventArgs e) {
            configList.Enabled = false;
            GamecubeControllerConfig config = configList.SelectedValue as GamecubeControllerConfig;
            await applyConfig(config);
            configList.Enabled = true;
        }

        private async Task applyConfig(GamecubeControllerConfig config) {
            await controller.press(DolphinButton.A).execute();
            await new NameConfigurer(controller).InputName(config.name);
            await controller.wait(1000).then()
                .press(DolphinButton.A).then()
                .wait(3000).then()
                .press(DolphinButton.A).then()
                .wait(1000).execute();
            await new GamecubeControllerConfigurer(controller).ApplyConfig(config);
        }

        private async void searchName_Tick(object sender, EventArgs e) {
            searchName.Stop();
            loadingWhileSearching.Show();
            timerLoadingSearch.Start();
            var configs = await collection.FindAsync(
                x => x.username.ToLower().Contains(nameTextbox.Text.ToLower()) || x.name.ToLower().Contains(nameTextbox.Text.ToLower())
            );
            List<GamecubeControllerConfig> list = await configs.ToListAsync();
            List<FormattedConfig> formatedList = new List<FormattedConfig>();
            list.ForEach(config => formatedList.Add(new FormattedConfig(config)));
            configList.DataSource = formatedList;
            timerLoadingSearch.Stop();
            loadingWhileSearching.Hide();
        }

        private void timerLoadingSearch_Tick(object sender, EventArgs e) {
            if (loadingWhileSearching.Value >= loadingWhileSearching.Maximum) {
                loadingWhileSearching.Value = loadingWhileSearching.Minimum;
            }
            loadingWhileSearching.Increment(5);
        }
    }
}
