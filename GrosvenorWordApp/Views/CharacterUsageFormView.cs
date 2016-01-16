using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrosvenorTextEditor
{
    public partial class CharacterUsageForm : Form
    {
        protected CharacterUsageForm()
        {
            InitializeComponent();
        }

        public CharacterUsageForm(IDictionary<char, int> characterCollection)
            : this()
        {
            PopulateListView(characterCollection);
        }

        private void PopulateListView(IDictionary<char, int> characterCollection)
        {
            foreach(var item in characterCollection.OrderByDescending(kp => kp.Value))
            {
                ListViewItem lvi = new ListViewItem(item.Key.ToString());
                lvi.SubItems.Add(item.Value.ToString());

                CharacterUsageListView.Items.Add(lvi);
            }
        }
    }
}
