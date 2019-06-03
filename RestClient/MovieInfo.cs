using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using MoviePage.Models;

namespace MoviePage.RestClient
{
    public class MovieInfo
    {
        public static readonly HttpClient client = new HttpClient();

        public async Task<imdbResponse> GetMovieInfo(string title)
        {

            var serializer = new DataContractJsonSerializer(typeof(imdbResponse));

            var streamTask = client.GetStreamAsync($"http://www.omdbapi.com/?t={title}&apikey=b956d895");
            var movieInfo = serializer.ReadObject(await streamTask) as imdbResponse;

            return movieInfo;

        }
    }
}
