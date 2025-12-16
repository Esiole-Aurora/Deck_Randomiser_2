using System.Net;
using System.Text.Json.Nodes;

namespace Deck_Randomiser_2;

public partial class RulingsScreen : Form
{
    public RulingsScreen()
    {
        InitializeComponent();
    }

    private Image image;
    private PictureBox cardImage;

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

    private PictureBox getCardImage()
    {
        image?.Dispose();
        using (var client = new WebClient())
        {
            client.Headers.Add(HttpRequestHeader.Accept, "image/jpg");
            client.Headers.Add(HttpRequestHeader.UserAgent, "Deck_Randomiser_2");
            var uri = "https://api.scryfall.com/cards/";
            uri += CardName.Text;
            uri += "/?format=image";
            try
            {
                client.DownloadFile(uri, "cards2.jpg");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        image = Image.FromFile("cards2.jpg");
        var pictureBox = new PictureBox();
        pictureBox.Location = new Point(350, 48);
        pictureBox.Image = image;
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox.Size = new Size(165, 230);
        return pictureBox;
    }

    private void EnterButton_Click(object sender, EventArgs e)
    {
        cardImage?.Dispose();
        Rulings.Text = "";
        Scryfall_GetRuling();
        cardImage = new PictureBox();
        cardImage = getCardImage();
        Controls.Add(cardImage);
        ParseCardRulings();
    }
}