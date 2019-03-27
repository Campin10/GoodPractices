using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Data
{
    public class ServiceRest : IServices
    {
        private ISoaRest _ISoaRest;
        //private IHttpClient _IHttpClient;
        //public static HttpClient client;
        public ServicesSoaRest(ISoaRest ISoaRest)
        {
            _ISoaRest = ISoaRest;

        }
        public List<Employe> CallService(dynamic Json, string Config)
        {
            client = _IHttpClient.getHttpClient();
            //dynamic mensaje = _ISoaMessage.BuildMessage(Json, addData);
            var result = _ISoaRest.callSoaPost("", Config, client).Result;
            //if (!result.State)
            //{
            //    try
            //    {
            //        var stack = CompileTools.GetReflectionData(result.Message);
            //        LogTrace.WriteLogError(stack.Stack, Json, ClassName: stack.ClassName, Method: stack.Method, Line: stack.Line);
            //    }
            //    catch (Exception ex)

            //    {
            //        result.State = false;
            //        result.Message = ex.Message;
            //    }
            //}

            return result;
        }

        //public void callLogService(LogHandlerModel logModel, Authentication Config)
        //{
        //    string json = JsonConvert.SerializeObject(logModel);
        //    client = _IHttpClient.getHttpClient();
        //    _ISoaRest.callLogSoaPost(json, Config, client);
        //}
    }
}
