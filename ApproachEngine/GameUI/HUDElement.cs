using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproachEngine.GameUI
{
    class HUDelement
    {
        public string Name, Value;
        public enum Position { TopLeft, TopMid, TopRight, MidLeft, MidMid, MidRight, BotLeft, BotMid, BotRight, nill};
        public Position position;
        public int X, Y;

        //public colour;

        public HUDelement(string Name, string Value, Position pos, int x, int y)
        {
            this.Name = Name;
            this.Value = Value;
            this.position = pos;
            this.X = x;
            this.Y = y;
        }

        public void Update(string newValue, Position pos = Position.nill)
        {
            if (pos != Position.nill)
            {
                position = pos;
            }
            Value = newValue;
        }

        public override string ToString()
        {
            return Name + ": " + Value;
        }
    }
}
