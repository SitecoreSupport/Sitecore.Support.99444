namespace Sitecore.Support.CES.Client
{
    using Sitecore.Diagnostics;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;

    class WebRequestFactory : Sitecore.CES.Client.WebRequestFactory
    {
        public override WebRequest Create(string requestUri)
        {
            Assert.ArgumentNotNullOrEmpty(requestUri, "requestUri");
            string proxyServerConnectionString = Sitecore.Configuration.Settings.GetSetting("Proxy.Server.Connection.String");
            
            WebRequest baseResult = base.Create(requestUri);
            if (!String.IsNullOrEmpty(proxyServerConnectionString))
            {
                baseResult.Proxy = new WebProxy(proxyServerConnectionString);
            }

            return baseResult;
        }
    }
}
