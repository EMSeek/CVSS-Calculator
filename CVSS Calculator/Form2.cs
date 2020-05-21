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
            txtCopyName.Text = _parent.CopyName;
            txtCopyText.Text = _parent.CopyText;
            for (int x = 0; x < _parent.Template_array.Length; x++) {
                cboTemplate.Items.Add(_parent.Template_array[x]);
                if (_parent.CopyName == _parent.Template_array[x]) {
                    cboTemplate.SelectedIndex = x;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            _parent.Low = Convert.ToDouble(txtLow.Text);
            _parent.Medium = Convert.ToDouble(txtMedium.Text);
            _parent.High = Convert.ToDouble(txtHigh.Text);
            _parent.Critical = Convert.ToDouble(txtCritical.Text);
            _parent.CopyName = txtCopyName.Text;
            _parent.CopyText = txtCopyText.Text;
            RegistryKey Settings = Registry.CurrentUser.CreateSubKey("Seekurity");
            Settings.SetValue("Low",_parent.Low);
            Settings.SetValue("Medium", _parent.Medium);
            Settings.SetValue("High", _parent.High);
            Settings.SetValue("Critical", _parent.Critical);
            Settings.SetValue("Template", _parent.CopyName);
            RegistryKey Templates = Settings.CreateSubKey("Templates");
            Templates.SetValue(_parent.CopyName, _parent.CopyText);
            this.Close();
        }

        private void cboTemplate_SelectedIndexChanged(object sender, EventArgs e) {
            RegistryKey Templates = Registry.CurrentUser.OpenSubKey("Seekurity").OpenSubKey("Templates");
            txtCopyName.Text = cboTemplate.SelectedItem.ToString();
            txtCopyText.Text = Templates.GetValue(txtCopyName.Text).ToString();
        }
    }
}
