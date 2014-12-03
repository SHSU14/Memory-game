using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
   public class Player
    {
    
       public Player(string name)
       {
           this.Name = name;
           Score = 0;
       }
       public string Name { get; set; }
       public int Score { get; set; }

       public System.Drawing.Color Color { get; set; }
    }
}
