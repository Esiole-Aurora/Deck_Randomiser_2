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
        Random_Card_Button = new System.Windows.Forms.Button();
        Modify_Decks_List = new System.Windows.Forms.Button();
        RulingsButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // Deck_Selector_Button
        // 
        Deck_Selector_Button.BackColor = System.Drawing.Color.Coral;
        Deck_Selector_Button.Cursor = System.Windows.Forms.Cursors.Hand;
        Deck_Selector_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        Deck_Selector_Button.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Deck_Selector_Button.Location = new System.Drawing.Point(40, 40);
        Deck_Selector_Button.Name = "Deck_Selector_Button";
        Deck_Selector_Button.Size = new System.Drawing.Size(203, 107);
        Deck_Selector_Button.TabIndex = 0;
        Deck_Selector_Button.Text = "Deck Selector";
        Deck_Selector_Button.UseVisualStyleBackColor = false;
        Deck_Selector_Button.Click += Deck_Selector_Button_Click_1;
        // 
        // Stats_Button
        // 
        Stats_Button.BackColor = System.Drawing.Color.Coral;
        Stats_Button.Cursor = System.Windows.Forms.Cursors.Hand;
        Stats_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        Stats_Button.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Stats_Button.Location = new System.Drawing.Point(280, 40);
        Stats_Button.Name = "Stats_Button";
        Stats_Button.Size = new System.Drawing.Size(203, 107);
        Stats_Button.TabIndex = 1;
        Stats_Button.Text = "Statistics";
        Stats_Button.UseVisualStyleBackColor = false;
        Stats_Button.Click += Stats_Button_Click;
        // 
        // Random_Card_Button
        // 
        Random_Card_Button.BackColor = System.Drawing.Color.Coral;
        Random_Card_Button.Cursor = System.Windows.Forms.Cursors.Hand;
        Random_Card_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        Random_Card_Button.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Random_Card_Button.Location = new System.Drawing.Point(40, 182);
        Random_Card_Button.Name = "Random_Card_Button";
        Random_Card_Button.Size = new System.Drawing.Size(203, 107);
        Random_Card_Button.TabIndex = 2;
        Random_Card_Button.Text = "Random Card";
        Random_Card_Button.UseVisualStyleBackColor = false;
        Random_Card_Button.Click += Random_Card_Button_Click;
        // 
        // Modify_Decks_List
        // 
        Modify_Decks_List.BackColor = System.Drawing.Color.Coral;
        Modify_Decks_List.Cursor = System.Windows.Forms.Cursors.Hand;
        Modify_Decks_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        Modify_Decks_List.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Modify_Decks_List.Location = new System.Drawing.Point(280, 182);
        Modify_Decks_List.Name = "Modify_Decks_List";
        Modify_Decks_List.Size = new System.Drawing.Size(203, 107);
        Modify_Decks_List.TabIndex = 3;
        Modify_Decks_List.Text = "Modify Decks List";
        Modify_Decks_List.UseVisualStyleBackColor = false;
        Modify_Decks_List.Click += Modify_Decks_List_Click;
        // 
        // RulingsButton
        // 
        RulingsButton.BackColor = System.Drawing.Color.Coral;
        RulingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
        RulingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        RulingsButton.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        RulingsButton.Location = new System.Drawing.Point(40, 324);
        RulingsButton.Name = "RulingsButton";
        RulingsButton.Size = new System.Drawing.Size(203, 107);
        RulingsButton.TabIndex = 4;
        RulingsButton.Text = "Rulings";
        RulingsButton.UseVisualStyleBackColor = false;
        RulingsButton.Click += RulingsButton_Click;
        // 
        // MenuScreen
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)6)), ((int)((byte)0)), ((int)((byte)91)));
        ClientSize = new System.Drawing.Size(520, 453);
        Controls.Add(RulingsButton);
        Controls.Add(Modify_Decks_List);
        Controls.Add(Random_Card_Button);
        Controls.Add(Stats_Button);
        Controls.Add(Deck_Selector_Button);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Text = "MTG_ASSISTANT";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button RulingsButton;

    private System.Windows.Forms.Button Modify_Decks_List;

    private System.Windows.Forms.Button Random_Card_Button;

    private System.Windows.Forms.Button Deck_Selector_Button;
    private System.Windows.Forms.Button Stats_Button;

    #endregion
}