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
        Enter_Button = new System.Windows.Forms.Button();
        Commander_Button = new System.Windows.Forms.Button();
        SearchCriteria = new System.Windows.Forms.RichTextBox();
        SuspendLayout();
        // 
        // Back_Button
        // 
        Back_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        Back_Button.BackColor = System.Drawing.Color.Coral;
        Back_Button.Cursor = System.Windows.Forms.Cursors.Hand;
        Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        Back_Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Back_Button.Location = new System.Drawing.Point(358, 375);
        Back_Button.Name = "Back_Button";
        Back_Button.Size = new System.Drawing.Size(152, 69);
        Back_Button.TabIndex = 0;
        Back_Button.Text = "BACK";
        Back_Button.UseVisualStyleBackColor = false;
        Back_Button.Click += Back_Button_Click;
        // 
        // Enter_Button
        // 
        Enter_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        Enter_Button.BackColor = System.Drawing.Color.Coral;
        Enter_Button.Cursor = System.Windows.Forms.Cursors.Hand;
        Enter_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        Enter_Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Enter_Button.Location = new System.Drawing.Point(358, 300);
        Enter_Button.Name = "Enter_Button";
        Enter_Button.Size = new System.Drawing.Size(152, 69);
        Enter_Button.TabIndex = 2;
        Enter_Button.Text = "GET A CARD";
        Enter_Button.UseVisualStyleBackColor = false;
        Enter_Button.Click += Enter_Button_Click;
        // 
        // Commander_Button
        // 
        Commander_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        Commander_Button.BackColor = System.Drawing.Color.Coral;
        Commander_Button.Cursor = System.Windows.Forms.Cursors.Hand;
        Commander_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        Commander_Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Commander_Button.Location = new System.Drawing.Point(358, 225);
        Commander_Button.Name = "Commander_Button";
        Commander_Button.Size = new System.Drawing.Size(152, 69);
        Commander_Button.TabIndex = 4;
        Commander_Button.Text = "GET A COMMANDER";
        Commander_Button.UseVisualStyleBackColor = false;
        Commander_Button.Click += Commander_Button_Click;
        // 
        // SearchCriteria
        // 
        SearchCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        SearchCriteria.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        SearchCriteria.Location = new System.Drawing.Point(358, 24);
        SearchCriteria.Name = "SearchCriteria";
        SearchCriteria.Size = new System.Drawing.Size(151, 195);
        SearchCriteria.TabIndex = 5;
        SearchCriteria.Text = "";
        // 
        // RandomCard
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)6)), ((int)((byte)0)), ((int)((byte)91)));
        ClientSize = new System.Drawing.Size(520, 453);
        Controls.Add(SearchCriteria);
        Controls.Add(Commander_Button);
        Controls.Add(Enter_Button);
        Controls.Add(Back_Button);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Location = new System.Drawing.Point(19, 19);
        MaximizeBox = false;
        Text = "MTG_ASSISTANT";
        ResumeLayout(false);
    }

    private System.Windows.Forms.RichTextBox SearchCriteria;

    private System.Windows.Forms.Button Commander_Button;

    private System.Windows.Forms.Button Enter_Button;

    private System.Windows.Forms.Button Back_Button;

    #endregion
}