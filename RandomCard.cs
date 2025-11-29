using System.Net;
using PictureBox = System.Windows.Forms.PictureBox;

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
    /// Event handler for enter button, makes a http get request to Scryfall API for a random card
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Enter_Button_Click(object sender, EventArgs e)
    {
        cardImage?.Dispose();

        this.Controls.Remove(cardImage);
        cardImage = new PictureBox();
        
        using (var client = new WebClient())
        {
            client.Headers.Add(HttpRequestHeader.Accept, "image/png");
            client.Headers.Add(HttpRequestHeader.UserAgent, "Deck_Randomiser_2");
            client.DownloadFile("https://api.scryfall.com/cards/random/?format=image", "cards.png");
        }

        var image = Image.FromFile("cards.png");
        cardImage.Location = new Point(40, 20);
        cardImage.Image = image;
        cardImage.SizeMode = PictureBoxSizeMode.StretchImage;
        cardImage.Size = new Size(292, 408);
        this.Controls.Add(cardImage);
        
    }


}