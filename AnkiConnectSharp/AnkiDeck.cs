using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnkiConnectSharp
{
    public class AnkiDeck
    {
        public AnkiDeck(AnkiConnect ankiConnect, decimal id, string deckName)
        {
            this.AnkiConnect = ankiConnect;
            this.Id = id;
            this.Name = deckName;
        }

        public AnkiConnect AnkiConnect { get; }

        public decimal Id { get; }

        public string Name { get; }

        public decimal AddNote(string front, string back)
        {
            var json = NativeActions.NoteActions.AddNote(AnkiConnect.HttpClient, Name, front, back);
            return json.RootElement.GetProperty("result").GetDecimal();
        }

        public void DeleteNotes(decimal[] noteIds)
        {
            NativeActions.NoteActions.DeleteNotes(AnkiConnect.HttpClient, noteIds);
        }
    }
}
