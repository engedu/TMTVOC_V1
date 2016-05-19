namespace TMTVOC_V1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonComboBoxLocation = new System.Windows.Forms.RibbonComboBox();
            this.EN001 = new System.Windows.Forms.RibbonLabel();
            this.EN002 = new System.Windows.Forms.RibbonLabel();
            this.EN003 = new System.Windows.Forms.RibbonLabel();
            this.EN004 = new System.Windows.Forms.RibbonLabel();
            this.EN005 = new System.Windows.Forms.RibbonLabel();
            this.EN006 = new System.Windows.Forms.RibbonLabel();
            this.EN007 = new System.Windows.Forms.RibbonLabel();
            this.EN008 = new System.Windows.Forms.RibbonLabel();
            this.EN009 = new System.Windows.Forms.RibbonLabel();
            this.EN010 = new System.Windows.Forms.RibbonLabel();
            this.EN011 = new System.Windows.Forms.RibbonLabel();
            this.EN012 = new System.Windows.Forms.RibbonLabel();
            this.ribbonComboBoxDateBegin = new System.Windows.Forms.RibbonComboBox();
            this.ribbonHost3 = new System.Windows.Forms.RibbonHost();
            this.ribbonComboBoxDateEnd = new System.Windows.Forms.RibbonComboBox();
            this.ribbonHost1 = new System.Windows.Forms.RibbonHost();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbOptionButton1 = new System.Windows.Forms.RibbonOrbOptionButton();
            this.ribbonOrbOptionButton2 = new System.Windows.Forms.RibbonOrbOptionButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Panels.Add(this.ribbonPanel4);
            this.ribbonTab1.Panels.Add(this.ribbonPanel5);
            this.ribbonTab1.Text = "Raw Data";
            this.ribbonTab1.ActiveChanged += new System.EventHandler(this.ribbonTab1_ActiveChanged);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.ribbonComboBoxLocation);
            this.ribbonPanel1.Text = "Location";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.ribbonComboBoxDateBegin);
            this.ribbonPanel2.Items.Add(this.ribbonComboBoxDateEnd);
            this.ribbonPanel2.Items.Add(this.ribbonButton5);
            this.ribbonPanel2.Text = "Date Selector";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(517, 340);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(749, 340);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 3;
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.ribbonButton1);
            this.ribbonPanel3.Text = "Data Download";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.ribbonButton2);
            this.ribbonPanel4.Items.Add(this.ribbonButton3);
            this.ribbonPanel4.Text = "View";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.ribbonButton4);
            this.ribbonPanel5.Text = "Export Data";
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbon1.OrbText = "VOC Monitor system";
            this.ribbon1.OrbVisible = false;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.Visible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1035, 135);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1035, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "Station:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // ribbonComboBoxLocation
            // 
            this.ribbonComboBoxLocation.DrawIconsBar = false;
            this.ribbonComboBoxLocation.DropDownItems.Add(this.EN001);
            this.ribbonComboBoxLocation.DropDownItems.Add(this.EN002);
            this.ribbonComboBoxLocation.DropDownItems.Add(this.EN003);
            this.ribbonComboBoxLocation.DropDownItems.Add(this.EN004);
            this.ribbonComboBoxLocation.DropDownItems.Add(this.EN005);
            this.ribbonComboBoxLocation.DropDownItems.Add(this.EN006);
            this.ribbonComboBoxLocation.DropDownItems.Add(this.EN007);
            this.ribbonComboBoxLocation.DropDownItems.Add(this.EN008);
            this.ribbonComboBoxLocation.DropDownItems.Add(this.EN009);
            this.ribbonComboBoxLocation.DropDownItems.Add(this.EN010);
            this.ribbonComboBoxLocation.DropDownItems.Add(this.EN011);
            this.ribbonComboBoxLocation.DropDownItems.Add(this.EN012);
            this.ribbonComboBoxLocation.Image = global::TMTVOC_V1.Properties.Resources.Search_online;
            this.ribbonComboBoxLocation.LabelWidth = 10;
            this.ribbonComboBoxLocation.Text = " ";
            this.ribbonComboBoxLocation.TextBoxText = "BP Mainstack";
            this.ribbonComboBoxLocation.TextBoxWidth = 150;
            // 
            // EN001
            // 
            this.EN001.LabelWidth = 150;
            this.EN001.Text = "BP Mainstack";
            this.EN001.Click += new System.EventHandler(this.EN001_Click);
            // 
            // EN002
            // 
            this.EN002.LabelWidth = 150;
            this.EN002.Text = "BP RTO (old)";
            this.EN002.Click += new System.EventHandler(this.EN002_Click);
            // 
            // EN003
            // 
            this.EN003.LabelWidth = 150;
            this.EN003.Text = "Community (Honda)";
            this.EN003.Visible = false;
            this.EN003.Click += new System.EventHandler(this.EN003_Click);
            // 
            // EN004
            // 
            this.EN004.Text = "Community (Governor)";
            this.EN004.Visible = false;
            this.EN004.Click += new System.EventHandler(this.EN004_Click);
            // 
            // EN005
            // 
            this.EN005.Text = "115 kV";
            this.EN005.Click += new System.EventHandler(this.EN005_Click);
            // 
            // EN006
            // 
            this.EN006.Text = "Community (Phook Mit)";
            this.EN006.Visible = false;
            this.EN006.Click += new System.EventHandler(this.EN006_Click);
            // 
            // EN007
            // 
            this.EN007.Text = "Community";
            this.EN007.Click += new System.EventHandler(this.EN007_Click);
            // 
            // EN008
            // 
            this.EN008.Text = "Shrimp farm";
            this.EN008.Click += new System.EventHandler(this.EN008_Click);
            // 
            // EN009
            // 
            this.EN009.Text = "Commercial building";
            this.EN009.Click += new System.EventHandler(this.EN009_Click);
            // 
            // EN010
            // 
            this.EN010.Text = "Community (Welding)";
            this.EN010.Visible = false;
            this.EN010.Click += new System.EventHandler(this.EN010_Click);
            // 
            // EN011
            // 
            this.EN011.Text = "SR ED Oven";
            this.EN011.Visible = false;
            this.EN011.Click += new System.EventHandler(this.EN011_Click);
            // 
            // EN012
            // 
            this.EN012.Text = "SR T/C1 Booth";
            this.EN012.Visible = false;
            this.EN012.Click += new System.EventHandler(this.EN012_Click);
            // 
            // ribbonComboBoxDateBegin
            // 
            this.ribbonComboBoxDateBegin.DropDownItems.Add(this.ribbonHost3);
            this.ribbonComboBoxDateBegin.Image = global::TMTVOC_V1.Properties.Resources.clock_16x162;
            this.ribbonComboBoxDateBegin.LabelWidth = 45;
            this.ribbonComboBoxDateBegin.Text = "Begin:";
            this.ribbonComboBoxDateBegin.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.ribbonComboBoxDateBegin.TextBoxText = "";
            // 
            // ribbonHost3
            // 
            this.ribbonHost3.HostedControl = this.monthCalendar1;
            // 
            // ribbonComboBoxDateEnd
            // 
            this.ribbonComboBoxDateEnd.DropDownItems.Add(this.ribbonHost1);
            this.ribbonComboBoxDateEnd.Image = global::TMTVOC_V1.Properties.Resources.clock_16x161;
            this.ribbonComboBoxDateEnd.LabelWidth = 45;
            this.ribbonComboBoxDateEnd.Text = "End:  ";
            this.ribbonComboBoxDateEnd.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.ribbonComboBoxDateEnd.TextBoxText = "";
            // 
            // ribbonHost1
            // 
            this.ribbonHost1.HostedControl = this.monthCalendar2;
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Image = global::TMTVOC_V1.Properties.Resources.Time;
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Text = "Today";
            this.ribbonButton5.Click += new System.EventHandler(this.ribbonButton5_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = global::TMTVOC_V1.Properties.Resources.download_32;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "Download";
            this.ribbonButton1.Click += new System.EventHandler(this.ribbonButton1_Click);
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = global::TMTVOC_V1.Properties.Resources.table_32x32;
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "Table";
            this.ribbonButton2.Click += new System.EventHandler(this.rbTableView_Click);
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = global::TMTVOC_V1.Properties.Resources.graphView;
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "Graph";
            this.ribbonButton3.Click += new System.EventHandler(this.rbGraphView_Click);
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = global::TMTVOC_V1.Properties.Resources.CSV;
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Text = "csv";
            this.ribbonButton4.Click += new System.EventHandler(this.ribbonButton4_Click);
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "ribbonOrbMenuItem1";
            // 
            // ribbonOrbOptionButton1
            // 
            this.ribbonOrbOptionButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton1.Image")));
            this.ribbonOrbOptionButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton1.SmallImage")));
            this.ribbonOrbOptionButton1.Text = "ribbonOrbOptionButton1";
            // 
            // ribbonOrbOptionButton2
            // 
            this.ribbonOrbOptionButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton2.Image")));
            this.ribbonOrbOptionButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton2.SmallImage")));
            this.ribbonOrbOptionButton2.Text = "ribbonOrbOptionButton2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 602);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.ribbon1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Banpho VOC Monitor System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonComboBox ribbonComboBoxDateBegin;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RibbonComboBox ribbonComboBoxDateEnd;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.RibbonComboBox ribbonComboBoxLocation;
        private System.Windows.Forms.RibbonLabel EN001;
        private System.Windows.Forms.RibbonLabel EN002;
        private System.Windows.Forms.RibbonLabel EN003;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.RibbonOrbOptionButton ribbonOrbOptionButton1;
        private System.Windows.Forms.RibbonOrbOptionButton ribbonOrbOptionButton2;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem2;
        private System.Windows.Forms.RibbonHost ribbonHost3;
        private System.Windows.Forms.RibbonHost ribbonHost1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RibbonLabel EN004;
        private System.Windows.Forms.RibbonLabel EN005;
        private System.Windows.Forms.RibbonLabel EN006;
        private System.Windows.Forms.RibbonLabel EN007;
        private System.Windows.Forms.RibbonLabel EN008;
        private System.Windows.Forms.RibbonLabel EN009;
        private System.Windows.Forms.RibbonLabel EN010;
        private System.Windows.Forms.RibbonLabel EN011;
        private System.Windows.Forms.RibbonLabel EN012;
        private System.Windows.Forms.RibbonButton ribbonButton5;
    }
}

