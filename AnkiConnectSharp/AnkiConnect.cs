using System.Text.Json;

namespace AnkiConnectSharp
{
    public class AnkiConnect
    {
        internal readonly HttpClient HttpClient = new();

        public AnkiConnect(Uri uri)
        {
            HttpClient.BaseAddress = uri;
        }

        public int GetApiVersion()
        {
            var json = NativeActions.MiscellaneousActions.Version(HttpClient);
            return json.RootElement.GetProperty("result").GetInt32();
        }

        public AnkiDeck[] GetDecksOfCurrentUser()
        {
            var json = NativeActions.DeskActions.DeckNamesAndIds(HttpClient);
            var decks = json.RootElement.GetProperty("result").EnumerateObject()
                .Select(x => new AnkiDeck(this, x.Value.GetDecimal(), x.Name));
            
            return decks.ToArray();
        }
    }
}
