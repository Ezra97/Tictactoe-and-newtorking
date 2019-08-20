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

namespace tictactoe_networking
{
    public partial class Form1 : Form
    {
        IPAddress myipaddress;
        TcpClient connection;
        StreamReader linein;
        StreamWriter lineout;
        bool misitmyturn;
        string mysign;

        public Form1()
        {
            InitializeComponent();
        }

        private void onload(object sender, EventArgs e)
        {
            foreach (IPAddress ip in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    myipaddress = ip;
            }
            label_host.Text = myipaddress.ToString();
        }

        private void onconnect(object sender, EventArgs e)
        {
            connection = new TcpClient();
            connection.Connect(IPAddress.Parse(textBox_connect.Text), 6000);
            linein = new StreamReader(connection.GetStream());
            lineout = new StreamWriter(connection.GetStream());
            misitmyturn = true;
            mysign = "X";
        }

        private void onhost(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(myipaddress,6000);
            listener.Start();
            connection = listener.AcceptTcpClient();
            linein = new StreamReader(connection.GetStream());
            lineout = new StreamWriter(connection.GetStream());
            misitmyturn = false;
            mysign = "O";
        }

        private void whichwasclicked(object sender, EventArgs e)
        {
            //dont allow make out of turn selection
            if (!misitmyturn)
                return;

            Button btn = ((Button)sender);
            int row = int.Parse(btn.Name.Split(new[] { '_' })[1]);
            int col = int.Parse(btn.Name.Split(new[] { '_' })[2]);

            //dont mark if already clicked on
            if (!string.IsNullOrEmpty(btn.Text))
            {
                btn.Text = mysign;
                misitmyturn = false;
                lineout.Write(row);
                lineout.Write(col);
            }
        }

        private void ongetdata(object sender, EventArgs e)
        {
            if (connection.GetStream().DataAvailable && !misitmyturn)
            {
                int row = int.Parse(linein.ReadLine());
                int col = int.Parse(linein.ReadLine());
                if (mysign == "X")
                    Controls["button_" + row + "_" + col].Text = "O";
                else
                    Controls["button_" + row + "_" + col].Text = "X";

                misitmyturn = true;
            }
        }
    }
}
