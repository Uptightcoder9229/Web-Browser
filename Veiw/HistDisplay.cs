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
    public partial class HistDisplay : Form
    {
        public HistDisplay()
        {
            InitializeComponent();
        }

        private void HistDisplay_Load(object sender, EventArgs e)
        {
            HistClass His = new HistClass();
            List<HisData> temp = new List<HisData>();
            temp = (List<HisData>)His.GetList();

            var query = from x in temp                                //LinQ to select all values in list HisData
                        where x.NoHis <= temp.Count
                        select x;
            string Disp = "";

            try
            {
                if (query != null)
                {
                    foreach (HisData s in query)
                    {
                        Disp = Disp + s.NoHis + "        " + s.HisURL + "\n";
                    }
                }else
                {
                    Disp= "No Url present";
                }
                HistDis.Text = Disp;
            } catch(Exception)
            {
                MessageBox.Show("History Not Loaded", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void HistDis_LinkClicked(object sender, LinkClickedEventArgs e)
        {
             Browser bo = new Browser(e.LinkText);
             bo.ShowDialog();
            this.Close();
        }

        private void ClearHis_Click(object sender, EventArgs e)
        {
            HistClass His = new HistClass();
            His.RemoveFrom("");
            List <HisData> temp = new List<HisData>();
            temp = (List<HisData>)His.GetList();
            HistDis.Text = "";
            
        }

    }
    }

