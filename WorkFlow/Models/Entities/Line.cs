using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkFlow.Models.Entities
{
    public class Line
    {
        public string Key { set; get; }
        public string Type { set; get; }
        // node key 
        public string From { set; get; }
        public string To { set; get; }
        public string Name { set; get; }

    }
}