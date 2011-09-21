using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace IpSwitcher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            if (ipListBox.Items.Count != 0)
            {
                String ipAddress = ipListBox.SelectedValue.ToString();
                MessageBox.Show("Ip changing to " + ipAddress);
                LocalIpChanger.setLocalIpAddressHelper("", ipAddress, "255.255.255.0", ipAddress.Substring(0, ipAddress.LastIndexOf('.')) + ".1", "8.8.8.8");
                NetWorkHelper.restartEthernet();
            }
            doRefresh();
        }


        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Use!!!");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            doRefresh();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            doRefresh();
        }
        private void doRefresh()
        {
            ArrayList ips = ReadIni.ReadAllIps();
            if (ips.Count != 0)
                ipListBox.DataSource = ips;
            else
            {
                MessageBox.Show("Please edit config file 'IpSwitcher.ini' first ,after that do Refresh !!!");
                System.Diagnostics.Process pro = new System.Diagnostics.Process();
                pro.StartInfo.FileName = "notepad.exe ";
                pro.StartInfo.Arguments = "IpSwitcher.ini";
                pro.Start();
            }
            currentIplabel.Text = "Current IpAddr:" + LocalIpChanger.getLocalIpAddress();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process pro = new System.Diagnostics.Process();
            pro.StartInfo.FileName = "notepad.exe ";
            pro.StartInfo.Arguments = "IpSwitcher.ini";
            pro.Start();
        }
    }
}
