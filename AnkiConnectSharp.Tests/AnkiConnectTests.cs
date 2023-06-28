using NUnit.Framework;
using AnkiConnectSharp;
using FluentAssertions;

namespace AnkiConnectSharp.Tests
{
    [TestFixture()]
    public class AnkiConnectTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test()]
        public void GetVersionTest()
        {
            var ankiConnect = new AnkiConnect(new Uri("http://localhost:8765"));
            var version = ankiConnect.GetApiVersion();
            version.Should().Be(6);
        }

        [Test()]
        public void GetDecksOfCurrentUserTest()
        {
            var ankiConnect = new AnkiConnect(new Uri("http://localhost:8765"));
            var decks = ankiConnect.GetDecksOfCurrentUser();
            decks.Should().NotBeEmpty();

            foreach (var ankiDeck in decks)
            {
                Console.WriteLine($"{ankiDeck.Name} ({ankiDeck.Id})");
            }
        }
    }
}
