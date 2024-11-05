using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Sample2
{
    public class Game : ProtypeGame
    {

        public int PlayerID {  get; set; }
        public string GameName {  get; set; }
        public string GameType {  get; set; }
        public bool IsActive {  get; set; }

        public Game(int playerID, string gameName, string gameType, bool isActive)
        {
            PlayerID = playerID;
            GameName = gameName;
            GameType = gameType;
            IsActive = isActive;
        }

        public override ProtypeGame Clone()
        {
            return this.MemberwiseClone() as ProtypeGame;
        }
    }
}
