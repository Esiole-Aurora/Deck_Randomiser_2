using System.Collections;
using System.Security.Cryptography;

namespace Deck_Randomiser_2;

public partial class NumberSelect : Form
/*
 * Form containing randomizer for list of decks
 */
{
    private ArrayList Decks = new ArrayList();
    private ArrayList Labels = new ArrayList();
    private const int NUMBER_OF_DECKS_OWNED = 18;
    public NumberSelect()
    {
        InitializeComponent();
    }
    private void DecksList_Setup()
    {
        Decks = new ArrayList();
        TextReader reader = new StreamReader("DecksList.csv");
        foreach (string line in reader.ReadToEnd().Split('\n'))
        {
            Decks.Add(line);
        }
    }


    private void button2_Click(object sender, EventArgs e)
    {
        DecksList_Setup();
        
        foreach (Label label in Labels)
        {
            this.Controls.Remove(label);
        }
        Labels.Clear();
        
        if (validate(No_Select_Box.Text))
        {
            int number_of_decks = int.Parse(No_Select_Box.Text);
            Random rand  = new Random();
            
            for (int i = 0; i < number_of_decks; i++) {
                string next_deck = Decks[rand.Next(0, Decks.Count- 1)].ToString();
                Decks.Remove(next_deck);
                Label label = new Label();
                label.Text = next_deck;
                // set font here
                label.AutoSize = true;
                if (i < NUMBER_OF_DECKS_OWNED/2)
                {
                    label.Location = new Point(30, (i * 20) + 85);
                } else
                {
                    label.Location = new Point(200, ((i-9) * 20) + 85);
                }
                Labels.Add(label);
                this.Controls.Add(label);
                
            }
        }
    }

    private bool validate(String Text_To_Convert)
    {
        try
        {
            int num = int.Parse(Text_To_Convert);
            if (num > NUMBER_OF_DECKS_OWNED)
            {
                return false;
            }
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
    
    private void BackButton_Click(object sender, EventArgs e)
    {
        MenuScreen MenuScreen = new MenuScreen();
        MenuScreen.Show();
        this.Close();
    }
}