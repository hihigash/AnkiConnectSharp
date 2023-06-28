using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace AnkiConnectSharp.NativeActions
{
    /// <summary>
    /// Miscellaneous actions
    /// </summary>
    /// <see cref="https://foosoft.net/projects/anki-connect/index.html#miscellaneous-actions"/>
    internal static class MiscellaneousActions
    {
        public static void RequestPermission()
        {
            throw new NotImplementedException();
        }

        public static JsonDocument Version(HttpClient client)
        {
            var json = new JsonObject
            {
                ["action"] = "version",
                ["version"] = 6,
            };
            var response = client.PostAsync("/", new StringContent(json.ToJsonString())).Result;
            return response.ConvertJsonDocumentAndValidateResponse();
        }

        public static void ApiReflect()
        {
            throw new NotImplementedException();
        }

        public static void Sync()
        {
            throw new NotImplementedException();
        }

        public static void GetProfiles()
        {
            throw new NotImplementedException();
        }

        public static void LoadProfile()
        {
            throw new NotImplementedException();
        }

        public static void Multi()
        {
            throw new NotImplementedException();
        }

        public static void ExportPackage()
        {
            throw new NotImplementedException();
        }

        public static void ImportPackage()
        {
            throw new NotImplementedException();
        }

        public static void ReloadCollection()
        {
            throw new NotImplementedException();
        }
    }
}
