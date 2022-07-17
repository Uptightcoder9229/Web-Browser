using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CW1_IP.Model;
namespace CW1_IP.Veiw
{
    public partial class FavDisplay : Form
    {
        public FavDisplay()
        {
            InitializeComponent();

        }
        void RFav()                        // Function to display Fav on box
        {
            FavClass His = new FavClass();
            HashSet<FavData> temp = new HashSet<FavData>();
            temp = (HashSet<FavData>)His.getList();
            string Disp = "";
            try
            {
                if (temp.Count != 0)
                {
                    foreach (FavData s in temp)
                    {
                        Disp = Disp + s.FavName + "        " + s.FavURL + "\n";
                    }
                }
                else
                {
                    Disp = "No Url present";
                }
                RemoveDis.Text = Disp;
            }
            catch (Exception)
            {
                MessageBox.Show("Favorites Not Loaded", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RemoveDis.Text = "Favorites Not Loaded";
            }
        }

        void DFav()
        {
            FavClass His = new FavClass();
            HashSet<FavData> temp = new HashSet<FavData>();
            temp = (HashSet<FavData>)His.getList();

            string Disp = "";

            try
            {
                if (temp.Count != 0)
                {
                    foreach (FavData s in temp)
                    {
                        Disp = Disp + s.FavName + "        " + s.FavURL + "\n";
                    }
                }
                else
                {
                    Disp = "No Url present";
                }
                FavDisp.Text = Disp;
            }
            catch (Exception)
            {
                MessageBox.Show("History Not Loaded", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FavDisp_TextChanged(object sender, EventArgs e)
        {
        }
        bool textChange;
        private void FavDisplay_Load(object sender, EventArgs e)
        {

            DFav();

        }

        private void FavDisp_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Browser bo = new Browser(e.LinkText);
            bo.Show();
            
        }

        

        private void EditFav_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 0)
                panel2.Height = 330;
            else
                panel2.Height = 0;

             if (panel2.Height == 330)
            {
                RFav();

            }
        }

        private void RemoveDis_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            if (panel1.Height == 0)
                panel1.Height = 62;
            FavClass His = new FavClass();
            HashSet<FavData> temp = new HashSet<FavData>();
            temp = (HashSet<FavData>)His.getList();

            var query = from x in temp
                        where x.FavURL == e.LinkText
                        select x;
            foreach (FavData s in query.ToList())
            {
                NameFav.Text = s.FavName;
                UrlFav.Text = s.FavURL;
            }
        }

        private void ModifyFav_Click(object sender, EventArgs e)
        {
            FavClass His = new FavClass();
            His.ModifyFav(UrlFav.Text , NameFav.Text, textChange);
            DFav();
            RFav();
            
        }

        private void RemoveFav_Click(object sender, EventArgs e)
        {
            FavClass His = new FavClass();
           bool tmp=  His.RemoveFrom(UrlFav.Text);
            DFav();
            RFav();
            if (tmp == true)
                MessageBox.Show("Removed Favorite", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Not Removed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NameFav_TextChanged(object sender, EventArgs e)
        {
            textChange = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UrlFav_TextChanged(object sender, EventArgs e)
        {
            textChange = false;
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 330)
            {
                panel2.Height = 0;

            }
            if (panel1.Height == 62)
                panel1.Height = 0;
        }
    }
}
