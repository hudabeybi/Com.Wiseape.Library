using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.Wiseape.Utility;
using System.Collections.Specialized;

namespace Com.Wiseape.Utility.HttpUtility
{
    public class HttpParameterListProcessor : Com.Wiseape.Utility.ListUtility.IListProcessor
    {
        public string Process(IDictionary<string, object> list)
        {
            string sList = "";
            foreach(KeyValuePair<string, object > entry in list)
            {
                sList += entry.Key + "=" + entry.Value + "&";
            }
            if (sList.Length > 0)
                sList = sList.Substring(0, sList.Length - 1);
            return sList;
        }


        public static string ToQueryString(NameValueCollection nvc)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string key in nvc.Keys)
            {
                if (string.IsNullOrEmpty(key)) continue;

                string[] values = nvc.GetValues(key);
                if (values == null) continue;

                foreach (string value in values)
                {
                    sb.Append(sb.Length == 0 ? "?" : "&");
                    sb.AppendFormat("{0}={1}", Uri.EscapeDataString(key), Uri.EscapeDataString(value));
                }
            }

            return sb.ToString();
        }


    }
}
