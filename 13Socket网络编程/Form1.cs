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

namespace _13Socket网络编程
{
    /// <summary>
    /// 
    /// Socket 英文孔或者插座的意思
    /// 
    /// 计算机中进程的通信机制，套接字描述IP地址和端口号
    /// 
    /// 服务器（各种应用程序进程，比如数据库远程连接）
    /// 
    /// 客户端 -->连接服务器
    /// 
    /// 现在服务器-->客户端 通信 那么就需要知道服务器的IP地址，同时还要知道服务器服务的端口号：比如IIS 网站端口号
    /// 
    /// 过程：服务器进程开启：IP+端口号
    /// 
    /// 然后应用程序进行 三次握手连接认证，最后进行通讯。
    /// 
    /// 服务器和客户端进行交换数据
    /// 
    /// 服务器：Ip地址，客户端，某一个应用地址，应用程序所占用的端口号
    /// 
    /// 客户端：准确的连接到应用程序；
    /// 
    /// 协议：TCP/UDP协议，TCP比较安全稳定，不会丢失数据
    /// 
    /// TCP：三次握手 TCP要求必须有服务器（三次握手）
    /// 
    /// 1.你有空吗？     
    /// 
    /// 2.我有空！
    /// 
    /// 3.我知道你有空了
    /// 
    /// TCP好处：安全稳定，效率低 三次握手占用，时间慢
    /// 
    /// UDP：快速效率高，不稳定，容易发生 数据丢失
    /// 
    /// 客户端发消息：不管服务器忙不忙，全部发送，消息不验证，不管服务器忙不忙，直接数据包发送过去，单向的直传，服务器没时间处理，就出现数据丢失
    /// 
    /// 两个各有优缺点
    /// 
    /// 
    /// Socket通信的基本流程
    /// 
    /// 服务器：
    /// 
    /// 1.创建Socket监听 并绑定了端口号
    /// 
    /// 2.设置监听队列 Listen(10) 默认监听队列（服务器在一个时间点内所能接纳的客户端是有限的）
    /// 
    /// 3.等待客户端的连接
    /// 
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {


            //开始监听的时候，在服务器创建一个负责监听的IP地址跟端口号的Socket


            Socket socketwath = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

     
            IPAddress ip = IPAddress.Parse(txtIp.Text);

            //创建端口对象

            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));

            socketwath.Bind(point);

            //一个时间段内 只能接纳10个客户端

            //厕所蹲坑 坑位+加便池=总容量 但是我设置厕所只有五个人能蹲坑
            
            //第十一个人来了排队

            //Socket监听队列

            ShowMsg("监听成功！");

            socketwath.Listen(10);

            Thread thread = new Thread(Listent);

            thread.IsBackground = true;

            thread.Start(socketwath);
         

            //IPEndPoint ip = IPAddress.Any;
        }

        /// <summary>
        /// 
        /// 等待客户端连接
        /// 
        /// 并创建与之通信的Socket
        /// 
        /// </summary>

        void Listent(object sw)
        {


            Socket socketwath = (Socket)sw;


            //Accept 等待客户端连接

            //Accept 来接受客户端的请求 并为之创建一个socket

            //返回的Socket 是负责通信的Socket


            //服务器分配一个Socket给 客户端

            //Accept 等待连接 一直持续性的连接 这个时候开启一个新的线程

            //只能一个客户端 写在一个循环里面

            //统计在线人数 使用的是 集合类型的 变量 存储数据让后进行统计

            //不同类型的文件怎么办？？

            //自己制作协议 “自定义协议”

            //把传输的字节数组之前 加上相应的二进制字符（这样可以代表不同的数据类型 比如：文件，图片，消息等等）

            //然后把相应的文件存储为相应的文件或者消息

            while(true)
            {


                try
                {

                    //服务器分配一个Socket给 客户端

                    Socket socksend = socketwath.Accept();

                    //socketwath.

                    //拿到远程服务器的IP和端口号

                    ShowMsg(socksend.RemoteEndPoint.ToString() + ":" + "连接成功！");

                    //客户端连接成功后 服务器应该接受客户端发来的消息

                    Thread thread = new Thread(ReciveData);

                    thread.IsBackground = true;

                    thread.Start(socksend);


                }
                catch
                {
 
                }

              

            
     

            }

          
 
        }


        /// <summary>
        /// 
        /// 关闭后 死循环
        /// 
        /// 接收不到数据后 跳出循环
        /// 
        /// </summary>
        /// <param name="sw"></param>


        Socket socksends;

        private void ReciveData(object sw)
        {


            socksends = (Socket)sw;

            byte[] bufffer = new byte[1024 * 1024 * 2];

            while(true)
            {

                try
                {

                    int realByte = socksends.Receive(bufffer);

                    if (realByte == 0)
                    {
                        break;
                    }

                    string gedata = Encoding.UTF8.GetString(bufffer, 0, realByte);

                    ShowMsg(socksends.RemoteEndPoint.ToString() + ":" + gedata);

                }
                catch
                {
 
                }

            
            }

            
        }


        private void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }


        /// <summary>
        /// 
        /// 服务端给客户端发送消息
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(textBox1.Text);

            socksends.Send(buffer);

        }



    }
}
