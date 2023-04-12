using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DosiApp.Services.Otp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosiApp.UI.Modules
{
    public partial class ucOtpGet : DevExpress.DXperience.Demos.TutorialControlBase //DevExpress.XtraEditors.XtraUserControl
    {
        public ucOtpGet()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var handle = SplashScreenManager.ShowOverlayForm(this);
            var otpGetBalance = new ViOtpProvider("45b256a26d0e40b4b6c8578e7569d278", "https://api.viotp.com");
            var response = otpGetBalance.GetBalanceRequest();
            if(response.Code == 200)
            {
                XtraMessageBox.Show(response.Data.Balance.ToString());
            }
            SplashScreenManager.CloseOverlayForm(handle);

        }
    }
}
