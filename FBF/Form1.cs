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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            var token = txtToken.Text;
            if (string.IsNullOrEmpty(token))
            {
                MessageBox.Show("Enter your token");
                return;
            }
            var fb = new Facebook.FacebookClient
            {
                AccessToken = txtToken.Text,
                Version = "v12.2"
            };
            var url = $"https://graph.facebook.com/v2.12/me/friends?limit=5000";
            var rs = fb.Get(url);
            Console.Write(rs);
            //return JsonConvert.DeserializeObject<Posts>(rs.ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
                Application.Exit();

        }
    }
}
