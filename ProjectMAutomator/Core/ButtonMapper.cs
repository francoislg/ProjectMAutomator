﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMAutomator.Core {
    using DolphinControllerAutomator;
    public class ButtonMapper {
        private DolphinAsyncController controller;
        private List<Command> commands;
        private int position;
        public ButtonMapper(DolphinAsyncController controller, List<Command> commands, Command defaultCommand) {
            this.controller = controller;
            this.commands = commands;
            this.position = commands.IndexOf(defaultCommand);
        }

        public async Task GoTo(Command command) {
            int newPosition = commands.IndexOf(command);
            if (newPosition != position) {
                controller.press(DolphinButton.A).then();
                while (position < newPosition) {
                    controller.press(DolphinPOVButton.RIGHT).then();
                    position++;
                }
                while (position > newPosition) {
                    controller.press(DolphinPOVButton.LEFT).then();
                    position--;
                }
                controller.press(DolphinButton.A).then();
                await controller.execute();
            }
        }
    }
}
