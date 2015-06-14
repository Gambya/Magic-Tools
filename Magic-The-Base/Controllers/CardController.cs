using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositorioUtilidades;
using System.Net;
using System.Text.RegularExpressions;

namespace Magic_The_Base.Controllers
{
    public class CardController
    {
        private CookieContainer cookie;

        public List<String> recoverCard()
        {
            String strHTMLCollection = String.Empty;
            MatchCollection matches;
            List<String> listCollection = new List<string>();

            strHTMLCollection = HttpWebRequestHelper.Get(new Uri("http://gatherer.wizards.com/Pages/Default.aspx"), ref cookie, Encoding.UTF8);
            if (strHTMLCollection != null)
            {
                strHTMLCollection = Utilidade.removerQuebraDeLinha(strHTMLCollection);
                strHTMLCollection = Regex.Match(strHTMLCollection, @"id=.ctl00_ctl00_MainContent_Content_SearchControls_setAddText.>(.+?)<\/select>").Value;
                matches = Regex.Matches(strHTMLCollection, @"<option\s*value=.(?<Collection>.+?).>");

                foreach (Match item in matches)
                {
                    if (!Regex.IsMatch(item.Groups["Collection"].Value, @".><\/optio"))
                    {
                        listCollection.Add(item.Groups["Collection"].Value);
                    }
                }
            }

            return listCollection;
        }
    }
}
