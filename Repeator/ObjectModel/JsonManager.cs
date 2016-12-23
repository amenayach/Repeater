using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Repeator.ObjectModel
{
    public class JsonManager
    {

        public static bool IsArray(string jsonText)
        {
            try
            {
                JArray.Parse(jsonText);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
