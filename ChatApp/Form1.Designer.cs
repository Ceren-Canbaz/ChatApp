﻿
namespace ChatApp
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnStart = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.txtIp = new System.Windows.Forms.TextBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSend = new System.Windows.Forms.Button();
			this.chatScreen = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(180, 24);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(127, 42);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start Server";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(313, 24);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(115, 42);
			this.btnConnect.TabIndex = 1;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// txtIp
			// 
			this.txtIp.Location = new System.Drawing.Point(47, 34);
			this.txtIp.Name = "txtIp";
			this.txtIp.Size = new System.Drawing.Size(127, 22);
			this.txtIp.TabIndex = 3;
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(15, 276);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(381, 128);
			this.txtMessage.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "IP:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 241);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Message:";
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(15, 420);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(91, 42);
			this.btnSend.TabIndex = 7;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// chatScreen
			// 
			this.chatScreen.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.chatScreen.Enabled = false;
			this.chatScreen.Location = new System.Drawing.Point(7, 80);
			this.chatScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chatScreen.Multiline = true;
			this.chatScreen.Name = "chatScreen";
			this.chatScreen.ReadOnly = true;
			this.chatScreen.Size = new System.Drawing.Size(456, 122);
			this.chatScreen.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 491);
			this.Controls.Add(this.chatScreen);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.txtIp);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.btnStart);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox txtIp;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox chatScreen;
	}
}

