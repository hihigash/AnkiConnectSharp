using NUnit.Framework;
using AnkiConnectSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace AnkiConnectSharp.Tests
{
    [TestFixture()]
    public class AnkiDeckTests
    {
        private static List<decimal>? _noteIds;
        public AnkiDeckTests()
        {
            _noteIds = new List<decimal>();
        }
 
        [Test()]
        public void AddNoteAndDeleteNotesTest()
        {
            AnkiConnect ankiConnect = new AnkiConnect(new Uri("http://localhost:8765"));
            var docks = ankiConnect.GetDecksOfCurrentUser();
            var noteId = docks[1].AddNote("front", "back", new[] { "tag1", "tag2" });
            noteId.Should().NotBe(0);

            docks[1].DeleteNotes(new decimal[] { noteId });
        }
    }
}
