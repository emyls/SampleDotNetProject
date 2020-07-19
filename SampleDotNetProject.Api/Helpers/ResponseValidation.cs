using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SampleDotNetProject.Api.Helpers
{
    public static class ResponseValidation
    {
        private const string _httpCodeLable = "StatusCode";

        private static readonly string _messageLabel = "Message";

        private static readonly dynamic _data = "Data";

        public static Dictionary<string, object> GetHTTPStatusCode(Exception ex)
        {
            var httpStatus = new Dictionary<string, object>();

            if (ex is NotImplementedException)
            {
                httpStatus.Add(_httpCodeLable, (HttpStatusCode)501);
                httpStatus.Add(_messageLabel, "Requested route`s functions are not implemented");
            }

            return httpStatus;
        }

        public static Dictionary<string, object> GetHTTPCreatedStatus()
        {
            var httpStatus = new Dictionary<string, object>();

            httpStatus.Add(_httpCodeLable, (HttpStatusCode)201);
            httpStatus.Add(_messageLabel, "Created");

            return httpStatus;
        }

        public static Dictionary<string, object> GetHTTPSuccessStatus(dynamic data=null)
        {
            var httpStatus = new Dictionary<string, object>();

            httpStatus.Add(_httpCodeLable, (HttpStatusCode)200);
            httpStatus.Add(_messageLabel, "Success");

            if(data != null)
            {
                httpStatus.Add(_data, data);
            }

            return httpStatus;
        }
    }
}
