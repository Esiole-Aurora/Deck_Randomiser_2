namespace Deck_Randomiser_2;

/// <summary>
/// The Decks List Modifier Form, allows the user to modify the list of decks accessed by other forms.
/// </summary>
public partial class DecksListModifier : Form
{
    private string FilePath = "DecksList.csv";
    /// <summary>
    /// The constructor for this form
    /// </summary>
    public DecksListModifier()
    {
        InitializeComponent();
    }

    /// <summary>
    /// When the form is loaded, reads contents of DecksList.csv into Deck_Names_Box's text attribute
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DecksListModifier_Load(object sender, EventArgs e)
    {
        TextReader reader = new StreamReader(FilePath);
        Deck_Names_Box.Text = reader.ReadToEnd();
        reader.Close();
    }

    /// <summary>
    /// Event handler for the update button.
    /// When update button is clicked, writes the contents of Deck_Names_Box to DecksList.csv
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Update_Button_Click(object sender, EventArgs e)
    {
        TextWriter textWriter = new StreamWriter(FilePath);
        textWriter.Write(Deck_Names_Box.Text);
        textWriter.Close();
    }

    /// <summary>
    /// Event handler for the back button, loads the menu screen form and closes this form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button1_Click(object sender, EventArgs e)
    {
        var menuScreen = new MenuScreen();
        menuScreen.Show();
        this.Close();
    }
}