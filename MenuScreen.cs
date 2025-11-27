using System;
using System.Windows.Forms;

namespace Deck_Randomiser_2;

/// <summary>
/// MENU SCREEN
/// Contains buttons that link to the following forms:
/// - Deck Selector
/// - Statistics Calculator
/// </summary>
public partial class MenuScreen : Form
{
    /// <summary>
    /// Constructor for this class
    /// </summary>
    public MenuScreen()
    {
        InitializeComponent();
        
    }
    /// <summary>
    /// Instantiates deck selector form, hides this form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Deck_Selector_Button_Click_1(object sender, EventArgs e)
    {
        var numberSelect = new NumberSelect();
        numberSelect.Show();
        this.Hide();
    }
    
    /// <summary>
    /// Instantiates calculator form, hides this form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Stats_Button_Click(object sender, EventArgs e)
    {
        var statsCalc = new StatsCalc();
        statsCalc.Show();
        this.Hide();
    }


    private void Random_Card_Button_Click(object sender, EventArgs e)
    {
        var randomCard = new RandomCard();
        randomCard.Show();
        this.Hide();
    }
}