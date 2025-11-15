namespace Deck_Randomiser_2;

public partial class MenuScreen : Form
{
    /*
     * MENU SCREEN
     * Contains buttons to select and load the following forms:
     * Deck Selector
     * Statistical Calculator
     */
    public MenuScreen()
    {
        InitializeComponent();
        
    }
    private void Deck_Selector_Button_Click_1(object sender, EventArgs e)
    {
        NumberSelect numberSelect = new NumberSelect();
        numberSelect.Show();
        this.Hide();
    }
    
    private void Stats_Button_Click(object sender, EventArgs e)
    {
        StatsCalc statsCalc = new StatsCalc();
        statsCalc.Show();
        this.Hide();
    }


}