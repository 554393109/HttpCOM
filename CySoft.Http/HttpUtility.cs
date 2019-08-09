namespace CySoft.Http
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// 
    /// </summary>
    [ComVisible(true)
        , Guid("63A6D95D-9E43-471E-A9BD-EA9A0B8F395D")
        , ProgId("CySoft.Http.HttpUtility")
        //, ComSourceInterfaces(typeof(IHttp))
        /*, ClassInterface(ClassInterfaceType.AutoDual)*/]
    public partial class HttpUtility : IHttp
    {
        #region Post
        public int Post()
        {
            return 10000;
        }

        public string Post(string url, string content)
        {
            return string.Format("我是DotNet程序 url：【{0}】，content：【{1}】，ReqId：【{2:N}】", url, content, Guid.NewGuid());
        }

        public string Post(string url, string content, string charset, string contentType)
        {
            return string.Format("我是DotNet程序 url：【{0}】，content：【{1}】，charset：【{2}】，contentType：【{3}】，ReqId：【{4:N}】", url, content, charset, contentType, Guid.NewGuid());
        }

        public string Post(string url, string content, string charset, string contentType, int timeOut)
        {
            return string.Format("我是DotNet程序 url：【{0}】，content：【{1}】，charset：【{2}】，contentType：【{3}】，timeOut：【{4}】，ReqId：【{5:N}】", url, content, charset, contentType, timeOut, Guid.NewGuid());
        }

        public string Post(string url, string content, string charset, string contentType, string userAgent, int timeOut)
        {
            return string.Format("我是DotNet程序 url：【{0}】，content：【{1}】，charset：【{2}】，contentType：【{3}】，userAgent：【{4}】，timeOut：【{5}】，ReqId：【{6:N}】", url, content, charset, contentType, userAgent, timeOut, Guid.NewGuid());
        }

        public string Post(string url, string content, string charset, string contentType, string userAgent, string structHeader, int timeOut)
        {
            return string.Format("我是DotNet程序 url：【{0}】，content：【{1}】，charset：【{2}】，contentType：【{3}】，userAgent：【{4}】，structHeader：【{5}】，timeOut：【{6}】，ReqId：【{7:N}】", url, content, charset, contentType, userAgent, structHeader, timeOut, Guid.NewGuid());
        }

        #endregion Post

        #region PostWithCert

        public string PostWithCert(string url, string content, string certPath, string certPwd)
        {
            throw new NotImplementedException();
        }

        public string PostWithCert(string url, string content, string certPath, string certPwd, string charset, string contentType)
        {
            throw new NotImplementedException();
        }

        public string PostWithCert(string url, string content, string certPath, string certPwd, string charset, string contentType, int timeOut)
        {
            throw new NotImplementedException();
        }

        public string PostWithCert(string url, string content, string certPath, string certPwd, string charset, string contentType, string userAgent, int timeOut)
        {
            throw new NotImplementedException();
        }

        public string PostWithCert(string url, string content, string certPath, string certPwd, string charset, string contentType, string userAgent, string structHeader, int timeOut)
        {
            throw new NotImplementedException();
        }

        #endregion PostWithCert

        public string Get(string url, string queryString)
        {
            throw new NotImplementedException();
        }

        public string Get(string url, string queryString, string charset)
        {
            throw new NotImplementedException();
        }
    }
}
