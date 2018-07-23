using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;

namespace SSHBlackListChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            System.Net.ServicePointManager.Expect100Continue = false;
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = File.OpenText(openFileDialog1.FileName))
                {
                    int i = 0;
                    string s = String.Empty;
                    while ((s = sr.ReadLine()) != null)
                    {
                        string _yourString = s;
                        string[] ssh = _yourString.Split('|');
                        dtSSH.Rows.Add((ssh[0]).ToString());
                        dtSSH.Rows[i].Cells[1].Value = ssh[1].Trim();
                        dtSSH.Rows[i].Cells[2].Value = ssh[2].Trim();
                        dtSSH.Rows[i].Cells[3].Value = ssh[3].Trim();
                        i++;
                     //   Thread.Sleep(5);


                    }
                    sr.Close();
                }
                txt2.Text = dtSSH.Rows.Count.ToString() + " (SSH)";
                MessageBox.Show("Completed");
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt4.Text = "Running ...";
            timer1.Enabled = true;
            timer1.Start();
        }

        private string[] Blacklist(string Ipaddress, string[] BlackListServers)
        {
            string[] kq = new string[2];

            VerifyIP IP = new VerifyIP(Ipaddress, BlackListServers);
            if (IP.IPAddr.Valid)    //Is the IP valid
            {
                if (IP.BlackList.IsListed)  //Is the IP address listed?
                {
                    kq[0] = "Yes";
                    kq[1] = IP.BlackList.VerifiedOnServer;
                }
                else
                {
                    kq[0] = "No";
                    kq[1] = "";
                }
            }

            return kq;
        }

        int xxx = 0;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker7_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker8_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker9_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker10_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker11_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker12_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker13_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker14_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker15_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker16_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker17_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker18_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker19_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void backgroundWorker20_DoWork(object sender, DoWorkEventArgs e)
        {
            xxx++;
            if ((xxx - 1) <= dtSSH.Rows.Count)
            {
                string[] BLS = new string[] { "sbl-xbl.spamhaus.org", "bl.spamcop.net", "dnsbl.njabl.org", "list.dsbl.org", "multihop.dsbl.org", "cbl.abuseat.org" };

                string[] blacklist = Blacklist(dtSSH.Rows[xxx - 1].Cells[0].Value.ToString(), BLS);
                dtSSH.Rows[xxx - 1].Cells[4].Value = blacklist[0];
                dtSSH.Rows[xxx - 1].Cells[5].Value = blacklist[1];
                if (blacklist[0] == "Yes")
                {
                    try
                    {
                        txt3.Text = (Int32.Parse(txt3.Text) + 1).ToString();
                    }
                    catch { }
                }
            }
            else timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy) backgroundWorker1.RunWorkerAsync();
            if (!backgroundWorker2.IsBusy) backgroundWorker2.RunWorkerAsync();
            if (!backgroundWorker3.IsBusy) backgroundWorker3.RunWorkerAsync();
            if (!backgroundWorker4.IsBusy) backgroundWorker4.RunWorkerAsync();
            if (!backgroundWorker5.IsBusy) backgroundWorker5.RunWorkerAsync();
            if (!backgroundWorker6.IsBusy) backgroundWorker6.RunWorkerAsync();
            if (!backgroundWorker7.IsBusy) backgroundWorker7.RunWorkerAsync();
            if (!backgroundWorker8.IsBusy) backgroundWorker8.RunWorkerAsync();
            if (!backgroundWorker9.IsBusy) backgroundWorker9.RunWorkerAsync();
            if (!backgroundWorker10.IsBusy) backgroundWorker10.RunWorkerAsync();
            if (!backgroundWorker11.IsBusy) backgroundWorker11.RunWorkerAsync();
            if (!backgroundWorker12.IsBusy) backgroundWorker12.RunWorkerAsync();
            if (!backgroundWorker13.IsBusy) backgroundWorker13.RunWorkerAsync();
            if (!backgroundWorker14.IsBusy) backgroundWorker14.RunWorkerAsync();
            if (!backgroundWorker15.IsBusy) backgroundWorker15.RunWorkerAsync();
            if (!backgroundWorker16.IsBusy) backgroundWorker16.RunWorkerAsync();
            if (!backgroundWorker17.IsBusy) backgroundWorker17.RunWorkerAsync();
            if (!backgroundWorker18.IsBusy) backgroundWorker18.RunWorkerAsync();
            if (!backgroundWorker19.IsBusy) backgroundWorker19.RunWorkerAsync();
            if (!backgroundWorker20.IsBusy) backgroundWorker20.RunWorkerAsync();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

   







    }
}
