namespace CVSS_Calculator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtCVSSText = new System.Windows.Forms.TextBox();
            this.txtCVSSScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRisk = new System.Windows.Forms.TextBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblAV_N = new System.Windows.Forms.Label();
            this.lblAV_A = new System.Windows.Forms.Label();
            this.lblAV_L = new System.Windows.Forms.Label();
            this.lblAV_P = new System.Windows.Forms.Label();
            this.lblAC_L = new System.Windows.Forms.Label();
            this.lblAC_H = new System.Windows.Forms.Label();
            this.lblPR_L = new System.Windows.Forms.Label();
            this.lblPR_N = new System.Windows.Forms.Label();
            this.lblPR_H = new System.Windows.Forms.Label();
            this.lblC_N = new System.Windows.Forms.Label();
            this.lblC_H = new System.Windows.Forms.Label();
            this.lblC_L = new System.Windows.Forms.Label();
            this.lblI_H = new System.Windows.Forms.Label();
            this.lblI_L = new System.Windows.Forms.Label();
            this.lblI_N = new System.Windows.Forms.Label();
            this.lblA_H = new System.Windows.Forms.Label();
            this.lblA_L = new System.Windows.Forms.Label();
            this.lblA_N = new System.Windows.Forms.Label();
            this.lblUI_R = new System.Windows.Forms.Label();
            this.lblUI_N = new System.Windows.Forms.Label();
            this.lblS_C = new System.Windows.Forms.Label();
            this.lblS_U = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtCVSSText
            // 
            this.txtCVSSText.Location = new System.Drawing.Point(27, 41);
            this.txtCVSSText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCVSSText.Name = "txtCVSSText";
            this.txtCVSSText.Size = new System.Drawing.Size(559, 38);
            this.txtCVSSText.TabIndex = 0;
            this.txtCVSSText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCVSSText.TextChanged += new System.EventHandler(this.txtCVSSText_TextChanged);
            this.txtCVSSText.Enter += new System.EventHandler(this.txtCVSSText_Enter);
            this.txtCVSSText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCVSSText_KeyDown);
            // 
            // txtCVSSScore
            // 
            this.txtCVSSScore.Location = new System.Drawing.Point(605, 41);
            this.txtCVSSScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCVSSScore.Name = "txtCVSSScore";
            this.txtCVSSScore.ReadOnly = true;
            this.txtCVSSScore.Size = new System.Drawing.Size(100, 38);
            this.txtCVSSScore.TabIndex = 1;
            this.txtCVSSScore.TabStop = false;
            this.txtCVSSScore.Text = "0.0";
            this.txtCVSSScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCVSSScore.TextChanged += new System.EventHandler(this.txtCVSSScore_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Attack Vector (AV)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Attack Complexity (AC)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Privileges Required (PR)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "User Interaction (UI)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Scope (S)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Confidentiality Impact (C)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "Availability Impact (A)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(547, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 32);
            this.label8.TabIndex = 11;
            this.label8.Text = "Integrity Impact (I)";
            // 
            // txtRisk
            // 
            this.txtRisk.Location = new System.Drawing.Point(728, 41);
            this.txtRisk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRisk.Name = "txtRisk";
            this.txtRisk.ReadOnly = true;
            this.txtRisk.Size = new System.Drawing.Size(119, 38);
            this.txtRisk.TabIndex = 12;
            this.txtRisk.TabStop = false;
            this.txtRisk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfig
            // 
            this.btnConfig.Image = global::CVSS_Calculator.Properties.Resources.AzureDocumentDBStoredProcedure_16x;
            this.btnConfig.Location = new System.Drawing.Point(968, 33);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(64, 64);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Image = global::CVSS_Calculator.Properties.Resources.Copy_16x;
            this.btnCopy.Location = new System.Drawing.Point(891, 33);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(64, 64);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblAV_N
            // 
            this.lblAV_N.AutoSize = true;
            this.lblAV_N.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblAV_N.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAV_N.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAV_N.Location = new System.Drawing.Point(19, 153);
            this.lblAV_N.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblAV_N.Name = "lblAV_N";
            this.lblAV_N.Size = new System.Drawing.Size(138, 34);
            this.lblAV_N.TabIndex = 13;
            this.lblAV_N.Text = "(N)etwork";
            this.lblAV_N.Click += new System.EventHandler(this.lblAV_N_Click);
            // 
            // lblAV_A
            // 
            this.lblAV_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAV_A.Location = new System.Drawing.Point(157, 153);
            this.lblAV_A.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblAV_A.Name = "lblAV_A";
            this.lblAV_A.Size = new System.Drawing.Size(191, 34);
            this.lblAV_A.TabIndex = 14;
            this.lblAV_A.Text = "(A)dj Network";
            this.lblAV_A.Click += new System.EventHandler(this.lblAV_A_Click);
            // 
            // lblAV_L
            // 
            this.lblAV_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAV_L.Location = new System.Drawing.Point(19, 186);
            this.lblAV_L.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblAV_L.Name = "lblAV_L";
            this.lblAV_L.Size = new System.Drawing.Size(138, 34);
            this.lblAV_L.TabIndex = 15;
            this.lblAV_L.Text = "(L)ocal";
            this.lblAV_L.Click += new System.EventHandler(this.lblAV_L_Click);
            // 
            // lblAV_P
            // 
            this.lblAV_P.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAV_P.Location = new System.Drawing.Point(157, 186);
            this.lblAV_P.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblAV_P.Name = "lblAV_P";
            this.lblAV_P.Size = new System.Drawing.Size(191, 34);
            this.lblAV_P.TabIndex = 16;
            this.lblAV_P.Text = "(P)hysical";
            this.lblAV_P.Click += new System.EventHandler(this.lblAV_P_Click);
            // 
            // lblAC_L
            // 
            this.lblAC_L.AutoSize = true;
            this.lblAC_L.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblAC_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAC_L.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAC_L.Location = new System.Drawing.Point(19, 281);
            this.lblAC_L.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblAC_L.Name = "lblAC_L";
            this.lblAC_L.Size = new System.Drawing.Size(87, 34);
            this.lblAC_L.TabIndex = 17;
            this.lblAC_L.Text = "(L)ow";
            this.lblAC_L.Click += new System.EventHandler(this.lblAC_L_Click);
            // 
            // lblAC_H
            // 
            this.lblAC_H.AutoSize = true;
            this.lblAC_H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAC_H.Location = new System.Drawing.Point(104, 281);
            this.lblAC_H.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblAC_H.Name = "lblAC_H";
            this.lblAC_H.Size = new System.Drawing.Size(94, 34);
            this.lblAC_H.TabIndex = 18;
            this.lblAC_H.Text = "(H)igh";
            this.lblAC_H.Click += new System.EventHandler(this.lblAC_H_Click);
            // 
            // lblPR_L
            // 
            this.lblPR_L.AutoSize = true;
            this.lblPR_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPR_L.Location = new System.Drawing.Point(122, 365);
            this.lblPR_L.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblPR_L.Name = "lblPR_L";
            this.lblPR_L.Size = new System.Drawing.Size(87, 34);
            this.lblPR_L.TabIndex = 20;
            this.lblPR_L.Text = "(L)ow";
            this.lblPR_L.Click += new System.EventHandler(this.lblPR_L_Click);
            // 
            // lblPR_N
            // 
            this.lblPR_N.AutoSize = true;
            this.lblPR_N.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblPR_N.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPR_N.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPR_N.Location = new System.Drawing.Point(19, 365);
            this.lblPR_N.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblPR_N.Name = "lblPR_N";
            this.lblPR_N.Size = new System.Drawing.Size(103, 34);
            this.lblPR_N.TabIndex = 19;
            this.lblPR_N.Text = "(N)one";
            this.lblPR_N.Click += new System.EventHandler(this.lblPR_N_Click);
            // 
            // lblPR_H
            // 
            this.lblPR_H.AutoSize = true;
            this.lblPR_H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPR_H.Location = new System.Drawing.Point(209, 365);
            this.lblPR_H.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblPR_H.Name = "lblPR_H";
            this.lblPR_H.Size = new System.Drawing.Size(94, 34);
            this.lblPR_H.TabIndex = 21;
            this.lblPR_H.Text = "(H)igh";
            this.lblPR_H.Click += new System.EventHandler(this.lblPR_H_Click);
            // 
            // lblC_N
            // 
            this.lblC_N.AutoSize = true;
            this.lblC_N.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblC_N.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblC_N.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblC_N.Location = new System.Drawing.Point(555, 281);
            this.lblC_N.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblC_N.Name = "lblC_N";
            this.lblC_N.Size = new System.Drawing.Size(103, 34);
            this.lblC_N.TabIndex = 24;
            this.lblC_N.Text = "(N)one";
            this.lblC_N.Click += new System.EventHandler(this.lblC_N_Click);
            // 
            // lblC_H
            // 
            this.lblC_H.AutoSize = true;
            this.lblC_H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblC_H.Location = new System.Drawing.Point(745, 281);
            this.lblC_H.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblC_H.Name = "lblC_H";
            this.lblC_H.Size = new System.Drawing.Size(94, 34);
            this.lblC_H.TabIndex = 26;
            this.lblC_H.Text = "(H)igh";
            this.lblC_H.Click += new System.EventHandler(this.lblC_H_Click);
            // 
            // lblC_L
            // 
            this.lblC_L.AutoSize = true;
            this.lblC_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblC_L.Location = new System.Drawing.Point(658, 281);
            this.lblC_L.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblC_L.Name = "lblC_L";
            this.lblC_L.Size = new System.Drawing.Size(87, 34);
            this.lblC_L.TabIndex = 25;
            this.lblC_L.Text = "(L)ow";
            this.lblC_L.Click += new System.EventHandler(this.lblC_L_Click);
            // 
            // lblI_H
            // 
            this.lblI_H.AutoSize = true;
            this.lblI_H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblI_H.Location = new System.Drawing.Point(745, 365);
            this.lblI_H.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblI_H.Name = "lblI_H";
            this.lblI_H.Size = new System.Drawing.Size(94, 34);
            this.lblI_H.TabIndex = 29;
            this.lblI_H.Text = "(H)igh";
            this.lblI_H.Click += new System.EventHandler(this.lblI_H_Click);
            // 
            // lblI_L
            // 
            this.lblI_L.AutoSize = true;
            this.lblI_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblI_L.Location = new System.Drawing.Point(658, 365);
            this.lblI_L.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblI_L.Name = "lblI_L";
            this.lblI_L.Size = new System.Drawing.Size(87, 34);
            this.lblI_L.TabIndex = 28;
            this.lblI_L.Text = "(L)ow";
            this.lblI_L.Click += new System.EventHandler(this.lblI_L_Click);
            // 
            // lblI_N
            // 
            this.lblI_N.AutoSize = true;
            this.lblI_N.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblI_N.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblI_N.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblI_N.Location = new System.Drawing.Point(555, 365);
            this.lblI_N.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblI_N.Name = "lblI_N";
            this.lblI_N.Size = new System.Drawing.Size(103, 34);
            this.lblI_N.TabIndex = 27;
            this.lblI_N.Text = "(N)one";
            this.lblI_N.Click += new System.EventHandler(this.lblI_N_Click);
            // 
            // lblA_H
            // 
            this.lblA_H.AutoSize = true;
            this.lblA_H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblA_H.Location = new System.Drawing.Point(745, 460);
            this.lblA_H.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblA_H.Name = "lblA_H";
            this.lblA_H.Size = new System.Drawing.Size(94, 34);
            this.lblA_H.TabIndex = 32;
            this.lblA_H.Text = "(H)igh";
            this.lblA_H.Click += new System.EventHandler(this.lblA_H_Click);
            // 
            // lblA_L
            // 
            this.lblA_L.AutoSize = true;
            this.lblA_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblA_L.Location = new System.Drawing.Point(658, 460);
            this.lblA_L.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblA_L.Name = "lblA_L";
            this.lblA_L.Size = new System.Drawing.Size(87, 34);
            this.lblA_L.TabIndex = 31;
            this.lblA_L.Text = "(L)ow";
            this.lblA_L.Click += new System.EventHandler(this.lblA_L_Click);
            // 
            // lblA_N
            // 
            this.lblA_N.AutoSize = true;
            this.lblA_N.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblA_N.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblA_N.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblA_N.Location = new System.Drawing.Point(555, 460);
            this.lblA_N.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblA_N.Name = "lblA_N";
            this.lblA_N.Size = new System.Drawing.Size(103, 34);
            this.lblA_N.TabIndex = 30;
            this.lblA_N.Text = "(N)one";
            this.lblA_N.Click += new System.EventHandler(this.lblA_N_Click);
            // 
            // lblUI_R
            // 
            this.lblUI_R.AutoSize = true;
            this.lblUI_R.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUI_R.Location = new System.Drawing.Point(122, 460);
            this.lblUI_R.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblUI_R.Name = "lblUI_R";
            this.lblUI_R.Size = new System.Drawing.Size(151, 34);
            this.lblUI_R.TabIndex = 23;
            this.lblUI_R.Text = "(R)equired";
            this.lblUI_R.Click += new System.EventHandler(this.lblUI_R_Click);
            // 
            // lblUI_N
            // 
            this.lblUI_N.AutoSize = true;
            this.lblUI_N.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblUI_N.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUI_N.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUI_N.Location = new System.Drawing.Point(19, 460);
            this.lblUI_N.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblUI_N.Name = "lblUI_N";
            this.lblUI_N.Size = new System.Drawing.Size(103, 34);
            this.lblUI_N.TabIndex = 22;
            this.lblUI_N.Text = "(N)one";
            this.lblUI_N.Click += new System.EventHandler(this.lblUI_N_Click);
            // 
            // lblS_C
            // 
            this.lblS_C.AutoSize = true;
            this.lblS_C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblS_C.Location = new System.Drawing.Point(736, 153);
            this.lblS_C.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblS_C.Name = "lblS_C";
            this.lblS_C.Size = new System.Drawing.Size(151, 34);
            this.lblS_C.TabIndex = 34;
            this.lblS_C.Text = "(C)hanged";
            this.lblS_C.Click += new System.EventHandler(this.lblS_C_Click);
            // 
            // lblS_U
            // 
            this.lblS_U.AutoSize = true;
            this.lblS_U.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblS_U.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblS_U.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblS_U.Location = new System.Drawing.Point(555, 153);
            this.lblS_U.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblS_U.Name = "lblS_U";
            this.lblS_U.Size = new System.Drawing.Size(181, 34);
            this.lblS_U.TabIndex = 33;
            this.lblS_U.Text = "(U)nchanged";
            this.lblS_U.Click += new System.EventHandler(this.lblS_U_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 548);
            this.Controls.Add(this.lblS_C);
            this.Controls.Add(this.lblS_U);
            this.Controls.Add(this.lblA_H);
            this.Controls.Add(this.lblA_L);
            this.Controls.Add(this.lblA_N);
            this.Controls.Add(this.lblI_H);
            this.Controls.Add(this.lblI_L);
            this.Controls.Add(this.lblI_N);
            this.Controls.Add(this.lblC_H);
            this.Controls.Add(this.lblC_L);
            this.Controls.Add(this.lblC_N);
            this.Controls.Add(this.lblUI_R);
            this.Controls.Add(this.lblUI_N);
            this.Controls.Add(this.lblPR_H);
            this.Controls.Add(this.lblPR_L);
            this.Controls.Add(this.lblPR_N);
            this.Controls.Add(this.lblAC_H);
            this.Controls.Add(this.lblAC_L);
            this.Controls.Add(this.lblAV_P);
            this.Controls.Add(this.lblAV_L);
            this.Controls.Add(this.lblAV_A);
            this.Controls.Add(this.lblAV_N);
            this.Controls.Add(this.txtRisk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtCVSSScore);
            this.Controls.Add(this.txtCVSSText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "Seekurity CVSS Calculator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCVSSText;
        private System.Windows.Forms.TextBox txtCVSSScore;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRisk;
        private System.Windows.Forms.Label lblAV_N;
        private System.Windows.Forms.Label lblAV_A;
        private System.Windows.Forms.Label lblAV_L;
        private System.Windows.Forms.Label lblAV_P;
        private System.Windows.Forms.Label lblAC_L;
        private System.Windows.Forms.Label lblAC_H;
        private System.Windows.Forms.Label lblPR_L;
        private System.Windows.Forms.Label lblPR_N;
        private System.Windows.Forms.Label lblPR_H;
        private System.Windows.Forms.Label lblC_N;
        private System.Windows.Forms.Label lblC_H;
        private System.Windows.Forms.Label lblC_L;
        private System.Windows.Forms.Label lblI_H;
        private System.Windows.Forms.Label lblI_L;
        private System.Windows.Forms.Label lblI_N;
        private System.Windows.Forms.Label lblA_H;
        private System.Windows.Forms.Label lblA_L;
        private System.Windows.Forms.Label lblA_N;
        private System.Windows.Forms.Label lblUI_R;
        private System.Windows.Forms.Label lblUI_N;
        private System.Windows.Forms.Label lblS_C;
        private System.Windows.Forms.Label lblS_U;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

