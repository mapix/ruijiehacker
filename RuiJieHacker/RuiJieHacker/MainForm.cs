/************************************************************************/
/*  Project Name : RuiJieHacker                                         */
/*  Author: luoweifeng1989                                              */
/*  Date: 2011-4-22                                                     */
/*  All Rights Reserved.                                                */
/************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Net;
using System.Net.NetworkInformation;
using System.Collections;
using System.Management;


namespace RuiJieHacker
{
    /************************************************************************/
    /*  RuiJieHacker主窗口程序                                              */
    /************************************************************************/
    public partial class MainForm : Form
    {

        /************************************************************************/
        /*                                                                      */
        /************************************************************************/
        private DoHacker doHacker = new DoHacker();


        /************************************************************************/
        /*  Form构造函数，用来初始化窗口组件                                    */
        /************************************************************************/
        public MainForm()
        {
            InitializeComponent();
        }

        /************************************************************************/
        /*                                                                      */
        /************************************************************************/
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
 
        


        /************************************************************************/
        /*                                                                      */
        /************************************************************************/
        private void SearchButton_Click(object sender, EventArgs e)
        {
                EnumComputers(domainTextBox.Text.ToString());
        }


        /************************************************************************/
        /*  枚举局域网内可用机器                                                */
        /************************************************************************/
        private void EnumComputers(String gatewayIPAddress)
        {
            doHacker.usableIpMacPairs.Clear();
            String domain = null;
            try{
                 domain =  gatewayIPAddress.Substring(0, gatewayIPAddress.LastIndexOf('.'));
            }catch(Exception )
            {
                MessageBox.Show("请输入正确的网关地址（e.g. 172.29.132.1）");
                return;
            }
            try
            {
                for (int i = 2; i <  255; i++)
                {
                    Ping myPing;
                    myPing = new Ping();
                    myPing.PingCompleted += new PingCompletedEventHandler(myPing_PingCompleted);
                    string pingIP = domain + "." + i.ToString();
                    myPing.SendAsync(pingIP, 10000, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /************************************************************************/
        /*  ICMP报文完成事件处理，在此函数中生成可用IP/Mac pairs                */
        /************************************************************************/
        private void myPing_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            if (e.Reply.Status == IPStatus.Success)
            {
               
                this.doHacker.usableIpMacPairs.Add(e.Reply.Address.ToString(), NetWorkHelper.GetMacAddress(e.Reply.Address.ToString()));
                ArrayList newArray = new ArrayList(doHacker.usableIpMacPairs.Values);
                this.macListBox.DataSource = newArray;
            }
        }

        /************************************************************************/
        /*                                                                      */
        /************************************************************************/
        private void hackerButton_Click(object sender, EventArgs e)
        {
            this.doHacker.execute(macListBox.SelectedValue.ToString());
        }

        /************************************************************************/
        /* 为本机生成一个唯一MAC                                                */
        /************************************************************************/
        private void generateButton_Click(object sender, EventArgs e)
        {

            String mac = Guid.NewGuid().ToString();
            if(mac.Contains('-') ){
               String[] tmp  = mac.Split('-');
               mac = "";
               foreach (String subTmp in tmp)
               {
                   mac += subTmp;
               }
           }
            mac = mac.Substring(0, 12).ToUpper();
             LocalMacChanger.setLocalMacAddress( mac);
             MessageBox.Show("Ok,Now to restart your network with your self!");

        }

        /************************************************************************/
        /*                                                                      */
        /************************************************************************/
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /************************************************************************/
        /*                                                                      */
        /************************************************************************/
        private void SetMacButton_Click(object sender, EventArgs e)
        {
           String mac = macTextBox.Text.ToString().Trim();
           if(mac.Contains('-') ){
               String[] tmp  = mac.Split('-');
               mac = "";
               foreach (String subTmp in tmp)
               {
                   mac += subTmp;
               }
           }
           if (mac.Length != 12)
           {
               MessageBox.Show("Please Input The Right Mac Addr!");
               return;
           }
           LocalMacChanger.setLocalMacAddress(mac.ToUpper());
           MessageBox.Show("Ok,Now to restart your network with your self!");
        }
    }
}
