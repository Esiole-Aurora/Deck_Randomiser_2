using System;
using System.Collections;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace Deck_Randomiser_2;

/// <summary>
/// The form for hypergeometric calculator
/// </summary>
public partial class StatsCalc : Form
{
    private readonly ArrayList _labels = new ArrayList();

    /// <summary>
    /// Constructor for this class
    /// </summary>
    public StatsCalc()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Event handler for the back button, loads menu screen and closes this form
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
    /// Event handler for the enter button
    /// Deletes all labels previously created and calls relevant functions to calculate the probability given values in the text boxes
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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
    
    /// <summary>
    /// Validates that all values are integers and greater than 0
    /// </summary>
    /// <returns>A boolean, true if all values are valid, false otherwise</returns>
    private static bool ValidateVals()
    {
        return true;
    }

    /// <summary>
    /// Calls relevant functions to use a hypergeometric distribution to calculate the probability of n success states in a sample
    /// </summary>
    /// <param name="sampleSize">The size of the sample taken from the population</param>
    /// <param name="populationSize">The size of the population</param>
    /// <param name="successStates">The number of success states in the population</param>
    /// <param name="successesInSample">The number of success states wanted in the sample</param>
    /// <returns>The probability as a double</returns>
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

    /// <summary>
    /// Calculates the probability of less than n success states and then subtracts that value from 1 to calculate greater than or equal to
    /// </summary>
    /// <param name="sampleSize">The size of the sample taken from the population</param>
    /// <param name="populationSize">The size of the population</param>
    /// <param name="successStates">The number of success states in the population</param>
    /// <param name="successesInSample">The number of success states wanted in the sample</param>
    /// <returns>The probability as a double</returns>
    private static double GreaterThanEqualTo(int sampleSize, 
        int populationSize, 
        int successStates, 
        int successesInSample)
    {
        double probability = 0;
        for (var i = 0; i < successesInSample; i++)
        {
            probability += CalculateProbability(sampleSize, populationSize, successStates, i);
        }

        return 1 - probability;
    }
    /// <summary>
    /// Computes the number of combinations of size r without repetitions from a set of size n
    /// </summary>
    /// <param name="n">The size of the set</param>
    /// <param name="r">The size of each combination</param>
    /// <returns>A double of the number of combinations without repetitions</returns>
    private static double CombinationsWithoutRepetitions(int n, int r)
    {
        BigInteger factN = Fact(n);
        BigInteger factR = Fact(r);
        BigInteger factNr = Fact(n-r); 
        var val = (double) BigInteger.Divide(factN, BigInteger.Multiply(factR, factNr));
        return val;
    }

    /// <summary>
    /// Computes the factorial of an integer n
    /// </summary>
    /// <param name="n">An integer value</param>
    /// <returns>A BigInteger: n!</returns>
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