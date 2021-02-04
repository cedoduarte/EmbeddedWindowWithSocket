using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace EmbeddedWindow
{
    /// <summary>
    /// form to embedd in Qt widgets application
    /// </summary>
    public partial class Form1 : Form
    {
        private TcpClient clientSocket = null;
        private Thread thread = null;

        /// <summary>
        /// constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            thread = makeThread();
            clientSocket = makeClientSocket();
            fromQt_textBox2.ReadOnly = true;
        }

        /// <summary>
        /// sends data from here "C#" to "Qt"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendToQt_button1_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(sendToQt_textBox1.Text);
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            ActiveControl = null;
        }

        /// <summary>
        /// makes the thread to keep listening for incomming data from Qt
        /// </summary>
        /// <returns></returns>
        private Thread makeThread()
        {
            Thread thread = new Thread(new ThreadStart(ThreadProc));
            thread.Start();
            return thread;
        }

        /// <summary>
        /// makes the client tcp socket to connect with the Qt server application
        /// </summary>
        /// <returns></returns>
        private TcpClient makeClientSocket()
        {
            TcpClient socket = new TcpClient();
            socket.Connect("127.0.0.1", 12345);
            return socket;
        }

        /// <summary>
        /// procedure to execute within the thread
        /// </summary>
        private void ThreadProc()
        {
            while (true)
            {
                if (clientSocket != null)
                {
                    if (clientSocket.Connected)
                    {
                        if (clientSocket.Available > 0)
                        {
                            NetworkStream serverStream = clientSocket.GetStream();
                            byte[] inStream = new byte[10025];
                            serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                            string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                            fromQt_textBox2.Text = returndata;
                        }
                    }
                }
                Thread.Sleep(100);
            }
        }
    }
}
