namespace Deck_Randomiser_2;

public partial class StatsCalc : Form
{
    public StatsCalc()
    {
        InitializeComponent();
    }

    private void Enter_Button_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        MenuScreen MenuScreen = new MenuScreen();
        MenuScreen.Show();
        this.Close();
    }
}