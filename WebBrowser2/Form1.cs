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

namespace WebBrowser2
{
    public partial class Form1 : Form
    {
        List<Link> bookmarks = new List<Link>();
        List<Link> historyAdded = new List<Link>();
        History_Manager hm = new History_Manager();
        Bookmark_Manager bm = new Bookmark_Manager();


        public Form1()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage("New Tab");
            tabControl1.TabPages.Add(tab);
            webBrowser1.Parent = tabControl1.SelectedTab;
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Navigate("www.google.com");
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void savePageAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This web browser will help you search the web and " +
                "takes you anywhere you want to go online [Except the Dark Web -" +
                "stay AWAY from that. It was created by myself, Candace Williams," +
                "a student of Auburn University's online Computer Science Bachelors" +
                "degree program who believes her student ID is crw0077, if she's not" +
                " mistaken...");
        }

        private void StatusTime_Tick(object sender, EventArgs e)
        {
            this.ProgressBar1.Increment(20);
            toolStripStatusLabel1.Text = "Done.";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            toolStripTextBox1.Text = webBrowser1.Url.ToString();
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            var address = ("http://" + toolStripTextBox1.Text);
            webBrowser1.Navigate(address);
            hm.listBox1.Items.Add(address);
            this.StatusTime.Start();
            toolStripStatusLabel1.Text = "Loading";
        }
        
        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hm.ShowDialog();
        }
        
            private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
            {
                bm.ShowDialog();
            }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var website = webBrowser1.Url.ToString();
            bm.BlistBox1.Items.Add(website.ToString());
            bm.BookmarkAdder(website);
        }
    }
    }

