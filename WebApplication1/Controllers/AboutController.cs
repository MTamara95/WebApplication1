using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class AboutController : Controller
    {
        public string Create(string firstname, string lastname)
        {
            List<string> tmpUsernames = new List<string>(new string[] { "tmarcetic", "mnesic", "nilic", "lmarkovic", "vkovacevic",
            "tmarkovic", "tamarkovic", "tammarkovic", "tamamarkovic", "tamarmarkovic", "tamaramarkovic"});

            string username = "";
            int endIndex = 1;

            while (endIndex < firstname.Length)
            {
                if (!tmpUsernames.Contains(firstname.Substring(0, endIndex).ToLower() + lastname.ToLower()))
                {
                    username = firstname.Substring(0, endIndex).ToLower() + lastname.ToLower();
                    break;
                }
                endIndex++;
            }

            if (username == "")
            {
                int num = 1;
                while (true)
                {
                    if (!tmpUsernames.Contains(firstname.Substring(0, endIndex - 1).ToLower() + lastname.ToLower() + num.ToString()))
                    {
                        username = firstname.Substring(0, 1).ToLower() + lastname.ToLower() + num.ToString();
                        break;
                    }
                    num++;
                }
            }

            return username;
        }

    }
}
