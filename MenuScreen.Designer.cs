namespace Deck_Randomiser_2;

partial class MenuScreen
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Deck_Selector_Button = new System.Windows.Forms.Button();
        Stats_Button = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // Deck_Selector_Button
        // 
        Deck_Selector_Button.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Deck_Selector_Button.Location = new System.Drawing.Point(40, 40);
        Deck_Selector_Button.Name = "Deck_Selector_Button";
        Deck_Selector_Button.Size = new System.Drawing.Size(203, 107);
        Deck_Selector_Button.TabIndex = 0;
        Deck_Selector_Button.Text = "Deck Selector";
        Deck_Selector_Button.UseVisualStyleBackColor = true;
        Deck_Selector_Button.Click += Deck_Selector_Button_Click_1;
        // 
        // Stats_Button
        // 
        Stats_Button.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Stats_Button.Location = new System.Drawing.Point(280, 40);
        Stats_Button.Name = "Stats_Button";
        Stats_Button.Size = new System.Drawing.Size(203, 107);
        Stats_Button.TabIndex = 1;
        Stats_Button.Text = "Statistics";
        Stats_Button.UseVisualStyleBackColor = true;
        Stats_Button.Click += Stats_Button_Click;
        // 
        // MenuScreen
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)192)), ((int)((byte)255)));
        ClientSize = new System.Drawing.Size(520, 453);
        Controls.Add(Stats_Button);
        Controls.Add(Deck_Selector_Button);
        Text = "MTG_ASSISTANT";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button Deck_Selector_Button;
    private System.Windows.Forms.Button Stats_Button;

    #endregion
}