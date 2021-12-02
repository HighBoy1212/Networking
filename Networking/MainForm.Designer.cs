namespace Networking {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gbxConnection = new System.Windows.Forms.GroupBox();
            this.lblLocalPort = new System.Windows.Forms.Label();
            this.lblLocalIP = new System.Windows.Forms.Label();
            this.txtLocalPort = new System.Windows.Forms.TextBox();
            this.txtLocalIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtRemotePort = new System.Windows.Forms.TextBox();
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            this.lblRemotePort = new System.Windows.Forms.Label();
            this.lblRemoteIP = new System.Windows.Forms.Label();
            this.gbxConversation = new System.Windows.Forms.GroupBox();
            this.rtbConversation = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miDNSLookup = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxConnection.SuspendLayout();
            this.gbxConversation.SuspendLayout();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxConnection
            // 
            this.gbxConnection.Controls.Add(this.lblLocalPort);
            this.gbxConnection.Controls.Add(this.lblLocalIP);
            this.gbxConnection.Controls.Add(this.txtLocalPort);
            this.gbxConnection.Controls.Add(this.txtLocalIP);
            this.gbxConnection.Controls.Add(this.btnConnect);
            this.gbxConnection.Controls.Add(this.txtRemotePort);
            this.gbxConnection.Controls.Add(this.txtRemoteIP);
            this.gbxConnection.Controls.Add(this.lblRemotePort);
            this.gbxConnection.Controls.Add(this.lblRemoteIP);
            this.gbxConnection.Location = new System.Drawing.Point(12, 27);
            this.gbxConnection.Name = "gbxConnection";
            this.gbxConnection.Size = new System.Drawing.Size(260, 156);
            this.gbxConnection.TabIndex = 0;
            this.gbxConnection.TabStop = false;
            this.gbxConnection.Text = "Connection";
            // 
            // lblLocalPort
            // 
            this.lblLocalPort.AutoSize = true;
            this.lblLocalPort.Location = new System.Drawing.Point(6, 130);
            this.lblLocalPort.Name = "lblLocalPort";
            this.lblLocalPort.Size = new System.Drawing.Size(58, 13);
            this.lblLocalPort.TabIndex = 8;
            this.lblLocalPort.Text = "Local Port:";
            // 
            // lblLocalIP
            // 
            this.lblLocalIP.AutoSize = true;
            this.lblLocalIP.Location = new System.Drawing.Point(6, 104);
            this.lblLocalIP.Name = "lblLocalIP";
            this.lblLocalIP.Size = new System.Drawing.Size(49, 13);
            this.lblLocalIP.TabIndex = 7;
            this.lblLocalIP.Text = "Local IP:";
            // 
            // txtLocalPort
            // 
            this.txtLocalPort.Location = new System.Drawing.Point(81, 127);
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.ReadOnly = true;
            this.txtLocalPort.Size = new System.Drawing.Size(100, 20);
            this.txtLocalPort.TabIndex = 6;
            // 
            // txtLocalIP
            // 
            this.txtLocalIP.Location = new System.Drawing.Point(81, 101);
            this.txtLocalIP.Name = "txtLocalIP";
            this.txtLocalIP.ReadOnly = true;
            this.txtLocalIP.Size = new System.Drawing.Size(100, 20);
            this.txtLocalIP.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(93, 71);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Location = new System.Drawing.Point(81, 45);
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.Size = new System.Drawing.Size(100, 20);
            this.txtRemotePort.TabIndex = 3;
            // 
            // txtRemoteIP
            // 
            this.txtRemoteIP.Location = new System.Drawing.Point(81, 19);
            this.txtRemoteIP.Name = "txtRemoteIP";
            this.txtRemoteIP.Size = new System.Drawing.Size(100, 20);
            this.txtRemoteIP.TabIndex = 2;
            // 
            // lblRemotePort
            // 
            this.lblRemotePort.AutoSize = true;
            this.lblRemotePort.Location = new System.Drawing.Point(6, 48);
            this.lblRemotePort.Name = "lblRemotePort";
            this.lblRemotePort.Size = new System.Drawing.Size(69, 13);
            this.lblRemotePort.TabIndex = 1;
            this.lblRemotePort.Text = "Remote Port:";
            // 
            // lblRemoteIP
            // 
            this.lblRemoteIP.AutoSize = true;
            this.lblRemoteIP.Location = new System.Drawing.Point(6, 22);
            this.lblRemoteIP.Name = "lblRemoteIP";
            this.lblRemoteIP.Size = new System.Drawing.Size(60, 13);
            this.lblRemoteIP.TabIndex = 0;
            this.lblRemoteIP.Text = "Remote IP:";
            // 
            // gbxConversation
            // 
            this.gbxConversation.Controls.Add(this.rtbConversation);
            this.gbxConversation.Controls.Add(this.btnSend);
            this.gbxConversation.Controls.Add(this.txtMessage);
            this.gbxConversation.Location = new System.Drawing.Point(12, 189);
            this.gbxConversation.Name = "gbxConversation";
            this.gbxConversation.Size = new System.Drawing.Size(260, 173);
            this.gbxConversation.TabIndex = 1;
            this.gbxConversation.TabStop = false;
            this.gbxConversation.Text = "Conversation";
            // 
            // rtbConversation
            // 
            this.rtbConversation.Location = new System.Drawing.Point(6, 20);
            this.rtbConversation.Name = "rtbConversation";
            this.rtbConversation.ReadOnly = true;
            this.rtbConversation.Size = new System.Drawing.Size(248, 118);
            this.rtbConversation.TabIndex = 2;
            this.rtbConversation.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(204, 144);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(50, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(6, 146);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(192, 20);
            this.txtMessage.TabIndex = 0;
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(284, 24);
            this.msMainMenu.TabIndex = 2;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDNSLookup,
            this.miQuit});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // miDNSLookup
            // 
            this.miDNSLookup.Name = "miDNSLookup";
            this.miDNSLookup.Size = new System.Drawing.Size(140, 22);
            this.miDNSLookup.Text = "DNS Lookup";
            this.miDNSLookup.Click += new System.EventHandler(this.miDNSLookup_Click);
            // 
            // miQuit
            // 
            this.miQuit.Name = "miQuit";
            this.miQuit.Size = new System.Drawing.Size(140, 22);
            this.miQuit.Text = "Quit";
            this.miQuit.Click += new System.EventHandler(this.miQuit_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 374);
            this.Controls.Add(this.gbxConversation);
            this.Controls.Add(this.gbxConnection);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "MainForm";
            this.Text = "Networking";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbxConnection.ResumeLayout(false);
            this.gbxConnection.PerformLayout();
            this.gbxConversation.ResumeLayout(false);
            this.gbxConversation.PerformLayout();
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxConnection;
        private System.Windows.Forms.Label lblLocalPort;
        private System.Windows.Forms.Label lblLocalIP;
        private System.Windows.Forms.TextBox txtLocalPort;
        private System.Windows.Forms.TextBox txtLocalIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtRemotePort;
        private System.Windows.Forms.TextBox txtRemoteIP;
        private System.Windows.Forms.Label lblRemotePort;
        private System.Windows.Forms.Label lblRemoteIP;
        private System.Windows.Forms.GroupBox gbxConversation;
        private System.Windows.Forms.RichTextBox rtbConversation;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miDNSLookup;
        private System.Windows.Forms.ToolStripMenuItem miQuit;
    }
}

