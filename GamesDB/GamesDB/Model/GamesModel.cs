using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamesDB.Data;
using Windows.Data.Json;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace GamesDB.Model
{
    public class GamesModel
    {
        public string queryResponse { get; set; }
        public List<Game> titles { get; set; }
        public List<Game> gamesList = new List<Game>();
        public static string chars = "\\\""; // Delimiters for image src

        // Empty constructor
        public GamesModel()
        {

        }

        public async Task GetGamesData(string search, int offset)
        {
            //Create an HTTP client object
            Windows.Web.Http.HttpClient httpClient = new Windows.Web.Http.HttpClient();

            //Add headers
            httpClient.DefaultRequestHeaders.Add("X-Mashape-Key", "aCbxpIpyLomshOig8RGZl7c7pKXGp1Mc7l5jsnl4I2aQIyU11X"); //Custom header

            httpClient.DefaultRequestHeaders.Accept.Add(new Windows.Web.Http.Headers.HttpMediaTypeWithQualityHeaderValue("application/json")); //Accept header

            //Search parameterized uri
            string uri = "https://igdbcom-internet-game-database-v1.p.mashape.com/games/?fields=name%2Csummary%2Cfirst_release_date%2Ccover.url&limit=10&offset=" + offset + "&order=name%3Adesc&search=" + search;
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

        public async Task<List<Game>> GetData(string userQuery, int offset)
        {
            gamesList = new List<Game>();
            await GetGamesData(userQuery, offset);

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
                Boolean hasImage = false;

                foreach (var key in game.Keys)
                {
                    IJsonValue value;
                    if (!game.TryGetValue(key, out value))
                        continue;

                    switch (key)
                    {
                        case "name":
                            string name = Regex.Replace(value.ToString(), @chars, "");
                            g.name = name;
                            break;
                        case "first_release_date":
                            DateTime date = UnixTimeStampToDateTime(value.GetNumber());
                            g.releaseDate = "Release date: " + date.ToString();
                            break;
                        case "summary":
                            string summary = Regex.Replace(value.ToString(), @chars, "");
                            g.summary = summary;
                            break;
                        case "cover":
                            hasImage = true;
                            JsonObject covers = value.GetObject();
                            foreach (var val in covers.Keys)
                            {
                                IJsonValue url;
                                if (!covers.TryGetValue(val, out url))
                                    continue;

                                switch (val)
                                {
                                    case "url":
                                        // Use a regular expression to fix the returned url for image from DB
                                        string source = Regex.Replace(url.ToString(), @chars, "");
                                        source = "http:" + source;
                                        g.cover = source;

                                        break;
                                }
                            }
                            break;
                    } // end switch

                } // end foreach(var key in tempGamesList.Keys )
                // App was crashing if there was no image for the game in the database, so I've created a failsafe
                if (hasImage)
                {
                    // If game has a cover image, grand, make the boolean false for next iteration
                    hasImage = false;
                }
                else
                {
                    // If game has no cover image, use default "No image found" image
                    g.cover = "/Images/noImage.jpg";
                }
                // Add game to list
                gamesList.Add(g);
            } // end foreach (var item in tempGamesList)
        }
        // Adapted from http://stackoverflow.com/questions/249760/how-to-convert-a-unix-timestamp-to-datetime-and-vice-versa
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddMilliseconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}
