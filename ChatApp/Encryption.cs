using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
	public class Encryption
	{
		public  string Message { get; set; }
		public  string Algorithm { get; set; }
		public  string EncryptedMessage { get; set; }
		public  string DescryptedMessage { get; set; }
		public  bool Situation { get; set; }











		public static Encryption SHA256_Encrypted(string message, string pass)
		{
			Encryption msg = new Encryption();

			//Enccryption
			byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(message);
			byte[] passwordBytes = Encoding.UTF8.GetBytes(pass);

		
			passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

			byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

			string encryptedResult = Convert.ToBase64String(bytesEncrypted);
			msg.EncryptedMessage = encryptedResult;
			//descryption
			byte[] bytesToBeDecrypted = Convert.FromBase64String(encryptedResult);
			byte[] passwordBytesdecrypt = Encoding.UTF8.GetBytes(pass);
			passwordBytes = SHA256.Create().ComputeHash(passwordBytesdecrypt);

			byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

			msg.DescryptedMessage = Encoding.UTF8.GetString(bytesDecrypted);
			return msg;

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


		public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
		{
			byte[] decryptedBytes = null;

			// Set your salt here, change it to meet your flavor:
			// The salt bytes must be at least 8 bytes.
			byte[] saltBytes = new byte[] { 2, 1, 7, 3, 6, 4, 8, 5 };

			using (MemoryStream ms = new MemoryStream())
			{
				using (RijndaelManaged AES = new RijndaelManaged())
				{
					AES.KeySize = 256;
					AES.BlockSize = 128;

					var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
					AES.Key = key.GetBytes(AES.KeySize / 8);
					AES.IV = key.GetBytes(AES.BlockSize / 8);

					AES.Mode = CipherMode.CBC;

					using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
					{
						cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
						cs.Close();
					}
					decryptedBytes = ms.ToArray();
				}
			}

			return decryptedBytes;
		}
		public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
		{
			byte[] encryptedBytes = null;

			// Set your salt here, change it to meet your flavor:
			// The salt bytes must be at least 8 bytes.
			byte[] saltBytes = new byte[] { 2, 1, 7, 3, 6, 4, 8, 5 };

			using (MemoryStream ms = new MemoryStream())
			{
				using (RijndaelManaged AES = new RijndaelManaged())
				{
					AES.KeySize = 256;
					AES.BlockSize = 128;

					var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
					AES.Key = key.GetBytes(AES.KeySize / 8);
					AES.IV = key.GetBytes(AES.BlockSize / 8);

					AES.Mode = CipherMode.CBC;

					using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
					{
						cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
						cs.Close();
					}
					encryptedBytes = ms.ToArray();
				}
			}

			return encryptedBytes;
		}

		public static string SHA_256_Encrypting(string deger)
		{
			SHA256 sha = SHA256.Create();
			byte[] degerBytes = Encoding.UTF8.GetBytes(deger);
			byte[] shaBytes = sha.ComputeHash(degerBytes);
			return HashToByte_256(shaBytes);
		}

		public static string HashToByte_256(byte[] hash)
		{
			StringBuilder result = new StringBuilder();
			foreach (byte item in hash)
			{
				result.Append(item.ToString("x2"));

			}

			return result.ToString();
		}
		public static Encryption SPN_Encryp(Encryption enc,Connection cn)
		{
			int j = 0;
			string mesaj = "";
			string s1 = "";
			string s2 = "";
			string s3 = "";
			string s4 = "";
			for (int i = 0; i < enc.Message.Length; i++)
			{
				enc.EncryptedMessage += Convert.ToChar(Convert.ToInt32(enc.Message[i] + Convert.ToInt32(cn.key[j])) % 351);

				if (j == cn.key.Length)
					j = 0;


				if (Convert.ToInt32(enc.Message[i]) == Convert.ToInt32(cn.key[j]))
				{
					mesaj += 0;
				}
				else
				{
					mesaj += 1;
				}
				j += 1;

			}
			for (int k = 0; k < 16; k++)
			{
				if (k < 4)
				{
					s1 += mesaj[k];
				}
				if ((k >= 4) && (k < 8))
				{
					s2 += mesaj[k];
				}
				if ((k >= 8) && (k < 12))
				{
					s3 += mesaj[k];
				}
				if (k >= 12)
				{
					s4 += mesaj[k];
				}
			}
			
			return enc;
		}
	}
}
