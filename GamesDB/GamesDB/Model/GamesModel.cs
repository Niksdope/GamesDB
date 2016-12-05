using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamesDB.Data;
using Windows.Data.Json;
using System.Diagnostics;

namespace GamesDB.Model
{
    public class GamesModel
    {
        public string queryResponse { get; set; }
        public List<Game> titles { get; set; }
        public List<Game> gamesList = new List<Game>();

        public GamesModel()
        {
            //queryResponse = query;
            //GetData();
            //Debug.WriteLine("New GamesModel()");

            //titles = gamesList; // Initialize titles
        }

        public async Task GetGamesData(string search)
        {
            //Create an HTTP client object
            Windows.Web.Http.HttpClient httpClient = new Windows.Web.Http.HttpClient();

            //Add headers
            httpClient.DefaultRequestHeaders.Add("X-Mashape-Key", "aCbxpIpyLomshOig8RGZl7c7pKXGp1Mc7l5jsnl4I2aQIyU11X"); //Custom header

            httpClient.DefaultRequestHeaders.Accept.Add(new Windows.Web.Http.Headers.HttpMediaTypeWithQualityHeaderValue("application/json")); //Accept header

            //Search parameterized uri
            string uri = "https://igdbcom-internet-game-database-v1.p.mashape.com/games/?fields=name%2Cid%2Csummary%2Crelease_dates.platform%2Crelease_dates.date%2Cgame_modes&offset=0&order=name%3Adesc&search=" + search;
            Uri requestUri = new Uri(uri);

            //Send the GET request asynchronously and retrieve the response as a string.
            Windows.Web.Http.HttpResponseMessage httpResponse = new Windows.Web.Http.HttpResponseMessage();

            try
            {
                //Send the GET request
                httpResponse = await httpClient.GetAsync(requestUri);
                httpResponse.EnsureSuccessStatusCode();
                queryResponse = await httpResponse.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                queryResponse = "Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message;
            }
        }

        public async Task<List<Game>> GetData(string userQuery)
        {
            await GetGamesData(userQuery);

            var tempGamesList = JsonArray.Parse(queryResponse);
            CreateGamesList(tempGamesList);
            return gamesList;
        }

        public void CreateGamesList(JsonArray tempGamesList)
        {
            foreach (var item in tempGamesList)
            {
                var game = item.GetObject();
                Debug.WriteLine(game.ToString());
                Game g = new Game();

                foreach (var key in game.Keys)
                {
                    IJsonValue value;
                    if (!game.TryGetValue(key, out value))
                        continue;

                    switch (key)
                    {
                        case "id":
                            g.id = value.ToString();
                            Debug.WriteLine(g.id);
                            break;
                        case "name":
                            g.name = value.ToString();
                            break;
                        case "summary":
                            g.summary = value.ToString();
                            break;
                        case "game_modes":
                            /* Put the array containing game_modes into a JsonArray object.
                             * Create a temporary list of game_modes(strings) and for each
                             * item in the JsonArray, put the string value into the temp list. 
                             * Once that's done, assign this Game objects gameModes list
                             * to the temporary list.
                             */
                            JsonArray modes = value.GetArray();
                            List<string> gameModes = new List<string>();
                            for (int i = 0; i< modes.Count; i++)
                            {
                                gameModes.Add(modes[i].ToString());
                            }
                            g.gameModes = gameModes;
                            break;
                        case "release_dates":
                           
                            JsonArray platforms = value.GetArray();
                            foreach (var obj in platforms)
                            {
                                var platform = obj.GetObject();
                                string plat = "";
                                string date = "";
                                foreach (var o in platform.Keys)
                                {
                                    IJsonValue val;
                                    if (!platform.TryGetValue(o, out val))
                                        continue;

                                    switch (o)
                                    {
                                        case "platform":
                                            plat = val.ToString();
                                            break;
                                        case "date":
                                            date = val.ToString();
                                            break;
                                    }
                                }
                                Platform p = new Platform();
                                p.name = plat;
                                p.releaseDate = date;
                                try
                                {
                                    g.platforms.Add(p);
                                }
                                catch(Exception ex)
                                { }
                            }
                            break;
                    } // end switch

                } // end foreach(var key in tempGamesList.Keys )
                gamesList.Add(g);
                //Debug.WriteLine(g.name + "XoXOXOXOOOOXOXOXOXOXOXOOXOXOXOXOXOOXOXOXOOXOXOXOXOXOXOOXOXOOXOXOXOOO");
            } // end foreach (var item in tempGamesList)
            titles = gamesList; // Initialize titles
        }
    }
}
