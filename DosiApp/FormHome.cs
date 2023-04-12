using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DosiApp.UI.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosiApp
{
    public partial class FormHome : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FormHome()
        {
            InitializeComponent();
        }

        async Task LoadModuleAsync(ModuleInfo module)
        {
            await Task.Factory.StartNew(() =>
            {
                if (!fluentDesignFormControl.Controls.ContainsKey(module.Name))
                {
                    TutorialControlBase control = module.TModule as TutorialControlBase;
                    if (control != null)
                    {
                        control.Dock = DockStyle.Fill;
                        control.CreateWaitDialog();
                        fluentDesignFormContainer.Invoke(new MethodInvoker(delegate ()
                        {
                            fluentDesignFormContainer.Controls.Add(control);
                            control.BringToFront();
                        }));
                    }

                }
                else
                {
                    var control = fluentDesignFormContainer.Controls.Find(module.Name, true);
                    if (control.Length == 1)
                    {
                        fluentDesignFormContainer.Invoke(new MethodInvoker(delegate ()
                        {
                            control[0].BringToFront();
                        }));
                    }
                }
            });
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer.Controls.Add(new ucOtpSetup() { Dock = DockStyle.Fill });
            this.itemNav.Caption = $"{accordionControlOtp.Text}/{accordionControlOtpSetup.Text}";
        }

        private async void OnOtpSetupClicked(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlOtp.Text}/{accordionControlOtpSetup.Text}";
            if (ModulesInfo.GetItem("ucOtpSetup") == null)
            {
                ModulesInfo.Add(new ModuleInfo("ucOtpSetup", "DosiApp.UI.Modules.ucOtpSetup"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("ucOtpSetup"));
        }

        private async void OnOtpGetClicked(object sender, EventArgs e)
        {
            this.itemNav.Caption = $"{accordionControlOtp.Text}/{accordionControlOtpGet.Text}";
            if (ModulesInfo.GetItem("ucOtpGet") == null)
            {
                ModulesInfo.Add(new ModuleInfo("ucOtpGet", "DosiApp.UI.Modules.ucOtpGet"));
            }
            await LoadModuleAsync(ModulesInfo.GetItem("ucOtpGet"));
        }
    }
}
