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
        public String id { get; set; }
        public String name { get; set; }
        // mm/dd/yyyy
        public String summary { get; set; }
        public List<String> gameModes { get; set; }
        public List<Platform> platforms = new List<Platform>();

    }

    public class Platform
    {
        public String name { get; set; }
        public String releaseDate { get; set; }
    }
}
