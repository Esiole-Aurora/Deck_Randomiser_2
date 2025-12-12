namespace Deck_Randomiser_2;

public partial class RulingsScreen : Form
{
    public RulingsScreen()
    {
        InitializeComponent();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        var menuScreen = new MenuScreen();
        menuScreen.Show();
        this.Close();
    }
}