using System.ComponentModel;

namespace Deck_Randomiser_2;

partial class DecksListModifier
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
        button1 = new System.Windows.Forms.Button();
        Deck_Names_Box = new System.Windows.Forms.RichTextBox();
        Update_Button = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.Location = new System.Drawing.Point(358, 375);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(152, 69);
        button1.TabIndex = 0;
        button1.Text = "BACK";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Deck_Names_Box
        // 
        Deck_Names_Box.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Deck_Names_Box.Location = new System.Drawing.Point(15, 15);
        Deck_Names_Box.Name = "Deck_Names_Box";
        Deck_Names_Box.Size = new System.Drawing.Size(337, 429);
        Deck_Names_Box.TabIndex = 1;
        Deck_Names_Box.Text = "";
        // 
        // Update_Button
        // 
        Update_Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Update_Button.Location = new System.Drawing.Point(358, 300);
        Update_Button.Name = "Update_Button";
        Update_Button.Size = new System.Drawing.Size(152, 69);
        Update_Button.TabIndex = 2;
        Update_Button.Text = "UPDATE";
        Update_Button.UseVisualStyleBackColor = true;
        Update_Button.Click += Update_Button_Click;
        // 
        // DecksListModifier
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)192)), ((int)((byte)255)));
        ClientSize = new System.Drawing.Size(520, 453);
        Controls.Add(Update_Button);
        Controls.Add(Deck_Names_Box);
        Controls.Add(button1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Text = "DecksListModifier";
        Load += DecksListModifier_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button Update_Button;

    private System.Windows.Forms.RichTextBox Deck_Names_Box;

    private System.Windows.Forms.Button button1;

    #endregion
}