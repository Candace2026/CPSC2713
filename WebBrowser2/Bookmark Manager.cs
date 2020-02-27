using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WebBrowser2
{
    public partial class Bookmark_Manager : Form
    {
        public Bookmark_Manager()
        {
            InitializeComponent();
        }

        public void BtoolStripButton2_Click(object sender, EventArgs e)
        {
            BlistBox1.Items.RemoveAt(0);
        }

        public void BookmarkAdder(string website)
        {
            BlistBox1.Items.Add(this.toolStripTextBox1.Text);
        }

        public void BtoolStripButton1_Click(object sender, EventArgs e)
        {
            string word = toolStripTextBox1.Text;
            string result = " ";
            string foundIt = " ";
            List<string> foundTrue = new List<string>();

            if (word.Length > 0)
            {
                int count = 0;
                foreach (Match x in Regex.Matches(word, foundIt))
                {
                    BlistBox1.Items.Contains(foundIt);
                }
            }
        }
    }
}
