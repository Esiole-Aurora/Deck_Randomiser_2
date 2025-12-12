using System.Net;
using System.Text.Json.Nodes;

namespace Deck_Randomiser_2;

public partial class RulingsScreen : Form
{
    public RulingsScreen()
    {
        InitializeComponent();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        var menuScreen = new MenuScreen();
        menuScreen.Show();
        this.Close();
    }
    
    private void Scryfall_GetRuling()
    {
        using (var client = new WebClient())
        {
            client.Headers.Add(HttpRequestHeader.Accept, "*/*");
            client.Headers.Add(HttpRequestHeader.UserAgent, "Deck_Randomiser_2");
            string uri = "https://api.scryfall.com/cards/";
            uri += CardName.Text;
            uri += "/rulings";
            try
            {
                client.DownloadFile(uri, "cardrulings.json");
            }
            catch (Exception e)
            {
                Rulings.Text = e.Message + "\nHTTP Error";
            }
        }
    }

    private void ParseCardRulings()
    {
        string allRulings = "";
        if (File.Exists("cardrulings.json")) {
            string jsonString = File.ReadAllText("cardrulings.json");
            JsonNode obj = JsonObject.Parse(jsonString);
            
            for (int i = 0; i<obj[2].AsArray().Count; i++) {
                string ruling = obj[2][i][4].ToString();
                allRulings += ruling + "\n\n";
            }
            Rulings.Text = allRulings;
        }
        else
        {
            Rulings.Text = "File 'cardrulings.json' not found";
        }

    }
    
    private void EnterButton_Click(object sender, EventArgs e)
    {
        Rulings.Text = "";
        Scryfall_GetRuling();
        ParseCardRulings();
    }
}