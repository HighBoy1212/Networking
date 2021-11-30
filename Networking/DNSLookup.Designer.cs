namespace Networking {
    partial class DNSLookup {
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
            this.lblDomainName = new System.Windows.Forms.Label();
            this.txtDomainName = new System.Windows.Forms.TextBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.dgvAddresses = new System.Windows.Forms.DataGridView();
            this.ColAddresses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddresses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDomainName
            // 
            this.lblDomainName.AutoSize = true;
            this.lblDomainName.Location = new System.Drawing.Point(12, 15);
            this.lblDomainName.Name = "lblDomainName";
            this.lblDomainName.Size = new System.Drawing.Size(77, 13);
            this.lblDomainName.TabIndex = 0;
            this.lblDomainName.Text = "Domain Name:";
            // 
            // txtDomainName
            // 
            this.txtDomainName.Location = new System.Drawing.Point(95, 12);
            this.txtDomainName.Name = "txtDomainName";
            this.txtDomainName.Size = new System.Drawing.Size(240, 20);
            this.txtDomainName.TabIndex = 1;
            // 
            // btnLookup
            // 
            this.btnLookup.Location = new System.Drawing.Point(136, 38);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(75, 23);
            this.btnLookup.TabIndex = 2;
            this.btnLookup.Text = "Lookup";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // dgvAddresses
            // 
            this.dgvAddresses.AllowUserToAddRows = false;
            this.dgvAddresses.AllowUserToDeleteRows = false;
            this.dgvAddresses.AllowUserToResizeColumns = false;
            this.dgvAddresses.AllowUserToResizeRows = false;
            this.dgvAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColAddresses});
            this.dgvAddresses.Location = new System.Drawing.Point(12, 67);
            this.dgvAddresses.Name = "dgvAddresses";
            this.dgvAddresses.ReadOnly = true;
            this.dgvAddresses.RowHeadersVisible = false;
            this.dgvAddresses.Size = new System.Drawing.Size(323, 150);
            this.dgvAddresses.TabIndex = 3;
            // 
            // ColAddresses
            // 
            this.ColAddresses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColAddresses.HeaderText = "Addresses";
            this.ColAddresses.Name = "ColAddresses";
            this.ColAddresses.ReadOnly = true;
            // 
            // DNSLookup
            // 
            this.AcceptButton = this.btnLookup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 229);
            this.Controls.Add(this.dgvAddresses);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.txtDomainName);
            this.Controls.Add(this.lblDomainName);
            this.Name = "DNSLookup";
            this.Text = "DNSLookup";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddresses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDomainName;
        private System.Windows.Forms.TextBox txtDomainName;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.DataGridView dgvAddresses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddresses;
    }
}