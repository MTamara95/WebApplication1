using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class AboutController : Controller
    {
        public string GenerateUsername(string firstname, string lastname)
        {
            List<string> tmpUsernames = new List<string>(new string[] { "tmarcetic", "mnesic", "nilic", "lmarkovic", "vkovacevic",
            "tmarkovic", "tamarkovic", "tammarkovic", "tamamarkovic", "tamarmarkovic", "tamaramarkovic"});

            string username = "";
            int endIndex = 1;

            // Username is initially created from the first letter of the firstname and the whole lastname;
            // If there exists employee with that username, it should be considered other letters of the firstname
            while (endIndex < firstname.Length)
            {
                username = firstname.Substring(0, endIndex).ToLower().Replace(" ", string.Empty) + lastname.ToLower().Replace(" ", string.Empty);
                if (!tmpUsernames.Contains(username))
                {
                    break;
                }
                // If we reach here, username is already used and is not valid
                username = "";
                endIndex++;
            }

            // If there are two or more employees with the same fullname, we should appending numbers at the end of the username until it became unique
            if (username == "")
            {
                int num = 1;
                while (true)
                {
                    username = Char.ToLower(firstname[0]) + lastname.ToLower().Replace(" ", string.Empty) + num.ToString();
                    if (!tmpUsernames.Contains(username))
                    {
                        break;
                    }
                    // If we reach here, username is already used and is not valid
                    username = "";
                    num++;
                }
            }

            return username;
        }

    }
}
