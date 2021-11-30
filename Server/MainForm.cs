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
            
        }

        // Accept connection requests and handle each one.
        private void vAcceptConnects() {
            
        }

        // Stop listening for connection requests.
        private void vStopListening() {
            
        }

        // Method that echos every byte received over a given socket.
        private void vEchoAll(Socket socComm) {
            
        }
    }
}
