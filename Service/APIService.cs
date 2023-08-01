using System.Diagnostics;
using System.Text.Json;
using Microsoft.VisualBasic;

namespace Service;
public class APIService : IAPIService
{
    HttpClient _client;
    JsonSerializerOptions _json;
    private string testURI = "https://localhost:7138/Note/GetTestResponse";

    public APIService()
    {
        _client = new HttpClient();
        _json = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };
    }

    public async Task<string> GetTestInfo()
    {
        try
        {
            Uri uri = new Uri(string.Format(testURI, string.Empty));
            HttpResponseMessage response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                
                return content;
            }

            return "failed";
        }
        catch(Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return "error";
        }
    }
}
