using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;

namespace FBF
{
    public partial class Main : Form
    {
        private FacebookClient _fb;
        private readonly string _url = $"https://graph.facebook.com/v2.12/me/friends";
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


            _fb = new FacebookClient
            {
                AccessToken = txtToken.Text,
                Version = "v12.2"
            };

            if(!backgroundWorker_getFriends.IsBusy)
                backgroundWorker_getFriends.RunWorkerAsync(100);

        }

        private void GetFriends(string url, ref List<string> frList)
        {
            try
            {
                int totalFriends = 0;
                var json = _fb.Get(url) as JsonObject;
                var hasData = json.TryGetValue("data", out var data);
                if (!hasData) return;
                if (json.TryGetValue("summary", out dynamic summary))
                {
                    totalFriends = Convert.ToInt32(summary["total_count"]);

                }
                
                foreach (dynamic fr in (JsonArray)data)
                {
                    var id = fr["id"];
                    frList.Add(id);
                    var percent = frList.Count * 100 / totalFriends;
                    if (percent>0)backgroundWorker_getFriends.ReportProgress(percent);
                    Utilities.WriteFriendIdToFile(id, txtFilePath.Text);
                    //                        frList.Add(id);
                }

                var paging = json.TryGetValue("paging", out object page);
                if (!paging) return;
                var hasNext = ((JsonObject) page).TryGetValue("next", out var next);
                if (!hasNext)
                {
                    backgroundWorker_getFriends.ReportProgress(100);
//                    e.Result = 100;
                    return;
                }
                GetFriends(next.ToString(),ref frList);
            }
            catch (Exception ex)
            {
                Utilities.WriteErrorToLog(ex.StackTrace);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Do you want to exit?", @"Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Exit();

        }

        private void backgroundWorker_getFriends_DoWork(object sender, DoWorkEventArgs e)
        {
            var frs = new List<string>();
            GetFriends(_url,ref frs);
        }

        private void backgroundWorker_getFriends_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {

                prComplete.Value = e.ProgressPercentage;
            }
            catch (Exception ex)
               {
                Utilities.WriteErrorToLog(ex.StackTrace);
            }
            
        }

        private void backgroundWorker_getFriends_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Completed!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = folder.SelectedPath + @"\friend_ids.txt";
            }
        }
    }
}
