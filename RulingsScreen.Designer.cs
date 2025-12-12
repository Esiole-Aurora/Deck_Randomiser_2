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
        // RulingsScreen
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)192)), ((int)((byte)255)));
        ClientSize = new System.Drawing.Size(520, 453);
        Controls.Add(BackButton);
        Text = "RulingsScreen";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button BackButton;

    #endregion
}