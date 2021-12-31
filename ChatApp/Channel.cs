using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
	public class Channel
	{
		
		public Connection startChannel(Connection c)
		{
			try
			{
				//local ip ve baglanti noktasi ile girismleri dinleyen yeni bir sınıf baslatilir.
				TcpListener tcpListener = new TcpListener(IPAddress.Any, 10);
				tcpListener.Start(); //baglanti istekleri dinlenir
				c.client = tcpListener.AcceptTcpClient();//baglanti istegi kabul edilir
				c.s_reader = new StreamReader(c.client.GetStream());//veri okur
				c.s_writer = new StreamWriter(c.client.GetStream());//verileri yazar
				c.s_writer.AutoFlush = true;
				
			}
			catch
			{
				MessageBox.Show("Failed Connection");
			}
			return c;
		}


		public Connection connectChannel(Connection c, string address)
		{
			
			try
			{
				c.client = new TcpClient();
				IPEndPoint Ip = new IPEndPoint(IPAddress.Parse(address), 10);
				c.client.Connect(Ip);
				if (c.client.Connected)
				{
					c.situation = "Connection";
					c.s_reader = new StreamReader(c.client.GetStream());
					c.s_writer = new StreamWriter(c.client.GetStream());
					c.s_writer.AutoFlush = true;
				}
			}
			catch
			{
				MessageBox.Show("Failed Connection");
			}
			return c;
		}
		public Encryption readChannel(Connection cn, Encryption encr)
		{

			if(encr.Algorithm=="sha256")
			{
				encr = Encryption.SHA256_Encrypted(encr.Message,cn.key); 
			}
			else //spn 
			{
				encr = Encryption.SPN_Encryp(encr, cn);
			}
			return encr;
		}
		public Encryption sendChannel(Connection cn, Encryption encr)
		{

			if (encr.Algorithm == "sha256")
			{
				encr = Encryption.SHA256_Encrypted(encr.Message, cn.key);
			}
			else //spn
			{
				encr = Encryption.SPN_Encryp(encr,cn);
			
			}
			return encr;
		}

	}


}


