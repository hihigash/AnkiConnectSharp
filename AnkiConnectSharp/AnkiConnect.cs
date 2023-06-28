using System.Text.Json;

namespace AnkiConnectSharp
{
    public class AnkiConnect
    {
        internal readonly HttpClient _httpClient;

        public AnkiConnect(Uri uri)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = uri;
        }

        public int GetApiVersion()
        {
            var json = NativeActions.MiscellaneousActions.Version(_httpClient);
            return json.RootElement.GetProperty("result").GetInt32();
        }

        public AnkiDeck[] GetDecksOfCurrentUser()
        {
            var json = NativeActions.DeskActions.DeckNamesAndIds(_httpClient);
            var decks = json.RootElement.GetProperty("result").EnumerateObject()
                .Select(x => new AnkiDeck(this, x.Value.GetDecimal(), x.Name));
            
            return decks.ToArray();
        }
    }
}
