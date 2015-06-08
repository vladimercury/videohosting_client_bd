namespace video_hosting_client
{
    partial class MainBrowser
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
            this.UserInfoPanel = new System.Windows.Forms.Panel();
            this.UserVideoStatusPanel = new System.Windows.Forms.Panel();
            this.VideoCntLabel = new System.Windows.Forms.Label();
            this.UserViewsStatusPanel = new System.Windows.Forms.Panel();
            this.ViewCntLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.VideoOverviewLink = new System.Windows.Forms.LinkLabel();
            this.MainView = new System.Windows.Forms.Panel();
            this.VideoAddForm = new System.Windows.Forms.GroupBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ThemeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewVideoDescr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewVideoName = new System.Windows.Forms.TextBox();
            this.VideoInfoList = new System.Windows.Forms.ListBox();
            this.VideoFrame = new System.Windows.Forms.PictureBox();
            this.UserProfileInfoVideos = new System.Windows.Forms.Button();
            this.UserProfileInfoListBox = new System.Windows.Forms.ListBox();
            this.VideoOverviewCountPanel = new System.Windows.Forms.Panel();
            this.VideoOverviewCountLabel = new System.Windows.Forms.Label();
            this.VideoOverviewLinkList = new System.Windows.Forms.ListBox();
            this.UserProfileLinkLabel = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.NewVideoLink = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.UserInfoPanel.SuspendLayout();
            this.UserVideoStatusPanel.SuspendLayout();
            this.UserViewsStatusPanel.SuspendLayout();
            this.MainView.SuspendLayout();
            this.VideoAddForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoFrame)).BeginInit();
            this.VideoOverviewCountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInfoPanel
            // 
            this.UserInfoPanel.BackColor = System.Drawing.Color.White;
            this.UserInfoPanel.Controls.Add(this.UserVideoStatusPanel);
            this.UserInfoPanel.Controls.Add(this.UserViewsStatusPanel);
            this.UserInfoPanel.Controls.Add(this.UserNameLabel);
            this.UserInfoPanel.Location = new System.Drawing.Point(10, 14);
            this.UserInfoPanel.Name = "UserInfoPanel";
            this.UserInfoPanel.Size = new System.Drawing.Size(882, 61);
            this.UserInfoPanel.TabIndex = 0;
            // 
            // UserVideoStatusPanel
            // 
            this.UserVideoStatusPanel.Controls.Add(this.VideoCntLabel);
            this.UserVideoStatusPanel.Location = new System.Drawing.Point(757, 3);
            this.UserVideoStatusPanel.Name = "UserVideoStatusPanel";
            this.UserVideoStatusPanel.Size = new System.Drawing.Size(57, 50);
            this.UserVideoStatusPanel.TabIndex = 2;
            // 
            // VideoCntLabel
            // 
            this.VideoCntLabel.AutoSize = true;
            this.VideoCntLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoCntLabel.ForeColor = System.Drawing.Color.Green;
            this.VideoCntLabel.Location = new System.Drawing.Point(3, 0);
            this.VideoCntLabel.Name = "VideoCntLabel";
            this.VideoCntLabel.Size = new System.Drawing.Size(158, 50);
            this.VideoCntLabel.TabIndex = 3;
            this.VideoCntLabel.Text = "0 videos";
            this.VideoCntLabel.Click += new System.EventHandler(this.VideoCntLabel_Click);
            // 
            // UserViewsStatusPanel
            // 
            this.UserViewsStatusPanel.Controls.Add(this.ViewCntLabel);
            this.UserViewsStatusPanel.Location = new System.Drawing.Point(820, 3);
            this.UserViewsStatusPanel.Name = "UserViewsStatusPanel";
            this.UserViewsStatusPanel.Size = new System.Drawing.Size(57, 53);
            this.UserViewsStatusPanel.TabIndex = 1;
            // 
            // ViewCntLabel
            // 
            this.ViewCntLabel.AutoSize = true;
            this.ViewCntLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCntLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.ViewCntLabel.Location = new System.Drawing.Point(0, 0);
            this.ViewCntLabel.Name = "ViewCntLabel";
            this.ViewCntLabel.Size = new System.Drawing.Size(141, 50);
            this.ViewCntLabel.TabIndex = 4;
            this.ViewCntLabel.Text = "0 views";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(2, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(279, 50);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "UserNameLabel";
            this.UserNameLabel.Click += new System.EventHandler(this.UserNameLabel_Click);
            // 
            // VideoOverviewLink
            // 
            this.VideoOverviewLink.AutoSize = true;
            this.VideoOverviewLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VideoOverviewLink.LinkColor = System.Drawing.Color.RoyalBlue;
            this.VideoOverviewLink.Location = new System.Drawing.Point(12, 78);
            this.VideoOverviewLink.Name = "VideoOverviewLink";
            this.VideoOverviewLink.Size = new System.Drawing.Size(63, 21);
            this.VideoOverviewLink.TabIndex = 1;
            this.VideoOverviewLink.TabStop = true;
            this.VideoOverviewLink.Text = "ОБЗОР";
            this.VideoOverviewLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VideoOverviewLink_LinkClicked);
            // 
            // MainView
            // 
            this.MainView.BackColor = System.Drawing.Color.White;
            this.MainView.Controls.Add(this.VideoAddForm);
            this.MainView.Controls.Add(this.VideoInfoList);
            this.MainView.Controls.Add(this.VideoFrame);
            this.MainView.Controls.Add(this.UserProfileInfoVideos);
            this.MainView.Controls.Add(this.UserProfileInfoListBox);
            this.MainView.Controls.Add(this.VideoOverviewCountPanel);
            this.MainView.Controls.Add(this.VideoOverviewLinkList);
            this.MainView.Location = new System.Drawing.Point(14, 104);
            this.MainView.Name = "MainView";
            this.MainView.Size = new System.Drawing.Size(877, 233);
            this.MainView.TabIndex = 2;
            // 
            // VideoAddForm
            // 
            this.VideoAddForm.Controls.Add(this.FileNameLabel);
            this.VideoAddForm.Controls.Add(this.button2);
            this.VideoAddForm.Controls.Add(this.button1);
            this.VideoAddForm.Controls.Add(this.label3);
            this.VideoAddForm.Controls.Add(this.ThemeComboBox);
            this.VideoAddForm.Controls.Add(this.label2);
            this.VideoAddForm.Controls.Add(this.NewVideoDescr);
            this.VideoAddForm.Controls.Add(this.label1);
            this.VideoAddForm.Controls.Add(this.NewVideoName);
            this.VideoAddForm.Location = new System.Drawing.Point(437, 5);
            this.VideoAddForm.Name = "VideoAddForm";
            this.VideoAddForm.Size = new System.Drawing.Size(275, 202);
            this.VideoAddForm.TabIndex = 8;
            this.VideoAddForm.TabStop = false;
            this.VideoAddForm.Text = "Добавление видео";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileNameLabel.Location = new System.Drawing.Point(198, 133);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(0, 21);
            this.FileNameLabel.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(100, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(100, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тема";
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeComboBox.FormattingEnabled = true;
            this.ThemeComboBox.Location = new System.Drawing.Point(100, 89);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(169, 29);
            this.ThemeComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NewVideoDescr
            // 
            this.NewVideoDescr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewVideoDescr.Location = new System.Drawing.Point(100, 54);
            this.NewVideoDescr.Name = "NewVideoDescr";
            this.NewVideoDescr.Size = new System.Drawing.Size(169, 29);
            this.NewVideoDescr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // NewVideoName
            // 
            this.NewVideoName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewVideoName.Location = new System.Drawing.Point(100, 23);
            this.NewVideoName.Name = "NewVideoName";
            this.NewVideoName.Size = new System.Drawing.Size(169, 29);
            this.NewVideoName.TabIndex = 0;
            // 
            // VideoInfoList
            // 
            this.VideoInfoList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VideoInfoList.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.VideoInfoList.FormattingEnabled = true;
            this.VideoInfoList.ItemHeight = 21;
            this.VideoInfoList.Location = new System.Drawing.Point(753, 5);
            this.VideoInfoList.Name = "VideoInfoList";
            this.VideoInfoList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.VideoInfoList.Size = new System.Drawing.Size(120, 88);
            this.VideoInfoList.TabIndex = 7;
            // 
            // VideoFrame
            // 
            this.VideoFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VideoFrame.Location = new System.Drawing.Point(241, 115);
            this.VideoFrame.Name = "VideoFrame";
            this.VideoFrame.Size = new System.Drawing.Size(67, 36);
            this.VideoFrame.TabIndex = 6;
            this.VideoFrame.TabStop = false;
            // 
            // UserProfileInfoVideos
            // 
            this.UserProfileInfoVideos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserProfileInfoVideos.Location = new System.Drawing.Point(715, 200);
            this.UserProfileInfoVideos.Name = "UserProfileInfoVideos";
            this.UserProfileInfoVideos.Size = new System.Drawing.Size(163, 33);
            this.UserProfileInfoVideos.TabIndex = 5;
            this.UserProfileInfoVideos.Text = "Видеозаписи";
            this.UserProfileInfoVideos.UseVisualStyleBackColor = true;
            this.UserProfileInfoVideos.Click += new System.EventHandler(this.UserProfileInfoVideos_Click);
            // 
            // UserProfileInfoListBox
            // 
            this.UserProfileInfoListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserProfileInfoListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UserProfileInfoListBox.FormattingEnabled = true;
            this.UserProfileInfoListBox.ItemHeight = 21;
            this.UserProfileInfoListBox.Location = new System.Drawing.Point(0, 0);
            this.UserProfileInfoListBox.Name = "UserProfileInfoListBox";
            this.UserProfileInfoListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.UserProfileInfoListBox.Size = new System.Drawing.Size(120, 88);
            this.UserProfileInfoListBox.TabIndex = 4;
            // 
            // VideoOverviewCountPanel
            // 
            this.VideoOverviewCountPanel.Controls.Add(this.VideoOverviewCountLabel);
            this.VideoOverviewCountPanel.Location = new System.Drawing.Point(0, 0);
            this.VideoOverviewCountPanel.Name = "VideoOverviewCountPanel";
            this.VideoOverviewCountPanel.Size = new System.Drawing.Size(431, 30);
            this.VideoOverviewCountPanel.TabIndex = 3;
            // 
            // VideoOverviewCountLabel
            // 
            this.VideoOverviewCountLabel.AutoSize = true;
            this.VideoOverviewCountLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VideoOverviewCountLabel.Location = new System.Drawing.Point(3, 5);
            this.VideoOverviewCountLabel.Name = "VideoOverviewCountLabel";
            this.VideoOverviewCountLabel.Size = new System.Drawing.Size(184, 20);
            this.VideoOverviewCountLabel.TabIndex = 1;
            this.VideoOverviewCountLabel.Text = "Последние видеозаписи:";
            // 
            // VideoOverviewLinkList
            // 
            this.VideoOverviewLinkList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VideoOverviewLinkList.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.VideoOverviewLinkList.FormattingEnabled = true;
            this.VideoOverviewLinkList.ItemHeight = 25;
            this.VideoOverviewLinkList.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six"});
            this.VideoOverviewLinkList.Location = new System.Drawing.Point(0, 28);
            this.VideoOverviewLinkList.Name = "VideoOverviewLinkList";
            this.VideoOverviewLinkList.Size = new System.Drawing.Size(365, 179);
            this.VideoOverviewLinkList.TabIndex = 0;
            this.VideoOverviewLinkList.SelectedIndexChanged += new System.EventHandler(this.VideoOverviewLinkList_SelectedIndexChanged);
            // 
            // UserProfileLinkLabel
            // 
            this.UserProfileLinkLabel.AutoSize = true;
            this.UserProfileLinkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserProfileLinkLabel.LinkColor = System.Drawing.Color.RoyalBlue;
            this.UserProfileLinkLabel.Location = new System.Drawing.Point(81, 78);
            this.UserProfileLinkLabel.Name = "UserProfileLinkLabel";
            this.UserProfileLinkLabel.Size = new System.Drawing.Size(92, 21);
            this.UserProfileLinkLabel.TabIndex = 3;
            this.UserProfileLinkLabel.TabStop = true;
            this.UserProfileLinkLabel.Text = "ПРОФИЛЬ";
            this.UserProfileLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UserProfileLinkLabel_LinkClicked);
            // 
            // NewVideoLink
            // 
            this.NewVideoLink.AutoSize = true;
            this.NewVideoLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewVideoLink.LinkColor = System.Drawing.Color.RoyalBlue;
            this.NewVideoLink.Location = new System.Drawing.Point(179, 78);
            this.NewVideoLink.Name = "NewVideoLink";
            this.NewVideoLink.Size = new System.Drawing.Size(125, 21);
            this.NewVideoLink.TabIndex = 4;
            this.NewVideoLink.TabStop = true;
            this.NewVideoLink.Text = "НОВОЕ ВИДЕО";
            this.NewVideoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewVideoLink_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif|BMP|*.bmp";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Location = new System.Drawing.Point(310, 78);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(147, 21);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "УДАЛИТЬ ВИДЕО";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 363);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.NewVideoLink);
            this.Controls.Add(this.UserProfileLinkLabel);
            this.Controls.Add(this.MainView);
            this.Controls.Add(this.VideoOverviewLink);
            this.Controls.Add(this.UserInfoPanel);
            this.Name = "MainBrowser";
            this.ShowIcon = false;
            this.Text = "MainBrowser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainBrowser_FormClosed);
            this.Load += new System.EventHandler(this.MainBrowser_Load);
            this.ResizeEnd += new System.EventHandler(this.MainBrowser_ResizeEnd);
            this.UserInfoPanel.ResumeLayout(false);
            this.UserInfoPanel.PerformLayout();
            this.UserVideoStatusPanel.ResumeLayout(false);
            this.UserVideoStatusPanel.PerformLayout();
            this.UserViewsStatusPanel.ResumeLayout(false);
            this.UserViewsStatusPanel.PerformLayout();
            this.MainView.ResumeLayout(false);
            this.VideoAddForm.ResumeLayout(false);
            this.VideoAddForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoFrame)).EndInit();
            this.VideoOverviewCountPanel.ResumeLayout(false);
            this.VideoOverviewCountPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UserInfoPanel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Panel UserViewsStatusPanel;
        private System.Windows.Forms.Panel UserVideoStatusPanel;
        private System.Windows.Forms.Label VideoCntLabel;
        private System.Windows.Forms.Label ViewCntLabel;
        private System.Windows.Forms.LinkLabel VideoOverviewLink;
        private System.Windows.Forms.Panel MainView;
        private System.Windows.Forms.Panel VideoOverviewCountPanel;
        private System.Windows.Forms.Label VideoOverviewCountLabel;
        private System.Windows.Forms.ListBox VideoOverviewLinkList;
        private System.Windows.Forms.LinkLabel UserProfileLinkLabel;
        private System.Windows.Forms.ListBox UserProfileInfoListBox;
        private System.Windows.Forms.Button UserProfileInfoVideos;
        private System.Windows.Forms.PictureBox VideoFrame;
        private System.Windows.Forms.ListBox VideoInfoList;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel NewVideoLink;
        private System.Windows.Forms.GroupBox VideoAddForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewVideoDescr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewVideoName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ThemeComboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}