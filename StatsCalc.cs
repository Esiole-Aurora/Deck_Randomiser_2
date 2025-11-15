namespace Deck_Randomiser_2;
using System.Windows.Forms.DataVisualization.Charting;
    
public partial class StatsCalc : Form
{
    public StatsCalc()
    {
        InitializeComponent();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        MenuScreen MenuScreen = new MenuScreen();
        MenuScreen.Show();
        this.Close();
    }

    private void Enter_Button_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}