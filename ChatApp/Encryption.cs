using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
	public class Encryption
	{
		public string Message { get; set; }
		public string Agorithm { get; set; }
		public string EncryptedMessage { get; set; }

		public static string SHA256_Encrypting(string message)
		{
			SHA256 sha = SHA256.Create();
			byte[] degerBytes = Encoding.UTF8.GetBytes(message);
			byte[] shaBytes = sha.ComputeHash(degerBytes);
			return HashToByte(shaBytes);
		}

		public static string HashToByte(byte[] shaBytes)
		{
			StringBuilder result = new StringBuilder();
			foreach (byte item in shaBytes)
			{
				result.Append(item.ToString("x2"));

			}

			return result.ToString();
		}
	}
}
