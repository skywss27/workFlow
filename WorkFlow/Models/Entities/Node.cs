using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkFlow.Models.Entities
{
    public class Node
    {
        //node key
        public string Key { set; get; }
        public string Name { set; get; }
        // node location
        public int Left { set; get; }
        public int Top { set; get; }
        public string Type { set; get; }
        // node size
        public int Width { set; get; }
        public int Height { set; get; }
        public bool Alt { set; get; }
    }

}