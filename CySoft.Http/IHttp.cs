namespace CySoft.Http
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// 
    /// </summary>
    [ComVisible(true)
        , Guid("63A6D95D-9E43-471E-A9BD-EA9A0B8F395C")
        /*, InterfaceType(ComInterfaceType.InterfaceIsDual)*/]
    public interface IHttp
    {
        #region Post

        [DispId(1)]
        int Post();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        [DispId(2)]
        string Post(string url, string content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <param name="charset"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        [DispId(3)]
        string Post(string url, string content, string charset, string contentType);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <param name="charset"></param>
        /// <param name="contentType"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        [DispId(4)]
        string Post(string url, string content, string charset, string contentType, int timeOut);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <param name="charset"></param>
        /// <param name="contentType"></param>
        /// <param name="userAgent"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        [DispId(5)]
        string Post(string url, string content, string charset, string contentType, string userAgent, int timeOut);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <param name="charset"></param>
        /// <param name="contentType"></param>
        /// <param name="userAgent"></param>
        /// <param name="structHeader"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        [DispId(6)]
        string Post(string url, string content, string charset, string contentType, string userAgent, string structHeader, int timeOut);

        #endregion Post

        #region PostWithCert - 服务方需要验证客户端证书时使用

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <param name="certPath"></param>
        /// <param name="certPwd"></param>
        /// <returns></returns>
        [DispId(7)]
        string PostWithCert(string url, string content, string certPath, string certPwd);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <param name="certPath"></param>
        /// <param name="certPwd"></param>
        /// <param name="charset"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        [DispId(8)]
        string PostWithCert(string url, string content, string certPath, string certPwd, string charset, string contentType);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <param name="certPath"></param>
        /// <param name="certPwd"></param>
        /// <param name="charset"></param>
        /// <param name="contentType"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        [DispId(9)]
        string PostWithCert(string url, string content, string certPath, string certPwd, string charset, string contentType, int timeOut);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <param name="certPath"></param>
        /// <param name="certPwd"></param>
        /// <param name="charset"></param>
        /// <param name="contentType"></param>
        /// <param name="userAgent"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        [DispId(10)]
        string PostWithCert(string url, string content, string certPath, string certPwd, string charset, string contentType, string userAgent, int timeOut);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <param name="certPath"></param>
        /// <param name="certPwd"></param>
        /// <param name="charset"></param>
        /// <param name="contentType"></param>
        /// <param name="userAgent"></param>
        /// <param name="structHeader"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        [DispId(11)]
        string PostWithCert(string url, string content, string certPath, string certPwd, string charset, string contentType, string userAgent, string structHeader, int timeOut);

        #endregion PostWithCert - 服务方需要验证客户端证书时使用

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="queryString"></param>
        /// <returns></returns>
        [DispId(12)]
        string Get(string url, string queryString);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="queryString"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        [DispId(13)]
        string Get(string url, string queryString, string charset);
    }
}
