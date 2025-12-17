using System.ComponentModel;

namespace Deck_Randomiser_2;

partial class NumberSelect
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        BackButton = new System.Windows.Forms.Button();
        No_Select_Box = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        Select_Button = new System.Windows.Forms.Button();
        Reroll_Button = new System.Windows.Forms.Button();
        MinBracket = new System.Windows.Forms.TextBox();
        MaxBracket = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        DecksListButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // BackButton
        // 
        BackButton.BackColor = System.Drawing.Color.Coral;
        BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
        BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        BackButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        BackButton.Location = new System.Drawing.Point(358, 375);
        BackButton.Name = "BackButton";
        BackButton.Size = new System.Drawing.Size(152, 69);
        BackButton.TabIndex = 0;
        BackButton.Text = "BACK";
        BackButton.UseVisualStyleBackColor = false;
        BackButton.Click += BackButton_Click;
        // 
        // No_Select_Box
        // 
        No_Select_Box.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        No_Select_Box.Location = new System.Drawing.Point(160, 29);
        No_Select_Box.Name = "No_Select_Box";
        No_Select_Box.Size = new System.Drawing.Size(100, 27);
        No_Select_Box.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label1.Location = new System.Drawing.Point(30, 33);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(141, 23);
        label1.TabIndex = 2;
        label1.Text = "No. of decks";
        // 
        // Select_Button
        // 
        Select_Button.BackColor = System.Drawing.Color.Coral;
        Select_Button.Cursor = System.Windows.Forms.Cursors.Hand;
        Select_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        Select_Button.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Select_Button.Location = new System.Drawing.Point(266, 29);
        Select_Button.Name = "Select_Button";
        Select_Button.Size = new System.Drawing.Size(90, 27);
        Select_Button.TabIndex = 3;
        Select_Button.Text = "SELECT";
        Select_Button.UseVisualStyleBackColor = false;
        Select_Button.Click += button2_Click;
        // 
        // Reroll_Button
        // 
        Reroll_Button.BackColor = System.Drawing.Color.Coral;
        Reroll_Button.Cursor = System.Windows.Forms.Cursors.Hand;
        Reroll_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        Reroll_Button.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Reroll_Button.Location = new System.Drawing.Point(362, 29);
        Reroll_Button.Name = "Reroll_Button";
        Reroll_Button.Size = new System.Drawing.Size(90, 27);
        Reroll_Button.TabIndex = 4;
        Reroll_Button.Text = "REROLL";
        Reroll_Button.UseVisualStyleBackColor = false;
        Reroll_Button.Click += button1_Click;
        // 
        // MinBracket
        // 
        MinBracket.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        MinBracket.Location = new System.Drawing.Point(470, 234);
        MinBracket.Name = "MinBracket";
        MinBracket.Size = new System.Drawing.Size(40, 27);
        MinBracket.TabIndex = 5;
        MinBracket.Text = "1";
        MinBracket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        MinBracket.TextChanged += MinBracket_TextChanged;
        // 
        // MaxBracket
        // 
        MaxBracket.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        MaxBracket.Location = new System.Drawing.Point(470, 267);
        MaxBracket.Name = "MaxBracket";
        MaxBracket.Size = new System.Drawing.Size(40, 27);
        MaxBracket.TabIndex = 6;
        MaxBracket.Text = "5";
        MaxBracket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        MaxBracket.TextChanged += MaxBracket_TextChanged;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label2.Location = new System.Drawing.Point(343, 234);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(130, 27);
        label2.TabIndex = 7;
        label2.Text = "MIN BRACKET:";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        label3.Location = new System.Drawing.Point(343, 267);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(130, 27);
        label3.TabIndex = 8;
        label3.Text = "MAX BRACKET:";
        // 
        // DecksListButton
        // 
        DecksListButton.BackColor = System.Drawing.Color.Coral;
        DecksListButton.Cursor = System.Windows.Forms.Cursors.Hand;
        DecksListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        DecksListButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        DecksListButton.Location = new System.Drawing.Point(358, 300);
        DecksListButton.Name = "DecksListButton";
        DecksListButton.Size = new System.Drawing.Size(152, 69);
        DecksListButton.TabIndex = 9;
        DecksListButton.Text = "MODIFY DECKS";
        DecksListButton.UseVisualStyleBackColor = false;
        DecksListButton.Click += DecksListButton_Click;
        // 
        // NumberSelect
        // 
        AcceptButton = Select_Button;
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)6)), ((int)((byte)0)), ((int)((byte)91)));
        CancelButton = BackButton;
        ClientSize = new System.Drawing.Size(520, 453);
        Controls.Add(DecksListButton);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(MaxBracket);
        Controls.Add(MinBracket);
        Controls.Add(Reroll_Button);
        Controls.Add(Select_Button);
        Controls.Add(No_Select_Box);
        Controls.Add(label1);
        Controls.Add(BackButton);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Text = "Number_Select";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button DecksListButton;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.TextBox MinBracket;
    private System.Windows.Forms.TextBox MaxBracket;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button Reroll_Button;

    private System.Windows.Forms.Button Select_Button;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox No_Select_Box;

    private System.Windows.Forms.Button BackButton;

    #endregion
}