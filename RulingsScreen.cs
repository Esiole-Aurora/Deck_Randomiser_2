using System.Net;
using System.Text.Json.Nodes;

namespace Deck_Randomiser_2;

/// <summary>
/// The Form for the rulings screen:
/// Allows the user to search a card by set and collector number to fetch its rulings from scryfall API
/// </summary>
public partial class RulingsScreen : Form
{
    /// <summary>
    /// The constructor of this class
    /// </summary>
    public RulingsScreen()
    {
        InitializeComponent();
    }

    private Image _image = null;
    private PictureBox _cardImage = null;

    /// <summary>
    /// Event handler for the Back Button, closes this form and reopens the menu form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BackButton_Click(object sender, EventArgs e)
    {
        var menuScreen = new MenuScreen();
        menuScreen.Show();
        this.Close();
    }
    
    /// <summary>
    /// Makes an HTTP GET request to the Scryfall API to fetch the rulings for a given card and saves to cardrulings.json
    /// </summary>
    private void Scryfall_GetRuling()
    {
        using var client = new WebClient();
        client.Headers.Add(HttpRequestHeader.Accept, "*/*");
        client.Headers.Add(HttpRequestHeader.UserAgent, "Deck_Randomiser_2");
        var uri = "https://api.scryfall.com/cards/";
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

    /// <summary>
    /// Parses the data from cardrulings.json and writes it to the rulings text box on the form.
    /// </summary>
    private void ParseCardRulings()
    {
        var allRulings = "";
        if (File.Exists("cardrulings.json")) {
            var jsonString = File.ReadAllText("cardrulings.json");
            var obj = JsonNode.Parse(jsonString);
            
            for (var i = 0; i<obj?[2]?.AsArray().Count; i++) {
                var ruling = obj[2]?[i]?[4]?.ToString();
                allRulings += ruling + "\n\n";
            }
            Rulings.Text = allRulings;
        }
        else
        {
            Rulings.Text = "File 'cardrulings.json' not found";
        }

    }

    /// <summary>
    /// Makes an HTTP GET request to Scryfall API to fetch the image of the card queried, stores it in a file and retrieves the image from that file
    /// </summary>
    /// <returns>A PictureBox object containing the image fetched</returns>
    private PictureBox GetCardImage()
    {
        _image?.Dispose();
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
                return new PictureBox();
            }
        }
        _image = Image.FromFile("cards2.jpg");
        var pictureBox = new PictureBox();
        pictureBox.Location = new Point(350, 48);
        pictureBox.Image = _image;
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox.Size = new Size(165, 230);
        return pictureBox;
    }

    /// <summary>
    /// Event handler for Enter Button:
    /// Clears all data currently in the form, then fetches new rulings and card image
    /// Adds the new rulings and card image to the form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EnterButton_Click(object sender, EventArgs e)
    {
        _cardImage?.Dispose();
        Rulings.Text = "";
        Scryfall_GetRuling();
        _cardImage = new PictureBox();
        _cardImage = GetCardImage();
        Controls.Add(_cardImage);
        ParseCardRulings();
    }
}