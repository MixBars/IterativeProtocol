using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IterativeProtocol
{
    public partial class window_connection : Form
    {
        public window_connection()
        {

            InitializeComponent();
            // Получение имени компьютера.
            String host = System.Net.Dns.GetHostName();
            // Получение ip-адреса.
            System.Net.IPAddress ip = System.Net.Dns.GetHostByName(host).AddressList[0];
            // Показ адреса в label'е.
            host_ip.Text = ip.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect_to_correspondent newForm = new connect_to_correspondent();
            newForm.Show();
            this.Hide();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(host_ip.Text, TextDataFormat.UnicodeText);
        }

        private void host_ip_Click(object sender, EventArgs e)
        {

        }
    }
}
