using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser2.Data;
using System.Text.RegularExpressions;
using WebBrowser2.Properties;

namespace WebBrowser2
{
    public partial class History_Manager : Form
    {
        public History_Manager()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

       
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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
                    listBox1.Items.Contains(foundIt);
                }
            }
        }

        public void HistoryAdder(string web)
        {
            listBox1.Items.Add(web);
        }
    }
}
