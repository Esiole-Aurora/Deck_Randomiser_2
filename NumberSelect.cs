using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using Random = System.Random;

namespace Deck_Randomiser_2;

public partial class NumberSelect : Form
/*
 * Form containing randomizer for list of decks
 */
{
    private ArrayList Decks = new ArrayList();
    private Dictionary<Label, CheckBox> Labels = new Dictionary<Label, CheckBox>();
    private const int NUMBER_OF_DECKS_OWNED = 18;
    public NumberSelect()
    {
        InitializeComponent();
    }
    private void DecksList_Setup()
    {
        Decks = new ArrayList();
        TextReader reader = new StreamReader("DecksList.csv");
        foreach (var line in reader.ReadToEnd().Split('\n'))
        {
            Decks.Add(line);
        }
    }


    private void button2_Click(object sender, EventArgs e)
    {
        DecksList_Setup();
        
        foreach (Label key in Labels.Keys)
        {
            this.Controls.Remove(key);
            this.Controls.Remove(Labels[key]);
        }
        Labels.Clear();
        
        if (validate(No_Select_Box.Text))
        {
            var number_of_decks = int.Parse(No_Select_Box.Text);
            Random rand  = new Random();
            
            for (var i = 0; i < number_of_decks; i++) {
                var next_deck = Decks[rand.Next(0, Decks.Count- 1)].ToString();
                Decks.Remove(next_deck);
                var label = new Label();
                label.Text = next_deck;
                // set font here
                label.AutoSize = true;
                var checkBox = new CheckBox();
                checkBox.AutoSize = true;
                checkBox.Checked = false;
                if (i < NUMBER_OF_DECKS_OWNED/2)
                {
                    label.Location = new Point(30, (i * 20) + 85);
                    checkBox.Location = new Point(180, (i * 20) + 85);
                } else
                {
                    label.Location = new Point(200, ((i-9) * 20) + 85);
                    checkBox.Location = new Point(350, ((i-9) * 20) + 85);
                }
                
                
                Labels[label] = checkBox;
                this.Controls.Add(checkBox);
                this.Controls.Add(label);
                
            }
        }
    }

    private bool validate(string Text_To_Convert)
    {
        try
        {
            var num = int.Parse(Text_To_Convert);
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
        var menuScreen = new MenuScreen();
        menuScreen.Show();
        this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        foreach (Label key in Labels.Keys)
        {
            Random rand = new Random();
            if (Labels[key].Checked == true)
            {
                if (Decks.Count > 0)
                {
                    int val = rand.Next(0, Decks.Count - 1);
                    key.Text = Decks[val]?.ToString();
                    Decks.RemoveAt(val);
                }

            }
        }
    }
}