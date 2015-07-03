using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMAutomator.Core {
    using DolphinControllerAutomator;
    public class GamecubeControllerConfigurer {
        private DolphinAsyncController controller;
        private ButtonMapper LMapping, RMapping, ZMapping, YMapping, XMapping, AMapping, BMapping, CStickMapping, UpMapping, SideMapping, DownMapping;
        public List<Command> ButtonsCommands { get; private set; }
        public List<Command> CStickCommands { get; private set; }
        public GamecubeControllerConfigurer(DolphinAsyncController controller) {
            this.controller = controller;
            this.ButtonsCommands = new List<Command>() {
                Command.Attack, Command.Special, Command.Jump, Command.Shield, Command.Grab, Command.UpTaunt, Command.SideTaunt, Command.DownTaunt, Command.None
            };
            this.CStickCommands = new List<Command>() {
                Command.Attack, Command.Special, Command.Jump, Command.Shield, Command.Grab, Command.Smash, Command.None
            };
            this.LMapping = new ButtonMapper(controller, ButtonsCommands, Command.Shield);
            this.RMapping = new ButtonMapper(controller, ButtonsCommands, Command.Shield);
            this.ZMapping = new ButtonMapper(controller, ButtonsCommands, Command.Grab);
            this.YMapping = new ButtonMapper(controller, ButtonsCommands, Command.Jump);
            this.XMapping = new ButtonMapper(controller, ButtonsCommands, Command.Jump);
            this.AMapping = new ButtonMapper(controller, ButtonsCommands, Command.Attack);
            this.BMapping = new ButtonMapper(controller, ButtonsCommands, Command.Special);
            this.CStickMapping = new ButtonMapper(controller, CStickCommands, Command.Smash);
            this.UpMapping = new ButtonMapper(controller, ButtonsCommands, Command.UpTaunt);
            this.SideMapping = new ButtonMapper(controller, ButtonsCommands, Command.SideTaunt);
            this.DownMapping = new ButtonMapper(controller, ButtonsCommands, Command.DownTaunt);
        }

        public async Task ApplyConfig(GamecubeControllerConfig config){
            await LMapping.GoTo(config.LButton);
            await controller.press(DolphinPOVButton.RIGHT).execute();
            await RMapping.GoTo(config.RButton);
            if (!config.TapJump) {
                await controller.press(DolphinPOVButton.RIGHT).then()
                    .press(DolphinButton.A).then()
                    .press(DolphinPOVButton.LEFT).execute();
            }
            await controller.press(DolphinPOVButton.DOWN).execute();
            await ZMapping.GoTo(config.ZButton);
            await controller.press(DolphinPOVButton.DOWN).execute();
            await YMapping.GoTo(config.YButton);
            await controller.press(DolphinPOVButton.DOWN).execute();
            await XMapping.GoTo(config.XButton);
            await controller.press(DolphinPOVButton.DOWN).execute();
            await AMapping.GoTo(config.AButton);
            await controller.press(DolphinPOVButton.LEFT).execute();
            await UpMapping.GoTo(config.UpButton);
            await controller.press(DolphinPOVButton.DOWN).execute();
            await SideMapping.GoTo(config.SideButton);
            await controller.press(DolphinPOVButton.RIGHT).execute();
            await BMapping.GoTo(config.BButton);
            await controller.press(DolphinPOVButton.DOWN).execute();
            await CStickMapping.GoTo(config.CStick);
            await controller.press(DolphinPOVButton.LEFT).execute();
            await DownMapping.GoTo(config.DownButton);
            await controller.press(DolphinPOVButton.LEFT).then()
                .press(DolphinButton.A).then()
                .wait(5000).then()
                .press(DolphinButton.B).execute();
        }
    }
}
