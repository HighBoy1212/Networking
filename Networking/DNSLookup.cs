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

namespace Networking {
    public partial class DNSLookup : Form {
        public DNSLookup() {
            InitializeComponent();
        }

        private void btnLookup_Click(object sender, EventArgs e) {
            // Get the domain name from the text box and do a lookup on it.
            
            // Make it easy to do another lookup.
            txtDomainName.SelectAll();
            txtDomainName.Focus();
        }
    }
}
