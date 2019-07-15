using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Required for json, xml or ini
using Microsoft.Extensions.Configuration.Json;
// using Microsoft.Extensions.Configuration.Ini;
// using Microsoft.Extensions.Configuration.Xml;

namespace Web_Server_Environment.Common
{
    public class ApplicationSettings
    {
        public Application Application { get; set; }
    }

    public class Application
    {
        public int Height { get; set; }
        public int Width { get; set; }
    }

}
