using System;

namespace WebSites
{
    public class WebSite
    {
        public string siteName { get; set; }
        public string URL { get; set; }
        public string description { get; set; }

        public WebSite(string siteName, string uRL, string description)
        {
            this.siteName = siteName;
            URL = uRL;
            this.description = description;
        }
    }
}
