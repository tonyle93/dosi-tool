using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DosiApp.Services.Otp
{
    public class ViOtpProvider : OtpProvider
    {
        public ViOtpProvider(string apiKey, string apiUrl) : base(apiKey, apiUrl, "Vi-OTP")
        {
        }

        public override BaseResponseData<OtpBalance> GetBalanceRequest()
        {
            var response = BaseResponseData<OtpBalance>.Failure(null);
            var query = QueryHelpers.AddQueryString("/users/balance", new Dictionary<string, string>()
            {
                ["token"] = this.ApiKey,
            });
            HttpResponseMessage message = Client.GetAsync(query).Result;
            if (message.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var rawData = message.Content.ReadAsAsync<JObject>().Result;
                var code = rawData.GetValue("status_code").Value<int>();
                var data = rawData.GetValue("data");
                if (rawData != null && 200 == code && data != null)
                {
                    var userBalanceRaw = data.Value<JObject>();
                    var balance = userBalanceRaw.GetValue("balance")?.Value<double>() ?? 0d;
                    return BaseResponseData<OtpBalance>.Success(new OtpBalance() { Balance = balance });
                }
            }
            return response;
        }

        public override BaseResponseData<OtpCode> GetOtpCodeRequest(string orderId)
        {
            var response = BaseResponseData<OtpCode>.Failure(null);
            var query = QueryHelpers.AddQueryString("/request/getv2", new Dictionary<string, string>()
            {
                ["token"] = ApiKey,
                ["requestId"] = orderId
            });
            HttpResponseMessage message = Client.GetAsync(query).Result;
            if (message.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var rawData = message.Content.ReadAsAsync<JObject>().Result;
                var code = rawData.GetValue("status_code").Value<int>();
                var data = rawData.GetValue("data");
                if (rawData != null && 200 == code && data != null)
                {
                    var orderRaw = data.Value<JObject>();
                    var serviceId = orderRaw.GetValue("ServiceID")?.Value<string>() ?? "";
                    var phone = orderRaw.GetValue("Phone")?.Value<string>() ?? "";
                    var otpCode = orderRaw.GetValue("Code")?.Value<string>() ?? "";
                    var status = orderRaw.GetValue("Status")?.Value<int>() ?? 999;
                    return BaseResponseData<OtpCode>.Success(new OtpCode()
                    {
                        OrderId = orderId,
                        ServiceId = serviceId,
                        Phone = phone,
                        Code = otpCode,
                        Status = status
                    });
                }
            }
            return response;
        }

        public override BaseResponseData<OtpPhoneOrder> GetOtpPhoneRequest(string serviceId)
        {
            var response = BaseResponseData<OtpPhoneOrder>.Failure(null);
            var query = QueryHelpers.AddQueryString("/request/getv2", new Dictionary<string, string>()
            {
                ["token"] = ApiKey,
                ["serviceId"] = serviceId
            });
            HttpResponseMessage message = Client.GetAsync(query).Result;
            if (message.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var rawData = message.Content.ReadAsAsync<JObject>().Result;
                var code = rawData.GetValue("status_code").Value<int>();
                var data = rawData.GetValue("data");
                if (rawData != null && 200 == code && data != null)
                {
                    var orderRaw = data.Value<JObject>();
                    var orderId = orderRaw.GetValue("request_id")?.Value<string>() ?? "";
                    var phone = orderRaw.GetValue("phone_number")?.Value<string>() ?? "";
                    return BaseResponseData<OtpPhoneOrder>.Success(new OtpPhoneOrder() { 
                        OrderId = orderId,
                        ServiceId = serviceId,
                        Phone = phone
                    });
                }
            }
            return response;
        }

        public override BaseResponseListData<OtpService> GetServicesRequest()
        {
            var response = BaseResponseListData<OtpService>.Failure(null);
            var query = QueryHelpers.AddQueryString("/service/getv2", new Dictionary<string, string>()
            {
                ["token"] = ApiKey,
                ["country"] = "vn"
            });
            HttpResponseMessage message = Client.GetAsync(query).Result;
            if (message.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var rawData = message.Content.ReadAsAsync<JObject>().Result;
                var code = rawData.GetValue("status_code").Value<int>();
                var data = rawData.GetValue("data");
                if (rawData != null && 200 == code && data != null)
                {
                    List<OtpService> otpServices = new List<OtpService>();
                    var servicesRaw = data.Value<JArray>();
                    if(servicesRaw != null)
                    {
                        for (int i = 0; i < servicesRaw.Count; i++)
                        {
                            var serviceRaw = servicesRaw[i].Value<JObject>();
                            var id = serviceRaw.GetValue("id").Value<string>();
                            var name = serviceRaw.GetValue("name").Value<string>();
                            var price = serviceRaw.GetValue("price").Value<string>();
                            otpServices.Add(new OtpService(id, name, price));
                            return BaseResponseListData<OtpService>.Success(otpServices);
                        }
                    }
                }
            }
            return response;
        }
    }
    
}
