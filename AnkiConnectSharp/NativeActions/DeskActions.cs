using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace AnkiConnectSharp.NativeActions
{
    internal static class DeskActions
    {
        public static JsonDocument DeckNames(HttpClient client)
        {
            var node = new JsonObject
            {
                ["action"] = "deckNames",
                ["version"] = 6,
            };
            var response = client.PostAsync("/", new StringContent(node.ToJsonString())).Result;
            return response.ConvertJsonDocumentAndValidateResponse();
        }

        public static JsonDocument DeckNamesAndIds(HttpClient client)
        {
            var node = new JsonObject
            {
                ["action"] = "deckNamesAndIds",
                ["version"] = 6,
            };
            var response = client.PostAsync("/", new StringContent(node.ToJsonString())).Result;
            return response.ConvertJsonDocumentAndValidateResponse();
        }

        public static void GetDecks()
        {
            throw new NotImplementedException();
        }

        public static void CreateDeck()
        {
            throw new NotImplementedException();
        }

        public static void ChangeDeck()
        {
            throw new NotImplementedException();
        }

        public static void DeleteDecks()
        {
            throw new NotImplementedException();
        }

        public static void GetDeckConfig()
        {
            throw new NotImplementedException();
        }

        public static void SaveDeckConfig()
        {
            throw new NotImplementedException();
        }

        public static void SetDeckConfigId()
        {
            throw new NotImplementedException();
        }

        public static void CloneDeckConfigId()
        {
            throw new NotImplementedException();
        }

        public static void RemoveDeckConfigId()
        {
            throw new NotImplementedException();
        }

        public static void GetDeckStats()
        {
            throw new NotImplementedException();
        }
    }
}
