using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
	public partial class Form1 : Form
	{
		
		Connection connection = new Connection();
		Channel channel = new Channel();
		Encryption encryption = new Encryption();
		public Form1()
		{
		
			InitializeComponent();
			//ip adresimizi connection sınıfımızın içindeki Adres çağırma 
			//fonksiyonununu çağırarak alıyoruz
			//multi thread için 
			connection.IPAddresses = connection.GetAddresses();
			foreach (IPAddress adress in connection.IPAddresses)
			{
				if (adress.AddressFamily == AddressFamily.InterNetwork)
				{
					txtIp.Text = adress.ToString();
				}
			}

		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			channel.startChannel(connection);
			chatScreen.AppendText("Server started");
		}

		
		private void btnConnect_Click(object sender, EventArgs e)
		{
			string address = txtIp.Text;
			channel.connectChannel(connection, address);
			chatScreen.AppendText("Connection is successful.");
		}
		private void btnSend_Click(object sender, EventArgs e)
		{
			
		}
	}
}
