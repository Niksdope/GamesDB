using GamesDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDB.ViewModel
{
    public class GameVM : NotificationBase<Game>
    {
        public GameVM(Game game = null) : base(game)
        {
            // If game is null, creates a blank game obj
        }

        public string id
        {
            get { return This.id; }
            set { SetProperty(This.id, value, () => This.id = value); }
        }
        public string name
        {
            get { return This.name; }
            set { SetProperty(This.name, value, () => This.name = value); }
        }
        public string summary
        {
            get { return This.summary; }
            set { SetProperty(This.summary, value, () => This.summary = value); }
        }

        public List<String> gameModes
        {
            get { return This.gameModes; }
            set { SetProperty(This.gameModes, value, () => This.gameModes = value); }
        }
        
        public List<Platform> platforms
        {
            get { return This.platforms; }
            set { SetProperty(This.platforms, value, () => This.platforms = value); }
        }
    }
}
