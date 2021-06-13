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
using System.IO;
using System.Threading;

namespace PROJECT
{
    public partial class Server : Form
    {
        private TcpListener tcpls;
        private IPEndPoint iepsv;
        private StreamReader sr;
        private StreamWriter sw;
        private NetworkStream ns;
        private Socket client;
        public Server()
        {
            InitializeComponent();
        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread lssv = new Thread(new ThreadStart(safeListen));
            lssv.Start();
        }
        public void safeListen()
        {
            try
            {

                iepsv = new IPEndPoint(IPAddress.Parse(txt_ip.Text.Trim()), int.Parse(txt_port.Text));
                tcpls = new TcpListener(iepsv);
                //1.Bắt đầu lắng nghe kết nối tại địa chỉ này
                tcpls.Start();
                listViewcommand.Items.Add(new ListViewItem("Server running on " + tcpls.LocalEndpoint));
                //Lằng nghe và chấp nhận kết nối
                while(true)
                {
                     client = tcpls.AcceptSocket();
                    listViewcommand.Items.Add(new ListViewItem("New connected from " + client.RemoteEndPoint));
                }
                //2.nhận dữ liệu từ client.
                byte[] dataReceive = new byte[1024];
                client.Receive(dataReceive);
                string textReceive = Encoding.ASCII.GetString(dataReceive);
                listViewcommand.Items.Add(new ListViewItem("Nội dung nhận được: " + textReceive));
            }
            catch
            {

            }
        }    
    }
}
