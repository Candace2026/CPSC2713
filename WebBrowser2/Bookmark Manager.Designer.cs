namespace WebBrowser2
{
    partial class Bookmark_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bookmark_Manager));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.BtoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtoolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.BlistBox1 = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.BtoolStripButton1,
            this.toolStripSeparator1,
            this.BtoolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(993, 31);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(83, 28);
            this.toolStripLabel1.Text = "Search for: ";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 31);
            // 
            // BtoolStripButton1
            // 
            this.BtoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("BtoolStripButton1.Image")));
            this.BtoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtoolStripButton1.Name = "BtoolStripButton1";
            this.BtoolStripButton1.Size = new System.Drawing.Size(57, 28);
            this.BtoolStripButton1.Text = "Search";
            this.BtoolStripButton1.Click += new System.EventHandler(this.BtoolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // BtoolStripButton2
            // 
            this.BtoolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtoolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("BtoolStripButton2.Image")));
            this.BtoolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtoolStripButton2.Name = "BtoolStripButton2";
            this.BtoolStripButton2.Size = new System.Drawing.Size(57, 28);
            this.BtoolStripButton2.Text = "Delete";
            this.BtoolStripButton2.Click += new System.EventHandler(this.BtoolStripButton2_Click);
            // 
            // BlistBox1
            // 
            this.BlistBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BlistBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlistBox1.FormattingEnabled = true;
            this.BlistBox1.ItemHeight = 20;
            this.BlistBox1.Location = new System.Drawing.Point(0, 31);
            this.BlistBox1.Name = "BlistBox1";
            this.BlistBox1.Size = new System.Drawing.Size(993, 419);
            this.BlistBox1.TabIndex = 11;
            // 
            // Bookmark_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 450);
            this.Controls.Add(this.BlistBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Bookmark_Manager";
            this.Text = "Bookmark Manager";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStripButton BtoolStripButton1;
        public System.Windows.Forms.ToolStripButton BtoolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        public System.Windows.Forms.ListBox BlistBox1;
    }
}