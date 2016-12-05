using GamesDB.Data;
using GamesDB.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDB.ViewModel
{
    public class TitleVM : NotificationBase
    {
        GamesModel gm;
        List<Game> games = new List<Game>();

        public TitleVM()
        {
            gm = new GamesModel();

            _SelectedIndex = -1;
        }

        public async Task populateCollection(string query)
        { 
            games = await gm.GetData(query);
            // Populate observable list
            removeAll(_Games);
            foreach (var game in games)
            {
                Debug.WriteLine("Adding title to _Games");
                var ng = new GameVM(game);
                _Games.Add(ng);
            }
        }

        public void removeAll(ObservableCollection<GameVM> games)
        {
            for (int i = games.Count - 1; i >= 0; i--)
            {
                games.RemoveAt(i);
            }
        }

        public ObservableCollection<GameVM> _Games = new ObservableCollection<GameVM>();

        public ObservableCollection<GameVM> Games
        {
            get { return _Games; }
            set { SetProperty(ref _Games, value); }
        }

        public int _SelectedIndex;
        public int SelectedIndex
        {
            get { return _SelectedIndex; }
            set { if (SetProperty(ref _SelectedIndex, value)) { RaisePropertyChanged(nameof(SelectedGame)); } }
        }

        public GameVM SelectedGame
        {
            get { return (_SelectedIndex >= 0) ? _Games[_SelectedIndex] : null; }
        }
    }
}
