namespace CVSS_Calculator {
    partial class frmOptions {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.lblLow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblCritical = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtMedium = new System.Windows.Forms.TextBox();
            this.txtCritical = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCopy = new System.Windows.Forms.Label();
            this.txtCopyText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Location = new System.Drawing.Point(26, 31);
            this.lblLow.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(67, 13);
            this.lblLow.TabIndex = 0;
            this.lblLow.Text = "Low treshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medium treshold";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Location = new System.Drawing.Point(26, 77);
            this.lblHigh.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(69, 13);
            this.lblHigh.TabIndex = 2;
            this.lblHigh.Text = "High treshold";
            // 
            // lblCritical
            // 
            this.lblCritical.AutoSize = true;
            this.lblCritical.Location = new System.Drawing.Point(26, 100);
            this.lblCritical.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCritical.Name = "lblCritical";
            this.lblCritical.Size = new System.Drawing.Size(78, 13);
            this.lblCritical.TabIndex = 3;
            this.lblCritical.Text = "Critical treshold";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(178, 27);
            this.lblURL.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblURL.Size = new System.Drawing.Size(60, 13);
            this.lblURL.TabIndex = 4;
            this.lblURL.Text = "CVSS URL";
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(113, 24);
            this.txtLow.Margin = new System.Windows.Forms.Padding(1);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(59, 20);
            this.txtLow.TabIndex = 5;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(178, 47);
            this.txtURL.Margin = new System.Windows.Forms.Padding(1);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(415, 20);
            this.txtURL.TabIndex = 6;
            this.txtURL.Text = "https://nvd.nist.gov/vuln-metrics/cvss/v3-calculator?vector=%CVSS%&version=3.1";
            // 
            // txtMedium
            // 
            this.txtMedium.Location = new System.Drawing.Point(113, 47);
            this.txtMedium.Margin = new System.Windows.Forms.Padding(1);
            this.txtMedium.Name = "txtMedium";
            this.txtMedium.Size = new System.Drawing.Size(59, 20);
            this.txtMedium.TabIndex = 7;
            // 
            // txtCritical
            // 
            this.txtCritical.Location = new System.Drawing.Point(113, 93);
            this.txtCritical.Margin = new System.Windows.Forms.Padding(1);
            this.txtCritical.Name = "txtCritical";
            this.txtCritical.Size = new System.Drawing.Size(59, 20);
            this.txtCritical.TabIndex = 8;
            // 
            // txtHigh
            // 
            this.txtHigh.Location = new System.Drawing.Point(113, 70);
            this.txtHigh.Margin = new System.Windows.Forms.Padding(1);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(59, 20);
            this.txtHigh.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(441, 214);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(520, 214);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Location = new System.Drawing.Point(178, 73);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(51, 13);
            this.lblCopy.TabIndex = 12;
            this.lblCopy.Text = "Copy text";
            // 
            // txtCopyText
            // 
            this.txtCopyText.Location = new System.Drawing.Point(181, 94);
            this.txtCopyText.Multiline = true;
            this.txtCopyText.Name = "txtCopyText";
            this.txtCopyText.Size = new System.Drawing.Size(411, 94);
            this.txtCopyText.TabIndex = 13;
            this.txtCopyText.Text = "The risk is considered to be %RISK% with a CVSS score of %SCORE% - %URL%";
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 253);
            this.Controls.Add(this.txtCopyText);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtCritical);
            this.Controls.Add(this.txtMedium);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblCritical);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmOptions";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblCritical;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtMedium;
        private System.Windows.Forms.TextBox txtCritical;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.TextBox txtCopyText;
    }
}