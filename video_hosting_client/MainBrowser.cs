using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace video_hosting_client
{
    public partial class MainBrowser : Form
    {
        private string UID;
        private string ULogin;
        private bool NoUser;
        private Form MainForm;

        private bool DeletingMode;

        private const int UserInfoPanelWidth = 96;
        private const int UserInfoPanelHeight = 10;
        private const int UserInfoPanelVOffset = 2;
        private const int MainViewVOffset = 6;

        private ArrayList VideoIdList;

        private string LastUid;

        public MainBrowser(string UserId, string UserLogin, Form MF)
        {
            InitializeComponent();
            this.UID = UserId;
            this.ULogin = UserLogin;
            this.MainForm = MF;
            if (this.UID.CompareTo("") == 0) this.NoUser = true; else this.NoUser = false;
            if (this.NoUser) this.ULogin = "[Гостевой сеанс]";
            this.Text = "VideoHostingClient - [" + this.ULogin + "]";
            this.UserNameLabel.Text = this.ULogin;
            DeletingMode = false;
        }

        private void MainBrowser_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Close();
        }

        private void MainBrowser_Resize(object sender, EventArgs e)
        {

        }

        private void MainBrowser_ResizeEnd(object sender, EventArgs e)
        {
            ResizePanels();
        }

        private void MainBrowser_Load(object sender, EventArgs e)
        {
            VideoIdList = new ArrayList();
            RefreshViewsAndRatingData();
            ResizePanels();
            OpenVideoOverview("");
        }

        private void FitLabelToPanel(Label label, Panel panel)
        {
            while (label.Height < panel.Height)
                label.Font = new Font(label.Font.FontFamily.Name, label.Font.Size + 1, label.Font.Style);
            while (label.Height > panel.Height)
                label.Font = new Font(label.Font.FontFamily.Name, label.Font.Size - 1, label.Font.Style);
        }

        private void ResizePanels()
        {
            UserInfoPanel.Width = this.Width * UserInfoPanelWidth / 100;
            UserInfoPanel.Height = this.Height * UserInfoPanelHeight / 100;
            UserInfoPanel.Location = new Point((100 - UserInfoPanelWidth) * this.Width / 200, this.Height * UserInfoPanelVOffset / 100);

            FitLabelToPanel(UserNameLabel, UserInfoPanel);

            UserVideoStatusPanel.Height = UserInfoPanel.Height / 2;
            UserViewsStatusPanel.Height = UserInfoPanel.Height / 2;

            FitLabelToPanel(ViewCntLabel, UserViewsStatusPanel);
            FitLabelToPanel(VideoCntLabel, UserVideoStatusPanel);

            UserVideoStatusPanel.Width = VideoCntLabel.Width;
            UserViewsStatusPanel.Width = ViewCntLabel.Width;

            UserViewsStatusPanel.Location = new Point(UserInfoPanel.Width - UserViewsStatusPanel.Width, 0);
            UserVideoStatusPanel.Location = new Point(UserInfoPanel.Width - UserVideoStatusPanel.Width, UserViewsStatusPanel.Height);

            VideoOverviewLink.Location = new Point(UserInfoPanel.Location.X, UserInfoPanel.Location.Y + UserInfoPanel.Height);
            UserProfileLinkLabel.Location = new Point(VideoOverviewLink.Location.X + VideoOverviewLink.Width + 5, VideoOverviewLink.Location.Y);
            NewVideoLink.Location = new Point(UserProfileLinkLabel.Location.X + UserProfileLinkLabel.Width + 5, VideoOverviewLink.Location.Y);
            linkLabel1.Location = new Point(NewVideoLink.Location.X + NewVideoLink.Width + 5, NewVideoLink.Location.Y);

            MainView.Width = UserInfoPanel.Width;
            MainView.Location = new Point(UserInfoPanel.Location.X, VideoOverviewLink.Location.Y + VideoOverviewLink.Height);
            MainView.Height = this.Height - MainView.Location.Y - this.Height * MainViewVOffset / 100;

            VideoOverviewCountLabel.Width = MainView.Width;

            UserProfileInfoListBox.Width = MainView.Width;
            UserProfileInfoListBox.Height = MainView.Height;

            UserProfileInfoVideos.Location = new Point(MainView.Width - UserProfileInfoVideos.Width, MainView.Height - UserProfileInfoVideos.Height);

            VideoFrame.Width = MainView.Width / 2;
            VideoFrame.Height = MainView.Height - VideoOverviewCountLabel.Height - 10 ;
            VideoFrame.Location = new Point(0, VideoOverviewCountLabel.Height + 5);

            VideoInfoList.Width = VideoFrame.Width;
            VideoInfoList.Height = VideoFrame.Height;
            VideoInfoList.Location = new Point(VideoFrame.Width, VideoFrame.Location.Y);

            VideoAddForm.Width = MainView.Width;
            VideoAddForm.Height = MainView.Height;
            VideoAddForm.Location = new Point(0, 0);

            ResizeMainViewContent();
        }

        private void UserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void RefreshViewsAndRatingData()
        {
            if (this.NoUser) return;
            this.Cursor = Cursors.WaitCursor;
            using (SqlConnection connection = new SqlConnection("Data Source=VOVANLSKSPB;Initial Catalog=VideoHosting;Persist Security Info=True;User ID=vladimir;Password=reverse"))
            {

                SqlCommand cmd = new SqlCommand("SELECT Count(VideoId) FROM [Video] WHERE UserId = @uid", connection);
                cmd.Parameters.AddWithValue("@uid", this.UID);
                SqlCommand cmd2 = new SqlCommand("SELECT Sum(ViewsCnt) FROM [Video] WHERE UserId = @uid", connection);
                cmd2.Parameters.AddWithValue("@uid", this.UID);
                try
                {
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        IDataRecord record = (IDataRecord)reader;
                        this.VideoCntLabel.Text = record[0].ToString() + " videos";
                    }
                    reader.Close();
                    reader = cmd2.ExecuteReader();
                    if (reader.Read())
                    {
                        IDataRecord record = (IDataRecord)reader;
                        this.ViewCntLabel.Text = record[0].ToString() + " views";
                    }

                    connection.Close();
                }
                catch
                {
                }
                this.Cursor = Cursors.Default;
            }
            ResizePanels();
        }

        private void VideoCntLabel_Click(object sender, EventArgs e)
        {

        }

        private void VideoOverviewLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeletingMode = false;
            OpenVideoOverview("");
        }

        private void OpenVideoOverview( string UserId )
        {
            this.Cursor = Cursors.WaitCursor;
            this.VideoOverviewCountLabel.Text = "Последние загруженные видеозаписи";
            if (DeletingMode) this.VideoOverviewCountLabel.Text = "Выберите видео для удаления"; 

            HideAll();
            this.VideoOverviewLinkList.Visible = true ;
            this.VideoOverviewCountPanel.Visible = true;

            LatestVideosRequest(UserId);

            this.Cursor = Cursors.Default;

        }

        private void LatestVideosRequest( string UserId  )
        {
            this.Cursor = Cursors.WaitCursor;
            using (SqlConnection connection = new SqlConnection("Data Source=VOVANLSKSPB;Initial Catalog=VideoHosting;Persist Security Info=True;User ID=vladimir;Password=reverse"))
            {
                this.VideoOverviewLinkList.Items.Clear();
                this.VideoIdList.Clear();

                SqlCommand cmd;
                if (UserId.CompareTo("") == 0) cmd = new SqlCommand("SELECT VideoId, VideoName, ViewsCnt FROM [Video]", connection);
                else
                {
                    cmd = new SqlCommand("SELECT VideoId, VideoName, ViewsCnt FROM [Video] where UserId = @uid", connection);
                    cmd.Parameters.AddWithValue("@uid", UserId);
                }
                try
                {
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        IDataRecord record = (IDataRecord)reader;
                        this.VideoIdList.Add(record["VideoId"].ToString());
                        this.VideoOverviewLinkList.Items.Add(record["VideoName"].ToString() + " [" +
                            record["ViewsCnt"].ToString() + " views]");
                    }

                    connection.Close();
                }
                catch
                {
                }
                this.Cursor = Cursors.Default;
            }
        }

        private void ResizeMainViewContent()
        {
            VideoOverviewCountPanel.Width = MainView.Width;
            VideoOverviewLinkList.Width = MainView.Width;
            VideoOverviewLinkList.Height = MainView.Height - VideoOverviewCountPanel.Height;
        }

        private void OpenWatchingProfile( string UserId )
        {
            if (UserId.CompareTo("") == 0) return;
            HideAll();
            UserProfileInfoListBox.Visible = true ;
            UserProfileInfoVideos.Visible = true;
            LastUid = UserId;

            this.Cursor = Cursors.WaitCursor;
            using (SqlConnection connection = new SqlConnection("Data Source=VOVANLSKSPB;Initial Catalog=VideoHosting;Persist Security Info=True;User ID=vladimir;Password=reverse"))
            {
                this.UserProfileInfoListBox.Items.Clear();

                SqlCommand cmd = new SqlCommand("SELECT UserLogin, UserEmail, RegisterDate FROM [UserInfo] where UserId = @uid", connection);
                cmd.Parameters.AddWithValue("@uid", UserId);
                SqlCommand cmd2 = new SqlCommand("SELECT Count(VideoId) FROM [Video] WHERE UserId = @uid", connection);
                cmd2.Parameters.AddWithValue("@uid", UserId);
                SqlCommand cmd3 = new SqlCommand("SELECT Sum(ViewsCnt) FROM [Video] WHERE UserId = @uid", connection);
                cmd3.Parameters.AddWithValue("@uid", UserId);
                try
                {
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        IDataRecord record = (IDataRecord)reader;
                        this.UserProfileInfoListBox.Items.Add("Логин: " + reader["UserLogin"]);
                        this.UserProfileInfoListBox.Items.Add("E-mail: " + reader["UserEmail"]);
                        this.UserProfileInfoListBox.Items.Add("Дата регистрации: " + reader["RegisterDate"]);
                    }
                    reader.Close();
                    reader = cmd2.ExecuteReader();
                    if (reader.Read())
                    {
                        IDataRecord record = (IDataRecord)reader;
                        this.UserProfileInfoListBox.Items.Add("Видеозаписей: " + reader[0]);
                    }
                    reader.Close();
                    reader = cmd3.ExecuteReader();
                    if (reader.Read())
                    {
                        IDataRecord record = (IDataRecord)reader;
                        this.UserProfileInfoListBox.Items.Add("Просмотров: " + reader[0]);
                    }
                    connection.Close();
                }
                catch
                {
                }
                this.Cursor = Cursors.Default;
            }
        }

        private void UserProfileLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWatchingProfile(this.UID);
        }

        private void HideAll()
        {
            VideoOverviewCountPanel.Visible = false;
            VideoOverviewLinkList.Visible = false;
            UserProfileInfoListBox.Visible = false;
            UserProfileInfoVideos.Visible = false;
            VideoInfoList.Visible = false;
            VideoFrame.Visible = false;
            VideoAddForm.Visible = false;
            RefreshViewsAndRatingData();
        }

        private void UserProfileLinkLabel_LinkClicked()
        {

        }

        private void UserProfileInfoVideos_Click(object sender, EventArgs e)
        {
            DeletingMode = false;
            OpenVideoOverview(LastUid);
        }

        private void VideoOverviewLinkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string VideoId;
            try { VideoId = VideoIdList[VideoOverviewLinkList.SelectedIndex].ToString(); }
            catch { return; }
            if (DeletingMode) DeleteVideo(VideoId); else RunVideo(VideoId);
        }

        private void DeleteVideo(string VideoId)
        {
            DialogResult Confirmed = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Confirmed == DialogResult.No) return;
            using (SqlConnection connection = new SqlConnection("Data Source=VOVANLSKSPB;Initial Catalog=VideoHosting;Persist Security Info=True;User ID=vladimir;Password=reverse"))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Video where VideoId = @vid", connection);
                cmd.Parameters.AddWithValue("@vid", VideoId);
                try
                {
                    connection.Open();

                    cmd.ExecuteNonQuery();
                    
                    connection.Close();
                }
                catch( SqlException exc )
                {
                    MessageBox.Show( exc.Message );
                    MessageBox.Show("Ошибка при удалении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Cursor = Cursors.Default;
                OpenVideoOverview(this.UID);
            }
        }

        private void RunVideo(string VideoId)
        {
            HideAll();
            VideoOverviewCountPanel.Visible = true;
            VideoFrame.Visible = true;
            VideoInfoList.Visible = true;

            using (SqlConnection connection = new SqlConnection("Data Source=VOVANLSKSPB;Initial Catalog=VideoHosting;Persist Security Info=True;User ID=vladimir;Password=reverse"))
            {
                this.VideoInfoList.Items.Clear();
                this.VideoFrame.BackgroundImage = this.VideoFrame.ErrorImage;
                SqlCommand cmd = new SqlCommand("SELECT UserId, ThemeId, VideoName, Descr, SubmitDate, ViewsCnt, Rating, DataLink FROM [Video] where VideoId = @vid", connection);
                cmd.Parameters.AddWithValue("@vid", VideoId);
                SqlCommand PlusCmd = new SqlCommand("EXEC AddView @vid", connection);
                PlusCmd.Parameters.AddWithValue("@vid", VideoId);

                try
                {
                    connection.Open();
                    string UserId = "";
                    string ThemeId = "";
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {

                        IDataRecord record = (IDataRecord)reader;
                        VideoOverviewCountLabel.Text = record["VideoName"].ToString();
                        toolTip1.SetToolTip(VideoFrame, record["Descr"].ToString());
                        VideoInfoList.Items.Add("Добавлено " + record["SubmitDate"].ToString());
                        VideoInfoList.Items.Add("Просмотров: " + record["ViewsCnt"].ToString());
                        VideoInfoList.Items.Add("Рейтинг: " + record["Rating"].ToString());
                        try { VideoFrame.BackgroundImage = Image.FromFile(record["DataLink"].ToString()); }catch{}
                        UserId = record["UserId"].ToString();
                        ThemeId = record["ThemeId"].ToString();
                    }
                    reader.Close();
                    SqlCommand cmd2 = new SqlCommand("SELECT ThemeName FROM [Theme] where ThemeId = @tid", connection);
                    cmd2.Parameters.AddWithValue("@tid", ThemeId);
                    SqlCommand cmd3 = new SqlCommand("SELECT UserLogin FROM [UserInfo] where UserId = @uid", connection);
                    cmd3.Parameters.AddWithValue("@uid", UserId);

                    reader = cmd2.ExecuteReader();
                    if (reader.Read())
                        VideoInfoList.Items.Add("Тема: " + ((IDataRecord)reader)[0].ToString());
                    reader.Close();
                    reader = cmd3.ExecuteReader();
                    if (reader.Read())
                        VideoInfoList.Items.Add("Добавил: " + ((IDataRecord)reader)[0].ToString());
                    reader.Close();
                    PlusCmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch
                {
                }
                this.Cursor = Cursors.Default;
            }
        }

        private void NewVideoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewVideo();
        }

        private void NewVideo()
        {
            if (this.NoUser) return;
            HideAll();
            VideoAddForm.Visible = true;
            using (SqlConnection connection = new SqlConnection("Data Source=VOVANLSKSPB;Initial Catalog=VideoHosting;Persist Security Info=True;User ID=vladimir;Password=reverse"))
            {
                this.ThemeComboBox.Items.Clear();
                this.FileNameLabel.Text = "";

                SqlCommand cmd = new SqlCommand("SELECT ThemeName FROM [Theme]", connection);
                
                try
                {
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        IDataRecord record = (IDataRecord)reader;
                        ThemeComboBox.Items.Add(record[0].ToString());
                    }
                    ThemeComboBox.SelectedIndex = 0;

                    connection.Close();
                }
                catch
                {
                }
                this.Cursor = Cursors.Default;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileNameLabel.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=VOVANLSKSPB;Initial Catalog=VideoHosting;Persist Security Info=True;User ID=vladimir;Password=reverse"))
            {
                
                SqlCommand cmd = new SqlCommand("INSERT INTO Video (VideoName, UserId, ThemeId, Descr, Datalink ) VALUES ('" +NewVideoName.Text + 
                    "' , '" + this.UID + "', (select ThemeId from Theme where ThemeName = '"+ ThemeComboBox.SelectedItem.ToString()+"'), '"+
                    NewVideoDescr.Text + "', '" + FileNameLabel.Text + "')", connection);
                /*cmd.Parameters.AddWithValue("@vnm", NewVideoName.Text);
                cmd.Parameters.AddWithValue("@uid", this.UID);
                cmd.Parameters.AddWithValue("@tnm", ThemeComboBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@dscr", NewVideoDescr.Text);
                cmd.Parameters.AddWithValue("@dtl", FileNameLabel.Text);*/

                try
                {
                    connection.Open();

                    cmd.ExecuteNonQuery();

                    connection.Close();

                    OpenVideoOverview("");
                }
                catch
                {
                    MessageBox.Show("Ошибка при создании видео", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeletingMode = true;
            OpenVideoOverview(UID);
        }
     
    }
}
