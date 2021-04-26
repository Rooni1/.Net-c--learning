using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minauppgift
{
     public class personaldata
    {
        public string characterName { get; set; }
        public string opponentName { get; set; }
        public string health { get; set; }
        public string Strength { get; set; }
        public string turn { get; set; }

        public personaldata(string name)
        {
            this.characterName = name;
        }
    }
}
