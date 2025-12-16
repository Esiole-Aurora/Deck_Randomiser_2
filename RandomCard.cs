using System.Net;
using System.Web;
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
        cardImage = Scryfall_Get(false);
        this.Controls.Add(cardImage);
    }

    /// <summary>
    /// Makes an HTTP GET request to the scryfall api to get a random card and add it to the form in a PictureBox
    /// </summary>
    /// <returns>A PictureBox of the card image</returns>
    private PictureBox Scryfall_Get(bool isCommander)
    {
        image?.Dispose();
        using (var client = new WebClient())
        {
            client.Headers.Add(HttpRequestHeader.Accept, "image/jpg");
            client.Headers.Add(HttpRequestHeader.UserAgent, "Deck_Randomiser_2");
            string uri = "https://api.scryfall.com/cards/random/?";
            if (isCommander || SearchCriteria.Text != "")
            {
                uri += "q=";
            }
            if (isCommander) {
                uri += "is%3Acommander";
            }
            
            foreach (string line in SearchCriteria.Text.Split("\n"))
            {
                string encodeLine = HtmlEncode(line);
                if (line != SearchCriteria.Text.Split("\n")[0] || isCommander)
                {
                   encodeLine = "+" + encodeLine; 
                }
                uri += encodeLine;
            }
            uri += "&format=image";
            try
            {
                client.DownloadFile(uri, "cards.jpg");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
        image = Image.FromFile("cards.jpg");
        var pictureBox = new PictureBox();
        pictureBox.Location = new Point(40, 20);
        pictureBox.Image = image;
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox.Size = new Size(292, 408);
        return pictureBox;
    }

    private void Commander_Button_Click(object sender, EventArgs e)
    { 
        cardImage?.Dispose();
        this.Controls.Remove(cardImage);
        cardImage = new PictureBox();
        cardImage = Scryfall_Get(true);
        this.Controls.Add(cardImage);
    }

    private string HtmlEncode(string text)
    {
        string encoded = text.Replace(" ", "+");
        encoded = encoded.Replace("<", "%3C");
        encoded = encoded.Replace("=", "%3D");
        encoded = encoded.Replace(">", "%3E");
        encoded = encoded.Replace("&", "%26");
        encoded = encoded.Replace(":", "%3A");
        encoded = encoded.Replace("/", "%2F");
        encoded = encoded.Replace("(", "%28");
        encoded = encoded.Replace(")", "%29");
        encoded = encoded.Replace("!", "%21");
        return encoded;
    }
}