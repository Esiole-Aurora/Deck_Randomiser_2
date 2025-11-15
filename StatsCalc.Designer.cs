using System.ComponentModel;

namespace Deck_Randomiser_2;

partial class StatsCalc
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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        Deck_Size = new System.Windows.Forms.TextBox();
        Copies = new System.Windows.Forms.TextBox();
        Hand_Size = new System.Windows.Forms.TextBox();
        Enter_Button = new System.Windows.Forms.Button();
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
        // label1
        // 
        label1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(30, 33);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(188, 23);
        label1.TabIndex = 1;
        label1.Text = "Size of Deck";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(30, 63);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(188, 23);
        label2.TabIndex = 2;
        label2.Text = "Number of copies";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(30, 93);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(188, 23);
        label3.TabIndex = 3;
        label3.Text = "Cards in opening";
        // 
        // Deck_Size
        // 
        Deck_Size.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Deck_Size.Location = new System.Drawing.Point(213, 33);
        Deck_Size.Name = "Deck_Size";
        Deck_Size.Size = new System.Drawing.Size(72, 27);
        Deck_Size.TabIndex = 4;
        Deck_Size.Text = "100";
        // 
        // Copies
        // 
        Copies.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Copies.Location = new System.Drawing.Point(213, 63);
        Copies.Name = "Copies";
        Copies.Size = new System.Drawing.Size(72, 27);
        Copies.TabIndex = 5;
        Copies.Text = "1";
        // 
        // Hand_Size
        // 
        Hand_Size.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Hand_Size.Location = new System.Drawing.Point(213, 93);
        Hand_Size.Name = "Hand_Size";
        Hand_Size.Size = new System.Drawing.Size(72, 27);
        Hand_Size.TabIndex = 6;
        Hand_Size.Text = "7";
        // 
        // Enter_Button
        // 
        Enter_Button.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Enter_Button.Location = new System.Drawing.Point(30, 123);
        Enter_Button.Name = "Enter_Button";
        Enter_Button.Size = new System.Drawing.Size(255, 30);
        Enter_Button.TabIndex = 7;
        Enter_Button.Text = "CALCULATE";
        Enter_Button.UseVisualStyleBackColor = true;
        // 
        // StatsCalc
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)192)), ((int)((byte)255)));
        ClientSize = new System.Drawing.Size(520, 453);
        Controls.Add(Enter_Button);
        Controls.Add(Hand_Size);
        Controls.Add(Copies);
        Controls.Add(Deck_Size);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(BackButton);
        Text = "Stats_Calc";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox Copies;
    private System.Windows.Forms.TextBox Hand_Size;
    private System.Windows.Forms.Button Enter_Button;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox Deck_Size;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button BackButton;

    #endregion
}