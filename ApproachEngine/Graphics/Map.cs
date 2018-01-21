using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproachEngine.Graphics
{
    public class Map
    {
        public string Name { get; set; }
        public int HEIGHT { get; set; }
        public int WIDTH { get; set; }
        public Region.Tile[,] Tiles { get; set; }

        public Map(int HEIGHT, int WIDTH, string Name)
        {

            this.HEIGHT = HEIGHT;
            this.WIDTH = WIDTH;
            this.Name = Name;
            Tiles = new Region.Tile[WIDTH, HEIGHT];

        }
        
        
    }
}
