using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        Socket client;
        IPEndPoint ipServer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSendClient_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes(txtboxMessageClient.Text);
            Listbox.Items.Add("Client " + txtboxMessageClient.Text);
            txtboxMessageClient.Text = "";
            client.Send(data);
            data = new byte[1024];
            client.Receive(data);
            string text = Encoding.ASCII.GetString(data);
            Listbox.Items.Add("Server: " + text);
        }

        private void BtnConn_Click(object sender, EventArgs e)
        {
            ipServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(ipServer);
        }

        private void txtboxMessageClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxMessageClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BtnSendClient.PerformClick();
        }
    }
}
