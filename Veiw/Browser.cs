using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CW1_IP.Controller;
using CW1_IP.Model;

namespace CW1_IP.Veiw
{
    public partial class Browser : Form
    {
        private static int HisC { get; set; } // this is an internal counter to count pages opened
        static int HisB = 0;                  // To keep count of back presses
        static int HisF = 0;                  // To keep count of forward presses

        public string CurrentURL;
        
        public Browser()
        {
            
            InitializeComponent();
            FormNav(ob1.GetHomePg());
        }

        public Browser(string url)
        {
            InitializeComponent();
            FormNav(url);

        }
        HomePg ob1 = new HomePg();
        HistClass Atemp = new HistClass();
        getHtml ob;
        public Boolean FormNav(string url)
        {
            ob = new getHtml(url);
            
            int StatCode = ob.GetStatusCode();
                StatusDis.Text = StatCode.ToString();
            URLEnter.Text = url;
            if (StatCode == 200)
                {
                    DisplayMain.Text = ob.HtmlResponse();
                    TitleDis.Text = ob.GetTitle();
                    Atemp.AddTo(URLEnter.Text, "");
                    CurrentURL = url;
                    return true;

                }
                else if (StatCode == 0)
                {
                    return false;
                }
                else
                {
                DisplayMain.Text = ob.HtmlResponse();
                    TitleDis.Text = ob.GetStatusCode().ToString();
                    Atemp.AddTo(URLEnter.Text, "");
                    return true;
            }
            
            
        }

        private void GoButt_Click(object sender, EventArgs e)
        {
           
            if (CurrentURL != URLEnter.Text)
            {
                bool temp = FormNav(URLEnter.Text);
     
            }
           
        }

        private void HomeButt_Click(object sender, EventArgs e)
        {
            string url = ob1.GetHomePg();

            if (url != null)
            {
                FormNav(url);
            }                                                         //HomePage displayed on set
            
 
            

        }

        private void DisplayMain_LinkClicked(object sender, LinkClickedEventArgs e)
        {

            FormNav(e.LinkText);
               
        }

        private void SettingsView_Click(object sender, EventArgs e)
        {
            if(DropDon.Height == 41)
            {
                DropDon.Height = 221;
            }else
            {
                DropDon.Height = 41;
            }
        }

        private void FavSet_Click(object sender, EventArgs e)
        {
            FavDisplay ob = new FavDisplay();
            ob.ShowDialog();
        }

        private void HistSet_Click(object sender, EventArgs e)
        {
            HistDisplay ob = new HistDisplay();
            ob.ShowDialog();
        }

        private void HomeSet_Click(object sender, EventArgs e)
        {
            AddHomePG ob = new AddHomePG();
            ob.ShowDialog();
        }

        private void ExitSet_Click(object sender, EventArgs e)
        {

        }

        private void Browser_Load(object sender, EventArgs e)
        {
            // Assign an image to the Favarites.

            FavButt.Image = Image.FromFile(@".\Data\Icons\Button-Favorite-icon.png");
            // Align the image to the button.
            FavButt.ImageAlign = ContentAlignment.MiddleCenter;
            

            // Assign an image to the Go.
            GoBut.Image = Image.FromFile(@".\Data\Icons\go.png");
            // Align the image  to the button.
            GoBut.ImageAlign = ContentAlignment.MiddleCenter;
            

            // Assign an image to the Forward.

            BackButt.Image = Image.FromFile(@".\Data\Icons\Back.png");
            // Align the image to the button.
            BackButt.ImageAlign = ContentAlignment.MiddleCenter;
            

            // Assign an image to the button1(Go).

            ForButt.Image = Image.FromFile(@".\Data\Icons\forward.png");
            // Align the image to the button.
            ForButt.ImageAlign = ContentAlignment.MiddleCenter;
            

            // Assign an image to the Home.

            HomeButt.Image = Image.FromFile(@".\Data\Icons\Home.png");
            // Align the image  to the button.
            HomeButt.ImageAlign = ContentAlignment.MiddleCenter;
            
            //Assign an image to Refresh
            RefrButt.Image = Image.FromFile(@".\Data\Icons\Refresh.jpg");
            // Align the image to the button.
            RefrButt.ImageAlign = ContentAlignment.MiddleCenter;
            

        }

        private void ForButt_Click(object sender, EventArgs e)
        {


        }

        private void StatusDis_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButt_Click(object sender, EventArgs e)
        {
            HistClass Atemp = new HistClass();

            List<HisData> Htemp = new List<HisData>();
            Htemp = (List<HisData>)Atemp.GetList();
            HisC = Htemp.Count;
            HisB += 1;
            HisF = 0;
            string url;
            var query = from x in Htemp
                        where x.NoHis == HisC - HisB
                        select x;


            if (query == null)
            {
                MessageBox.Show("No Url Before This", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool tmp = false;
                foreach (HisData s in query) {
                    url = s.HisURL;
                    tmp = FormNav(url);
                }
                if (tmp == false)
                    MessageBox.Show("Internal error occured", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


        }

        private void RefrButt_Click(object sender, EventArgs e)
        { 

            URLEnter.Text = "Loading";
            TitleDis.Text = "Loading";
            StatusDis.Text = "";
            DisplayMain.Text = "Loading";
            

            if (CurrentURL != null)
                {
                bool temp = FormNav(CurrentURL);


                if (temp == false)
                {
                    ob = new getHtml(URLEnter.Text);
                    DisplayMain.Text = ob.HtmlResponse();
                    TitleDis.Text = ob.GetStatusCode().ToString();
                    
                }
            }

        }

        private void FavButt_Click(object sender, EventArgs e)
        {
             ob = new getHtml(URLEnter.Text);
            

            if (ob.GetStatusCode() == 200)
            {
                FavClass Ftemp = new FavClass();
                ob.HtmlResponse();
                Ftemp.AddTo(URLEnter.Text, ob.GetTitle());           //Adds Favourite along with Title on CLick;
            }
            else
                MessageBox.Show("Site Not Available- Not added to Favorites", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);

        }
    }
}
