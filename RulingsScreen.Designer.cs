using System.ComponentModel;

namespace Deck_Randomiser_2;

partial class RulingsScreen
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
        CardName = new System.Windows.Forms.TextBox();
        EnterButton = new System.Windows.Forms.Button();
        Rulings = new System.Windows.Forms.RichTextBox();
        SuspendLayout();
        // 
        // BackButton
        // 
        BackButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        BackButton.Location = new System.Drawing.Point(358, 375);
        BackButton.Name = "BackButton";
        BackButton.Size = new System.Drawing.Size(152, 69);
        BackButton.TabIndex = 0;
        BackButton.Text = "BACK";
        BackButton.UseVisualStyleBackColor = true;
        BackButton.Click += BackButton_Click;
        // 
        // CardName
        // 
        CardName.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        CardName.Location = new System.Drawing.Point(15, 15);
        CardName.Name = "CardName";
        CardName.PlaceholderText = "SET/ID";
        CardName.Size = new System.Drawing.Size(285, 27);
        CardName.TabIndex = 1;
        // 
        // EnterButton
        // 
        EnterButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        EnterButton.Location = new System.Drawing.Point(324, 15);
        EnterButton.Name = "EnterButton";
        EnterButton.Size = new System.Drawing.Size(146, 27);
        EnterButton.TabIndex = 2;
        EnterButton.Text = "ENTER";
        EnterButton.UseVisualStyleBackColor = true;
        EnterButton.Click += EnterButton_Click;
        // 
        // Rulings
        // 
        Rulings.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Rulings.Location = new System.Drawing.Point(15, 48);
        Rulings.Name = "Rulings";
        Rulings.ReadOnly = true;
        Rulings.Size = new System.Drawing.Size(332, 395);
        Rulings.TabIndex = 3;
        Rulings.Text = "";
        // 
        // RulingsScreen
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)192)), ((int)((byte)255)));
        ClientSize = new System.Drawing.Size(520, 453);
        Controls.Add(Rulings);
        Controls.Add(EnterButton);
        Controls.Add(CardName);
        Controls.Add(BackButton);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Text = "RulingsScreen";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button EnterButton;
    private System.Windows.Forms.RichTextBox Rulings;

    private System.Windows.Forms.TextBox CardName;

    private System.Windows.Forms.Button BackButton;

    #endregion
}