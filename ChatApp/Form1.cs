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
			connection=channel.startChannel(connection);
			chatScreen.AppendText("Server started");
		}

		
		private void btnConnect_Click(object sender, EventArgs e)
		{
			
			string address = txtIp.Text;
			connection=channel.connectChannel(connection, address);
			if(connection.client.Connected)
			{
				chatScreen.AppendText("Connection is successful.");
				RunAsyncClient.RunWorkerAsync();
				RunAsyncServer.WorkerSupportsCancellation = true;
			}
			
			
		}
		private void btnSend_Click(object sender, EventArgs e)
		{
			encryption.Message = txtMessage.Text;
			RunAsyncServer.RunWorkerAsync();
			
			//while(connection.client.Connected)
			//{

			//	//if sha256
			//	//encryption= Encryption.SHA256_Encrypted(txtMessage.Text,connection.key);
			//	//connection.s_writer.WriteLine(encryption.DescryptedMessage);
			//	//this.chatScreen.Invoke(new MethodInvoker(delegate ()
			//	//{
			//	//	chatScreen.AppendText("Client: " + encryption.DescryptedMessage + "\n");
			//	//}));
			//	connection.reciever = connection.s_reader.ReadLine();
			//	this.chatScreen.Invoke(new MethodInvoker(delegate ()
			//	{
			//		chatScreen.AppendText(connection.reciever);
			//	}));
			//	encryption.Message = txtMessage.Text;
			//	if(connection.client.Connected)
			//	{
			//		connection.s_writer.WriteLine(encryption.Message);
			//		this.chatScreen.Invoke(new MethodInvoker(delegate ()
			//		{
			//			chatScreen.AppendText(encryption.Message);
			//		}));
			//	}
			//}
			
			

		}

		private void RunAsyncServer_DoWork(object sender, DoWorkEventArgs e)
		{
			if(connection.client.Connected)
			{
				connection.s_writer.WriteLine(encryption.Message);
				this.chatScreen.Invoke(new MethodInvoker(delegate ()
				{
					chatScreen.AppendText("Ben: " + encryption.Message + "\r\n");

				}));
				RunAsyncServer.CancelAsync();
			}
		}

		private void RunAsyncClient_DoWork(object sender, DoWorkEventArgs e)
		{
			while(connection.client.Connected)
			{
				connection.reciever = connection.s_reader.ReadLine();
				this.chatScreen.Invoke(new MethodInvoker(delegate ()
				{
					chatScreen.AppendText("Arkadaş: " + connection.reciever + "\r\n");
				}));
				connection.reciever = "";
			}
		}
	}
}
