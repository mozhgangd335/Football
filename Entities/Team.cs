using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Team
    {
        public Team(string fullName, Color firstcolor, Color secondcolor)
        {
            FullName = fullName;
           
        }

        public int Id { get; set; }
        public string FullName { get; set; }

        public Color Firstcolor { get; set; }
        public Color Secondcolor { get; set; }
        HashSet<Player> Players { get; set; }
        void AddPlayer(Player player)
        {
            player = player;
        }
    }
    public enum Color
    {
        White=1,
        blue,
        Red,
        Yellow

    }
  
}
