using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Belvedere
{
    /// <summary>
    /// 
    /// </summary>
    public class BelevdereRule
    {
        public String Name { get; set; }
        public List<BelvedereCondition> Conditions { get; set; }
        Boolean Enabled { get; set; }
        Boolean ConfirmAction { get; set; }
        Boolean Recursive { get; set; }
        BelvedereAction Action { get; set; }
        public Folder Folder { get; set; }

        public BelevdereRule(String s)
        {
            Name = s;
        }
        
        
        public override string ToString()
        {
            return Name;
        }
    }
}
