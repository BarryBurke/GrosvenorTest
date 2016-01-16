namespace GrosvenorTextEditor
{
    partial class TextEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TotalWordCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CharacterCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DistinctCharacterCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.NumCharactersRemainingToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LargestWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SmallestWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MostFrequentWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isCaseSensitiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.TotalWordCountToolStripStatusLabel,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel2,
            this.CharacterCountToolStripStatusLabel,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel5,
            this.DistinctCharacterCountToolStripStatusLabel,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.NumCharactersRemainingToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 382);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(682, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(78, 17);
            this.toolStripStatusLabel1.Text = "Word Count: ";
            // 
            // TotalWordCountToolStripStatusLabel
            // 
            this.TotalWordCountToolStripStatusLabel.Name = "TotalWordCountToolStripStatusLabel";
            this.TotalWordCountToolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.TotalWordCountToolStripStatusLabel.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(97, 17);
            this.toolStripStatusLabel2.Text = "Character Count:";
            // 
            // CharacterCountToolStripStatusLabel
            // 
            this.CharacterCountToolStripStatusLabel.Name = "CharacterCountToolStripStatusLabel";
            this.CharacterCountToolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.CharacterCountToolStripStatusLabel.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel3.Text = "|";
            this.toolStripStatusLabel3.Visible = false;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(140, 17);
            this.toolStripStatusLabel5.Text = "Distinct Character Count:";
            this.toolStripStatusLabel5.Visible = false;
            // 
            // DistinctCharacterCountToolStripStatusLabel
            // 
            this.DistinctCharacterCountToolStripStatusLabel.Name = "DistinctCharacterCountToolStripStatusLabel";
            this.DistinctCharacterCountToolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.DistinctCharacterCountToolStripStatusLabel.Text = "0";
            this.DistinctCharacterCountToolStripStatusLabel.Visible = false;
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(246, 17);
            this.toolStripStatusLabel6.Spring = true;
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(179, 17);
            this.toolStripStatusLabel7.Text = "Number of characters remaning:";
            // 
            // NumCharactersRemainingToolStripStatusLabel
            // 
            this.NumCharactersRemainingToolStripStatusLabel.Name = "NumCharactersRemainingToolStripStatusLabel";
            this.NumCharactersRemainingToolStripStatusLabel.Size = new System.Drawing.Size(31, 17);
            this.NumCharactersRemainingToolStripStatusLabel.Text = "8000";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.wordStatsToolStripMenuItem,
            this.characterStatsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(98, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // wordStatsToolStripMenuItem
            // 
            this.wordStatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LargestWordToolStripMenuItem,
            this.SmallestWordToolStripMenuItem,
            this.MostFrequentWordToolStripMenuItem});
            this.wordStatsToolStripMenuItem.Name = "wordStatsToolStripMenuItem";
            this.wordStatsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.wordStatsToolStripMenuItem.Text = "Word Stats";
            // 
            // LargestWordToolStripMenuItem
            // 
            this.LargestWordToolStripMenuItem.Name = "LargestWordToolStripMenuItem";
            this.LargestWordToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.LargestWordToolStripMenuItem.Text = "Largest Word:";
            // 
            // SmallestWordToolStripMenuItem
            // 
            this.SmallestWordToolStripMenuItem.Name = "SmallestWordToolStripMenuItem";
            this.SmallestWordToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.SmallestWordToolStripMenuItem.Text = "Smallest Word:";
            // 
            // MostFrequentWordToolStripMenuItem
            // 
            this.MostFrequentWordToolStripMenuItem.Name = "MostFrequentWordToolStripMenuItem";
            this.MostFrequentWordToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.MostFrequentWordToolStripMenuItem.Text = "Most Frequent Word:";
            // 
            // characterStatsToolStripMenuItem
            // 
            this.characterStatsToolStripMenuItem.Name = "characterStatsToolStripMenuItem";
            this.characterStatsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.characterStatsToolStripMenuItem.Text = "Character Stats";
            this.characterStatsToolStripMenuItem.Click += new System.EventHandler(this.characterStatsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isCaseSensitiveToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // isCaseSensitiveToolStripMenuItem
            // 
            this.isCaseSensitiveToolStripMenuItem.CheckOnClick = true;
            this.isCaseSensitiveToolStripMenuItem.Name = "isCaseSensitiveToolStripMenuItem";
            this.isCaseSensitiveToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.isCaseSensitiveToolStripMenuItem.Text = "Is Case Sensitive";
            this.isCaseSensitiveToolStripMenuItem.Click += new System.EventHandler(this.isCaseSensitiveToolStripMenuItem_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputTextBox.Location = new System.Drawing.Point(0, 24);
            this.InputTextBox.MaxLength = 8000;
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputTextBox.Size = new System.Drawing.Size(682, 358);
            this.InputTextBox.TabIndex = 2;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            this.InputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTextBox_KeyDown);
            this.InputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            // 
            // TextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 404);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grosvenor Text Editor";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TotalWordCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel CharacterCountToolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel DistinctCharacterCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel NumCharactersRemainingToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem wordStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LargestWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SmallestWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MostFrequentWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isCaseSensitiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

