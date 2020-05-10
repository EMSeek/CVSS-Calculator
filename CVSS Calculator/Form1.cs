﻿using System;
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
    public partial class frmMain : Form {
        public double VERSION = 1.0;
        public String Author = "Eldar Marcussen";
        //Set default values
        public double Low = 0.1;
        public double Medium = 4.0;
        public double High = 7.0;
        public double Critical = 9.0;
        public String URL = "https://nvd.nist.gov/vuln-metrics/cvss/v3-calculator?vector=%CVSS%&version=3.1";
        public String CopyText = "The risk is considered to be %RISK% with a CVSS score of %SCORE% - %URL%";
        double AV = 0.85;
        String AVS = "AV:N";
        double AC = 0.77;
        String ACS = "AC:L";
        double PR = 0.85;
        String PRS = "PR:N";
        double UI = 0.85;
        String UIS = "UI:N";
        double S = 0;
        String SS = "S:U";
        double C = 0;
        String CS = "C:N";
        double I = 0;
        String IS = "I:N";
        double A = 0;
        String AS = "A:N";




        public frmMain() {
            InitializeComponent();
            // Assign custom values if they exist
            RegistryKey Settings = Registry.CurrentUser.OpenSubKey("Seekurity");
            if (Settings != null) {
                Low = Double.Parse(Settings.GetValue("Low").ToString());
                Medium = Double.Parse(Settings.GetValue("Medium").ToString());
                High = Double.Parse(Settings.GetValue("High").ToString());
                Critical = Double.Parse(Settings.GetValue("Critical").ToString());
                URL = Settings.GetValue("URL").ToString();
                CopyText = Settings.GetValue("CopyText").ToString();
            }
        }

        private void txtCVSSScore_TextChanged(object sender, EventArgs e) {
            if (txtCVSSScore.Text != "") {
                double _score;
                if (Double.TryParse(txtCVSSScore.Text, out _score)) {
                    if (_score < Low) {
                        txtRisk.Text = "";
                    } else if (_score < Medium) {
                        txtRisk.Text = "Low";
                    } else if (_score < High) {
                        txtRisk.Text = "Medium";
                    } else if (_score < Critical) {
                        txtRisk.Text = "High";
                    } else if (_score < 10.1) {
                        txtRisk.Text = "Critical";
                    } else {
                        txtRisk.Text = "ERROR";
                    }
                } else {
                    txtRisk.Text = "ERROR";
                }
            }
        }

        private void txtCVSSText_TextChanged(object sender, EventArgs e) {
            String CVSS = txtCVSSText.Text;
            if (CVSS.Length == 35) {
                if (CVSS.Substring(0, 3) == "AV:") {
                    AVS = CVSS.Substring(0, 4);
                } else { return; }
                if (CVSS.Substring(5, 3) == "AC:") {
                    ACS = CVSS.Substring(5, 4);
                } else { return; }
                if (CVSS.Substring(10, 3) == "PR:") {
                    PRS = CVSS.Substring(10, 4);
                } else { return; }
                if (CVSS.Substring(15, 3) == "UI:") {
                    UIS = CVSS.Substring(15, 4);
                } else { return; }
                if (CVSS.Substring(20, 2) == "S:") {
                    SS = CVSS.Substring(20, 3);
                } else { return; }
                if (CVSS.Substring(24, 2) == "C:") {
                    CS = CVSS.Substring(24, 3);
                } else { return; }
                if (CVSS.Substring(28, 2) == "I:") {
                    IS = CVSS.Substring(28, 3);
                } else { return; }
                if (CVSS.Substring(32, 2) == "A:") {
                    AS = CVSS.Substring(32, 3);
                } else { return; }
                updateButtons();
            }
        }


        private void btnConfig_Click(object sender, EventArgs e) {
            frmOptions opts = new frmOptions(this);
            opts.Show();
        }

        private void btnCopy_Click(object sender, EventArgs e) {
            String mURL = URL.Replace("%CVSS%", txtCVSSText.Text);
            mURL = mURL.Replace("%SCORE%", txtCVSSScore.Text);
            mURL = mURL.Replace("%RISK%", txtRisk.Text);
            String CP = CopyText.Replace("%CVSS%", txtCVSSText.Text);
            CP = CP.Replace("%SCORE%", txtCVSSScore.Text);
            CP = CP.Replace("%RISK%", txtRisk.Text);
            CP = CP.Replace("%URL%", mURL);
            Clipboard.SetText(CP);
        }

        private void calculate() {
            //Caclulate base score
            txtCVSSText.Text = $"{AVS}/{ACS}/{PRS}/{UIS}/{SS}/{CS}/{IS}/{AS}";
            double BSC = 0; //Base score
            double ESC = 0; //Exploitability sub score
            double ISC = 0; //Impact sub score
            double IBS = 0; //Impact base score
            double Score = 0; //Final score

            //Unconditional calculations:
            IBS = 1 - (1 - C) * (1 - I) * (1 - A);
            ESC = 8.22 * AV * AC * PR * UI;

            //Scope unchanged
            if (S == 0) {
                //Impact sub score
                ISC = 6.42 * IBS;
                BSC = ISC + ESC;
            } else { //Scope changed
                ISC = 7.52 * (IBS - 0.029) - 3.25 * Math.Pow(IBS - 0.02, 15);
                BSC = 1.08 * (ISC + ESC);
            }
            if (ISC <= 0) {
                BSC = 0;
            }
            Score = RoundUp(BSC, 1);
            if (Score > 10) {
                Score = 10;
            }
            txtCVSSScore.Text = Score.ToString("0.0");
            /*Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine();
            Console.WriteLine("Exploitability: " + ESC + "==> " + RoundUp(ESC, 1));
            Console.WriteLine("IBS: " + IBS);
            Console.WriteLine("Impact: " + ISC + "==> " + RoundUp(ISC, 1));
            Console.WriteLine("Base score: " + BSC + "==> " + RoundUp(BSC, 1));
            Console.WriteLine("Final score: " + Score);*/
        }

        private double RoundUp(double value, int decimalpoint) {
            var result = Math.Round(value, decimalpoint);
            if (result < value) {
                result += Math.Pow(10, -decimalpoint);
            }
            return result;
        }

        private void lblAV_N_Click(object sender, EventArgs e) {
            AVS = "AV:N";
            updateButtons();
        }

        private void lblAV_A_Click(object sender, EventArgs e) {
            AVS = "AV:A";
            updateButtons();

        }

        private void lblAV_L_Click(object sender, EventArgs e) {
            AVS = "AV:L";
            updateButtons();
        }

        private void lblAV_P_Click(object sender, EventArgs e) {
            AVS = "AV:P";
            updateButtons();
        }

        private void lblAC_L_Click(object sender, EventArgs e) {
            ACS = "AC:L";
            updateButtons();
        }

        private void lblAC_H_Click(object sender, EventArgs e) {
            ACS = "AC:H";
            updateButtons();
        }

        private void lblPR_N_Click(object sender, EventArgs e) {
            PRS = "PR:N";
            updateButtons();
        }
        private void lblPR_L_Click(object sender, EventArgs e) {
            PRS = "PR:L";
            updateButtons();
        }

        private void lblPR_H_Click(object sender, EventArgs e) {
            PRS = "PR:H";
            updateButtons();
        }

        private void lblUI_N_Click(object sender, EventArgs e) {
            UIS = "UI:N";
            updateButtons();
        }

        private void lblUI_R_Click(object sender, EventArgs e) {
            UIS = "UI:R";
            updateButtons();
        }

        private void lblS_U_Click(object sender, EventArgs e) {
            SS = "S:U";
            updateButtons();
        }

        private void lblS_C_Click(object sender, EventArgs e) {
            SS = "S:C";
            updateButtons();
        }

        private void lblC_N_Click(object sender, EventArgs e) {
            CS = "C:N";
            updateButtons();
        }

        private void lblC_L_Click(object sender, EventArgs e) {
            CS = "C:L";
            updateButtons();
        }

        private void lblC_H_Click(object sender, EventArgs e) {
            CS = "C:H";
            updateButtons();
        }
        private void lblI_N_Click(object sender, EventArgs e) {
            IS = "I:N";
            updateButtons();
        }

        private void lblI_L_Click(object sender, EventArgs e) {
            IS = "I:L";
            updateButtons();
        }

        private void lblI_H_Click(object sender, EventArgs e) {
            IS = "I:H";
            updateButtons();
        }

        private void lblA_N_Click(object sender, EventArgs e) {
            AS = "A:N";
            updateButtons();
        }

        private void lblA_L_Click(object sender, EventArgs e) {
            AS = "A:L";
            updateButtons();
        }

        private void lblA_H_Click(object sender, EventArgs e) {
            AS = "A:H";
            updateButtons();
        }

        private void updateButtons() {
            resetButtons();
            switch (AVS) {
                case "AV:N":
                    AV = 0.85;
                    lblAV_N.BackColor = SystemColors.Highlight;
                    lblAV_N.ForeColor = SystemColors.HighlightText;
                    break;
                case "AV:A":
                    AV = 0.62;
                    lblAV_A.BackColor = SystemColors.Highlight;
                    lblAV_A.ForeColor = SystemColors.HighlightText;
                    break;
                case "AV:L":
                    AV = 0.55;
                    lblAV_L.BackColor = SystemColors.Highlight;
                    lblAV_L.ForeColor = SystemColors.HighlightText;
                    break;
                case "AV:P":
                    AV = 0.2;
                    lblAV_P.BackColor = SystemColors.Highlight;
                    lblAV_P.ForeColor = SystemColors.HighlightText;
                    break;
            }
            switch (ACS) {
                case "AC:L":
                    AC = 0.77;
                    lblAC_L.BackColor = SystemColors.Highlight;
                    lblAC_L.ForeColor = SystemColors.HighlightText;
                    break;
                case "AC:H":
                    AC = 0.44;
                    lblAC_H.BackColor = SystemColors.Highlight;
                    lblAC_H.ForeColor = SystemColors.HighlightText;
                    break;
            }
            switch (PRS) {
                case "PR:N":
                    PR = 0.85;
                    lblPR_N.BackColor = SystemColors.Highlight;
                    lblPR_N.ForeColor = SystemColors.HighlightText;
                    break;
                case "PR:L":
                    PR = 0.62;
                    lblPR_L.BackColor = SystemColors.Highlight;
                    lblPR_L.ForeColor = SystemColors.HighlightText;
                    break;
                case "PR:H":
                    PR = 0.27;
                    lblPR_H.BackColor = SystemColors.Highlight;
                    lblPR_H.ForeColor = SystemColors.HighlightText;
                    break;
            }
            switch (UIS) {
                case "UI:N":
                    UI = 0.85;
                    lblUI_N.BackColor = SystemColors.Highlight;
                    lblUI_N.ForeColor = SystemColors.HighlightText;
                    break;
                case "UI:R":
                    UI = 0.62;
                    lblUI_R.BackColor = SystemColors.Highlight;
                    lblUI_R.ForeColor = SystemColors.HighlightText;
                    break;
            }
            switch (SS) {
                case "S:U":
                    S = 0;
                    lblS_U.BackColor = SystemColors.Highlight;
                    lblS_U.ForeColor = SystemColors.HighlightText;
                    break;
                case "S:C":
                    S = 1;
                    if (PR == 0.62) {
                        PR = 0.68;
                    } else if (PR == 0.27) {
                        PR = 0.5;
                    }
                    lblS_C.BackColor = SystemColors.Highlight;
                    lblS_C.ForeColor = SystemColors.HighlightText;
                    break;
            }
            switch (CS) {
                case "C:N":
                    C = 0;
                    lblC_N.BackColor = SystemColors.Highlight;
                    lblC_N.ForeColor = SystemColors.HighlightText;
                    break;
                case "C:L":
                    C = 0.22;
                    lblC_L.BackColor = SystemColors.Highlight;
                    lblC_L.ForeColor = SystemColors.HighlightText;
                    break;
                case "C:H":
                    C = 0.56;
                    lblC_H.BackColor = SystemColors.Highlight;
                    lblC_H.ForeColor = SystemColors.HighlightText;
                    break;
            }
            switch (IS) {
                case "I:N":
                    I = 0;
                    lblI_N.BackColor = SystemColors.Highlight;
                    lblI_N.ForeColor = SystemColors.HighlightText;
                    break;
                case "I:L":
                    I = 0.22;
                    lblI_L.BackColor = SystemColors.Highlight;
                    lblI_L.ForeColor = SystemColors.HighlightText;
                    break;
                case "I:H":
                    I = 0.56;
                    lblI_H.BackColor = SystemColors.Highlight;
                    lblI_H.ForeColor = SystemColors.HighlightText;
                    break;
            }
            switch (AS) {
                case "A:N":
                    A = 0;
                    lblA_N.BackColor = SystemColors.Highlight;
                    lblA_N.ForeColor = SystemColors.HighlightText;
                    break;
                case "A:L":
                    A = 0.22;
                    lblA_L.BackColor = SystemColors.Highlight;
                    lblA_L.ForeColor = SystemColors.HighlightText;
                    break;
                case "A:H":
                    A = 0.56;
                    lblA_H.BackColor = SystemColors.Highlight;
                    lblA_H.ForeColor = SystemColors.HighlightText;
                    break;
            }
            calculate();
        }


        private void resetButtons() {
            //Access Vector
            lblAV_N.BackColor = SystemColors.Control;
            lblAV_N.ForeColor = SystemColors.ControlText;
            lblAV_A.BackColor = SystemColors.Control;
            lblAV_A.ForeColor = SystemColors.ControlText;
            lblAV_L.BackColor = SystemColors.Control;
            lblAV_L.ForeColor = SystemColors.ControlText;
            lblAV_P.BackColor = SystemColors.Control;
            lblAV_P.ForeColor = SystemColors.ControlText;
            //Access Complexity
            lblAC_L.BackColor = SystemColors.Control;
            lblAC_L.ForeColor = SystemColors.ControlText;
            lblAC_H.BackColor = SystemColors.Control;
            lblAC_H.ForeColor = SystemColors.ControlText;
            //Privileges Required
            lblPR_N.BackColor = SystemColors.Control;
            lblPR_N.ForeColor = SystemColors.ControlText;
            lblPR_L.BackColor = SystemColors.Control;
            lblPR_L.ForeColor = SystemColors.ControlText;
            lblPR_H.BackColor = SystemColors.Control;
            lblPR_H.ForeColor = SystemColors.ControlText;
            //User interaction required
            lblUI_N.BackColor = SystemColors.Control;
            lblUI_N.ForeColor = SystemColors.ControlText;
            lblUI_R.BackColor = SystemColors.Control;
            lblUI_R.ForeColor = SystemColors.ControlText;
            //Scope changed
            lblS_U.BackColor = SystemColors.Control;
            lblS_U.ForeColor = SystemColors.ControlText;
            lblS_C.BackColor = SystemColors.Control;
            lblS_C.ForeColor = SystemColors.ControlText;
            //Confidentiality impact
            lblC_N.BackColor = SystemColors.Control;
            lblC_N.ForeColor = SystemColors.ControlText;
            lblC_L.BackColor = SystemColors.Control;
            lblC_L.ForeColor = SystemColors.ControlText;
            lblC_H.BackColor = SystemColors.Control;
            lblC_H.ForeColor = SystemColors.ControlText;
            //Integrity impact
            lblI_N.BackColor = SystemColors.Control;
            lblI_N.ForeColor = SystemColors.ControlText;
            lblI_L.BackColor = SystemColors.Control;
            lblI_L.ForeColor = SystemColors.ControlText;
            lblI_H.BackColor = SystemColors.Control;
            lblI_H.ForeColor = SystemColors.ControlText;
            //Availability impact
            lblA_N.BackColor = SystemColors.Control;
            lblA_N.ForeColor = SystemColors.ControlText;
            lblA_L.BackColor = SystemColors.Control;
            lblA_L.ForeColor = SystemColors.ControlText;
            lblA_H.BackColor = SystemColors.Control;
            lblA_H.ForeColor = SystemColors.ControlText;
        }

        private void txtCVSSText_KeyDown(object sender, KeyEventArgs e) {
            int idx = txtCVSSText.SelectionStart;
            String kc = e.KeyCode.ToString();
            e.Handled = true;
            if (e.Control && e.KeyCode == Keys.C) {
                btnCopy_Click(sender, null);
                e.SuppressKeyPress = true;
            } else  if (idx < 5) { //AV string
                idx = 0;
                if (kc == "Up") {
                    inc_AVS();
                } else if (kc == "Down") {
                    dec_AVS();
                } else if (kc == "Right") {
                    idx = 5;
                }
            } else if (idx < 10) { //AC String
                idx = 5;
                if (kc == "Up") {
                    inc_ACS();
                } else if (kc == "Down") {
                    dec_ACS();
                } else if (kc == "Right") {
                    idx = 10;
                } else if (kc == "Left") {
                    idx = 0;
                }
            } else if (idx < 15) { //PR String
                idx = 10;
                if (kc == "Up") {
                    inc_PRS();
                } else if (kc == "Down") {
                    dec_PRS();
                } else if (kc == "Right") {
                    idx = 15;
                } else if (kc == "Left") {
                    idx = 5;
                }
            } else if (idx < 20) { //UI String
                idx = 15;
                if (kc == "Up") {
                    inc_UIS();
                } else if (kc == "Down") {
                    dec_UIS();
                } else if (kc == "Right") {
                    idx = 20;
                } else if (kc == "Left") {
                    idx = 10;
                }
            } else if (idx < 24) { //S String
                idx = 20;
                if (kc == "Up") {
                    inc_SS();
                } else if (kc == "Down") {
                    dec_SS();
                } else if (kc == "Right") {
                    idx = 24;
                } else if (kc == "Left") {
                    idx = 15;
                }
            } else if (idx < 28) { //C String
                idx = 24;
                if (kc == "Up") {
                    inc_CS();
                } else if (kc == "Down") {
                    dec_CS();
                } else if (kc == "Right") {
                    idx = 28;
                } else if (kc == "Left") {
                    idx = 20;
                }
            } else if (idx < 32) { //I String
                idx = 28;
                if (kc == "Up") {
                    inc_IS();
                } else if (kc == "Down") {
                    dec_IS();
                } else if (kc == "Right") {
                    idx = 32;
                } else if (kc == "Left") {
                    idx = 24;
                }
            } else if (idx < 35) { //A String
                idx = 32;
                if (kc == "Up") {
                    inc_AS();
                } else if (kc == "Down") {
                    dec_AS();
                } else if (kc == "Left") {
                    idx = 28;
                }
            } else {
                e.Handled = false;
            }
            txtCVSSText.SelectionStart = idx;
        }

        private void inc_AVS() {
            if (AVS == "AV:N") {
                AVS = "AV:A";
            } else if (AVS == "AV:A") {
                AVS = "AV:L";
            } else if (AVS == "AV:L") {
                AVS = "AV:P";
            } else {
                //If we reach here AVS is wrapping around or an invalid value
                AVS = "AV:N";
            }
            updateButtons();
            calculate();
        }

        private void dec_AVS() {
            if (AVS == "AV:P") {
                AVS = "AV:L";
            } else if (AVS == "AV:L") {
                AVS = "AV:A";
            } else if (AVS == "AV:A") {
                AVS = "AV:N";
            } else {
                //If we reach here AVS is wrapping around or an invalid value
                AVS = "AV:P";
            }
            updateButtons();
            calculate();
        }

        private void inc_ACS() {
            if (ACS == "AC:L") {
                ACS = "AC:H";
            } else {
                //If we reach here ACS is wrapping around or an invalid value
                ACS = "AC:L";
            }
            updateButtons();
            calculate();
        }
        private void dec_ACS() {
            if (ACS == "AC:H") {
                ACS = "AC:L";
            } else {
                //If we reach here ACS is wrapping around or an invalid value
                ACS = "AC:H";
            }
            updateButtons();
            calculate();
        }
        private void inc_PRS() {
            if (PRS == "PR:N") {
                PRS = "PR:L";
            } else if (PRS == "PR:L") {
                PRS = "PR:H";
            } else {
                //If we reach here PRS is wrapping around or an invalid value
                PRS = "PR:N";
            }
            updateButtons();
            calculate();
        }

        private void dec_PRS() {
            if (PRS == "PR:H") {
                PRS = "PR:L";
            } else if (PRS == "PR:L") {
                PRS = "PR:N";
            } else {
                //If we reach here PRS is wrapping around or an invalid value
                PRS = "PR:H";
            }
            updateButtons();
            calculate();
        }

        private void inc_UIS() {
            if (UIS == "UI:N") {
                UIS = "UI:R";
            } else {
                //If we reach here UIS is wrapping around or an invalid value
                UIS = "UI:N";
            }
            updateButtons();
            calculate();
        }
        private void dec_UIS() {
            if (UIS == "UI:R") {
                UIS = "UI:N";
            } else {
                //If we reach here UIS is wrapping around or an invalid value
                UIS = "UI:R";
            }
            updateButtons();
            calculate();
        }

        private void inc_SS() {
            if (SS == "S:U") {
                SS = "S:C";
            } else {
                //If we reach here SS is wrapping around or an invalid value
                SS = "S:U";
            }
            updateButtons();
            calculate();
        }
        private void dec_SS() {
            if (SS == "S:C") {
                SS = "S:U";
            } else {
                //If we reach here SS is wrapping around or an invalid value
                SS = "S:C";
            }
            updateButtons();
            calculate();
        }
        private void inc_CS() {
            if (CS == "C:N") {
                CS = "C:L";
            } else if (CS == "C:L") {
                CS = "C:H";
            } else {
                //If we reach here CS is wrapping around or an invalid value
                CS = "C:N";
            }
            updateButtons();
            calculate();
        }

        private void dec_CS() {
            if (CS == "C:H") {
                CS = "C:L";
            } else if (CS == "C:L") {
                CS = "C:N";
            } else {
                //If we reach here CS is wrapping around or an invalid value
                CS = "C:H";
            }
            updateButtons();
            calculate();
        }

        private void inc_IS() {
            if (IS == "I:N") {
                IS = "I:L";
            } else if (IS == "I:L") {
                IS = "I:H";
            } else {
                //If we reach here IS is wrapping around or an invalid value
                IS = "I:N";
            }
            updateButtons();
            calculate();
        }

        private void dec_IS() {
            if (IS == "I:H") {
                IS = "I:L";
            } else if (IS == "I:L") {
                IS = "I:N";
            } else {
                //If we reach here IS is wrapping around or an invalid value
                IS = "I:H";
            }
            updateButtons();
            calculate();
        }

        private void inc_AS() {
            if (AS == "A:N") {
                AS = "A:L";
            } else if (AS == "A:L") {
                AS = "A:H";
            } else {
                //If we reach here AS is wrapping around or an invalid value
                AS = "A:N";
            }
            updateButtons();
            calculate();
        }

        private void dec_AS() {
            if (AS == "A:H") {
                AS = "A:L";
            } else if (AS == "A:L") {
                AS = "A:N";
            } else {
                //If we reach here AS is wrapping around or an invalid value
                AS = "A:H";
            }
            updateButtons();
            calculate();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            this.Text = this.Text + " v" + VERSION.ToString("0.0");
            calculate();
        }

        private void txtCVSSText_Enter(object sender, EventArgs e) {
            txtCVSSText.SelectionStart = 0;
            txtCVSSText.SelectionLength = 0;
        }
    }
}
