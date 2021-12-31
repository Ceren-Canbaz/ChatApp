using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace ChatApp
{
	public class Connection
	{
		public TcpClient client { get; set; }
		public StreamReader s_reader { get; set; }
		
		public StreamWriter s_writer { get; set; }
		
		public string msg { get; set; }
		public string situation { get; set; }
		public string text { get; set; }
		public string key = "12345";
		public IPAddress[] IPAddresses { get; set; }

		public IPAddress[] GetAddresses()
		{
			IPAddress[] ipAddress = Dns.GetHostAddresses(Dns.GetHostName());
			return ipAddress;
		}
     
    }
}
