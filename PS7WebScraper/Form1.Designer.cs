namespace PS7WebScraper
{
    partial class WebScraperForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scrapeButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.courseTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.multiscrapeButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.NumericUpDown();
            this.maxCoursesBox = new System.Windows.Forms.NumericUpDown();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCoursesBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scrapeButton
            // 
            this.scrapeButton.Location = new System.Drawing.Point(10, 134);
            this.scrapeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scrapeButton.Name = "scrapeButton";
            this.scrapeButton.Size = new System.Drawing.Size(301, 31);
            this.scrapeButton.TabIndex = 0;
            this.scrapeButton.Text = "Scrape Course";
            this.scrapeButton.UseVisualStyleBackColor = true;
            this.scrapeButton.Click += new System.EventHandler(this.scrapeButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(350, 29);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(340, 258);
            this.outputTextBox.TabIndex = 1;
            this.outputTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "PS7 Web Scraper by Matt McFarlane";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 297);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(340, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save to CSV";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Scrape a Single Course :\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Course to scrape :";
            // 
            // courseTextBox
            // 
            this.courseTextBox.Location = new System.Drawing.Point(124, 89);
            this.courseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(148, 23);
            this.courseTextBox.TabIndex = 6;
            this.courseTextBox.Text = "CS2420";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Scrape CS Courses from a Semester/Year :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Year :  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Semester :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Maximum Number of Courses :";
            // 
            // multiscrapeButton
            // 
            this.multiscrapeButton.Location = new System.Drawing.Point(10, 297);
            this.multiscrapeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.multiscrapeButton.Name = "multiscrapeButton";
            this.multiscrapeButton.Size = new System.Drawing.Size(301, 31);
            this.multiscrapeButton.TabIndex = 14;
            this.multiscrapeButton.Text = "Scrape Courses";
            this.multiscrapeButton.UseVisualStyleBackColor = true;
            this.multiscrapeButton.Click += new System.EventHandler(this.multiscrapeButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "(Department and Catalog Number e.g. CS2420)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(302, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "-----------------------------------------------------------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(302, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "-----------------------------------------------------------";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(700, 24);
            this.menuStrip.TabIndex = 19;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetAllToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.resetAllToolStripMenuItem.Text = "Reset All";
            this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.resetAllToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slowModeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fileToolStripMenuItem.Text = "Grading";
            // 
            // slowModeToolStripMenuItem
            // 
            this.slowModeToolStripMenuItem.CheckOnClick = true;
            this.slowModeToolStripMenuItem.Name = "slowModeToolStripMenuItem";
            this.slowModeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.slowModeToolStripMenuItem.Text = "Slow Mode";
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.semesterComboBox.DisplayMember = "1";
            this.semesterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semesterComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.semesterComboBox.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall"});
            this.semesterComboBox.Location = new System.Drawing.Point(76, 236);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(85, 23);
            this.semesterComboBox.TabIndex = 20;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(47, 207);
            this.yearBox.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.yearBox.Minimum = new decimal(new int[] {
            2007,
            0,
            0,
            0});
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(48, 23);
            this.yearBox.TabIndex = 21;
            this.yearBox.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // maxCoursesBox
            // 
            this.maxCoursesBox.Location = new System.Drawing.Point(189, 264);
            this.maxCoursesBox.Name = "maxCoursesBox";
            this.maxCoursesBox.Size = new System.Drawing.Size(50, 23);
            this.maxCoursesBox.TabIndex = 22;
            this.maxCoursesBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // WebScraperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 333);
            this.Controls.Add(this.maxCoursesBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.semesterComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.multiscrapeButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.courseTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.scrapeButton);
            this.Controls.Add(this.menuStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WebScraperForm";
            this.Text = "PS7WebScraper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebScraperForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxCoursesBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button scrapeButton;
        private RichTextBox outputTextBox;
        private Label label1;
        private Button button2;
        private Label label2;
        private Label label3;
        private RichTextBox courseTextBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button multiscrapeButton;
        private Label label9;
        private Label label10;
        private Label label11;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem slowModeToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem resetAllToolStripMenuItem;
        private ComboBox semesterComboBox;
        private NumericUpDown yearBox;
        private NumericUpDown maxCoursesBox;
    }
}