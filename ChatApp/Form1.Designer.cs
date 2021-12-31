
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
			this.btnSend = new System.Windows.Forms.Button();
			this.chatScreen = new System.Windows.Forms.TextBox();
			this.txtEncrypted = new System.Windows.Forms.TextBox();
			this.cb_alogo_msg2 = new System.Windows.Forms.CheckedListBox();
			this.cb_alogo_msg = new System.Windows.Forms.CheckedListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(12, 59);
			this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(101, 34);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(128, 58);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(101, 35);
			this.btnConnect.TabIndex = 1;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// txtIp
			// 
			this.txtIp.Location = new System.Drawing.Point(12, 11);
			this.txtIp.Multiline = true;
			this.txtIp.Name = "txtIp";
			this.txtIp.Size = new System.Drawing.Size(214, 26);
			this.txtIp.TabIndex = 3;
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(12, 370);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(389, 46);
			this.txtMessage.TabIndex = 4;
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(12, 435);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(133, 45);
			this.btnSend.TabIndex = 7;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// chatScreen
			// 
			this.chatScreen.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.chatScreen.Enabled = false;
			this.chatScreen.Location = new System.Drawing.Point(12, 120);
			this.chatScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chatScreen.Multiline = true;
			this.chatScreen.Name = "chatScreen";
			this.chatScreen.ReadOnly = true;
			this.chatScreen.Size = new System.Drawing.Size(389, 122);
			this.chatScreen.TabIndex = 8;
			// 
			// txtEncrypted
			// 
			this.txtEncrypted.Location = new System.Drawing.Point(12, 290);
			this.txtEncrypted.Multiline = true;
			this.txtEncrypted.Name = "txtEncrypted";
			this.txtEncrypted.Size = new System.Drawing.Size(389, 46);
			this.txtEncrypted.TabIndex = 10;
			// 
			// cb_alogo_msg2
			// 
			this.cb_alogo_msg2.BackColor = System.Drawing.SystemColors.Control;
			this.cb_alogo_msg2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.cb_alogo_msg2.CheckOnClick = true;
			this.cb_alogo_msg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_alogo_msg2.FormattingEnabled = true;
			this.cb_alogo_msg2.Items.AddRange(new object[] {
            "SHA-256",
            "SPN-16"});
			this.cb_alogo_msg2.Location = new System.Drawing.Point(305, 59);
			this.cb_alogo_msg2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cb_alogo_msg2.Name = "cb_alogo_msg2";
			this.cb_alogo_msg2.Size = new System.Drawing.Size(100, 44);
			this.cb_alogo_msg2.TabIndex = 16;
			// 
			// cb_alogo_msg
			// 
			this.cb_alogo_msg.BackColor = System.Drawing.SystemColors.Control;
			this.cb_alogo_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.cb_alogo_msg.CheckOnClick = true;
			this.cb_alogo_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_alogo_msg.FormattingEnabled = true;
			this.cb_alogo_msg.Items.AddRange(new object[] {
            "SHA-256",
            "SPN-16"});
			this.cb_alogo_msg.Location = new System.Drawing.Point(305, 11);
			this.cb_alogo_msg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cb_alogo_msg.Name = "cb_alogo_msg";
			this.cb_alogo_msg.Size = new System.Drawing.Size(104, 44);
			this.cb_alogo_msg.TabIndex = 15;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(268, 435);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(133, 45);
			this.button1.TabIndex = 17;
			this.button1.Text = "Test";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(232, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 17);
			this.label1.TabIndex = 18;
			this.label1.Text = "Server";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(232, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 17);
			this.label2.TabIndex = 19;
			this.label2.Text = "Client";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 491);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cb_alogo_msg2);
			this.Controls.Add(this.cb_alogo_msg);
			this.Controls.Add(this.txtEncrypted);
			this.Controls.Add(this.chatScreen);
			this.Controls.Add(this.btnSend);
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
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox chatScreen;
		private System.Windows.Forms.TextBox txtEncrypted;
		private System.Windows.Forms.CheckedListBox cb_alogo_msg2;
		private System.Windows.Forms.CheckedListBox cb_alogo_msg;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

