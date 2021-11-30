using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Namespaces for networking.
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Networking {
    public partial class MainForm : Form {
        // Fields for the socket and network stream, since they are shared by several
        // methods.
        private Socket socConnection = null;
        private NetworkStream nsConnection = null;

        public MainForm() {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e) {
            // If the button says "Connect", then connect, otherwise disconnect.
            if (btnConnect.Text == "Connect") {
                try {
                    vConnect();
                    btnConnect.Text = "Disconnect";
                } catch (Exception ex) {
                    // Tell the user there was a problem connecting.
                    MessageBox.Show("Problem connecting: " + ex.Message);
                }
            } else {
                vDisconnect();
                btnConnect.Text = "Connect";
            }
        }

        // Connect to the IP address and port number entered in the remote text boxes.
        private void vConnect() {
            // Get the IP address and port number for the remote app.
            IPAddress ipaRemoteIP = IPAddress.Parse(txtRemoteIP.Text);
            int iRemotePort = int.Parse(txtRemotePort.Text);
            // Create the socket that we are going to use for the connection and connect
            socConnection = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socConnection.Connect(ipaRemoteIP, iRemotePort);
        }

        // Disconnect: shutdown and close the existing connection.
        private void vDisconnect() {
            
        }

        // Reset everything on the form to prepare for a new connection.
        private void vResetForm() {
            // Clear the local IP address and port number.
            txtLocalIP.Clear();
            txtLocalPort.Clear();
            // Select the remote IP address and port number and move the focus
            // to the remote IP address.
            txtRemoteIP.SelectAll();
            txtRemotePort.SelectAll();
            txtRemoteIP.Focus();
            // Disable the Send button.
            btnSend.Enabled = false;
        }

        // Read data from the socket and display in the rich
        // text box.
        private void vDisplayIncoming() {
            
        }

        // Delegate for method with no parameters.
        private delegate void DelNoParams();

        // Delegate for method with one string parameter.
        private delegate void DelOneStringParam(string strNewText);

        // Method to change the text appearing on the Connect button.
        private void vChangeButtonText(string strNewText) {
            btnConnect.Text = strNewText;
        }

        private void btnSend_Click(object sender, EventArgs e) {
            // Get the text to send, append CR-LF, and convert to array of bytes.
            // Send the bytes out over the stream.
            // Prepare for next line: select text and move focus to message text box.
            txtMessage.SelectAll();
            txtMessage.Focus();
        }

        private void miDNSLookup_Click(object sender, EventArgs e) {
            DNSLookup frmLookup = new DNSLookup();
            frmLookup.ShowDialog();
        }

        private void miQuit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
