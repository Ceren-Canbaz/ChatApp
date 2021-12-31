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
			try { 
				connection=channel.startChannel(connection); 
				chatScreen.AppendText("Connected\r\n");
			}
			catch
			{
				MessageBox.Show("Failed Connection");
			}
		}

		
		private void btnConnect_Click(object sender, EventArgs e)
		{
			try
			{
				
				connection = channel.connectChannel(connection, txtIp.Text);
				connection.msg=connection.s_reader.ReadLine();
				chatScreen.AppendText(connection.situation);
				while(connection.client.Connected)
				{
					chatScreen.AppendText(connection.situation);
					encryption=channel.readChannel(connection,encryption);
				}
			
			}
			catch
			{
				MessageBox.Show("Failed Connection");
			}			
			
		}
		public void btnSend_Click(object sender, EventArgs e)
		{
			encryption.Message = txtMessage.Text;

			if (connection.client.Connected)
			{
					encryption = channel.sendChannel(connection, encryption);
					connection.s_writer.WriteLine(encryption.DescryptedMessage);
					this.chatScreen.Invoke(new MethodInvoker(delegate ()
					{
						chatScreen.AppendText("Send: " + encryption.DescryptedMessage + "\n");

					}));


				
				

			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			encryption.Message = txtMessage.Text;

			if (connection.client.Connected)
			{

				encryption = Encryption.SHA256_Encrypted(txtMessage.Text, connection.key);
				txtEncrypted.Text = Encryption.SHA_256_Encrypting(txtMessage.Text);
				connection.s_writer.WriteLine(encryption.DescryptedMessage);

			}
		}
	}
	
}
