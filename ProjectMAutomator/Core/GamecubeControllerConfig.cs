using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMAutomator.Core {
    using MongoDB.Bson;
    public class GamecubeControllerConfig {
        public ObjectId _id { get; set; }
        public String name { get; set; }
        public String username { get; set; }
        public Command LButton { get; set; }
        public Command RButton { get; set; }
        public Command ZButton { get; set; }
        public bool TapJump { get; set; }
        public Command YButton { get; set; }
        public Command XButton { get; set; }
        public Command AButton { get; set; }
        public Command BButton { get; set; }
        public Command CStick { get; set; }
        public Command UpButton { get; set; }
        public Command SideButton { get; set; }
        public Command DownButton { get; set; }

        public GamecubeControllerConfig() {
            name = "";
            username = "";
            LButton = Command.Shield;
            RButton = Command.Shield;
            ZButton = Command.Grab;
            TapJump = true;
            YButton = Command.Jump;
            XButton = Command.Jump;
            AButton = Command.Attack;
            BButton = Command.Special;
            CStick = Command.Smash;
            UpButton = Command.UpTaunt;
            SideButton = Command.SideTaunt;
            DownButton = Command.DownTaunt;
        }
    }
}
