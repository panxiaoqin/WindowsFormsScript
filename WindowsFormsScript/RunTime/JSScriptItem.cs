using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsScript.RunTime
{
    public class JSScriptItem
    {
        public string FunName;

        public List<string> Params = new List<string>();

        public JSScriptItem(string name)
        {
            FunName = name;
        }
    }
}
