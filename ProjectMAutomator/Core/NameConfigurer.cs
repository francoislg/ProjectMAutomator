using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMAutomator.Core {
    using DolphinControllerAutomator;
    public class NameConfigurer {
        private DolphinAsyncController controller;

        private class Letter {
            public int x { get; set; }
            public int y { get; set; }
            public int nbPress { get; set; }
            public Letter(int x, int y, int nbPress) {
                this.x = x;
                this.y = y;
                this.nbPress = nbPress;
            }
        }

        private Dictionary<char, Letter> lettersPosition = new Dictionary<char, Letter>();

        private int x;
        private int y;
        public NameConfigurer(DolphinAsyncController controller) {
            this.controller = controller;
            defineStringAt(" @()^:;", 0, 0); defineStringAt("ABCabc", 1, 0); defineStringAt("DEFdef", 2, 0);
            defineStringAt("GHIghi", 0, 1); defineStringAt("JKLjkl", 1, 1); defineStringAt("MNOmno", 2, 1);
            defineStringAt("PQRSpqrs", 0, 2); defineStringAt("TUVtuv", 1, 2); defineStringAt("WXYZwxyz", 2, 2);
            defineStringAt("!?&%", 0, 3); defineStringAt("-,./~", 1, 3);
        }

        private void defineStringAt(string letters, int x, int y) {
            char[] chars = letters.ToCharArray();
            for (int i = 0; i < chars.Length; i++) {
                lettersPosition.Add(chars[i], new Letter(x, y, i + 1));
            }
        }

        public async Task randomName() {
            await controller.press(DolphinButton.Z).execute();
        }

        public async Task InputName(string name){
            x = 0;
            y = 0;
            controller.wait(100).then();
            foreach(char letter in name.ToCharArray()){
                if(!lettersPosition.ContainsKey(letter)){
                    throw new NotSupportedException();
                }
                Letter position = lettersPosition[letter];
                if (x == position.x && y == position.y) {
                    controller
                        .press(DolphinPOVButton.DOWN).then()
                        .press(DolphinPOVButton.UP).then();
                }
                while (x < position.x) {
                    controller.press(DolphinPOVButton.RIGHT).then();
                    x++;
                }
                while (x > position.x) {
                    controller.press(DolphinPOVButton.LEFT).then();
                    x--;
                }
                while (y > position.y) {
                    controller.press(DolphinPOVButton.UP).then();
                    y--;
                }
                while (y < position.y) {
                    controller.press(DolphinPOVButton.DOWN).then();
                    y++;
                }
                for (int i = 0; i < position.nbPress; i++) {
                    controller.press(DolphinButton.A).then().wait(100);
                }
            }
            controller.press(DolphinButton.START).then().press(DolphinButton.A);
            await controller.execute();
        }
    }
}
