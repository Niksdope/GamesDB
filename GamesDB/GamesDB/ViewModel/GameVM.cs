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
        public string releaseDate
        {
            get { return This.releaseDate; }
            set { SetProperty(This.releaseDate, value, () => This.releaseDate = value); }
        }
        public string cover
        {
            get { return This.cover; }
            set { SetProperty(This.cover, value, () => This.cover = value); }
        }
    }
}
