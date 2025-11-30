using System.Net;
using PictureBox = System.Windows.Forms.PictureBox;
using Point = System.Drawing.Point;

namespace Deck_Randomiser_2;

/// <summary>
/// Random Card Form
/// </summary>
public partial class RandomCard : Form
{
    private PictureBox cardImage;
    /// <summary>
    /// Constructor for this class
    /// </summary>
    public RandomCard()
    {
        InitializeComponent();
    }

    private Image image;

    /// <summary>
    /// Event handler for the back button, loads menu screen and closes this form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Back_Button_Click(object sender, EventArgs e)
    {
        var menuScreen = new MenuScreen();
        menuScreen.Show();
        this.Close();
    }

    /// <summary>
    /// Event handler for enter button, makes a http get request to Scryfall API for a random card and displays that card in a PictureBox
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Enter_Button_Click(object sender, EventArgs e)
    {
        cardImage?.Dispose();
        this.Controls.Remove(cardImage);
        cardImage = new PictureBox();
        cardImage = Scryfall_Get();
        this.Controls.Add(cardImage);
    }

    /// <summary>
    /// Makes an HTTP GET request to the scryfall api to get a random card and add it to the form in a PictureBox
    /// </summary>
    /// <returns>A PictureBox of the card image</returns>
    private PictureBox Scryfall_Get()
    {
        image?.Dispose();
        using (var client = new WebClient())
        {
            client.Headers.Add(HttpRequestHeader.Accept, "image/png");
            client.Headers.Add(HttpRequestHeader.UserAgent, "Deck_Randomiser_2");
            string uri = "https://api.scryfall.com/cards/random/?format=image";
            if (Commander_Box.Checked) {
                uri = "https://api.scryfall.com/cards/random?q=is%3Acommander&format=image";
            }
            client.DownloadFile(uri, "cards.png");
        }
        image = Image.FromFile("cards.png");
        var pictureBox = new PictureBox();
        pictureBox.Location = new Point(40, 20);
        pictureBox.Image = image;
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox.Size = new Size(292, 408);
        return pictureBox;
    }
}