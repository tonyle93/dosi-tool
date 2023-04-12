namespace DosiApp
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.fluentDesignFormContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlOtp = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlOtpSetup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlOtpGet = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.itemNav = new DevExpress.XtraBars.BarStaticItem();
            this.fluentFormDefaultManager = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer
            // 
            this.fluentDesignFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer.Location = new System.Drawing.Point(260, 31);
            this.fluentDesignFormContainer.Name = "fluentDesignFormContainer";
            this.fluentDesignFormContainer.Size = new System.Drawing.Size(674, 501);
            this.fluentDesignFormContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlOtp});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 501);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlOtp
            // 
            this.accordionControlOtp.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlOtpSetup,
            this.accordionControlOtpGet});
            this.accordionControlOtp.Expanded = true;
            this.accordionControlOtp.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.accordionControlOtp.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlOtp.ImageOptions.SvgImage")));
            this.accordionControlOtp.Name = "accordionControlOtp";
            this.accordionControlOtp.Text = "OTP";
            // 
            // accordionControlOtpSetup
            // 
            this.accordionControlOtpSetup.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlOtpSetup.ImageOptions.SvgImage")));
            this.accordionControlOtpSetup.Name = "accordionControlOtpSetup";
            this.accordionControlOtpSetup.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlOtpSetup.Text = "SETUP";
            this.accordionControlOtpSetup.Click += new System.EventHandler(this.OnOtpSetupClicked);
            // 
            // accordionControlOtpGet
            // 
            this.accordionControlOtpGet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlOtpGet.ImageOptions.SvgImage")));
            this.accordionControlOtpGet.Name = "accordionControlOtpGet";
            this.accordionControlOtpGet.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlOtpGet.Text = "GET";
            this.accordionControlOtpGet.Click += new System.EventHandler(this.OnOtpGetClicked);
            // 
            // fluentDesignFormControl
            // 
            this.fluentDesignFormControl.FluentDesignForm = this;
            this.fluentDesignFormControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1,
            this.itemNav});
            this.fluentDesignFormControl.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl.Manager = this.fluentFormDefaultManager;
            this.fluentDesignFormControl.Name = "fluentDesignFormControl";
            this.fluentDesignFormControl.Size = new System.Drawing.Size(934, 31);
            this.fluentDesignFormControl.TabIndex = 2;
            this.fluentDesignFormControl.TabStop = false;
            this.fluentDesignFormControl.TitleItemLinks.Add(this.skinBarSubItem1);
            this.fluentDesignFormControl.TitleItemLinks.Add(this.itemNav);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Theme";
            this.skinBarSubItem1.Id = 0;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // itemNav
            // 
            this.itemNav.Caption = "???";
            this.itemNav.Id = 1;
            this.itemNav.Name = "itemNav";
            // 
            // fluentFormDefaultManager
            // 
            this.fluentFormDefaultManager.Form = this;
            this.fluentFormDefaultManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1,
            this.itemNav});
            this.fluentFormDefaultManager.MaxItemId = 2;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 532);
            this.ControlContainer = this.fluentDesignFormContainer;
            this.Controls.Add(this.fluentDesignFormContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl);
            this.FluentDesignFormControl = this.fluentDesignFormControl;
            this.IconOptions.Image = global::DosiApp.Properties.Resources.logo;
            this.Name = "FormHome";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlOtp;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlOtpSetup;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlOtpGet;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.BarStaticItem itemNav;
    }
}