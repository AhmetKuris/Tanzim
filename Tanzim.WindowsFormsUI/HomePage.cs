using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Net;
using System.Net.Mail;
using Tanzim.Business.Abstract;
using Tanzim.Business.DependencyResolvers.Ninject;
using Tanzim.Entities.Concrete;
using Tanzim.WindowsFormsUI.Properties;

namespace Tanzim.WindowsFormsUI
{
      

    public partial class HomePage : Form
    {
        

        private Color primerColor = Color.FromArgb(47, 54, 64);
        private Color sekonderColor = Color.FromArgb(232, 65, 24);

        private IUserService _userService;
        private ICategoryService _categoryService;
        private ITrackService _trackService;

        private DateTime _start;

        private DateTime _localStartTime;
        private List<Track> _listOfTracks;

        private int _ticks;
        public HomePage()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _trackService = InstanceFactory.GetInstance<ITrackService>();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

            LoadTracksOfCurrentUser();
            LoadCategories();
            CustomizedDesign();
            LoadTracks(_listOfTracks);


            //this.Font = Settings.Default.SettingsFontSyli;
            //this.BackColor = Settings.Default.SettingBackcolur;         
            // lblTrackCategory.Font = Settings.Default.SettingsFontSyli;
            //lblTrackName.Font = Settings.Default.SettingsFontSyli;
            //HomePageMenustrp.Font = Settings.Default.SettingsFontSyli;
            //dgwTracksHomePage.Font = Settings.Default.SettingsFontSyli;
            //lblShowAllCategories.Font = Settings.Default.SettingsFontSyli;
            //homePageSendpdfBtn.Font = Settings.Default.SettingsFontSyli;
            


            /*
            
            this.BackColor = Settings.Default.Formrengi;
            this.Font = Settings.Default.YaziOzellikleri;
            MenuStrip_Secenekler.Font = Settings.Default.YaziOzellikleri;*/
        }



        #region MailPart

        private void SendMail()
        {
            RefreshDgw();
            LoadTracksOfCurrentUser();
            LoadTracks(_listOfTracks);

            try
            {

                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress("vaktitanzim@gmail.com");
                ePosta.To.Add(_userService.GetLoggedInUserEmail());
                ePosta.Subject = "Tanzim Report";
                //ePosta.Body = dgwTracksHomePage.Rows.ToString();
                string fullBody = "";
                for (int i = 0; i < _listOfTracks.Count; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {

                        fullBody = fullBody + " --- " + dgwTracksHomePage.Rows[i].Cells[j].Value.ToString();
                    }
                    fullBody = fullBody + "\n";

                }

                ePosta.Body = fullBody;

                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new NetworkCredential("vaktitanzim@gmail.com", "Asd12345.");
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                //  smtp.SendAsync(ePosta, (object)ePosta);
                smtp.Send(ePosta);



            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        #endregion

        #region Reusable Loads-Refresh

        private void LoadCategories()
        {
            cbxTrackCategory.DataSource = _categoryService.ShowUserCategories();
            cbxTrackCategory.DisplayMember = "Name";
            cbxTrackCategory.ValueMember = "Id";

            cbxTrackCategoryDataGridView.DataSource = _categoryService.ShowUserCategories();
            cbxTrackCategoryDataGridView.DisplayMember = "Name";
            cbxTrackCategoryDataGridView.ValueMember = "Id";
        }
        private void LoadTracksOfCurrentUser()
        {
            _listOfTracks = _trackService.GetAllTracksOfCurrentUser();

        }

        private void RefreshDgw()
        {
            dgwTracksHomePage.Rows.Clear();
        }

        private string CategoryNameByCategoryId(int categoryId)
        {
            Category category = _categoryService.ShowUserCategories().FirstOrDefault(t => t.Id == categoryId);
            return category.Name;
        }

        private string TimeDifferenceBetweenStartStop(DateTime startTime, DateTime stopTime)
        {
            return (stopTime - startTime).ToString(@"hh\:mm\:ss");

        }
        #endregion

        #region Buttons

        private void homePageSendpdfBtn_Click(object sender, EventArgs e)
        {
            SendMail();
        }

        private void homePageStartBtn_Click(object sender, EventArgs e)
        {
            _start=DateTime.Now;
                
            timerMain.Start(); 

            homePageStopBtn.Visible = true;
            homePageStartBtn.Visible = false;

            _localStartTime = DateTime.Now;
         
        }

        private void homePageStopBtn_Click(object sender, EventArgs e)
        {
            timerMain.Stop();

            lblTimerMain.Text = "00:00:00";

            homePageStartBtn.Visible = true;
            homePageStopBtn.Visible = false;

            _trackService.SubmitTrackAndCategoryId(Convert.ToInt32(cbxTrackCategory.SelectedValue), new Track
            {
                Name = tbxTrackName.Text,
                StartTime = _localStartTime,
                StopTime = DateTime.Now
            });
            RefreshDgw();
            LoadTracksOfCurrentUser();
            LoadTracks(_listOfTracks);
        }


        #endregion

        #region Categories

        private void cbxTrackCategoryDataGridView_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxTrackCategory != null)
            {
                RefreshDgw();

                LoadTracks(_trackService.GetAllTracksOfCurrentUserByCategoryId(
                    Convert.ToInt32(cbxTrackCategoryDataGridView.SelectedValue)));

            }
        }

        private void lblShowAllCategories_Click(object sender, EventArgs e)
        {
            LoadTracksOfCurrentUser();
            RefreshDgw();
            LoadTracks(_listOfTracks);
        }



        #endregion

        #region DataGriedView

        private void LoadTracks(List<Track> listToShow)
        {


            listToShow.Reverse();

            foreach (var track in listToShow)
            {
                int rowId = dgwTracksHomePage.Rows.Add();

                dgwTracksHomePage.Rows[rowId].Cells[0].Value = track.Name;
                dgwTracksHomePage.Rows[rowId].Cells[1].Value = CategoryNameByCategoryId(track.CategoryId);
                dgwTracksHomePage.Rows[rowId].Cells[2].Value =
                    TimeDifferenceBetweenStartStop(track.StartTime, track.StopTime);
            }
        }

        #endregion

        #region CustomizeDesign

        private void CustomizedDesign()
        {
            dgwTracksHomePage.BorderStyle = BorderStyle.None;
            dgwTracksHomePage.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgwTracksHomePage.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgwTracksHomePage.DefaultCellStyle.SelectionBackColor = sekonderColor;
            dgwTracksHomePage.DefaultCellStyle.SelectionForeColor = Color.White;

            dgwTracksHomePage.ColumnHeadersDefaultCellStyle.BackColor = primerColor;
            dgwTracksHomePage.ColumnHeadersDefaultCellStyle.ForeColor = sekonderColor;
        }

        #endregion

        #region ExtraEvents

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {

            _userService.ClearSettingsDefault();

        }


        #endregion

 
        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void notifyIconMinimize_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void HomePage_Resize(object sender, EventArgs e)
        {
          
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Now - _start;

            lblTimerMain.Text = duration.ToString(@"hh\:mm\:ss");
        }

        private void fontStyliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage loginPageForm = new LoginPage();

            FontDialog FontWindow = new FontDialog();
            /*
             FontDialog FontPenceresi = new FontDialog();
            if (FontPenceresi.ShowDialog() == DialogResult.OK)
            {
                this.Font = FontPenceresi.Font;
                MenuStrip_Secenekler.Font = FontPenceresi.Font;
                Properties.Settings.Default.YaziOzellikleri = FontPenceresi.Font;
                Settings.Default.Save();
            }
             
             */
             if(FontWindow.ShowDialog() == DialogResult.OK)
             {
                this.Font = FontWindow.Font;
                lblTrackCategory.Font = FontWindow.Font;
                lblTrackName.Font = FontWindow.Font;
                HomePageMenustrp.Font = FontWindow.Font;
                dgwTracksHomePage.Font = FontWindow.Font;
                lblShowAllCategories.Font = FontWindow.Font;
                homePageSendpdfBtn.Font = FontWindow.Font;
                Properties.Settings.Default.SettingsFontSyli = FontWindow.Font;
                Settings.Default.Save();



                // eger forma yenoi bir eleman eklenirse burda yazi tipini degistirmemiz gerek ;


             }
            

        }

        private void backgroundColurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage loginPageForm = new LoginPage();
            ColorDialog ColorWindow = new ColorDialog();
            if(ColorWindow.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = ColorWindow.Color;
                loginPageForm.BackColor = ColorWindow.Color;

                /// eger form eklenirse buraya eklene formlarin backkolurunun eklenmesi lazim 


            }

            Settings.Default.SettingBackcolur = ColorWindow.Color;
            Settings.Default.Save();
        }
    }
}
