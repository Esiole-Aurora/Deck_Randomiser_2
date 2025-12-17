using System;
using System.Windows.Forms;

namespace Deck_Randomiser_2;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MenuScreen());
        Application.Exit();
    }
}