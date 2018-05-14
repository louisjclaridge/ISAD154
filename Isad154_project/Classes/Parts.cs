using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.IO;

namespace Isad154_project.Classes
{
    public class Parts
    {
        public string partName { get; set; }
        public Parts (string thePartName)
        {
            partName = thePartName;
        }
    public string allParts()
        {
            string output = partName;
            return output;
        }
    }
}