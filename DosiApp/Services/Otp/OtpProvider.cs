using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DosiApp.Services.Otp
{
    public abstract class OtpProvider
    {
        protected string ApiKey { get; set; }
        protected string ApiUrl { get; set; }
        protected string ProviderName { get; set; }

        protected HttpClient Client { get; set; }

        public OtpProvider(string apiKey, string apiUrl, string providerName)
        {
            ApiKey = apiKey;
            ApiUrl = apiUrl;
            ProviderName = providerName;
            Client = new HttpClient();
            Client.BaseAddress = new Uri(ApiUrl);
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public abstract BaseResponseData<OtpBalance> GetBalanceRequest();
        public abstract BaseResponseData<OtpPhoneOrder> GetOtpPhoneRequest(string serviceId);
        public abstract BaseResponseData<OtpCode> GetOtpCodeRequest(string orderId);

        public abstract BaseResponseListData<OtpService> GetServicesRequest();

    }

    public interface IBaseData { }

    public interface IBaseResponseData { }

    public class BaseResponseData<T> : IBaseResponseData where T : IBaseData
    {
        public const int StatusSuccess = 200;
        public const int StatusFailure = 999;

        public int Code { get; set; }
        public string Message { get; set; }
        public T Data { get; set; } = default(T);

        public static BaseResponseData<T> Create(int code, string message, T data)
        {
            var response = new BaseResponseData<T>();
            response.Code = code;
            response.Message = message;
            response.Data = data;
            return response;
        }

        public static BaseResponseData<T> Success(T data)
        {
            var response = new BaseResponseData<T>();
            response.Code = StatusSuccess;
            response.Message = "Success";
            response.Data = data;
            return response;
        }

        public static BaseResponseData<T> Failure(T data)
        {
            var response = new BaseResponseData<T>();
            response.Code = StatusFailure;
            response.Message = "Failure";
            response.Data = data;
            return response;
        }
    }

    public class BaseResponseListData<T> : IBaseResponseData where T : IBaseData
    {
        public const int StatusSuccess = 200;
        public const int StatusFailure = 999;
        public int Code { get; set; }
        public string Message { get; set; }
        public List<T> Data { get; set; } = default(List<T>);

        public static BaseResponseListData<T> Create(int code, string message, List<T> data)
        {
            var response = new BaseResponseListData<T>();
            response.Code = code;
            response.Message = message;
            response.Data = data;
            return response;
        }

        public static BaseResponseListData<T> Success(List<T> data)
        {
            var response = new BaseResponseListData<T>();
            response.Code = StatusSuccess;
            response.Message = "Success";
            response.Data = data;
            return response;
        }

        public static BaseResponseListData<T> Failure(List<T> data)
        {
            var response = new BaseResponseListData<T>();
            response.Code = StatusFailure;
            response.Message = "Failure";
            response.Data = data;
            return response;
        }
    }

    public class OtpBalance : IBaseData
    {
        public double Balance { get; set; }
    }

    public class OtpService : IBaseData
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Price { get; set; }

        public OtpService(string id, string name, string price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }

    public class OtpPhoneOrder : IBaseData
    {
        public string OrderId { get; set; }
        public string ServiceId { get; set; }
        public string Phone { get; set; }
    }

    public class OtpCode : IBaseData
    {
        public string OrderId { get; set; }
        public string ServiceId { get; set; }
        public string Phone { get; set; }
        public string Code { get; set; }
        public int Status { get; set; }
    }
}
