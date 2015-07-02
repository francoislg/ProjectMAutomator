using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMAutomator.Core {
    using DolphinControllerAutomator;
    public class InitialSetup {
        private DolphinAsyncController controller;
        public InitialSetup(DolphinAsyncController controller) {
            this.controller = controller;
        }
        public async Task execute(int volume) {
            controller
                    .press(DolphinPOVButton.DOWN).then()
                    .press(DolphinPOVButton.RIGHT).then()
                    .wait(100).then()
                    .press(DolphinPOVButton.RIGHT).then()
                    .press(DolphinButton.A).then();
            if (volume != 0) {
                controller
                    .press(DolphinPOVButton.DOWN).then()
                    .press(DolphinButton.A).then();
                int speed = Math.Abs(volume * 200);
                if (volume > 0) {
                    controller.hold(DolphinPOVButton.RIGHT).forMilliseconds(speed).then();
                } else if (volume < 0) {
                    controller.hold(DolphinPOVButton.LEFT).forMilliseconds(speed).then();
                }
                controller
                    .press(DolphinButton.B).then()
                    .press(DolphinPOVButton.UP).then();
            }

            // options
            controller.press(DolphinPOVButton.RIGHT).then()
                .press(DolphinButton.A).then()
                // Deflicker
                .press(DolphinButton.A).then()
                .press(DolphinButton.B).then()
                // options
                .press(DolphinPOVButton.RIGHT).then()
                .wait(100).then()
                .press(DolphinPOVButton.RIGHT).then()
                .press(DolphinButton.A);
            await controller.execute();
        }
    }
}
