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

namespace pc_remote
{
    public partial class pc_remote : Form
    {
        private TcpClient tcpcl;
        private IPEndPoint iep;
        private NetworkStream ns;
        private StreamReader sr;
        private StreamWriter sw;
        public pc_remote()
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
                //tạo luồng để đọc dữ liệu
                ns = tcpcl.GetStream();
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

        private void btn_send_Click(object sender, EventArgs e)
        {
            string textToSend = txt_linkfile.Text;
            try
            {
                byte[] dataSend = System.Text.Encoding.ASCII.GetBytes(textToSend);
                ns.Write(dataSend, 0, dataSend.Length);
                listviewconnect.Items.Add(new ListViewItem("Sent to server"));
            }
            catch
            {
                if (txt_linkfile.Text.Length == 0)
                    MessageBox.Show("Vui lòng nhập địa chỉ đường dẫn ");
            }
        }
    }
}
