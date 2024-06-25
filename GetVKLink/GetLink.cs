using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;

namespace GetVKLink
{
    internal class GetLink
    {
        private static readonly HttpClient _client = new HttpClient();

        public static async Task<string[]> YoutubeVideoLink(string request, string filter ="Все")
        {
            request = HttpUtility.UrlEncode(request);
            string htmlCode;
            HashSet<string> uniqueLinks;
            string pattern = @"watch\?v=[\w-]+";
            MatchCollection matches;

            switch (filter)
            {
                case "Все":
                    htmlCode = await _client.GetStringAsync($"https://www.youtube.com/results?search_query={request}");
                    uniqueLinks = new HashSet<string>();
                    matches = Regex.Matches(htmlCode, pattern);
                    foreach (Match match in matches)
                    {
                        uniqueLinks.Add("https://www.youtube.com/" + match.Value);
                    }
                    return uniqueLinks.ToArray();

                case "Неделя":
                    htmlCode = await _client.GetStringAsync($"https://www.youtube.com/results?search_query={request}&sp=EgIIAw%253D%253D");
                    uniqueLinks = new HashSet<string>();
                    matches = Regex.Matches(htmlCode, pattern);
                    foreach (Match match in matches)
                    {
                        uniqueLinks.Add("https://www.youtube.com/" + match.Value);
                    }
                    return uniqueLinks.ToArray();

                case "Месяц":
                    htmlCode = await _client.GetStringAsync($"https://www.youtube.com/results?search_query={request}&sp=EgQIBBAB");
                    uniqueLinks = new HashSet<string>();
                    matches = Regex.Matches(htmlCode, pattern);
                    foreach (Match match in matches)
                    {
                        uniqueLinks.Add("https://www.youtube.com/" + match.Value);
                    }
                    return uniqueLinks.ToArray();

                case "Год":
                    htmlCode = await _client.GetStringAsync($"https://www.youtube.com/results?search_query={request}&sp=EgQIBRAB");
                    uniqueLinks = new HashSet<string>();
                    matches = Regex.Matches(htmlCode, pattern);
                    foreach (Match match in matches)
                    {
                        uniqueLinks.Add("https://www.youtube.com/" + match.Value);
                    }
                    return uniqueLinks.ToArray();

                default:
                    throw new ArgumentException("Неверный фильтр", nameof(filter));
            }
        }
        public static async Task<string[]> VKlink(string startLink)
        {
            try
            {
                string htmlCode = await _client.GetStringAsync(startLink);
                HashSet<string> uniqueLinks = new HashSet<string>();
                string pattern = @"https?:\/\/vk\.com\/[\w\d_-]+";
                MatchCollection matches = Regex.Matches(htmlCode, pattern, RegexOptions.Singleline);

                foreach (Match match in matches)
                {
                    uniqueLinks.Add(match.Value.Trim());
                }

                return uniqueLinks.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return Array.Empty<string>();
            }
        }


    }
}
