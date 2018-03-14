using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBF
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtToken.Text))
            {
                MessageBox.Show("Enter your token");
                return;
            }


            var url = $"https://graph.facebook.com/v2.12/me/friends";
            List<string> list;
           GetFriends(url, out list);
//            Console.Write(rs);  
            //return JsonConvert.DeserializeObject<Posts>(rs.ToString());
        }

        private void GetFriends(string url, out List<string> frList)
        {
            frList = new List<string>();
            var fb = new Facebook.FacebookClient
            {
                AccessToken = txtToken.Text,
                Version = "v12.2"
            };
            frList.Add("1");
            var rs = fb.Get(url) as JsonObject;
            var data = rs.Keys;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Do you want to exit?", @"Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Exit();

        }
    }
}
