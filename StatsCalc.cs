using System;
using System.Collections;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace Deck_Randomiser_2;

public partial class StatsCalc : Form
{
    private readonly ArrayList _labels = new ArrayList();

    public StatsCalc()
    {
        InitializeComponent();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        var menuScreen = new MenuScreen();
        menuScreen.Show();
        this.Close();
    }

    private void Enter_Button_Click(object sender, EventArgs e)
    {
        foreach (Label label in _labels)
        {
            this.Controls.Remove(label);
        }

        _labels.Clear();

        if (!ValidateVals()) return;
        
        for (var i = int.Parse(Hand_Size.Text); i < int.Parse(Hand_Size.Text) + 4; i++)
        {
            var label = new Label();
            label.Text = "Probability after " + i.ToString() + " draws: " +
                         (GreaterThanEqualTo(i,int.Parse(Deck_Size.Text), 
                int.Parse(Copies.Text), int.Parse(Copies_Wanted.Text)).ToString("0.##"));
            // set font here
            label.AutoSize = true;
            label.Location = new Point(30, ((i - int.Parse(Hand_Size.Text)) * 20) + 200);
            _labels.Add(label);
            this.Controls.Add(label);

        }
        
    }

    private bool ValidateVals()
    {
        return true;
    }

    private static double CalculateProbability(int sampleSize, 
        int populationSize, 
        int successStates, 
        int successesInSample)
    {
        double probability = 0;
        
        if (successStates <= 0) return probability;
        
        probability = CombinationsWithoutRepetitions(successStates, successesInSample);
        probability *= CombinationsWithoutRepetitions(populationSize - successStates, 
            sampleSize - successesInSample);
        probability /= CombinationsWithoutRepetitions(populationSize, sampleSize);
        return probability;
    }

    private static double GreaterThanEqualTo(int sampleSize, 
        int populationSize, 
        int successStates, 
        int successesInSample)
    {
        double probability = 0;
        for (int i = 0; i < successesInSample; i++)
        {
            probability += CalculateProbability(sampleSize, populationSize, successStates, i);
        }

        return 1 - probability;
    }
    private static double CombinationsWithoutRepetitions(int n, int r)
    {
        BigInteger factN = Fact(n);
        BigInteger factR = Fact(r);
        BigInteger factNr = Fact(n-r); 
        var val = (double) BigInteger.Divide(factN, BigInteger.Multiply(factR, factNr));
        return val;
    }

    private static BigInteger Fact(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        BigInteger j = n;
        for (var i = n - 1; i >= 1; i--)
        {
            j = BigInteger.Multiply(j, i);
        }

        return j;
    }
    
}