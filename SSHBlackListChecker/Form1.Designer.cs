namespace SSHBlackListChecker
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
            this.components = new System.ComponentModel.Container();
            this.dtSSH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txt1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker6 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker7 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker8 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker9 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker10 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker11 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker12 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker13 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker14 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker15 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker16 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker17 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker18 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker19 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker20 = new System.ComponentModel.BackgroundWorker();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt4 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtSSH)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtSSH
            // 
            this.dtSSH.AllowUserToAddRows = false;
            this.dtSSH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtSSH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSSH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.dtSSH.Location = new System.Drawing.Point(0, 24);
            this.dtSSH.Name = "dtSSH";
            this.dtSSH.Size = new System.Drawing.Size(878, 310);
            this.dtSSH.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ip";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "User";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Pass";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Country";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Blacklist";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "On-Server";
            this.Column5.Name = "Column5";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.checkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.checkToolStripMenuItem.Text = "Check";
            this.checkToolStripMenuItem.Click += new System.EventHandler(this.checkToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt1,
            this.txt2,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.txt3,
            this.toolStripStatusLabel3,
            this.txt4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 337);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(878, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txt1
            // 
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(59, 17);
            this.txt1.Text = "Tổng số : ";
            // 
            // txt2
            // 
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(37, 17);
            this.txt2.Text = "0 SSH";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel1.Text = "      |      ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel2.Text = "Blacklist : ";
            // 
            // txt3
            // 
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(13, 17);
            this.txt3.Text = "0";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.WorkerReportsProgress = true;
            this.backgroundWorker3.WorkerSupportsCancellation = true;
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.WorkerReportsProgress = true;
            this.backgroundWorker4.WorkerSupportsCancellation = true;
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            // 
            // backgroundWorker5
            // 
            this.backgroundWorker5.WorkerReportsProgress = true;
            this.backgroundWorker5.WorkerSupportsCancellation = true;
            this.backgroundWorker5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker5_DoWork);
            // 
            // backgroundWorker6
            // 
            this.backgroundWorker6.WorkerReportsProgress = true;
            this.backgroundWorker6.WorkerSupportsCancellation = true;
            this.backgroundWorker6.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker6_DoWork);
            // 
            // backgroundWorker7
            // 
            this.backgroundWorker7.WorkerReportsProgress = true;
            this.backgroundWorker7.WorkerSupportsCancellation = true;
            this.backgroundWorker7.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker7_DoWork);
            // 
            // backgroundWorker8
            // 
            this.backgroundWorker8.WorkerReportsProgress = true;
            this.backgroundWorker8.WorkerSupportsCancellation = true;
            this.backgroundWorker8.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker8_DoWork);
            // 
            // backgroundWorker9
            // 
            this.backgroundWorker9.WorkerReportsProgress = true;
            this.backgroundWorker9.WorkerSupportsCancellation = true;
            this.backgroundWorker9.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker9_DoWork);
            // 
            // backgroundWorker10
            // 
            this.backgroundWorker10.WorkerReportsProgress = true;
            this.backgroundWorker10.WorkerSupportsCancellation = true;
            this.backgroundWorker10.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker10_DoWork);
            // 
            // backgroundWorker11
            // 
            this.backgroundWorker11.WorkerReportsProgress = true;
            this.backgroundWorker11.WorkerSupportsCancellation = true;
            this.backgroundWorker11.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker11_DoWork);
            // 
            // backgroundWorker12
            // 
            this.backgroundWorker12.WorkerReportsProgress = true;
            this.backgroundWorker12.WorkerSupportsCancellation = true;
            this.backgroundWorker12.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker12_DoWork);
            // 
            // backgroundWorker13
            // 
            this.backgroundWorker13.WorkerReportsProgress = true;
            this.backgroundWorker13.WorkerSupportsCancellation = true;
            this.backgroundWorker13.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker13_DoWork);
            // 
            // backgroundWorker14
            // 
            this.backgroundWorker14.WorkerReportsProgress = true;
            this.backgroundWorker14.WorkerSupportsCancellation = true;
            this.backgroundWorker14.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker14_DoWork);
            // 
            // backgroundWorker15
            // 
            this.backgroundWorker15.WorkerReportsProgress = true;
            this.backgroundWorker15.WorkerSupportsCancellation = true;
            this.backgroundWorker15.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker15_DoWork);
            // 
            // backgroundWorker16
            // 
            this.backgroundWorker16.WorkerReportsProgress = true;
            this.backgroundWorker16.WorkerSupportsCancellation = true;
            this.backgroundWorker16.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker16_DoWork);
            // 
            // backgroundWorker17
            // 
            this.backgroundWorker17.WorkerReportsProgress = true;
            this.backgroundWorker17.WorkerSupportsCancellation = true;
            this.backgroundWorker17.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker17_DoWork);
            // 
            // backgroundWorker18
            // 
            this.backgroundWorker18.WorkerReportsProgress = true;
            this.backgroundWorker18.WorkerSupportsCancellation = true;
            this.backgroundWorker18.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker18_DoWork);
            // 
            // backgroundWorker19
            // 
            this.backgroundWorker19.WorkerReportsProgress = true;
            this.backgroundWorker19.WorkerSupportsCancellation = true;
            this.backgroundWorker19.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker19_DoWork);
            // 
            // backgroundWorker20
            // 
            this.backgroundWorker20.WorkerReportsProgress = true;
            this.backgroundWorker20.WorkerSupportsCancellation = true;
            this.backgroundWorker20.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker20_DoWork);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel3.Text = " (SSH)";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt4
            // 
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(55, 17);
            this.txt4.Text = "................";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 359);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtSSH);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SSH Blacklist Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtSSH)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtSSH;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txt1;
        private System.Windows.Forms.ToolStripStatusLabel txt2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txt3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.ComponentModel.BackgroundWorker backgroundWorker6;
        private System.ComponentModel.BackgroundWorker backgroundWorker7;
        private System.ComponentModel.BackgroundWorker backgroundWorker8;
        private System.ComponentModel.BackgroundWorker backgroundWorker9;
        private System.ComponentModel.BackgroundWorker backgroundWorker10;
        private System.ComponentModel.BackgroundWorker backgroundWorker11;
        private System.ComponentModel.BackgroundWorker backgroundWorker12;
        private System.ComponentModel.BackgroundWorker backgroundWorker13;
        private System.ComponentModel.BackgroundWorker backgroundWorker14;
        private System.ComponentModel.BackgroundWorker backgroundWorker15;
        private System.ComponentModel.BackgroundWorker backgroundWorker16;
        private System.ComponentModel.BackgroundWorker backgroundWorker17;
        private System.ComponentModel.BackgroundWorker backgroundWorker18;
        private System.ComponentModel.BackgroundWorker backgroundWorker19;
        private System.ComponentModel.BackgroundWorker backgroundWorker20;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel txt4;
    }
}

