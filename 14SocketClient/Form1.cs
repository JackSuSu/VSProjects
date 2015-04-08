using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _14SocketClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Socket socketSende = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {

                IPAddress ip = IPAddress.Parse(textBox1.Text);

                IPEndPoint ipendpoint = new IPEndPoint(ip, Convert.ToInt32(textBox2.Text));

                socketSende.Connect(ipendpoint);

                ShowMsg("连接成功！");

                Thread thread = new Thread(Revice);

                thread.IsBackground = true;

                thread.Start();

            }
            catch
            { 
            }

           

        }

        void ShowMsg(string str)
        {
            textBox3.AppendText(str + "\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(textBox4.Text.Trim());

                socketSende.Send(buffer);

                textBox4.Text = string.Empty;

            }
            catch
            {
 
            }

           
        }



        void Revice()
        {

            while (true)
            {

                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 4];

                    int realdata = socketSende.Receive(buffer);

                    if (realdata == 0)
                    {
                        break;
                    }


                    string getdata = Encoding.UTF8.GetString(buffer, 0, realdata);

                    ShowMsg(socketSende.RemoteEndPoint.ToString() + ":" + getdata);
                }
                catch
                {
 
                }

                

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

    }
}
