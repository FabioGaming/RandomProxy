using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace RandomProxy
{
    class GetProxy
    {
        
        public enum proxyType
        {
            http,
            https,
            socks5,
            all,
        }

        public class getFullProxy
        {
            public getFullProxy(proxyType type = GetProxy.proxyType.all)
            {
                string Proxytype = "all";
                switch (type)
                {
                    case proxyType.all:
                        Proxytype = "all";
                        break;
                    case proxyType.http:
                        Proxytype = "http";
                        break;
                    case proxyType.https:
                        Proxytype = "https";
                        break;
                    case proxyType.socks5:
                        Proxytype = "socks5";
                        break;
                }
                string link = "https://api.proxyscrape.com/v2/?request=displayproxies&protocol=" + Proxytype + "&timeout=10000&country=all&ssl=all&anonymity=all";

                WebClient client = new WebClient();

                string data = client.DownloadString(link);
                List<string> proxyList = new List<string>();
                proxyList.AddRange(data.Split("\n"));
                Random rdm = new Random();

                ProxyType = Proxytype;
                ProxyList = proxyList.ToArray();
                ProxyCount = ProxyList.Count();
                Proxy = ProxyList[rdm.Next(ProxyList.Count())];

            }
            public string? ProxyType { get; set; }
            public string[]? ProxyList { get; set; }
            public int? ProxyCount { get; set; }
            public string? Proxy { get; set; }
        }

        public static string getRandomProxy(proxyType type = proxyType.all)
        {
            string Proxytype = "all";
            switch (type)
            {
                case proxyType.all:
                    Proxytype = "all";
                    break;
                case proxyType.http:
                    Proxytype = "http";
                    break;
                case proxyType.https:
                    Proxytype = "https";
                    break;
                case proxyType.socks5:
                    Proxytype = "socks5";
                    break;
            }
            string link = "https://api.proxyscrape.com/v2/?request=displayproxies&protocol=" + Proxytype + "&timeout=10000&country=all&ssl=all&anonymity=all";

            WebClient client = new WebClient();

            string data = client.DownloadString(link);
            List<string> proxyList = new List<string>();
            proxyList.AddRange(data.Split("\n"));
            Random rdm = new Random();
            return proxyList[rdm.Next(proxyList.Count)];
        }

        public static string[] getProxyList(proxyType type = proxyType.all)
        {
            string Proxytype = "all";
            switch (type)
            {
                case proxyType.all:
                    Proxytype = "all";
                    break;
                case proxyType.http:
                    Proxytype = "http";
                    break;
                case proxyType.https:
                    Proxytype = "https";
                    break;
                case proxyType.socks5:
                    Proxytype = "socks5";
                    break;
            }
            string link = "https://api.proxyscrape.com/v2/?request=displayproxies&protocol=" + Proxytype + "&timeout=10000&country=all&ssl=all&anonymity=all";

            WebClient client = new WebClient();

            string data = client.DownloadString(link);
            List<string> proxyList = new List<string>();
            proxyList.AddRange(data.Split("\n"));
            Random rdm = new Random();
            return proxyList.ToArray();
        }


    }
}
