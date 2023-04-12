using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using System.Net.Http.Headers; 

namespace GetOtpApp
{
    public partial class FormGetOtp : Form
    {
        static HttpClient client = new HttpClient();
        static string baseUrl = "https://api.viotp.com";
        static string defaultText = "---";
        string token = "";
        string currentRequestId = "";
        int timeOut = 30000;
        int currentTime = 0;
        List<ServiceData> services = new List<ServiceData>();

        public FormGetOtp()
        {
            InitializeComponent();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            this.Init();
        }

        private void Init()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.btnPhoneCopy.Enabled = false;
            this.btnCodeCopy.Enabled = false;
            this.token = this.txtApiKey.Text;
            this.txtBalance.Text = GetBalance().ToString();
            this.services = GetServices();
            this.BindServicesToCombobox();
            //timer
            this.getCodeTimer.Interval = 1000;
            this.getCodeTimer.Tick += OnTimerTick;
            this.getCodeTimer.Enabled = false;
        }

        private void BindServicesToCombobox()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.services;
            this.cmbService.DataSource = bindingSource.DataSource;
            this.cmbService.DisplayMember = "name";
            this.cmbService.ValueMember = "id";
            int defaultSelected = this.services.FindIndex(s => s.name == "DosiWallet");
            this.cmbService.SelectedIndex = defaultSelected != -1 ? defaultSelected : 0;
        }


        private void OnTokenChanged(object sender, EventArgs e)
        {
            this.token = this.txtApiKey.Text.Trim();
        }

        private void OnGetOtpClicked(object sender, EventArgs e)
        {
            int serviceId = (int)this.cmbService.SelectedValue;
            this.lbStatus.Text = "PENDING";
            this.lbStatus.ForeColor = Color.Orange;
            this.btnGetOtp.Enabled = false;
            this.txtPhone.Text = defaultText;
            this.txtCode.Text = defaultText;
            ServiceOrderData? serviceOrderData = this.GetServiceRequest(serviceId);
            if (serviceOrderData != null)
            {
                this.txtPhone.Text = serviceOrderData.phone_number;
                this.lbStatus.Text = "SUCCESS";
                this.lbStatus.ForeColor = Color.Green;
                this.currentRequestId = serviceOrderData.request_id ?? "";
                this.getCodeTimer.Enabled = true;
                this.currentTime = 0;
            }
            else
            {
                this.lbStatus.Text = "ERROR";
                this.lbStatus.ForeColor = Color.Red;
                this.btnGetOtp.Enabled = true;
            }
        }

        private void OnTimerTick(object? sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.currentRequestId))
            {
                CodeData? codeData = this.GetCode(this.currentRequestId);
                if(codeData != null && codeData.Status == "1")
                {
                    this.txtCode.Text = codeData.Code;
                    this.getCodeTimer.Enabled = false;
                    this.btnCodeCopy.Enabled = true;
                    this.btnGetOtp.Enabled = true;
                }
                this.currentTime += this.getCodeTimer.Interval;
                if(this.currentTime >= this.timeOut)
                {
                    this.getCodeTimer.Enabled = false;
                    this.btnGetOtp.Enabled = true;
                    this.lbStatus.Text = "ERROR";
                    this.lbStatus.ForeColor = Color.Red;
                    this.txtPhone.Text = defaultText;
                }
            }
        }

        private void OnPhoneCopyClicked(object sender, EventArgs e)
        {
            Clipboard.SetText(this.txtPhone.Text);
        }

        private void OnCodeCopyClicked(object sender, EventArgs e)
        {
            Clipboard.SetText(this.txtCode.Text);
        }

        private void OnCodeChanged(object sender, EventArgs e)
        {
            btnCodeCopy.Enabled = this.txtCode.Text != defaultText;
        }

        private void OnPhoneChanged(object sender, EventArgs e)
        {
            btnPhoneCopy.Enabled = this.txtPhone.Text != defaultText;
        }

        public double GetBalance()
        {
            var query = QueryHelpers.AddQueryString("/users/balance", new Dictionary<string, string>()
            {
                ["token"] = this.token,
            });
            HttpResponseMessage message = client.GetAsync(query).Result;
            //MessageBox.Show(message.ToString());
            if (message.StatusCode == System.Net.HttpStatusCode.OK)
            {
                UserBalanceResponseData responseData = message.Content.ReadAsAsync<UserBalanceResponseData>().Result;
                if (responseData != null && 200 == responseData.status_code && responseData.data != null)
                {
                    UserBalanceData userBalanceData = responseData.data;
                    return userBalanceData.balance;
                }
            }
            else
            {
                MessageBox.Show(message.Content.ReadAsStringAsync().Result);
            }
            return 0d;
        }

        public List<ServiceData> GetServices()
        {
            var query = QueryHelpers.AddQueryString("/service/getv2", new Dictionary<string, string>()
            {
                ["token"] = this.token,
                ["country"] = "vn"
            });
            HttpResponseMessage message = client.GetAsync(query).Result;
            if (message.StatusCode == System.Net.HttpStatusCode.OK)
            {
                ServiceResponseData responseData = message.Content.ReadAsAsync<ServiceResponseData>().Result;
                if (responseData != null && 200 == responseData.status_code && responseData.data != null)
                {
                    List<ServiceData> serviceDatas = responseData.data;
                    return serviceDatas;
                }
            }
            else
            {
                MessageBox.Show(message.Content.ReadAsStringAsync().Result);
            }
            return new List<ServiceData>();
        }

        public ServiceOrderData? GetServiceRequest(int serviceId)
        {
            var query = QueryHelpers.AddQueryString("/request/getv2", new Dictionary<string, string>()
            {
                ["token"] = this.token,
                ["serviceId"] = serviceId.ToString()
            });
            HttpResponseMessage message = client.GetAsync(query).Result;
            if (message.StatusCode == System.Net.HttpStatusCode.OK)
            {
                ServiceOrderResponseData responseData = message.Content.ReadAsAsync<ServiceOrderResponseData>().Result;
                if (responseData != null && 200 == responseData.status_code && responseData.data != null)
                {
                    return responseData.data;
                }
            }
            else
            {
                MessageBox.Show(message.Content.ReadAsStringAsync().Result);
            }
            return null;
        }

        public CodeData? GetCode(string requestId)
        {
            var query = QueryHelpers.AddQueryString("/session/getv2", new Dictionary<string, string>()
            {
                ["token"] = this.token,
                ["requestId"] = requestId
            });
            HttpResponseMessage message = client.GetAsync(query).Result;
            if (message.StatusCode == System.Net.HttpStatusCode.OK)
            {
                CodeResponseData responseData = message.Content.ReadAsAsync<CodeResponseData>().Result;
                if (responseData != null && 200 == responseData.status_code && responseData.data != null)
                {
                    return responseData.data;
                }

            }
            else
            {
                MessageBox.Show(message.Content.ReadAsStringAsync().Result);
            }
            return null;
        }
    }

    public interface BaseData { }

    public class ResponseData<T>
    {
        public int? status_code;
        public bool? success;
        public string? message;
        public T? data;
    }

    public class UserBalanceResponseData : ResponseData<UserBalanceData> { }
    public class ServiceResponseData : ResponseData<List<ServiceData>> { }

    public class ServiceOrderResponseData : ResponseData<ServiceOrderData> { }

    public class CodeResponseData : ResponseData<CodeData> { }

    public class UserBalanceData : BaseData
    {
        public double balance;
    }

    public class ServiceData : BaseData
    {
        public int id { get; set; }
        public string? name { get; set; }
        public double price { get; set; }
    }

    public class ServiceOrderData : BaseData
    {
        public string? phone_number { get; set; }
        public double balance { get; set; }
        public string? request_id { get; set; }
        public string? re_phone_number { get; set; }
        public string? counstryISO { get; set; }
        public string? countruCode { get; set; }
    }

    public class CodeData : BaseData
    {
        public string? Code { get; set; }
        public string? Status { get; set; }
    }
}
