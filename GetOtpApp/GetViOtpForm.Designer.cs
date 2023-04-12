namespace GetOtpApp
{
    partial class GetViOtpForm
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
            this.btnGetOtp = new System.Windows.Forms.Button();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPhoneCopy = new System.Windows.Forms.Button();
            this.btnCodeCopy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.getCodeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnGetOtp
            // 
            this.btnGetOtp.Location = new System.Drawing.Point(191, 169);
            this.btnGetOtp.Margin = new System.Windows.Forms.Padding(5);
            this.btnGetOtp.Name = "btnGetOtp";
            this.btnGetOtp.Size = new System.Drawing.Size(145, 59);
            this.btnGetOtp.TabIndex = 0;
            this.btnGetOtp.Text = "GET";
            this.btnGetOtp.UseVisualStyleBackColor = true;
            this.btnGetOtp.Click += new System.EventHandler(this.OnGetOtpClicked);
            // 
            // cmbService
            // 
            this.cmbService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(125, 115);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(334, 29);
            this.cmbService.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Service";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.LightBlue;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.Location = new System.Drawing.Point(125, 304);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(223, 29);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.Text = "---";
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone.TextChanged += new System.EventHandler(this.OnPhoneChanged);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.LightBlue;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCode.Location = new System.Drawing.Point(125, 359);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(223, 29);
            this.txtCode.TabIndex = 5;
            this.txtCode.Text = "---";
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.TextChanged += new System.EventHandler(this.OnCodeChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Code";
            // 
            // btnPhoneCopy
            // 
            this.btnPhoneCopy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPhoneCopy.Location = new System.Drawing.Point(367, 304);
            this.btnPhoneCopy.Margin = new System.Windows.Forms.Padding(5);
            this.btnPhoneCopy.Name = "btnPhoneCopy";
            this.btnPhoneCopy.Size = new System.Drawing.Size(92, 32);
            this.btnPhoneCopy.TabIndex = 0;
            this.btnPhoneCopy.Text = "Copy";
            this.btnPhoneCopy.UseVisualStyleBackColor = true;
            this.btnPhoneCopy.Click += new System.EventHandler(this.OnPhoneCopyClicked);
            // 
            // btnCodeCopy
            // 
            this.btnCodeCopy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCodeCopy.Location = new System.Drawing.Point(367, 359);
            this.btnCodeCopy.Margin = new System.Windows.Forms.Padding(5);
            this.btnCodeCopy.Name = "btnCodeCopy";
            this.btnCodeCopy.Size = new System.Drawing.Size(92, 32);
            this.btnCodeCopy.TabIndex = 0;
            this.btnCodeCopy.Text = "Copy";
            this.btnCodeCopy.UseVisualStyleBackColor = true;
            this.btnCodeCopy.Click += new System.EventHandler(this.OnCodeCopyClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(33, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Status";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbStatus.Location = new System.Drawing.Point(125, 256);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(36, 25);
            this.lbStatus.TabIndex = 6;
            this.lbStatus.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Token";
            // 
            // txtApiKey
            // 
            this.txtApiKey.BackColor = System.Drawing.SystemColors.Window;
            this.txtApiKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApiKey.Location = new System.Drawing.Point(125, 64);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(334, 29);
            this.txtApiKey.TabIndex = 4;
            this.txtApiKey.Text = "45b256a26d0e40b4b6c8578e7569d278";
            this.txtApiKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtApiKey.TextChanged += new System.EventHandler(this.OnTokenChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(33, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.LightBlue;
            this.txtBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBalance.Location = new System.Drawing.Point(125, 14);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(261, 29);
            this.txtBalance.TabIndex = 4;
            this.txtBalance.Text = "---";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(399, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "VND";
            // 
            // GetViOtpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 410);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.btnCodeCopy);
            this.Controls.Add(this.btnPhoneCopy);
            this.Controls.Add(this.btnGetOtp);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetViOtpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GET OTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGetOtp;
        private ComboBox cmbService;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtCode;
        private Label label3;
        private Label label4;
        private Button btnPhoneCopy;
        private Button btnCodeCopy;
        private Label label5;
        private Label lbStatus;
        private Label label2;
        private TextBox txtApiKey;
        private Label label7;
        private TextBox txtBalance;
        private Label label8;
        private System.Windows.Forms.Timer getCodeTimer;
    }
}