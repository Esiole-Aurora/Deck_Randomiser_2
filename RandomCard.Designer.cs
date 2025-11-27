using System.ComponentModel;

namespace Deck_Randomiser_2;

partial class RandomCard
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
        Back_Button = new System.Windows.Forms.Button();
        Scryfall_Criteria = new System.Windows.Forms.TextBox();
        Enter_Button = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // Back_Button
        // 
        Back_Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Back_Button.Location = new System.Drawing.Point(358, 375);
        Back_Button.Name = "Back_Button";
        Back_Button.Size = new System.Drawing.Size(152, 69);
        Back_Button.TabIndex = 0;
        Back_Button.Text = "BACK";
        Back_Button.UseVisualStyleBackColor = true;
        Back_Button.Click += Back_Button_Click;
        // 
        // Scryfall_Criteria
        // 
        Scryfall_Criteria.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Scryfall_Criteria.Location = new System.Drawing.Point(20, 20);
        Scryfall_Criteria.Name = "Scryfall_Criteria";
        Scryfall_Criteria.Size = new System.Drawing.Size(304, 27);
        Scryfall_Criteria.TabIndex = 1;
        // 
        // Enter_Button
        // 
        Enter_Button.Location = new System.Drawing.Point(373, 27);
        Enter_Button.Name = "Enter_Button";
        Enter_Button.Size = new System.Drawing.Size(75, 23);
        Enter_Button.TabIndex = 2;
        Enter_Button.Text = "ENTER";
        Enter_Button.UseVisualStyleBackColor = true;
        // 
        // RandomCard
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)192)), ((int)((byte)255)));
        ClientSize = new System.Drawing.Size(520, 453);
        Controls.Add(Enter_Button);
        Controls.Add(Scryfall_Criteria);
        Controls.Add(Back_Button);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Text = "RandomCard";
        Load += RandomCard_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button Enter_Button;

    private System.Windows.Forms.TextBox Scryfall_Criteria;

    private System.Windows.Forms.Button Back_Button;

    #endregion
}