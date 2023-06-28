using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace AnkiConnectSharp.NativeActions
{
    internal static class HttpResponseMessageExtensions
    {
        public static JsonDocument ConvertJsonDocumentAndValidateResponse(this HttpResponseMessage response)
        {
            var text = response.Content.ReadAsStringAsync().Result;
            var document = JsonDocument.Parse(text);
            var error = document.RootElement.GetProperty("error").GetString();
            if (error != null)
            {
                throw new AnkiException(error);
            }

            return document;
        }
    }

    internal static class NoteActions
    {
        public static JsonDocument AddNote(HttpClient client, string deckName, string front, string back)
        {
            var request = new
            {
                action = "addNote",
                version = 6,
                @params = new
                {
                    note = new
                    {
                        deckName,
                        modelName = "Basic",
                        fields = new
                        {
                            Front = front,
                            Back = back
                        }
                    }
                }
            };

            var response = client.PostAsync("/", new StringContent(JsonSerializer.Serialize(request))).Result;
            return response.ConvertJsonDocumentAndValidateResponse();
        }

        public static void AddNotes()
        {
            throw new NotImplementedException();
        }

        public static void CanAddNotes()
        {
            throw new NotImplementedException();
        }

        public static void UpdateNoteFields()
        {
            throw new NotImplementedException();
        }

        public static void UpdateNote()
        {
            throw new NotImplementedException();
        }

        public static void UpdateNoteTags()
        {
            throw new NotImplementedException();
        }

        public static void GetNoteTags()
        {
            throw new NotImplementedException();
        }

        public static void AddTags()
        {
            throw new NotImplementedException();
        }

        public static void RemoveTags()
        {
            throw new NotImplementedException();
        }

        public static void GetTags()
        {
            throw new NotImplementedException();
        }

        public static void ClearUnusedTags()
        {
            throw new NotImplementedException();
        }

        public static void ReplaceTags()
        {
            throw new NotImplementedException();
        }

        public static void ReplaceTagsInAllNotes()
        {
            throw new NotImplementedException();
        }

        public static void FindNotes()
        {
            throw new NotImplementedException();
        }

        public static void NotesInfo()
        {
            throw new NotImplementedException();
        }

        public static JsonDocument DeleteNotes(HttpClient client, decimal[] noteIds)
        {
            var request = new
            {
                action = "deleteNotes",
                version = 6,
                @params = new
                {
                    notes = noteIds
                }
            };

            var response = client.PostAsync("/", new StringContent(JsonSerializer.Serialize(request))).Result;
            return response.ConvertJsonDocumentAndValidateResponse();
        }

        public static void RemoveEmptyNotes()
        {
            throw new NotImplementedException();
        }
    }
}
