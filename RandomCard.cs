namespace Deck_Randomiser_2;

/// <summary>
/// Random Card Form
/// </summary>
public partial class RandomCard : Form
{
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
        

    }
    
}