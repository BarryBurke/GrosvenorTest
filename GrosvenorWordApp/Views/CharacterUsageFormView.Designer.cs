namespace GrosvenorTextEditor
{
    partial class CharacterUsageForm
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
            this.CharacterUsageListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CharacterUsageListView
            // 
            this.CharacterUsageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.CharacterUsageListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CharacterUsageListView.FullRowSelect = true;
            this.CharacterUsageListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CharacterUsageListView.Location = new System.Drawing.Point(0, 0);
            this.CharacterUsageListView.Name = "CharacterUsageListView";
            this.CharacterUsageListView.Size = new System.Drawing.Size(418, 391);
            this.CharacterUsageListView.TabIndex = 0;
            this.CharacterUsageListView.UseCompatibleStateImageBehavior = false;
            this.CharacterUsageListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Letter";
            this.columnHeader1.Width = 144;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 133;
            // 
            // CharacterUsageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 391);
            this.Controls.Add(this.CharacterUsageListView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterUsageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Character Usage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CharacterUsageListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}