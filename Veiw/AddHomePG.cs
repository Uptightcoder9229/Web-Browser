using System;
using System.Windows.Forms;
using CW1_IP.Controller;
using CW1_IP.Model;
namespace CW1_IP.Veiw
{
    public partial class AddHomePG : Form
    {
        public AddHomePG()
        {
            InitializeComponent();
        }

        private void AddHg_Click(object sender, EventArgs e)
        {
            getHtml ob = new getHtml(HomeEnter.Text);
            int Tmp = ob.GetStatusCode();
            if (Tmp == 200) {
                HomePg of = new HomePg();
                if(HomeEnter.Text != of.GetHomePg())
                of.AddTo(HomeEnter.Text,"");
            }else
            {
                MessageBox.Show("URL unavialble", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Tmp == 200)
                this.Close();
        }

        private void HomeEnter_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddHomePG_Load(object sender, EventArgs e)
        {

        }
    }
}
