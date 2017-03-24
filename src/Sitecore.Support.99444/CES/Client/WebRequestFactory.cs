using Sitecore.Diagnostics;
using System;
using System.Net;

namespace Sitecore.Support.CES.Client
{
  class WebRequestFactory : Sitecore.CES.Client.WebRequestFactory
  {
    public override WebRequest Create(string requestUri)
    {
      Assert.ArgumentNotNullOrEmpty(requestUri, "requestUri");

      string proxyServerConnectionString = Configuration.Settings.GetSetting("Proxy.Server.Connection.String");

      WebRequest baseResult = base.Create(requestUri);

      if (!String.IsNullOrEmpty(proxyServerConnectionString))
      {
        baseResult.Proxy = new WebProxy(proxyServerConnectionString);
      }

      if (!String.IsNullOrEmpty(Configuration.Settings.GetSetting("Proxy.Server.Username")))
      {
        baseResult.Credentials = new NetworkCredential(Configuration.Settings.GetSetting("Proxy.Server.Username"), Sitecore.Configuration.Settings.GetSetting("Proxy.Server.Password"));
      }

      return baseResult;
    }
  }
}