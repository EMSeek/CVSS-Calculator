using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CVSS_Calculator {
    public partial class frmOptions : Form {
        frmMain _parent;
        public frmOptions(frmMain parent) {
            InitializeComponent();
            _parent = parent;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmOptions_Load(object sender, EventArgs e) {
            txtLow.Text = _parent.Low.ToString("0.0");
            txtMedium.Text = _parent.Medium.ToString("0.0");
            txtHigh.Text = _parent.High.ToString("0.0");
            txtCritical.Text = _parent.Critical.ToString("0.0");
            txtURL.Text = _parent.URL;
            txtCopyText.Text = _parent.CopyText;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            _parent.Low = Convert.ToDouble(txtLow.Text);
            _parent.Medium = Convert.ToDouble(txtMedium.Text);
            _parent.High = Convert.ToDouble(txtHigh.Text);
            _parent.Critical = Convert.ToDouble(txtCritical.Text);
            _parent.URL = txtURL.Text;
            _parent.CopyText = txtCopyText.Text;
            RegistryKey Settings = Registry.CurrentUser.CreateSubKey("Seekurity");
            Settings.SetValue("Low",_parent.Low);
            Settings.SetValue("Medium", _parent.Medium);
            Settings.SetValue("High", _parent.High);
            Settings.SetValue("Critical", _parent.Critical);
            Settings.SetValue("URL", _parent.URL);
            Settings.SetValue("CopyText", _parent.CopyText);
            this.Close();
        }
    }
}
