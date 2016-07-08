namespace 实况八记录器
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btAddToPL = new System.Windows.Forms.Button();
            this.btRefreshPL = new System.Windows.Forms.Button();
            this.PremierLeagueDatagridview = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btDeletePL = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btRefreshSD = new System.Windows.Forms.Button();
            this.btAddToSD = new System.Windows.Forms.Button();
            this.SecondDivisionDatagridview = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btRefreshLC = new System.Windows.Forms.Button();
            this.btAddToLC = new System.Windows.Forms.Button();
            this.LeagueCupDatagridview = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btRefreshCL = new System.Windows.Forms.Button();
            this.btAddToCL = new System.Windows.Forms.Button();
            this.ChampionsLeagueDatagridview = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btRefreshRecords = new System.Windows.Forms.Button();
            this.btAddToRecords = new System.Windows.Forms.Button();
            this.RecordsDatagridview = new System.Windows.Forms.DataGridView();
            this.btDeleteSD = new System.Windows.Forms.Button();
            this.btDeleteLC = new System.Windows.Forms.Button();
            this.btDeleteCL = new System.Windows.Forms.Button();
            this.btDeleteRecords = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PremierLeagueDatagridview)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondDivisionDatagridview)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeagueCupDatagridview)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChampionsLeagueDatagridview)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsDatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // btAddToPL
            // 
            this.btAddToPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddToPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btAddToPL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddToPL.Font = new System.Drawing.Font("隶书", 10.5F);
            this.btAddToPL.Location = new System.Drawing.Point(270, 424);
            this.btAddToPL.Name = "btAddToPL";
            this.btAddToPL.Size = new System.Drawing.Size(75, 23);
            this.btAddToPL.TabIndex = 2;
            this.btAddToPL.Text = "保存修改";
            this.btAddToPL.UseVisualStyleBackColor = false;
            this.btAddToPL.Click += new System.EventHandler(this.btAddToPL_Click);
            // 
            // btRefreshPL
            // 
            this.btRefreshPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRefreshPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btRefreshPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefreshPL.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRefreshPL.Location = new System.Drawing.Point(620, 424);
            this.btRefreshPL.Name = "btRefreshPL";
            this.btRefreshPL.Size = new System.Drawing.Size(75, 23);
            this.btRefreshPL.TabIndex = 3;
            this.btRefreshPL.Text = "刷新数据";
            this.btRefreshPL.UseVisualStyleBackColor = false;
            this.btRefreshPL.Click += new System.EventHandler(this.btRefreshPL_Click);
            // 
            // PremierLeagueDatagridview
            // 
            this.PremierLeagueDatagridview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PremierLeagueDatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PremierLeagueDatagridview.BackgroundColor = System.Drawing.Color.Gray;
            this.PremierLeagueDatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PremierLeagueDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PremierLeagueDatagridview.Location = new System.Drawing.Point(3, 3);
            this.PremierLeagueDatagridview.Margin = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.PremierLeagueDatagridview.Name = "PremierLeagueDatagridview";
            this.PremierLeagueDatagridview.RowTemplate.Height = 23;
            this.PremierLeagueDatagridview.Size = new System.Drawing.Size(784, 398);
            this.PremierLeagueDatagridview.TabIndex = 1;
            //this.PremierLeagueDatagridview.DefaultCellStyle.BackColor = System.Drawing.Color.Transparent;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(798, 701);
            this.tabControl.TabIndex = 4;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.btDeletePL);
            this.tabPage1.Controls.Add(this.PremierLeagueDatagridview);
            this.tabPage1.Controls.Add(this.btRefreshPL);
            this.tabPage1.Controls.Add(this.btAddToPL);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 675);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "甲级联赛";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btDeletePL
            // 
            this.btDeletePL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeletePL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDeletePL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDeletePL.Font = new System.Drawing.Font("隶书", 10.5F);
            this.btDeletePL.Location = new System.Drawing.Point(440, 424);
            this.btDeletePL.Name = "btDeletePL";
            this.btDeletePL.Size = new System.Drawing.Size(75, 23);
            this.btDeletePL.TabIndex = 4;
            this.btDeletePL.Text = "删除数据";
            this.btDeletePL.UseVisualStyleBackColor = false;
            this.btDeletePL.Click += new System.EventHandler(this.btDeletePL_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btDeleteSD);
            this.tabPage2.Controls.Add(this.btRefreshSD);
            this.tabPage2.Controls.Add(this.btAddToSD);
            this.tabPage2.Controls.Add(this.SecondDivisionDatagridview);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 675);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "乙级联赛";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btRefreshSD
            // 
            this.btRefreshSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRefreshSD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btRefreshSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefreshSD.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRefreshSD.Location = new System.Drawing.Point(643, 425);
            this.btRefreshSD.Name = "btRefreshSD";
            this.btRefreshSD.Size = new System.Drawing.Size(75, 23);
            this.btRefreshSD.TabIndex = 4;
            this.btRefreshSD.Text = "刷新数据";
            this.btRefreshSD.UseVisualStyleBackColor = false;
            this.btRefreshSD.Click += new System.EventHandler(this.btRefreshSD_Click);
            // 
            // btAddToSD
            // 
            this.btAddToSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddToSD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btAddToSD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddToSD.Font = new System.Drawing.Font("隶书", 10.5F);
            this.btAddToSD.Location = new System.Drawing.Point(326, 425);
            this.btAddToSD.Name = "btAddToSD";
            this.btAddToSD.Size = new System.Drawing.Size(75, 23);
            this.btAddToSD.TabIndex = 3;
            this.btAddToSD.Text = "保存修改";
            this.btAddToSD.UseVisualStyleBackColor = false;
            this.btAddToSD.Click += new System.EventHandler(this.btAddToSD_Click);
            // 
            // SecondDivisionDatagridview
            // 
            this.SecondDivisionDatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SecondDivisionDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecondDivisionDatagridview.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondDivisionDatagridview.Location = new System.Drawing.Point(3, 3);
            this.SecondDivisionDatagridview.Margin = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.SecondDivisionDatagridview.Name = "SecondDivisionDatagridview";
            this.SecondDivisionDatagridview.RowTemplate.Height = 23;
            this.SecondDivisionDatagridview.Size = new System.Drawing.Size(784, 384);
            this.SecondDivisionDatagridview.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btDeleteLC);
            this.tabPage3.Controls.Add(this.btRefreshLC);
            this.tabPage3.Controls.Add(this.btAddToLC);
            this.tabPage3.Controls.Add(this.LeagueCupDatagridview);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(790, 675);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "甲级联赛杯";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btRefreshLC
            // 
            this.btRefreshLC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRefreshLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btRefreshLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefreshLC.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRefreshLC.Location = new System.Drawing.Point(651, 409);
            this.btRefreshLC.Name = "btRefreshLC";
            this.btRefreshLC.Size = new System.Drawing.Size(75, 23);
            this.btRefreshLC.TabIndex = 6;
            this.btRefreshLC.Text = "刷新数据";
            this.btRefreshLC.UseVisualStyleBackColor = false;
            this.btRefreshLC.Click += new System.EventHandler(this.btRefreshLC_Click);
            // 
            // btAddToLC
            // 
            this.btAddToLC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddToLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btAddToLC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddToLC.Font = new System.Drawing.Font("隶书", 10.5F);
            this.btAddToLC.Location = new System.Drawing.Point(325, 409);
            this.btAddToLC.Name = "btAddToLC";
            this.btAddToLC.Size = new System.Drawing.Size(75, 23);
            this.btAddToLC.TabIndex = 5;
            this.btAddToLC.Text = "保存修改";
            this.btAddToLC.UseVisualStyleBackColor = false;
            this.btAddToLC.Click += new System.EventHandler(this.btAddToLC_Click);
            // 
            // LeagueCupDatagridview
            // 
            this.LeagueCupDatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LeagueCupDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeagueCupDatagridview.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeagueCupDatagridview.Location = new System.Drawing.Point(3, 3);
            this.LeagueCupDatagridview.Name = "LeagueCupDatagridview";
            this.LeagueCupDatagridview.RowTemplate.Height = 23;
            this.LeagueCupDatagridview.Size = new System.Drawing.Size(784, 321);
            this.LeagueCupDatagridview.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btDeleteCL);
            this.tabPage4.Controls.Add(this.btRefreshCL);
            this.tabPage4.Controls.Add(this.btAddToCL);
            this.tabPage4.Controls.Add(this.ChampionsLeagueDatagridview);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(790, 675);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "欧冠";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btRefreshCL
            // 
            this.btRefreshCL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRefreshCL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btRefreshCL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefreshCL.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRefreshCL.Location = new System.Drawing.Point(648, 429);
            this.btRefreshCL.Name = "btRefreshCL";
            this.btRefreshCL.Size = new System.Drawing.Size(75, 23);
            this.btRefreshCL.TabIndex = 8;
            this.btRefreshCL.Text = "刷新数据";
            this.btRefreshCL.UseVisualStyleBackColor = false;
            this.btRefreshCL.Click += new System.EventHandler(this.btRefreshCL_Click);
            // 
            // btAddToCL
            // 
            this.btAddToCL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddToCL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btAddToCL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddToCL.Font = new System.Drawing.Font("隶书", 10.5F);
            this.btAddToCL.Location = new System.Drawing.Point(315, 429);
            this.btAddToCL.Name = "btAddToCL";
            this.btAddToCL.Size = new System.Drawing.Size(75, 23);
            this.btAddToCL.TabIndex = 7;
            this.btAddToCL.Text = "保存修改";
            this.btAddToCL.UseVisualStyleBackColor = false;
            this.btAddToCL.Click += new System.EventHandler(this.btAddToCL_Click);
            // 
            // ChampionsLeagueDatagridview
            // 
            this.ChampionsLeagueDatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ChampionsLeagueDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChampionsLeagueDatagridview.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChampionsLeagueDatagridview.Location = new System.Drawing.Point(3, 3);
            this.ChampionsLeagueDatagridview.Name = "ChampionsLeagueDatagridview";
            this.ChampionsLeagueDatagridview.RowTemplate.Height = 23;
            this.ChampionsLeagueDatagridview.Size = new System.Drawing.Size(784, 398);
            this.ChampionsLeagueDatagridview.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btDeleteRecords);
            this.tabPage5.Controls.Add(this.btRefreshRecords);
            this.tabPage5.Controls.Add(this.btAddToRecords);
            this.tabPage5.Controls.Add(this.RecordsDatagridview);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(790, 675);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "名人堂";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btRefreshRecords
            // 
            this.btRefreshRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRefreshRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btRefreshRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefreshRecords.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRefreshRecords.Location = new System.Drawing.Point(645, 402);
            this.btRefreshRecords.Name = "btRefreshRecords";
            this.btRefreshRecords.Size = new System.Drawing.Size(75, 23);
            this.btRefreshRecords.TabIndex = 10;
            this.btRefreshRecords.Text = "刷新数据";
            this.btRefreshRecords.UseVisualStyleBackColor = false;
            this.btRefreshRecords.Click += new System.EventHandler(this.btRefreshRecords_Click);
            // 
            // btAddToRecords
            // 
            this.btAddToRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddToRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btAddToRecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAddToRecords.Font = new System.Drawing.Font("隶书", 10.5F);
            this.btAddToRecords.Location = new System.Drawing.Point(314, 402);
            this.btAddToRecords.Name = "btAddToRecords";
            this.btAddToRecords.Size = new System.Drawing.Size(75, 23);
            this.btAddToRecords.TabIndex = 9;
            this.btAddToRecords.Text = "保存修改";
            this.btAddToRecords.UseVisualStyleBackColor = false;
            this.btAddToRecords.Click += new System.EventHandler(this.btAddToRecords_Click);
            // 
            // RecordsDatagridview
            // 
            this.RecordsDatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecordsDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordsDatagridview.Dock = System.Windows.Forms.DockStyle.Top;
            this.RecordsDatagridview.Location = new System.Drawing.Point(3, 3);
            this.RecordsDatagridview.Name = "RecordsDatagridview";
            this.RecordsDatagridview.RowTemplate.Height = 23;
            this.RecordsDatagridview.Size = new System.Drawing.Size(784, 329);
            this.RecordsDatagridview.TabIndex = 0;
            // 
            // btDeleteSD
            // 
            this.btDeleteSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteSD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDeleteSD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDeleteSD.Font = new System.Drawing.Font("隶书", 10.5F);
            this.btDeleteSD.Location = new System.Drawing.Point(479, 425);
            this.btDeleteSD.Name = "btDeleteSD";
            this.btDeleteSD.Size = new System.Drawing.Size(75, 23);
            this.btDeleteSD.TabIndex = 5;
            this.btDeleteSD.Text = "删除数据";
            this.btDeleteSD.UseVisualStyleBackColor = false;
            this.btDeleteSD.Click += new System.EventHandler(this.btDeleteSD_Click);
            // 
            // btDeleteLC
            // 
            this.btDeleteLC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDeleteLC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDeleteLC.Font = new System.Drawing.Font("隶书", 10.5F);
            this.btDeleteLC.Location = new System.Drawing.Point(477, 409);
            this.btDeleteLC.Name = "btDeleteLC";
            this.btDeleteLC.Size = new System.Drawing.Size(75, 23);
            this.btDeleteLC.TabIndex = 7;
            this.btDeleteLC.Text = "删除数据";
            this.btDeleteLC.UseVisualStyleBackColor = false;
            this.btDeleteLC.Click += new System.EventHandler(this.btDeleteLC_Click);
            // 
            // btDeleteCL
            // 
            this.btDeleteCL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteCL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDeleteCL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDeleteCL.Font = new System.Drawing.Font("隶书", 10.5F);
            this.btDeleteCL.Location = new System.Drawing.Point(491, 429);
            this.btDeleteCL.Name = "btDeleteCL";
            this.btDeleteCL.Size = new System.Drawing.Size(75, 23);
            this.btDeleteCL.TabIndex = 9;
            this.btDeleteCL.Text = "删除数据";
            this.btDeleteCL.UseVisualStyleBackColor = false;
            this.btDeleteCL.Click += new System.EventHandler(this.btDeleteCL_Click);
            // 
            // btDeleteRecords
            // 
            this.btDeleteRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDeleteRecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDeleteRecords.Font = new System.Drawing.Font("隶书", 10.5F);
            this.btDeleteRecords.Location = new System.Drawing.Point(479, 402);
            this.btDeleteRecords.Name = "btDeleteRecords";
            this.btDeleteRecords.Size = new System.Drawing.Size(75, 23);
            this.btDeleteRecords.TabIndex = 11;
            this.btDeleteRecords.Text = "删除数据";
            this.btDeleteRecords.UseVisualStyleBackColor = false;
            this.btDeleteRecords.Click += new System.EventHandler(this.btDeleteRecords_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 497);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "欢迎来到实况世界";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PremierLeagueDatagridview)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SecondDivisionDatagridview)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeagueCupDatagridview)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChampionsLeagueDatagridview)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecordsDatagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAddToPL;
        private System.Windows.Forms.Button btRefreshPL;
        private System.Windows.Forms.DataGridView PremierLeagueDatagridview;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btAddToSD;
        private System.Windows.Forms.DataGridView SecondDivisionDatagridview;
        private System.Windows.Forms.Button btRefreshSD;
        private System.Windows.Forms.Button btRefreshLC;
        private System.Windows.Forms.Button btAddToLC;
        private System.Windows.Forms.DataGridView LeagueCupDatagridview;
        private System.Windows.Forms.DataGridView ChampionsLeagueDatagridview;
        private System.Windows.Forms.Button btRefreshCL;
        private System.Windows.Forms.Button btAddToCL;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView RecordsDatagridview;
        private System.Windows.Forms.Button btRefreshRecords;
        private System.Windows.Forms.Button btAddToRecords;
        private System.Windows.Forms.Button btDeletePL;
        private System.Windows.Forms.Button btDeleteSD;
        private System.Windows.Forms.Button btDeleteLC;
        private System.Windows.Forms.Button btDeleteCL;
        private System.Windows.Forms.Button btDeleteRecords;



    }
}