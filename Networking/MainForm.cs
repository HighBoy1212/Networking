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
using System.Threading;

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
            // Display the local IP address and port number for this connection]
            IPEndPoint ipeLocalEndPoint = (IPEndPoint)socConnection.LocalEndPoint;
            IPAddress ipaLocalIP = ipeLocalEndPoint.Address;
            int iLocalPort = ipeLocalEndPoint.Port;
            (txtLocalIP.Text, txtLocalPort.Text) = (ipaLocalIP.ToString(), iLocalPort.ToString());
            // Start receiving and displaying text from the remote application
            // Get a NetworkStream associated with the socket, so we can use it to send/receive data
            nsConnection = new NetworkStream(socConnection);
            // Run a seperate task to execute vDisplayIncoming()
            Task.Run(() => vDisplayIncoming());
            // Enable the send button so we can start sending text to the remote app
            btnSend.Enabled = true;
        }

        // Disconnect: shutdown and close the existing connection.
        private void vDisconnect() {
            // Only disconnect if we really have a connection socket
            if (socConnection != null)
            {
                // Shut down connection, close the socket, and dispose of the network stream and socket
                socConnection.Shutdown(SocketShutdown.Both);
                nsConnection.Close();
                socConnection.Close();
                nsConnection.Dispose();
                socConnection.Dispose();
                nsConnection = null;
                socConnection = null;
            }
            // Reset from to prepare for a new connection
            vResetForm();
        }

        // Reset everything on the form to prepare for a new connection.
        private void vResetForm() {
            // Clear the message, local IP address and port number.
            txtLocalIP.Clear();
            txtLocalPort.Clear();
            txtMessage.Clear();
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
            // Set up byte array to receive data and decoder for UTF-8
            byte[] byIncoming = new byte[1024];
            Encoding encUTF8 = Encoding.UTF8;
            int iNumBytesRcvd;
            string strIncoming;
            // Repeat forever
            while (true)
            {
                try
                {
                    iNumBytesRcvd = nsConnection.Read(byIncoming, 0, byIncoming.Length);
                    strIncoming = encUTF8.GetString(byIncoming, 0, iNumBytesRcvd);
                    // Tell the main form to append the string
                    DelOneStringParam delAppendText = new DelOneStringParam(rtbConversation.AppendText);
                    this.Invoke(delAppendText, strIncoming);                   
                }
                catch
                {
                    // Problem, disconnect
                    DelNoParams delDisconnect = new DelNoParams(vDisconnect);
                    this.Invoke(delDisconnect);
                    // Finished trying to receive data. Return to stop execution
                    return;
                }
            }
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
            // Get the text to send, append CRLF, and convert to array of bytes.
            string strMessage = txtMessage.Text;
            strMessage += "\r\n";
            byte[] byMessage = Encoding.UTF8.GetBytes(strMessage);
            // Send the bytes out over the stream.
            nsConnection.Write(byMessage, 0, byMessage.Length);
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
