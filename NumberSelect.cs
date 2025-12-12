using System.Collections;
using System.Drawing.Design;
using Random = System.Random;

namespace Deck_Randomiser_2;

/// <summary>
/// Deck Selection Form, allows user to randomly select a number of decks from a csv file
/// </summary>
public partial class NumberSelect : Form

{
    private ArrayList _decks = new ArrayList();
    private readonly Dictionary<Label, CheckBox> _labels = new Dictionary<Label, CheckBox>();
    private int _numberOfDecksOwned;
    private const string FilePath = "DecksList.csv";
    
    /// <summary>
    /// Constructor for this class
    /// </summary>
    public NumberSelect()
    {
        InitializeComponent();
    }
    /// <summary>
    /// Instantiates _decks as an ArrayList and reads the csv at FilePath
    /// </summary>
    private void DecksList_Setup()
    {
        _decks = new ArrayList();
        TextReader reader = new StreamReader(FilePath);
        foreach (var line in reader.ReadToEnd().Split('\n'))
        {
            var deckname = line.Split(',')[0].Trim();
            var bracket = Convert.ToInt32(line.Split(',')[1].Trim());
            if (!ValidateBrackets(MinBracket.Text) || !ValidateBrackets(MaxBracket.Text)) {return;}
            if (bracket >= int.Parse(MinBracket.Text) && bracket <= int.Parse(MaxBracket.Text))
            {
                _decks.Add(deckname);
            }
        }
        _numberOfDecksOwned = _decks.Count;
    }

    /// <summary>
    /// Deck selection button, deletes all current labels and checkboxes and instantiates a number equal o the contents of the textbox
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button2_Click(object sender, EventArgs e)
    {
        DecksList_Setup();
        
        foreach (var key in _labels.Keys)
        {
            Controls.Remove(key);
            Controls.Remove(_labels[key]);
        }
        _labels.Clear();

        if (!ValidateDecks(No_Select_Box.Text)||!ValidateBrackets(MaxBracket.Text)||!ValidateBrackets(MinBracket.Text)) return;
        var numberOfDecks = int.Parse(No_Select_Box.Text);
        var rand  = new Random();
            
        for (var i = 0; i < numberOfDecks; i++) {
            var nextDeck = _decks[rand.Next(0, _decks.Count- 1)].ToString();
            _decks.Remove(nextDeck);
            var label = new Label();
            label.Text = nextDeck;
            label.Font = new Font("Courier New", 10f);
            label.AutoSize = true;
            var checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.Checked = false;
            if (i < decimal.Round(_numberOfDecksOwned/2))
            {
                label.Location = new Point(30, (i * 20) + 85);
                checkBox.Location = new Point(210, (i * 20) + 85);
            } else
            {
                label.Location = new Point(280, ((i-9) * 20) + 85);
                checkBox.Location = new Point(470, ((i-9) * 20) + 85);
            }
                
                
            _labels[label] = checkBox;
            this.Controls.Add(checkBox);
            this.Controls.Add(label);
                
        }
    }

    /// <summary>
    /// Validates data passed as parameter, data must be an integer and less than the number of decks available
    /// </summary>
    /// <param name="textToConvert">The string value that is to be parsed as an integer</param>
    /// <returns>True if the contents of the textbox is an integer and less than the number of decks available</returns>
    private bool ValidateDecks(string textToConvert)
    {
        try
        {
            var num = int.Parse(textToConvert);
            return (int.Parse(No_Select_Box.Text) < _numberOfDecksOwned);
        }
        catch (Exception e)
        {
            return false;
        }
    }
    private bool ValidateBrackets(string textToConvert)
    {
        try
        {
            var num = int.Parse(textToConvert);
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    } 
    
    /// <summary>
    /// Event handler for back button, returns to menu screen and closes this form
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
    /// Event handler for reroll button, selects a new deck for any label with its checkbox ticked if there is a deck available
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button1_Click(object sender, EventArgs e)
    {
        foreach (var key in _labels.Keys)
        {
            var rand = new Random();
            if (_labels[key].Checked != true) continue;
            if (_decks.Count <= 0) continue;
            var val = rand.Next(0, _decks.Count - 1);
            key.Text = _decks[val]?.ToString();
            _decks.RemoveAt(val);
        }
    }

    private void MinBracket_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (MinBracket.Text != "" && MinBracket.Text != " ")
            {
                int i = int.Parse(MaxBracket.Text);
                if (int.Parse(MaxBracket.Text) < int.Parse(MinBracket.Text))
                {
                    MinBracket.Text = MaxBracket.Text;
                }
                             
                if (int.Parse(MinBracket.Text) < 1)
                {
                    MaxBracket.Text = "1";
                }
                             
                if (int.Parse(MaxBracket.Text) > 5)
                {
                    MaxBracket.Text = "5";
                }
            }
        }
        catch (Exception exception)
        {
            MinBracket.Text = "1";
        }

        
    }

    private void MaxBracket_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (MaxBracket.Text != "" && MaxBracket.Text != " ")
            {
                int i = int.Parse(MaxBracket.Text);
                 if (int.Parse(MaxBracket.Text) < int.Parse(MinBracket.Text))
                 {
                     MaxBracket.Text = MinBracket.Text;
                 }
                
                 if (int.Parse(MaxBracket.Text) < 1 && MaxBracket.Text!=" ")
                 {
                     MaxBracket.Text = "1";
                 }
                
                 if (int.Parse(MaxBracket.Text) > 5 && MaxBracket.Text!=" ")
                 {
                     MaxBracket.Text = "5";
                 }
            }
        }
        catch (Exception exception)
        {
            MaxBracket.Text = "5";
        }
    }

}
