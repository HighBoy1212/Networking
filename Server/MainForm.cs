using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server {
    public partial class MainForm : Form {
        // Fields.
        // The socket listening for connections.
        private Socket socListen = null;
        // The port number we listen on.
        private const int iPortNum = 33221;

        public MainForm() {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            // Start listening if our text says "Start", otherwise stop listening.
            if (btnStart.Text == "Start") {
                vStartListening();
                btnStart.Text = "Stop";
            } else {
                vStopListening();
                btnStart.Text = "Start";
            }
        }

        // Start listening for connections.
        private void vStartListening() {
            // Create and setup a socket to listen for icoming connection requests
            socListen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // Bind the socket to an IP address and port number. These will be the address and port numbers
            // that other apps must use to try to connect to this app
            // For this, the loopback IP address will be used (127.0.0.1). It is a dummy address that only
            // does networking with other applications on the same host
            IPAddress ipaListen = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipeListen = new IPEndPoint(ipaListen, iPortNum);
            socListen.Bind(ipeListen);
            // Tell the socket to start listening to incoming connection requests
            socListen.Listen(5);
            // Run a task that accepts connection requests and processes them
            Task.Run(new Action(vAcceptConnects));
        }

        // Accept connection requests and handle each one.
        private void vAcceptConnects() {
            // Repeat accepting connection requests forever
            while (true)
            {
                try
                {
                    // When a new connection request is accepted, it returns a new socket
                    // to use for exchanging data
                    Socket socConnection = socListen.Accept();
                    // Start another task to exchange data over the new connection
                    Task.Run(() => vEchoAll(socConnection));
                }
                catch
                {
                    // The only reason to get an exception is that the listening socket has been closed
                    // We can return to stop executing this function
                    return;
                }
            }
        }

        // Stop listening for connection requests.
        private void vStopListening() {
            // To stop listening for connection requests, close and dispose of the listening socket
            socListen.Close();
            socListen.Dispose();
            socListen = null;
        }

        // Method that echos every byte received over a given socket.
        private void vEchoAll(Socket socComm) {
            // Setup byte array to store incoming data
            byte[] byIncoming = new byte[1024];
            // Loop forever, echoing all incoming data back to the sender
            while (true)
            {
                try
                {
                    int iNumBytesRcvd = socComm.Receive(byIncoming);
                    socComm.Send(byIncoming, iNumBytesRcvd, SocketFlags.None);
                }
                catch
                {
                    // Assume the connection was shutdown. Close and dispose of the socket
                    socComm.Close();
                    socComm.Dispose();
                    return;
                }
            }
        }
    }
}
