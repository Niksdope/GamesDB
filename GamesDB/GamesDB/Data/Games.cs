using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDB.Data
{
    public class Game
    {
        public String name { get; set; }
        public String summary { get; set; }
        public String releaseDate { get; set; }
        public String cover { get; set; }
    }
}
