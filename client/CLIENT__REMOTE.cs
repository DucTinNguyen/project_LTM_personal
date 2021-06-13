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

namespace client
{
    public partial class CLIENT__REMOTE : Form
    {
        private TcpClient tcpcl;
        private IPEndPoint iep;
        private NetworkStream ns;
        public CLIENT__REMOTE()
        {
            InitializeComponent();
        }

        private void btn__connect_Click(object sender, EventArgs e)
        {
            //Kết nối
            try
            {
                tcpcl = new TcpClient();
                iep = new IPEndPoint(IPAddress.Parse(txt_ip.Text.Trim()), int.Parse(txt_port.Text.Trim()));
                tcpcl.Connect(iep);
                listviewconnect.Items.Add(new ListViewItem("Connected Server"));
            }
            catch
            {
                if (txt_ip.Text.Length == 0)
                    MessageBox.Show("Vui lòng nhập địa chỉ server");
                else if (txt_ip.Text.Length == 0)
                    MessageBox.Show("Vui lòng nhập cổng của server ");
                else
                    MessageBox.Show("Server không hoạt động");
            }
           
            
        }
        /*
        public string getIplocal()
        {
            string temp = "";
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    temp = ip.ToString();
            }
            return temp;
        }
        *
        private void label2_Click(object sender, EventArgs e)
        {

        }
        */
    }
}
