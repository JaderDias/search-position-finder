using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Globalization;

namespace SearchPositionFinder
{
    public static class Finder
    {
        public static int GetPosition(string searchUriFormat, string siteUri)
        {
            var webClient = new WebClient();
            var max = 100;
            foreach (var i in Enumerable.Range(0, max))
            {
                var result = webClient.DownloadString(String.Format(
                    CultureInfo.InvariantCulture,
                    searchUriFormat,
                    i.ToString(CultureInfo.InvariantCulture)
                ));
                if(result.Contains(siteUri))
                {
                    return i;
                }
            }
            return max;
        }
    }
}
