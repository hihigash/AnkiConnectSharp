using AnkiConnectSharp;

if (args.Length != 1)
{
    Console.WriteLine("Usage: AnkiImporter.exe <path to CSV file>");
    return;
}

var fileName = args[0];
if (!File.Exists(fileName))
{
    Console.WriteLine($"File {fileName} does not exist");
    return;
}

var ankiConnect = new AnkiConnect(new Uri(@"http://localhost:8765"));
var deck = ankiConnect.GetDecksOfCurrentUser().First(x => x.Name == "{desk name}");

var lines = File.ReadAllLines(fileName);
foreach (var line in lines)
{
    var cells = line.Split(',');
    deck.AddNote(cells[0], cells[1], new[] { cells[2] });
}
